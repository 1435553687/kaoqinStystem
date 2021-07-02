using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 上班考勤管理系统
{
    public partial class FrmMessage : Form
    {
        public static string PunchInformation;//定义一个参数，构成传参功能

        public FrmMessage()
        {
            InitializeComponent();
        }


        private void FrmMessage_Load(object sender, EventArgs e)
        {
            lblInformation.Text = PunchInformation;
            this.TimerOne.Enabled = true; //打开控件TimerOne
        }

        #region 控制消息框2s后关闭
        private void TimerOne_Tick(object sender, EventArgs e)
        {
            this.Close();
            this.TimerOne.Enabled = false;
        }
        #endregion

        //通过确认关闭消息框
        private void btnConflict_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
