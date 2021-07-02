using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using KV_ISO15693;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace 上班考勤管理系统
{
    public partial class FrmManagementMeeting : DockContent
    {
        KV_ISO15693.Reader reader = new Reader();  //实例化Reader类      
        private Thread Thread_15693;               //创建线程
        private delegate void ShowTextBoxMessageDel(TextBox txt, string msg);//定义委托
        SqlHelper sh = new SqlHelper();            //实例化SqlHelper类
        public string PunchInformation;
        public FrmManagementMeeting()
        {
            InitializeComponent();
        }

        #region 打开串口
        private void btnOpenSerial_Click(object sender, EventArgs e)
        {
            Timerone.Start();
            Byte value = reader.OpenSerialPort(Program.PortName);//打开串口
            if (value == 0x00)
            {
                this.TimerTwo.Enabled = true;
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
            Timerone.Stop();
            if (reader.IsOpen)
            {
                Byte value = reader.CloseSerialPort();
                if (value == 0x00)
                {
                    this.TimerTwo.Enabled = false;
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

        #region 刷新已进行会议签到的人员信息
        private void Timerone_Tick_1(object sender, EventArgs e)
        {
            DataSet ds = sh.RefreshMeetingSignInfo();//调用RefreshMeetingSignInfo()方法查询所有已进行会议签到的人员信息并将返回的结果存储在DataSet缓存中
            dgvMeeting.DataSource = ds.Tables[0];    //通过设置dgvCheckInOrOutInfo的数据源显示查询结果
        }
        #endregion

        #region 清空信息
        private void btndeleteData_Click(object sender, EventArgs e)
        {
            sh.DeleteData();
        }
        #endregion

        #region 控制自动签到
        private void TimerTwo_Tick(object sender, EventArgs e)
        {
            if (txtAccessID.Text.Trim() == "")
            {
                //MessageBox.Show("没有搜索到卡号!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (sh.CheckPunchCardInformation(txtAccessID.Text.Trim()))
                {
                    if (sh.SearchMeeting(txtAccessID.Text.Trim()))
                    {
                        PunchInformation = "已经打卡成功无需再签!";
                        Swich();
                    }
                    else
                    {
                        sh.SearchCardInfo(txtAccessID.Text.Trim());//查询将要签到的卡的信息
                        sh.InsertMeetingSignInfo();                //将会议签到信息存入数据库
                        int i = sh.IsSuccess();
                        if (i > 0)
                        {
                            PunchInformation = "会议签到成功!";
                            Swich();
                        }
                        else
                        {
                            PunchInformation = "数据库错误!会议签到信息失败!";
                            Swich();
                        }
                    }
                }
                else
                {
                    PunchInformation = "无该卡信息无法签到！！！";
                    Swich();
                }
            }
        }
        #endregion

        #region 跳转提示框
        private void Swich()
        {
            this.txtAccessID.Text = "";
            FrmMessage.PunchInformation = PunchInformation;
            FrmMessage message = new FrmMessage();
            message.Show();
        }
        #endregion

    }
}
