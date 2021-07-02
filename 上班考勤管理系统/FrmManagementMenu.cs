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
    public partial class FrmManagementMenu : DockContent
    {
        public FrmManagementMenu()
        {
            InitializeComponent();
        }


        #region 判断窗体是否已开过
        private void OpenForm(DockContent frm)
        {
            FrmManagementMain ManagementMain = (FrmManagementMain)this.Parent.Parent.Parent.Parent;//获取当前窗体的父窗体
            string name = frm.Name;
            foreach (Form item in ManagementMain.MdiChildren)
            {
                if (item.Name == name)  //判断是否打开过该窗体，若打开过则激活该窗体
                {
                    item.Activate();
                    return;
                }
            }
            ManagementMain.IsMdiContainer = true;//设置父窗体为容器窗体
            frm.MdiParent = ManagementMain;//设置子窗体的父窗体
            frm.DockHandler.Show(ManagementMain.dockPanel2);//打开子窗体
        }
        #endregion

        //信息录入
        private void lblAddInformation_Click(object sender, EventArgs e)
        {
            FrmHairpin hairpin = new FrmHairpin();
            OpenForm(hairpin);
        }

        //打卡签到
        private void lblPunch_Click(object sender, EventArgs e)
        {
            FrmManagementPunchCard managementpunchCard = new FrmManagementPunchCard();
            OpenForm(managementpunchCard);
        }

        //会议签到
        private void lblMeettingCard_Click(object sender, EventArgs e)
        {
            FrmManagementMeeting managementMeeting = new FrmManagementMeeting();
            OpenForm(managementMeeting);
        }

        //请假管理
        private void lblTravel_Click(object sender, EventArgs e)
        {
            FrmManagamentApplicationForLeave managamentApplicationForLeave = new FrmManagamentApplicationForLeave();
            OpenForm(managamentApplicationForLeave);
        }

        //考勤查询
        private void lblSearchInformation_Click(object sender, EventArgs e)
        {
            FrmManagementSearch ManagementSearch = new FrmManagementSearch();
            OpenForm(ManagementSearch);
        }

        //注销卡号
        private void lblDeleteCard_Click(object sender, EventArgs e)
        {
            FrmDeleteCard DeleteCard = new FrmDeleteCard();
            OpenForm(DeleteCard);
        }

        //请假查询及批假
        private void lblSearchLeaveOrConflict_Click(object sender, EventArgs e)
        {
            FrmManagementLeaveSearch managementLeaveSearch = new FrmManagementLeaveSearch();
            OpenForm(managementLeaveSearch);
        }

    }
}
