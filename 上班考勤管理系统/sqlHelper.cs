using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace 上班考勤管理系统
{
    class SqlHelper
    {
        //已修改
        #region 变量

        public string cardID;
        public string name;
        public string sex;
        public string PeoplePosition;
        public string identifyCardID;
        public string manageCode;
        public string cardInfoCardID;
        public string cardInfoName;
        public string cardInfoSex;
        public string cardInfoPeoplePosition;
        public string cardInfoLeaveTime;
        public string cardInfoLeaveReason;
        public string cardInfoSignStatus;
        public string cardInfoTime;
        public string cardInfoidentifyCardID;
        public string status;
        //建立连接字符串
        //public string connection = "server=.;database=db_PersonnelSignInSystem;uid=sa;pwd=123";
        public string connectionWin = @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True";//修改
        public int i = 0;
        //创建SqlConnection对象
        SqlConnection sc = new SqlConnection();
        #endregion

        /// <summary>
        /// 人员信息表 卡号 名字 性别 职位 身份证号
        /// tb_Employees e_cardID e_name e_Sex e_PeoplePosition e_identifyCardID
        /// </summary>
        #region 查询是否存在该卡用户（管理员）

        //已修改添加
        public bool CheckLoginID()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_Employees where e_CardID='" + cardID + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//windows连接
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        //已修改
        #region 登记信息
        public void Insert()
        {
            sc.ConnectionString = connectionWin;     //设置SqlConnecttion对象的连接字符串
            try
            {
                sc.Open();                         //打开数据库连接
                SqlCommand cmd = new SqlCommand(); //创建SqlCommand对象
                cmd.CommandType = CommandType.Text;//设置SqlCommand对象执行SQL文本命令
                cmd.Connection = sc;               //设置SqlCommand对象的Connection属性
                cmd.CommandText =                  //设置SqlCommand对象执行的Sql语句
                    "INSERT INTO tb_Employees values( '" + cardID + "','" + name + "','" + sex + "','"+ PeoplePosition + "','" + identifyCardID + "','"+manageCode+"')";
                i = cmd.ExecuteNonQuery();         //返回数据库中受影响的行数
            }
            finally
            {

                sc.Close();
            }
        }
        #endregion

        #region 查询是否已登记

        //已修改添加
        public bool CheckEmployees()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_Employees where e_CardID='" + cardID + "'", connectionWin);//windows连接
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region 确认签到时该卡是否还在数据库
        public bool CheckPunchCardInformation(string cardID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_Employees where e_CardID='" + cardID + "'", connectionWin);//windows连接
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 查询是否已经删除
        public bool CheckDeleteInformation(string cardID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_Employees where e_CardID='" + cardID + "'", connectionWin);//windows连接
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 查询本月是否已经请过假
        public bool CheckForLeave(string cardID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_Leave where 卡号='" + cardID + "'", connectionWin);//windows连接
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion       

        #region 查询未签到的人数
        public void CheckNotpunchInformation()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_Employees where NOT EXISTS(select 卡号 from tb_SignIN where tb_Employees.e_CardID = tb_SignIN.卡号)", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//windows连接
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中
            DataView dataCard = new DataView(ds.Tables[0]);    //创建自定义视图并将SQL语句执行结果存储在自定义视图中

            foreach (DataRowView row in dataCard)              //遍历自定义视图(SQL语句执行结果)并将结果分别存储在变量中
            {
                cardInfoCardID = row["e_CardID"].ToString();
                cardInfoName = row["e_Name"].ToString();
                cardInfoSex = row["e_Sex"].ToString();
                cardInfoidentifyCardID = row["e_IdentifyCardID"].ToString();
            }
        }
        #endregion

        #region 将未签到的人员存入数据库
        public void InsertNotPunch()
        {
            sc.ConnectionString = connectionWin;   ////设置SqlConnecttion对象的连接字符串(通过Windows服务器连接数据库)
            try
            {
                string s_SignStatus = null;
                sc.Open();                         //打开数据库连接
                SqlCommand cmd = new SqlCommand(); //创建SqlCommand对象
                cmd.CommandType = CommandType.Text;//设置SqlCommand对象执行SQL文本命令
                cmd.Connection = sc;               //设置SqlCommand对象的Connection属性
                cmd.CommandText =                  //设置SqlCommand对象执行的Sql语句
                        "INSERT INTO tb_SignIN values( '" + cardInfoCardID + "', '" + cardInfoName + "', '" + cardInfoSex + "','" + cardInfoidentifyCardID + "','" + s_SignStatus + "','" + DateTime.Today + "')";
                i = cmd.ExecuteNonQuery();         //返回数据库中受影响的行数                
            }
            finally
            {
                sc.Close();
            }            
        }
        #endregion

        #region
        public bool ConflictPunch(string SignStatus)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_SignIN where s_CardID = '" + cardInfoCardID + "'and s_SignStatus='" + SignStatus + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//通过SqlDataAdapter对象执行SQL语句           
            DataSet ds = new DataSet();    //创建DataSet缓存对象 
            sda.Fill(ds);                  //将查询结果存储在ds中

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 为未签到的人附加缺勤
        public void StoreNotpunch()
        {
            
            try
            {
                if (cardInfoCardID == "")
                {

                }
                else
                {
                    string SignStatus = "缺勤";
                    string s_SignStatus = null;
                    String connsql = @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True";
                    SqlConnection MyConnection = new SqlConnection(connsql);
                    string MyUpdate = "Update tb_SignIN set 签到状态='" + SignStatus + "'where 卡号='" + cardInfoCardID + "'and 签到状态 = '" + s_SignStatus + "'";
                    SqlCommand MyCommand = new SqlCommand(MyUpdate, MyConnection);
                    MyConnection.Open();
                    MyCommand.ExecuteNonQuery();
                    MyConnection.Close();
                }
            }
            catch
            {
                MessageBox.Show("已经是当前所有情况！");
            }
        }
        #endregion

        #region 返回受影响的行数
        public int IsSuccess()
        {
            return i;
        }
        #endregion

        #region 判断是否已经签到
        public bool CheckInOrOutPunch(string cardID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_SignIN where 卡号='" + cardID + "'", connectionWin);//windows连接
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }//s_SignStatus

            
            /*DataView dataCard = new DataView(ds.Tables[0]);    //创建自定义视图并将SQL语句执行结果存储在自定义视图中
            foreach (DataRowView row in dataCard)              //遍历自定义视图(SQL语句执行结果)并将结果分别存储在变量中
            {
                cardInfoSignStatus = row["s_SignStatus"].ToString();
            }*/
        }
        #endregion

        #region
        public void SwitchStatus(string cardID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select 签到状态 from tb_SignIN where 卡号='" + cardID + "'and 时间 = '" + DateTime.Today + "'", connectionWin);//windows连接
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中

            DataView dataCard = new DataView(ds.Tables[0]);    //创建自定义视图并将SQL语句执行结果存储在自定义视图中
            foreach (DataRowView row in dataCard)              //遍历自定义视图(SQL语句执行结果)并将结果分别存储在变量中
            {
                cardInfoSignStatus = row["s_SignStatus"].ToString();
            }            
        }
        #endregion

        #region 将判定签到状态返回
        public string CheckInOrOutStatus()
        {
            status = cardInfoSignStatus;
            return status;
            /*string status = cardInfoSignStatus;
            if (status == "已签到" || status == "迟到")
            {
                MessageBox.Show("您已签到成功！无需再签！");
            }
            else
            {
                //签到
            }
            if (status == "早退" || status == "已签退")
            {
                MessageBox.Show("您已签退成功！无需再签！");
            }
            else
            {
                //签退
            }*/
        }
        #endregion

        /// <summary>
        /// 连接数据库并删除库内该表内容
        /// </summary>
        /// <param name="CheckingOut"></param>
        /// <returns></returns>
        /*String MyConn = "server=.;database=db_PersonnelSignInSystem;uid=sa;pwd=123";
        SqlConnection MyConnection = new SqlConnection(MyConn);
        string MyDelete = "delete from tb_Employees where e_CardID='" + DeleteInOrOut + "'";
        SqlCommand MyCommand = new SqlCommand(MyDelete, MyConnection);*/

        //添加删除（已修改）
        #region 注销
        public DataSet Delete(string DeleteInOrOut)
        {
            SqlDataAdapter sda = new SqlDataAdapter("delete from tb_Employees where e_CardID='" + DeleteInOrOut + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//通过SqlDataAdapter对象执行SQL语句
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中
            return ds;                     //返回ds
        }
        #endregion  
  
        #region 返回删除的信息
        public DataSet ReturnDelete()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_Employees", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//允许SQL Windows服务器登录
            DataSet ds = new DataSet();//创建DataSet缓存对象
            sda.Fill(ds);              //将查询结果存储在ds中
            return ds;                 //返回ds
        }
        #endregion

        //添加查询，为注销确认信息（已修改添加）
        #region 查询人员信息
        public DataSet Search(string CheckingOut)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select e_CardID,e_Name,e_Sex,e_PeoplePosition,e_IdentifyCardID from tb_Employees where e_CardID='" + CheckingOut + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//通过SqlDataAdapter对象执行SQL语句
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中
            return ds;                     //返回ds
        }
        #endregion

        #region 查询签到/签退情况
        public DataSet CheckingInOrOut(string CheckingInOrOut)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_SignIN where 签到状态='" + CheckingInOrOut + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//通过SqlDataAdapter对象执行SQL语句
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中
            return ds;                     //返回ds
        }
        #endregion

        #region 具体查询
        public DataSet CheckingDetails(string CheckingInOrOut, string SearchDate)
        {

            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_SignIN where 签到状态='" + CheckingInOrOut + "'and s_Time ='" + SearchDate + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//通过SqlDataAdapter对象执行SQL语句
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中
            return ds;                     //返回ds
        }
        #endregion

        //已修改
        #region 查询签到/签退的卡对应的人员信息
        public void SearchCardInfo(string CardID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select e_CardID,e_Name,e_Sex,e_PeoplePosition,e_IdentifyCardID  from tb_Employees where e_CardID='" + CardID + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");
            DataSet ds = new DataSet();                        //建立数据集对象
            sda.Fill(ds);                                      //将SQL语句执行结果缓存在数据集ds中
            DataView dataCard = new DataView(ds.Tables[0]);    //创建自定义视图并将SQL语句执行结果存储在自定义视图中


            foreach (DataRowView row in dataCard)              //遍历自定义视图(SQL语句执行结果)并将结果分别存储在变量中
            {
                cardInfoCardID = row["e_CardID"].ToString();
                cardInfoName = row["e_Name"].ToString();
                cardInfoSex = row["e_Sex"].ToString();
                cardInfoPeoplePosition = row["e_PeoplePosition"].ToString();
                cardInfoidentifyCardID = row["e_IdentifyCardID"].ToString();
            }            
        }
        #endregion

        #region 清空签到数据
        public DataSet DeleteMassage()
        {
            SqlDataAdapter sda = new SqlDataAdapter("delete from tb_SignIN", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//通过SqlDataAdapter对象执行SQL语句
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中
            return ds;                     //返回ds
        }
        #endregion  

        #region 刷新已进行会议签到的人员信息
        public DataSet RefreshPunchInfo()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_SignIN", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//允许SQL Windows服务器登录
            DataSet ds = new DataSet();//创建DataSet缓存对象
            sda.Fill(ds);              //将查询结果存储在ds中
            return ds;                 //返回ds
        }
        #endregion

        /// <summary>
        /// 请假表 卡号 名字 请假理由 请假时间
        /// tb_Leave l_CardID l_Name l_Sex l_PeoplePosition l_LeaveReason l_LeaveTime l_WhetherLeave l_Time
        /// </summary>
        /// <param name="SignStatus"></param>

        //请假，已添加修改
        #region 将请假信息存入数据库
        public void InsertLeaveInfo(string LeaveTime,string LeaveReason)
        {
            sc.ConnectionString = connectionWin;   ////设置SqlConnecttion对象的连接字符串(通过Windows服务器连接数据库)
            try
            {
                string l_WhetherLeave = "";
                string l_Time = "";
                sc.Open();                         //打开数据库连接
                SqlCommand cmd = new SqlCommand(); //创建SqlCommand对象
                cmd.CommandType = CommandType.Text;//设置SqlCommand对象执行SQL文本命令
                cmd.Connection = sc;               //设置SqlCommand对象的Connection属性
                cmd.CommandText =                  //设置SqlCommand对象执行的Sql语句
                    "INSERT INTO tb_Leave values( '" + cardInfoCardID + "', '" + cardInfoName + "', '" + cardInfoSex + "','" + cardInfoPeoplePosition + "','" + LeaveReason + "', '" + LeaveTime + "','" + l_WhetherLeave + "','" + l_Time + "')";
                i = cmd.ExecuteNonQuery();         //返回数据库中受影响的行数
            }
            finally
            {
                sc.Close();
            }
        }
        #endregion     

        //请假信息查询
        #region 请假信息查询
        public DataSet CheckingReadLeave()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_Leave ", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//通过SqlDataAdapter对象执行SQL语句
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中
            return ds;                     //返回ds
        }
        #endregion

        //管理是否批假
        #region 管理是否批假
        public void ManagementLeave(string WhetherLeave,string LeaveCard)
        {
            String connsql = @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connsql);
            string MyUpdate = "Update tb_Leave set 是否批假='" + WhetherLeave + "',时间='" + DateTime.Now + "' where 卡号=" + "'" + LeaveCard + "'";
            SqlCommand MyCommand = new SqlCommand(MyUpdate, MyConnection);
            try
            {
                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();
                MessageBox.Show("管理成功！！！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 找到当前已经批假的人的信息
        public void CheckLeaveAll(string CardID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select 卡号,姓名,性别,请假时间 from tb_Leave where 卡号='" + CardID + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");
            DataSet ds = new DataSet();                        //建立数据集对象
            sda.Fill(ds);                                      //将SQL语句执行结果缓存在数据集ds中
            DataView dataCard = new DataView(ds.Tables[0]);    //创建自定义视图并将SQL语句执行结果存储在自定义视图中


            foreach (DataRowView row in dataCard)              //遍历自定义视图(SQL语句执行结果)并将结果分别存储在变量中
            {
                cardInfoCardID = row["卡号"].ToString();
                cardInfoName = row["姓名"].ToString();
                cardInfoSex = row["性别"].ToString();
                cardInfoTime = row["请假时间"].ToString();
            }
        }
        #endregion

        #region 将已经批假的人的信息存入数据库的签到状态表中
        public void InsertFoundLeaveInformation()
        {
            sc.ConnectionString = connectionWin;   ////设置SqlConnecttion对象的连接字符串(通过Windows服务器连接数据库)
            try
            {
                string SignStatus = "已请假";
                string IDInformation = "";
                sc.Open();                         //打开数据库连接
                SqlCommand cmd = new SqlCommand(); //创建SqlCommand对象
                cmd.CommandType = CommandType.Text;//设置SqlCommand对象执行SQL文本命令
                cmd.Connection = sc;               //设置SqlCommand对象的Connection属性
                cmd.CommandText =                  //设置SqlCommand对象执行的Sql语句
                    "INSERT INTO tb_SignIN values( '" + cardInfoCardID + "','" + cardInfoName + "','" + cardInfoSex + "','"+IDInformation+"','" + SignStatus + "','" + cardInfoTime + "')";
                i = cmd.ExecuteNonQuery();         //返回数据库中受影响的行数              
            }
            finally
            {
                sc.Close();
            }
        }
        #endregion

        //查询是否已经批假
        #region 查询是否已经批假
        public DataSet CheckingLeaveOK(string CheckingWhether)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_Leave where 卡号='" + CheckingWhether + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//通过SqlDataAdapter对象执行SQL语句
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中
            return ds;                     //返回ds
        }
        #endregion

        /// <summary>
        /// 签到信息表 卡号 姓名 性别 到签状况 签到时间
        /// tb_SignIN s_cardID s_name s_Sex s_SignStatus s_Time
        /// </summary>
        /// <param name="SignStatus"></param>

        #region 将签到签退信息存入数据库
        public void InsertCheckInfo(string SignStatus)
        {
            sc.ConnectionString = connectionWin;   ////设置SqlConnecttion对象的连接字符串(通过Windows服务器连接数据库)
            try
            {
                sc.Open();                         //打开数据库连接
                SqlCommand cmd = new SqlCommand(); //创建SqlCommand对象
                cmd.CommandType = CommandType.Text;//设置SqlCommand对象执行SQL文本命令
                cmd.Connection = sc;               //设置SqlCommand对象的Connection属性
                cmd.CommandText =                  //设置SqlCommand对象执行的Sql语句
                    "INSERT INTO tb_SignIN values( '" + cardInfoCardID + "','" + cardInfoName + "','" + cardInfoSex + "','" + cardInfoidentifyCardID + "','" + SignStatus + "','" + DateTime.Today + "')";
                i = cmd.ExecuteNonQuery();         //返回数据库中受影响的行数              
            }
            finally
            {
                sc.Close();
            }
        }
        #endregion

        /// <summary>
        /// 会议信息签到表 卡号 姓名 性别 签到时间
        /// tb_Meeting m_cardID m_name m_Sex m_Time
        /// </summary>

        #region 将会议签到信息存入数据库
        public void InsertMeetingSignInfo()
        {
            sc.ConnectionString = connectionWin;   //设置SqlConnecttion对象的连接字符串(通过Windows服务器连接数据库)
            try
            {
                sc.Open();                         //打开数据库连接
                SqlCommand cmd = new SqlCommand(); //创建SqlCommand对象
                cmd.CommandType = CommandType.Text;//设置SqlCommand对象执行SQL文本命令
                cmd.Connection = sc;               //设置SqlCommand对象的Connection属性
                cmd.CommandText =                  //设置SqlCommand对象执行的Sql语句
                    "INSERT INTO tb_Meeting values( '" + cardInfoCardID + "', '" + cardInfoName + "', '" + cardInfoSex + "', '" + DateTime.Now + "')";
                i = cmd.ExecuteNonQuery();         //返回数据库中受影响的行数
            }
            finally
            {
                sc.Close();
            }
        }
        #endregion

        #region 刷新已进行会议签到的人员信息
        public DataSet RefreshMeetingSignInfo()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_Meeting", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//允许SQL Windows服务器登录
            DataSet ds = new DataSet();//创建DataSet缓存对象
            sda.Fill(ds);              //将查询结果存储在ds中
            return ds;                 //返回ds
        }
        #endregion

        #region 判断是否已经签到
        public bool SearchMeeting(string CardID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_Meeting where 卡号='" + CardID + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//允许SQL Windows服务器登录
            DataSet ds = new DataSet();//创建DataSet缓存对象
            sda.Fill(ds);              //将查询结果存储在ds中

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 清空会议数据
        public DataSet DeleteData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("delete from tb_Meeting", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//通过SqlDataAdapter对象执行SQL语句
            DataSet ds = new DataSet();    //创建DataSet缓存对象
            sda.Fill(ds);                  //将查询结果存储在ds中
            return ds;                     //返回ds
        }
        #endregion  

        #region 统计当前情况
        public int statistics(string SignStatus)
        {
            int row;
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_SignIN where 签到状态='" + SignStatus + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//通过SqlDataAdapter对象执行SQL语句           
            DataSet ds = new DataSet();    //创建DataSet缓存对象 
            sda.Fill(ds);                  //将查询结果存储在ds中
            if (ds.Tables[0].Rows.Count > 0)
            {
                row = ds.Tables[0].Rows.Count;
                return row;                //返回统计结果
            }
            else
            {
                return row = 0;
                MessageBox.Show("没有该情况的信息！！！");
            }
        }
        #endregion

        #region
        public bool ConflictID(string ID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_SignIN where 身份证号='" + ID + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");
            DataSet ds = new DataSet();                        //建立数据集对象
            sda.Fill(ds);                                      //将SQL语句执行结果缓存在数据集ds中
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion

        #region
        public DataSet SearchDetail(DateTime Start, DateTime End)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_SignIN where 时间 between '" + Start + "' and '" + End + "'", @"Data Source=localhost\SQLExpress;Initial Catalog=db_PersonnelSignlnSystem;Integrated Security=True");//允许SQL Windows服务器登录
            DataSet ds = new DataSet();//创建DataSet缓存对象
            sda.Fill(ds);              //将查询结果存储在ds中
            return ds;                 //返回ds
        }
        #endregion

    }
}

