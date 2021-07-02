namespace 上班考勤管理系统
{
    partial class FrmManagementSerialPort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmbPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSerialPortSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbPort
            // 
            this.CmbPort.FormattingEnabled = true;
            this.CmbPort.Location = new System.Drawing.Point(165, 66);
            this.CmbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbPort.Name = "CmbPort";
            this.CmbPort.Size = new System.Drawing.Size(127, 23);
            this.CmbPort.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "请选择串口号：";
            // 
            // BtnSerialPortSelect
            // 
            this.BtnSerialPortSelect.Location = new System.Drawing.Point(327, 62);
            this.BtnSerialPortSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSerialPortSelect.Name = "BtnSerialPortSelect";
            this.BtnSerialPortSelect.Size = new System.Drawing.Size(100, 29);
            this.BtnSerialPortSelect.TabIndex = 3;
            this.BtnSerialPortSelect.Text = "串口选择";
            this.BtnSerialPortSelect.UseVisualStyleBackColor = true;
            this.BtnSerialPortSelect.Click += new System.EventHandler(this.BtnSerialPortSelect_Click);
            // 
            // FrmManagementSerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 159);
            this.Controls.Add(this.CmbPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSerialPortSelect);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(486, 206);
            this.MinimumSize = new System.Drawing.Size(486, 206);
            this.Name = "FrmManagementSerialPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口选择";
            this.Load += new System.EventHandler(this.FrmManagementSerialPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSerialPortSelect;
    }
}