using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 上班考勤管理系统
{
    static class Program
    {
        public static string PortName = "";//定义接口名称变量
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //入口传参，以便主界面能停止项目运行
            Frmwelcome welcome = new Frmwelcome();
            if (welcome.ShowDialog() == DialogResult.OK)
            {
                FrmSerialPort SerialPort = new FrmSerialPort();
                if (SerialPort.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FrmMain());
                }
            }
        }
    }
}
