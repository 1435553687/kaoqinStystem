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
    public partial class FrmManagementSearch : DockContent
    {
        SqlHelper sh = new SqlHelper();          //实例化SqlHelper类
        public FrmManagementSearch()
        {
            InitializeComponent();
        }

        #region 查询签到/签退情况
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbCheckStatus.Text.Trim() =="") //如果cmbCheckStatus 为空
            {
                MessageBox.Show("查询失败，请先选择查询条件再进行查询！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCheckStatus.Text.Trim() == "缺勤")
            {
                this.Timertwo.Enabled = true;       //启动运行Timetwo控件
            }
            else
            {
                DataSet ds = sh.CheckingInOrOut(cmbCheckStatus.Text.Trim());//调用CheckingInOrOut方法查询指定条件的签到/签退信息并将返回的结果存储在DataSet缓存中
                dgvCheckInOrOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckInOrOutInfo的数据源显示查询结果
            }
        }
        #endregion

        #region 清除全部
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("您是否要全部清除？", "清除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs == DialogResult.Yes)
            {
                sh.DeleteMassage();//清除签到数据
                this.TimerOne.Enabled = true;
            }
            else
            {
                this.Show();
            }
        }
        #endregion

        #region 刷新
        private void TimerOne_Tick(object sender, EventArgs e)
        {
            DataSet ds = sh.RefreshPunchInfo();//调用RefreshMeetingSignInfo()方法查询所有已进行会议签到的人员信息并将返回的结果存储在DataSet缓存中
            dgvCheckInOrOutInfo.DataSource = ds.Tables[0];    //通过设置dgvCheckInOrOutInfo的数据源显示查询结果
            this.TimerOne.Enabled = false;
        }
        #endregion

        #region 统计当前情况
        private void btnSum_Click(object sender, EventArgs e)
        {
            string Status = cmbCheckStatus.Text.Trim();
            int sum = sh.statistics(Status);
            this.textBox1.Text = sum.ToString();
        }
        #endregion

        #region 刷新缺勤
        private void Timertwo_Tick(object sender, EventArgs e)
        {
            sh.CheckNotpunchInformation();     //查询未签到的人员
            if (sh.ConflictPunch(cmbCheckStatus.Text.Trim()))  //ture
            {
                this.Timertwo.Enabled = false;
                MessageBox.Show("这已是目前所有情况！");  
            }
            else    //false
            {
                sh.InsertNotPunch();               //将未签到的人的基础信息存入数据库
                int i = sh.IsSuccess();
                if (i > 0)
                {
                    sh.StoreNotpunch();               //各未签到的人附加缺勤
                    DataSet ds = sh.CheckingInOrOut(cmbCheckStatus.Text.Trim());//调用CheckingInOrOut方法查询指定条件的签到/签退信息并将返回的结果存储在DataSet缓存中
                    dgvCheckInOrOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckInOrOutInfo的数据源显示查询结果 
                }
            }
        }
        #endregion

        #region 查询当日情况
        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            string SearchDate = dateTimePicker.Text.Trim();
            if (cmbCheckStatus.Text.Trim() == "") //如果cmbCheckStatus不为空
            {
                MessageBox.Show("查询失败，请先选择查询条件再进行查询！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCheckStatus.Text.Trim() == "缺勤")
            {
                sh.CheckNotpunchInformation();    //查询未签到的人员            
                sh.InsertNotPunch();              //将未签到的人的基础信息存入数据库
                sh.StoreNotpunch();               //各未签到的人附加缺勤
                DataSet ds = sh.CheckingDetails(cmbCheckStatus.Text.Trim(), SearchDate);//调用CheckingInOrOut方法查询指定条件的签到/签退信息并将返回的结果存储在DataSet缓存中
                dgvCheckInOrOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckInOrOutInfo的数据源显示查询结果                
            }
            else
            {
                DataSet ds = sh.CheckingDetails(cmbCheckStatus.Text.Trim(), SearchDate);//调用CheckingInOrOut方法查询指定条件的签到/签退信息并将返回的结果存储在DataSet缓存中
                dgvCheckInOrOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckInOrOutInfo的数据源显示查询结果 
            }
        }
        #endregion
    }        
}
