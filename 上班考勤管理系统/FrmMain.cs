using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KV_ISO15693;
using WeifenLuo.WinFormsUI.Docking;

namespace 上班考勤管理系统
{
    public partial class FrmMain : Form
    {       
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show(dockPanel1, DockState.DockLeft);
            dockPanel1.DockLeftPortion = 240;
            FrmHome home = new FrmHome();
            home.Show(dockPanel1);
        }
        //打卡签到
        private void 打卡签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPunchCard punchCard = new FrmPunchCard();
            punchCard.Show(dockPanel1);
        }

        //会议签到
        private void 会议签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMeeting meeting = new FrmMeeting();
            meeting.Show(dockPanel1);
        }

        //请假管理
        private void ToolStripMenuItem请假_Click(object sender, EventArgs e)
        {
            FrmApplicationForLeave applicationForLeave = new FrmApplicationForLeave();
            applicationForLeave.Show(dockPanel1);
        }

        //考勤查询
        private void 考勤查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearch search = new FrmSearch();
            search.Show(dockPanel1);
        }

        //请假查询
        private void 请假查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLeaveSearch leaveSearch = new FrmLeaveSearch();
            leaveSearch.Show(dockPanel1);
        }

        //串口转换
        private void ToolStripMenuItemModifySerialPort_Click(object sender, EventArgs e)
        {
            FrmSerialPort serialPort = new FrmSerialPort();
            this.Hide();
            serialPort.ShowDialog();
        }

        private void toolStripStatuslblQuitOrModify_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否注销用户？", "返回普通用户界面", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Frmwelcome welcome = new Frmwelcome();
                this.Hide();
                welcome.ShowDialog();
            }
            else
            {
                this.Show();
            }
        }
    }
}
