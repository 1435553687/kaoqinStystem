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
    public partial class FrmLeaveSearch : DockContent
    {
        SqlHelper sh = new SqlHelper();          //实例化SqlHelper类
        public FrmLeaveSearch()
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

        #region 查询是否批假
        private void btnComflict_Click(object sender, EventArgs e)
        {
            if (this.txtAccessID.Text =="") //如果cmbCheckStatus不为空
            { 
                MessageBox.Show("查询失败，请先选择查询卡号再进行查询！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = sh.CheckingLeaveOK(txtAccessID.Text.Trim());//调用CheckingLeaveOK方法查询指定条件的签到/签退信息并将返回的结果存储在DataSet缓存中          
                dgvCheckInOrOutInfo.DataSource = ds.Tables[0];              //通过设置dgvCheckInOrOutInfo的数据源显示查询结果
            }
        }
        #endregion
    }
}
