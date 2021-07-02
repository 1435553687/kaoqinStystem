namespace 上班考勤管理系统
{
    partial class FrmSerialPort
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSerialPortSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbPort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnSerialPortSelect
            // 
            this.BtnSerialPortSelect.Location = new System.Drawing.Point(313, 69);
            this.BtnSerialPortSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSerialPortSelect.Name = "BtnSerialPortSelect";
            this.BtnSerialPortSelect.Size = new System.Drawing.Size(100, 29);
            this.BtnSerialPortSelect.TabIndex = 0;
            this.BtnSerialPortSelect.Text = "串口选择";
            this.BtnSerialPortSelect.UseVisualStyleBackColor = true;
            this.BtnSerialPortSelect.Click += new System.EventHandler(this.BtnSerialPortSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择串口号：";
            // 
            // CmbPort
            // 
            this.CmbPort.FormattingEnabled = true;
            this.CmbPort.Location = new System.Drawing.Point(153, 72);
            this.CmbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbPort.Name = "CmbPort";
            this.CmbPort.Size = new System.Drawing.Size(127, 23);
            this.CmbPort.TabIndex = 2;
            // 
            // FrmSerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 170);
            this.Controls.Add(this.CmbPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSerialPortSelect);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSerialPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口选择";
            this.Load += new System.EventHandler(this.FrmSerialPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSerialPortSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbPort;
    }
}

