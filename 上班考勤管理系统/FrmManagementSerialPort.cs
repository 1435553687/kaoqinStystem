using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace 上班考勤管理系统
{
    public partial class FrmManagementSerialPort : Form
    {
        public FrmManagementSerialPort()
        {
            InitializeComponent();
        }

        //连接串口
        private void BtnSerialPortSelect_Click(object sender, EventArgs e)
        {
            Program.PortName = CmbPort.Text.Trim();
            Hide();
            FrmLogin login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
        }
        
        //获取连接串口
        private void FrmManagementSerialPort_Load(object sender, EventArgs e)
        {
            //获取当前计算机串口数组
            String[] PortNames = System.IO.Ports.SerialPort.GetPortNames();
            this.CmbPort.Items.Clear();
            if (PortNames.Length > 0)
            {
                for (Int32 i = 0; i < PortNames.Length; i++)
                {
                    if (PortNames[i].Length >= 7) continue;
                    this.CmbPort.Items.Add(PortNames[i]);
                }
                this.CmbPort.SelectedIndex = 0;
            }
            else
            { this.CmbPort.Text = "无串口"; }
        }
    }
}
