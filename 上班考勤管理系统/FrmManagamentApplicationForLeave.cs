using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KV_ISO15693;
using System.Threading;
using WeifenLuo.WinFormsUI.Docking;

namespace 上班考勤管理系统
{
    public partial class FrmManagamentApplicationForLeave : DockContent
    {
        KV_ISO15693.Reader reader = new Reader();  //实例化Reader类      
        private Thread Thread_15693;               //创建线程
        private delegate void ShowTextBoxMessageDel(TextBox txt, string msg);//定义委托
        SqlHelper sh = new SqlHelper();            //实例化SqlHelper类
        public FrmManagamentApplicationForLeave()
        {
            InitializeComponent();
        }

        #region 打开串口
        private void btnOpenSerial_Click(object sender, EventArgs e)
        {
            Byte value = reader.OpenSerialPort(Program.PortName);//打开串口
            if (value == 0x00)
            {
                MessageBox.Show("串口打开成功");

                //启动线程
                Thread_15693 = new Thread(new ThreadStart(ReadCard));//循环读卡
                Thread_15693.IsBackground = true;
                Thread_15693.Start();

            }
            else
            {
                MessageBox.Show("串口打开失败,请检查设备端口是否连接正常！");
            }
        }
        #endregion

        #region 读卡方法
        /// <summary>
        /// 读卡方法
        /// </summary>
        private void ReadCard()
        {
            while (true)
            {
                try
                {
                    ModulateMethod mm = ModulateMethod.ASK;     //设置读写器的调制方式为ASK(幅移键控)
                    InventoryModel im = InventoryModel.Multiple;//设置读写器的寻卡方式为寻多卡Multiple(寻多卡)
                    Int32 TagCount = 0;                          //TagCount用于返回读取到的卡片数量
                    String[] TagNumber = new String[1];           //TagNumber用于返回读取到的所有卡片的卡号
                    Byte value = reader.Inventory(mm, im, ref TagCount, ref TagNumber);//寻卡
                    if (TagCount == 1)                             //如果寻到一张卡
                    {
                        SetTextValue(txtAccessID, TagNumber[0]);   //通过委托设置TextBox控件的值

                    }
                    Thread.Sleep(100);                            //让线程休眠一秒
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("扫描失败");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        #region 关闭串口
        private void btnCloseSerial_Click(object sender, EventArgs e)
        {
            if (reader.IsOpen)
            {
                Byte value = reader.CloseSerialPort();
                if (value == 0x00)
                {
                    MessageBox.Show("串口关闭成功!");
                    //Thread_15693.Abort();

                }
                else
                    MessageBox.Show("串口关闭失败!");
            }
            else
            {
                MessageBox.Show(String.Format("错误：串口已经处于关闭状态！"));
            }
        }
        #endregion

        #region 申请请假
        private void btnConflimLeave_Click(object sender, EventArgs e)
        {
            if (txtAccessID.Text.Trim() =="")//判断卡号是否为空
            {
                MessageBox.Show("卡号为空无法申请，请输入卡号！！!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("一个月只能请假一次，是否确认请假？", "请假申请", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (sh.CheckForLeave(txtAccessID.Text.Trim()))
                    {
                        MessageBox.Show("您本月已经请过假了，无法再次申请！");
                    }
                    else
                    {
                        string LeaveTime = txtLeaveTime.Text.Trim();
                        string LeaveReason = RtxtLeaveReason.Text.Trim();
                        try
                        {
                            sh.SearchCardInfo(txtAccessID.Text.Trim());//查询将要请假人的卡的信息               
                            sh.InsertLeaveInfo(LeaveTime, LeaveReason);//将已签到的卡的卡号和对应的人员信息插入数据库
                            int i = sh.IsSuccess();
                            if (i > 0)
                            {
                                txtAccessID.Text = txtLeaveTime.Text = RtxtLeaveReason.Text = "";
                                MessageBox.Show("已成功申请请假!");
                            }
                            else
                            {
                                MessageBox.Show("数据库错误!申请失败!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("数据库错误!");
                        }
                    }
                }
                else
                {
                    this.Show();
                }
            }
        }
        #endregion

        #region 使用委托设置TextBox值得方法
        private void SetTextValue(TextBox txt, string msg)
        {
            if (txt.InvokeRequired)
            {
                ShowTextBoxMessageDel del = new ShowTextBoxMessageDel(SetTextValue);
                this.Invoke(del, txt, msg);
            }
            else
            {
                txt.Text = msg;
            }
        }
        #endregion
    }
}
