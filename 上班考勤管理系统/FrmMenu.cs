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
    public partial class FrmMenu : DockContent
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        //打卡签到
        private void lblPunch_Click(object sender, EventArgs e)
        {         
            FrmPunchCard punchCard = new FrmPunchCard();
            OpenForm(punchCard);
        }
        //会议签到
        private void lblMeettingCard_Click(object sender, EventArgs e)
        {
            FrmMeeting meeting = new FrmMeeting();
            OpenForm(meeting);
        }
        //请假管理
        private void lblTravel_Click(object sender, EventArgs e)
        {
            FrmApplicationForLeave applicationForLeave = new FrmApplicationForLeave();
            OpenForm(applicationForLeave);
        }
        //考勤查询
        private void lblSearchInformation_Click(object sender, EventArgs e)
        {
            FrmSearch search = new FrmSearch();
            OpenForm(search);
        }

        //请假查询
        private void lblSearchLeave_Click(object sender, EventArgs e)
        {
            FrmLeaveSearch leaveSearch = new FrmLeaveSearch();
            OpenForm(leaveSearch);
        }

        //定义一个方法，判断窗体如果已经打开过了，则再点击就会显示到最前端已打开过的窗口
        #region 判断窗体是否已开过
        private void OpenForm(DockContent frm)
        {
            FrmMain main = (FrmMain)this.Parent.Parent.Parent.Parent;//获取当前窗体的父窗体
            string name = frm.Name;
            foreach (Form item in main.MdiChildren)
            {
                if (item.Name == name)  //判断是否打开过该窗体，若打开过则激活该窗体
                {                    
                    item.Activate();
                    return;
                }
            }
            main.IsMdiContainer = true;//设置父窗体为容器窗体
            frm.MdiParent = main;//设置子窗体的父窗体
            frm.DockHandler.Show(main.dockPanel1);//打开子窗体
        }
        #endregion
    }
}
