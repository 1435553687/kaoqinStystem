namespace 上班考勤管理系统
{
    partial class FrmPunchCard
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAccessID = new System.Windows.Forms.TextBox();
            this.lbAccessID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.TimeTwo = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAccessID);
            this.groupBox3.Controls.Add(this.lbAccessID);
            this.groupBox3.Location = new System.Drawing.Point(51, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 89);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "签到/签退";
            // 
            // txtAccessID
            // 
            this.txtAccessID.Enabled = false;
            this.txtAccessID.Location = new System.Drawing.Point(143, 39);
            this.txtAccessID.Name = "txtAccessID";
            this.txtAccessID.Size = new System.Drawing.Size(161, 21);
            this.txtAccessID.TabIndex = 10;
            // 
            // lbAccessID
            // 
            this.lbAccessID.AutoSize = true;
            this.lbAccessID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAccessID.Location = new System.Drawing.Point(60, 47);
            this.lbAccessID.Name = "lbAccessID";
            this.lbAccessID.Size = new System.Drawing.Size(65, 12);
            this.lbAccessID.TabIndex = 9;
            this.lbAccessID.Text = "人员卡号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "关闭串口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.Location = new System.Drawing.Point(91, 131);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(80, 32);
            this.btnOpenSerial.TabIndex = 7;
            this.btnOpenSerial.Text = "打开串口";
            this.btnOpenSerial.UseVisualStyleBackColor = true;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // TimeTwo
            // 
            this.TimeTwo.Interval = 1500;
            this.TimeTwo.Tick += new System.EventHandler(this.TimeTwo_Tick);
            // 
            // FrmPunchCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 204);
            this.Controls.Add(this.btnOpenSerial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(500, 242);
            this.MinimumSize = new System.Drawing.Size(500, 242);
            this.Name = "FrmPunchCard";
            this.Text = "打卡签到";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAccessID;
        private System.Windows.Forms.Label lbAccessID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.Timer TimeTwo;
    }
}