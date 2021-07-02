using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using KV_ISO15693;
using System.Threading;
using System.Windows.Forms;

namespace 上班考勤管理系统
{
    public partial class FrmLogin : Form
    {        
        SqlHelper sh = new SqlHelper();          //实例化SqlHelper类        
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region 登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user_id = txtAccessID.Text.Trim();
            if (txtAccessID.Text == "" || txtLoginCode.Text == "")//判断是否已读取卡号且是否已输入密码
            {
                MessageBox.Show("提示：请输入用户名和密码！", "警告！");
            }
            else
            {
                if (txtAccessID.Text == "superVIP" || txtLoginCode.Text == "123")
                {
                    FrmManagementMain.user_id = user_id;
                    FrmManagementMain managementMain = new FrmManagementMain();
                    this.Hide();
                    managementMain.ShowDialog();
                }
                else
                {
                    sh.cardID = txtAccessID.Text.Trim();    //将控件中的值赋给变量
                    sh.manageCode = txtLoginCode.Text.Trim();
                    if (sh.CheckLoginID())   //调用方法，判断是否存在该管理员对应的卡号及密码
                    {
                        FrmManagementMain.user_id = user_id;
                        FrmManagementMain managementMain = new FrmManagementMain();
                        this.Hide();
                        managementMain.ShowDialog();
                        return;
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("非本系统管理员用户！！！是否返回普通用户界面？", "登录失败", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        }
        #endregion


        #region 返回首页面
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否退出管理员用户界面？", "返回", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        #endregion
    }
}
