using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace 上班考勤管理系统
{
    public partial class Frmwelcome : Form
    {
        public Frmwelcome()
        {
            InitializeComponent();
        }

        //点击确认，并弹出串口界面
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Welcome();//调用转换方法
        }

        //退出
        private void BtnWelcomeQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frmwelcome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Return) //判断用户是否按下的是回车键
            {
                Welcome();
            }
        }
        //创建转换界面方法
        private void Welcome()
        {
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmManagementSerialPort managementSerialPort = new FrmManagementSerialPort();
            this.Hide();
            managementSerialPort.ShowDialog();
        }
    }
}
