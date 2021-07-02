namespace 上班考勤管理系统
{
    partial class FrmManagementMeeting
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMeeting = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCloseSerial = new System.Windows.Forms.Button();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.txtAccessID = new System.Windows.Forms.TextBox();
            this.lbAccessID = new System.Windows.Forms.Label();
            this.Timerone = new System.Windows.Forms.Timer(this.components);
            this.btndeleteData = new System.Windows.Forms.Button();
            this.TimerTwo = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeeting)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMeeting);
            this.groupBox2.Location = new System.Drawing.Point(50, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 221);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "会议签到信息";
            // 
            // dgvMeeting
            // 
            this.dgvMeeting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeeting.Location = new System.Drawing.Point(3, 17);
            this.dgvMeeting.Name = "dgvMeeting";
            this.dgvMeeting.RowHeadersWidth = 51;
            this.dgvMeeting.RowTemplate.Height = 23;
            this.dgvMeeting.Size = new System.Drawing.Size(464, 201);
            this.dgvMeeting.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCloseSerial);
            this.groupBox1.Controls.Add(this.btnOpenSerial);
            this.groupBox1.Controls.Add(this.txtAccessID);
            this.groupBox1.Controls.Add(this.lbAccessID);
            this.groupBox1.Location = new System.Drawing.Point(50, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 99);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会议签到";
            // 
            // btnCloseSerial
            // 
            this.btnCloseSerial.Location = new System.Drawing.Point(316, 69);
            this.btnCloseSerial.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseSerial.Name = "btnCloseSerial";
            this.btnCloseSerial.Size = new System.Drawing.Size(80, 20);
            this.btnCloseSerial.TabIndex = 12;
            this.btnCloseSerial.Text = "关闭串口";
            this.btnCloseSerial.UseVisualStyleBackColor = true;
            this.btnCloseSerial.Click += new System.EventHandler(this.btnCloseSerial_Click);
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.Location = new System.Drawing.Point(316, 19);
            this.btnOpenSerial.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(80, 20);
            this.btnOpenSerial.TabIndex = 11;
            this.btnOpenSerial.Text = "打开串口";
            this.btnOpenSerial.UseVisualStyleBackColor = true;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // txtAccessID
            // 
            this.txtAccessID.Enabled = false;
            this.txtAccessID.Location = new System.Drawing.Point(130, 44);
            this.txtAccessID.Name = "txtAccessID";
            this.txtAccessID.Size = new System.Drawing.Size(161, 21);
            this.txtAccessID.TabIndex = 10;
            // 
            // lbAccessID
            // 
            this.lbAccessID.AutoSize = true;
            this.lbAccessID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAccessID.Location = new System.Drawing.Point(50, 52);
            this.lbAccessID.Name = "lbAccessID";
            this.lbAccessID.Size = new System.Drawing.Size(65, 12);
            this.lbAccessID.TabIndex = 9;
            this.lbAccessID.Text = "人员卡号：";
            // 
            // Timerone
            // 
            this.Timerone.Interval = 500;
            this.Timerone.Tick += new System.EventHandler(this.Timerone_Tick_1);
            // 
            // btndeleteData
            // 
            this.btndeleteData.Location = new System.Drawing.Point(431, 367);
            this.btndeleteData.Name = "btndeleteData";
            this.btndeleteData.Size = new System.Drawing.Size(86, 34);
            this.btndeleteData.TabIndex = 10;
            this.btndeleteData.Text = "清空数据";
            this.btndeleteData.UseVisualStyleBackColor = true;
            this.btndeleteData.Click += new System.EventHandler(this.btndeleteData_Click);
            // 
            // TimerTwo
            // 
            this.TimerTwo.Interval = 1500;
            this.TimerTwo.Tick += new System.EventHandler(this.TimerTwo_Tick);
            // 
            // FrmManagementMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 417);
            this.Controls.Add(this.btndeleteData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximumSize = new System.Drawing.Size(603, 455);
            this.MinimumSize = new System.Drawing.Size(603, 455);
            this.Name = "FrmManagementMeeting";
            this.Text = "会议签到";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeeting)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvMeeting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.TextBox txtAccessID;
        private System.Windows.Forms.Label lbAccessID;
        private System.Windows.Forms.Timer Timerone;
        private System.Windows.Forms.Button btndeleteData;
        private System.Windows.Forms.Timer TimerTwo;
    }
}