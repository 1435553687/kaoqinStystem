using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using KV_ISO15693;
using System.Threading;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace 上班考勤管理系统
{
    public partial class FrmDeleteCard : DockContent
    {
        KV_ISO15693.Reader reader = new Reader();  //实例化Reader类      
        private Thread Thread_15693;               //创建线程
        private delegate void ShowTextBoxMessageDel(TextBox txt, string msg);//定义委托
        SqlHelper sh = new SqlHelper();            //实例化SqlHelper类
        public FrmDeleteCard()
        {
            InitializeComponent();
        }

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

        //确认将要注销的卡号信息
        #region 将要注销的卡号信息
        private void btnSearchInformation_Click(object sender, EventArgs e)
        {
            if (txtAccessID.Text.Trim() =="") //如果txtAccessID不为空
            {
                MessageBox.Show("没有读取卡号请读卡，请重新输入！！！","提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (sh.CheckDeleteInformation(txtAccessID.Text.Trim()))
                {
                    DataSet ds = sh.Search(txtAccessID.Text.Trim());//调用Search方法查询指定条件的查询人员信息并将返回的结果存储在DataSet缓存中
                    dgvCheckOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckOutInfo的数据源显示查询结果                   
                }
                else
                {
                    MessageBox.Show("该卡已消除！无法查询！");
                    return;
                }
            }
        }
        #endregion

        //进行卡号注销
        #region 确认卡号注销
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定注销该卡号信息？", "卡号注销", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtAccessID.Text.Trim() =="") //如果txtAccessID不为空
                {
                    MessageBox.Show("请输入您要注销卡号！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (sh.CheckDeleteInformation(txtAccessID.Text.Trim()))
                        {
                            DataSet ds = sh.Delete(txtAccessID.Text.Trim());//调用Delete方法查询指定条件的人员卡号信息删除并将返回的结果存储在DataSet缓存中
                            try
                            {
                                dgvCheckOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckOutInfo的数据源显示已删除的空结果
                            }
                            catch
                            {
                                txtAccessID.Text = "";
                                this.timer1.Enabled = true;
                                MessageBox.Show("成功删除信息！");
                            }
                        }
                        else
                        {
                            MessageBox.Show("该卡已消除！无需删除！");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("没有该卡号！请重新读入卡号！！！");
                    }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataSet ds = sh.Search(txtAccessID.Text.Trim());//调用Search方法查询指定条件的查询人员信息并将返回的结果存储在DataSet缓存中
            dgvCheckOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckOutInfo的数据源显示查询结果
            this.timer1.Enabled = false;
        }
    }
}