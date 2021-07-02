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
using System.Data.SqlClient;

namespace 上班考勤管理系统
{
    public partial class FrmManagementPunchCard : DockContent
    {
        KV_ISO15693.Reader reader = new Reader();//实例化Reader类
        SqlHelper sh = new SqlHelper();          //实例化SqlHelper类
        private Thread Thread_15693;             //创建线程
        private delegate void ShowTextBoxMessageDel(TextBox txt, string msg);//定义委托
        public string PunchInformation;
        public string connectionWin = @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True";//修改
        public string cardInfoSignStatus;
        public FrmManagementPunchCard()
        {
            InitializeComponent();
        }

        #region 打开串口
        private void btnOpenSerial_Click(object sender, EventArgs e)
        {
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
                    Int32 TagCount = 0;                         //TagCount用于返回读取到的卡片数量
                    String[] TagNumber = new String[1];         //TagNumber用于返回读取到的所有卡片的卡号
                    Byte value = reader.Inventory(mm, im, ref TagCount, ref TagNumber);//寻卡
                    if (TagCount == 1)                         //如果寻到一张卡
                    {
                        SetTextValue(txtAccessID, TagNumber[0]);//通过委托设置TextBox控件的值

                    }
                    Thread.Sleep(100);                          //让线程休眠一秒
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("扫描失败");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        #region 签到/签退
        private void btnSignInOrOut_Click(object sender, EventArgs e)
        {
            /*if (txtAccessID.Text.Trim() =="")
            {
                MessageBox.Show("没有输入卡号!请先输入卡号！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (sh.CheckPunchCardInformation(txtAccessID.Text.Trim()))
                {
                    string SignStatus;
                    sh.SearchCardInfo(txtAccessID.Text.Trim());//查询将要签到的卡的信息
                    int hour = DateTime.Now.Hour;              //根据当前时间判断签到状态
                    if (hour <= 9)
                    {
                        SignStatus = "已签到";
                        MessageBox.Show("签到成功！");
                    }
                    else if (hour > 9 && hour <= 12)
                    {
                        SignStatus = "迟到";
                        MessageBox.Show("迟到！！！");
                    }
                    else if (hour > 12 && hour < 13)
                    {
                        SignStatus = "午餐休息时间";
                        MessageBox.Show("辛苦了");
                    }
                    else if (hour >= 13 && hour < 17)
                    {
                        SignStatus = "早退";
                        MessageBox.Show("早退！！！");
                    }
                    else
                    {
                        SignStatus = "已签退";
                        MessageBox.Show("签退成功！");
                    }
                    sh.InsertCheckInfo(SignStatus);//将已签到的卡的卡号和对应的人员信息插入数据库
                    int i = sh.IsSuccess();
                    if (i > 0)
                    {
                        txtAccessID.Text = "";
                        //说明数据库未出错
                    }
                    else
                    {
                        MessageBox.Show("数据库错误!签到/签退失败!");
                    }
                }
                else
                {
                    MessageBox.Show("已无该卡信息!无法签到！");
                    return;
                }
            }*/
        }
        #endregion

        #region 关闭串口
        private void button1_Click(object sender, EventArgs e)
        {
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

        #region 自动控制签到
        private void TimerTwo_Tick(object sender, EventArgs e)
        {
            string Mstatus;
            if (txtAccessID.Text.Trim() == "")
            {
                //MessageBox.Show("没有输入卡号!请先输入卡号！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (sh.CheckPunchCardInformation(txtAccessID.Text.Trim()))//判断是否存该卡信息
                {
                    int Time = DateTime.Now.Hour;              //根据当前时间判断签到状态
                    if (Time < 12)
                    {
                        if (sh.CheckInOrOutPunch(txtAccessID.Text.Trim()))//判断上午是否已签到
                        {
                            sh.SwitchStatus(txtAccessID.Text.Trim());
                            Mstatus = sh.CheckInOrOutStatus();//获取当前签到状态
                            if (Mstatus == "已签到" || Mstatus == "迟到")
                            {
                                PunchInformation = "您已签到成功！无需再签！";
                                Swich();
                            }
                            else
                            {
                                punch();//签到
                            }
                        }
                        else    //未签
                        {
                            punch();
                        }
                    }
                    else if(Time >=12&&Time <=23)  //除上午的所有签到时间
                    {
                        if (sh.CheckInOrOutPunch(txtAccessID.Text.Trim())) //判断是否已经签退
                        {                            
                            sh.SwitchStatus(txtAccessID.Text.Trim());
                            Mstatus = sh.CheckInOrOutStatus();//获取当前签到状态
                            if (Mstatus == "早退" || Mstatus == "已签退")
                            {
                                PunchInformation = "您已签退成功！无需再签！";
                                Swich();
                            }
                            else
                            {
                                punch();//签退
                            }
                        }
                        else     //未签
                        {
                            //punch();       
                            sh.SwitchStatus(txtAccessID.Text.Trim());
                            Mstatus = sh.CheckInOrOutStatus();//获取当前签到状态
                            if (Mstatus == "早退" || Mstatus == "已签退")
                            {
                                PunchInformation = "您已签退成功！无需再签！";
                                Swich();
                            }
                            else
                            {
                                //MessageBox.Show("没有输入卡号!请先输入卡号！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                punch();//签退
                            }
                        }
                    }  
                     
                }
                else
                {
                    PunchInformation = "已无该卡信息!无法签到！";
                    Swich();                    
                }
            }
        }
        #endregion

        #region 签到
        private void punch()
        {
            string SignStatus;
            sh.SearchCardInfo(txtAccessID.Text.Trim());//查询将要签到的卡的信息
            int hour = DateTime.Now.Hour;              //根据当前时间判断签到状态
            if (hour < 9)
            {
                SignStatus = "已签到";
                PunchInformation = "已签到成功！！！";
                txtAccessID.Text = "";
            }
            else if (hour >= 9 && hour < 12)
            {
                SignStatus = "迟到";
                PunchInformation = "迟到！！！";
                txtAccessID.Text = "";
            }
     
            else if (hour >= 13 && hour < 21)
            {
                SignStatus = "早退";
                PunchInformation = "早退！！！";
                txtAccessID.Text = "";
            }
            else
            {
                SignStatus = "已签退";
                PunchInformation = "签退成功！";
                txtAccessID.Text = "";
            }
            sh.InsertCheckInfo(SignStatus);//将已签到的卡的卡号和对应的人员信息插入数据库
            int i = sh.IsSuccess();
            if (i > 0)
            {             
                Swich();
                //说明数据库未出错
            }
            else
            {
                PunchInformation = "数据库错误!签到/签退失败!";
                Swich();
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
