using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace 上班考勤管理系统
{
    public partial class FrmManagementMain : Form
    {
        public static string user_id;
        public FrmManagementMain()
        {
            InitializeComponent();
        }

        private void FrmManagementMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel登录名.Text = user_id;
            FrmManagementMenu managementMenu = new FrmManagementMenu();
            managementMenu.Show(dockPanel2, DockState.DockLeft);
            dockPanel2.DockLeftPortion = 240;
            FrmManagementHome managementHome = new FrmManagementHome();
            managementHome.Show(dockPanel2);
        }

        private void toolStripMenuItemPunchCard_Click(object sender, EventArgs e)
        {
            FrmHairpin hairpin = new FrmHairpin();//将窗体实例化
            hairpin.Show(dockPanel2);//窗体show（）
        }

        private void toolStripMenuItemCancelCard_Click(object sender, EventArgs e)
        {
            FrmDeleteCard deleteCard = new FrmDeleteCard();
            deleteCard.Show(dockPanel2);
        }

        private void 打卡签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPunchCard punchCard = new FrmPunchCard();
            punchCard.Show(dockPanel2);
        }

        private void 会议签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMeeting meeting = new FrmMeeting();
            meeting.Show(dockPanel2);
        }

        private void ToolStripMenuItem请假_Click(object sender, EventArgs e)
        {
            FrmApplicationForLeave applicationForLeave = new FrmApplicationForLeave();
            applicationForLeave.Show(dockPanel2);
        }

        private void 考勤查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearch search = new FrmSearch();
            search.Show(dockPanel2);
        }

        private void 请假查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagementLeaveSearch managementLeaveSearch = new FrmManagementLeaveSearch();
            managementLeaveSearch.Show(dockPanel2);
        }

        private void ToolStripMenuItemModifySerialPort_Click(object sender, EventArgs e)
        {
            FrmManagementSerialPort ManagementSerialPort = new FrmManagementSerialPort();
            this.Hide();
            ManagementSerialPort.ShowDialog();
        }

        private void toolStripStatuslblQuit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否注销用户？", "退出登录", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
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
