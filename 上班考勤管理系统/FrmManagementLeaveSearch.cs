using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace 上班考勤管理系统
{
    public partial class FrmManagementLeaveSearch : DockContent
    {
        SqlHelper sh = new SqlHelper();          //实例化SqlHelper类
        public FrmManagementLeaveSearch()
        {
            InitializeComponent();
        }

        //检索所有
        #region 检索所有
        private void btnAllLeave_Click(object sender, EventArgs e)
        {
            try //如果cmbCheckStatus不为空
            {
                DataSet ds = sh.CheckingReadLeave();//调用CheckingInOrOut方法查询指定条件的签到/签退信息并将返回的结果存储在DataSet缓存中
                dgvCheckInOrOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckInOrOutInfo的数据源显示查询结果
            }
            catch
            {
                MessageBox.Show("查询失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        //批假管理
        private void btnComflict_Click(object sender, EventArgs e)
        {
            string Whether = cmbComfilctLeave.Text.ToString();//强转字符类型
            if (txtAccessID.Text.Trim() =="")
            {
                MessageBox.Show("没有输入卡号!请先输入卡号！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmbComfilctLeave.Text.Trim() == "不批")
                {                    
                    sh.ManagementLeave(Whether, txtAccessID.Text);//调用方法批假管理
                    cmbComfilctLeave.Text = txtAccessID.Text = "";
                }
                else
                {                   
                    sh.ManagementLeave(Whether, txtAccessID.Text.Trim());//调用方法批假管理
                    sh.CheckLeaveAll(txtAccessID.Text.Trim()); //找到当前已经被批假的人
                    sh.InsertFoundLeaveInformation();          //将当前被批假的人信息存入签到表
                    int i = sh.IsSuccess();
                    if (i > 0)
                    {
                        cmbComfilctLeave.Text = txtAccessID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("请假信息存入签到表失败！请再试！","提示");
                    }
                }
            }
        }
    }
}
