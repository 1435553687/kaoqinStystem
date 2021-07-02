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
    public partial class FrmSearch : DockContent
    {        
        SqlHelper sh = new SqlHelper();          //实例化SqlHelper类
        public FrmSearch()
        {
            InitializeComponent();
        }        

        #region 查询签到/签退情况
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbCheckStatus.Text.Trim() =="") //如果cmbCheckStatus不为空
            {
                MessageBox.Show("查询失败，请先选择查询条件再进行查询！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCheckStatus.Text.Trim() == "缺勤")
            {
                sh.CheckNotpunchInformation();    //查询未签到的人员            
                sh.InsertNotPunch();              //将未签到的人的基础信息存入数据库
                sh.StoreNotpunch();               //各未签到的人附加缺勤
                DataSet ds = sh.CheckingInOrOut(cmbCheckStatus.Text.Trim());//调用CheckingInOrOut方法查询指定条件的签到/签退信息并将返回的结果存储在DataSet缓存中
                dgvCheckInOrOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckInOrOutInfo的数据源显示查询结果              
            }
            else
            {
                DataSet ds = sh.CheckingInOrOut(cmbCheckStatus.Text.Trim());//调用CheckingInOrOut方法查询指定条件的签到/签退信息并将返回的结果存储在DataSet缓存中
                dgvCheckInOrOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckInOrOutInfo的数据源显示查询结果
            }
        }
        #endregion

        #region 查询具体情况
        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            DateTime Start = DateTime.Parse(txtEndTime.Text.Trim());//时间转换
            DateTime End = DateTime.Parse(txtEndTime.Text.Trim());
            string ID = txtAccessID.Text.Trim();
            if (cmbCheckStatus.Text.Trim() == "") //如果cmbCheckStatus不为空
            {
                MessageBox.Show("查询失败，请先选择查询条件再进行查询！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCheckStatus.Text.Trim() == "缺勤")
            {
                if (sh.ConflictID(txtAccessID.Text.Trim()))
                {
                    sh.CheckNotpunchInformation();    //查询未签到的人员            
                    sh.InsertNotPunch();              //将未签到的人的基础信息存入数据库
                    sh.StoreNotpunch();               //各未签到的人附加缺勤
                    DataSet ds = sh.SearchDetail(Start, End);//调用CheckingInOrOut方法查询指定条件的签到/签退信息并将返回的结果存储在DataSet缓存中
                    dgvCheckInOrOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckInOrOutInfo的数据源显示查询结果 
                }
                else
                {
                    MessageBox.Show("没有该身份证号相关信息！", "提示");
                }
            }
            else
            {
                if (sh.ConflictID(txtAccessID.Text.Trim()))
                {
                    DataSet ds = sh.SearchDetail(Start, End);//调用CheckingInOrOut方法查询指定条件的签到/签退信息并将返回的结果存储在DataSet缓存中
                    dgvCheckInOrOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckInOrOutInfo的数据源显示查询结果 
                }
                else
                {
                    MessageBox.Show("没有该身份证号相关信息！", "提示");
                }
            }
        }
        #endregion
    }
}
