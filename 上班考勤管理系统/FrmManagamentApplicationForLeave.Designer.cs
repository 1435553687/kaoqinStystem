namespace 上班考勤管理系统
{
    partial class FrmManagamentApplicationForLeave
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
            this.btnCloseSerial = new System.Windows.Forms.Button();
            this.btnConflimLeave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RtxtLeaveReason = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.txtLeaveTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccessID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseSerial
            // 
            this.btnCloseSerial.Location = new System.Drawing.Point(447, 387);
            this.btnCloseSerial.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseSerial.Name = "btnCloseSerial";
            this.btnCloseSerial.Size = new System.Drawing.Size(80, 27);
            this.btnCloseSerial.TabIndex = 18;
            this.btnCloseSerial.Text = "关闭串口";
            this.btnCloseSerial.UseVisualStyleBackColor = true;
            this.btnCloseSerial.Click += new System.EventHandler(this.btnCloseSerial_Click);
            // 
            // btnConflimLeave
            // 
            this.btnConflimLeave.Location = new System.Drawing.Point(447, 344);
            this.btnConflimLeave.Margin = new System.Windows.Forms.Padding(2);
            this.btnConflimLeave.Name = "btnConflimLeave";
            this.btnConflimLeave.Size = new System.Drawing.Size(80, 27);
            this.btnConflimLeave.TabIndex = 17;
            this.btnConflimLeave.Text = "确认请假";
            this.btnConflimLeave.UseVisualStyleBackColor = true;
            this.btnConflimLeave.Click += new System.EventHandler(this.btnConflimLeave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RtxtLeaveReason);
            this.groupBox2.Location = new System.Drawing.Point(66, 210);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(370, 206);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请假原因：";
            // 
            // RtxtLeaveReason
            // 
            this.RtxtLeaveReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtLeaveReason.Location = new System.Drawing.Point(2, 16);
            this.RtxtLeaveReason.Margin = new System.Windows.Forms.Padding(2);
            this.RtxtLeaveReason.Name = "RtxtLeaveReason";
            this.RtxtLeaveReason.Size = new System.Drawing.Size(366, 188);
            this.RtxtLeaveReason.TabIndex = 1;
            this.RtxtLeaveReason.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnOpenSerial);
            this.groupBox1.Controls.Add(this.txtLeaveTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAccessID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(68, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(365, 151);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请假信息：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(160, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "注意！！！日期格式如：2019-11-13";
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.Location = new System.Drawing.Point(268, 29);
            this.btnOpenSerial.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(80, 27);
            this.btnOpenSerial.TabIndex = 13;
            this.btnOpenSerial.Text = "打开串口";
            this.btnOpenSerial.UseVisualStyleBackColor = true;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // txtLeaveTime
            // 
            this.txtLeaveTime.Location = new System.Drawing.Point(110, 85);
            this.txtLeaveTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeaveTime.Name = "txtLeaveTime";
            this.txtLeaveTime.Size = new System.Drawing.Size(136, 21);
            this.txtLeaveTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "需假日期：";
            // 
            // txtAccessID
            // 
            this.txtAccessID.Location = new System.Drawing.Point(110, 36);
            this.txtAccessID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccessID.Name = "txtAccessID";
            this.txtAccessID.Size = new System.Drawing.Size(136, 21);
            this.txtAccessID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请假人卡号：";
            // 
            // FrmManagamentApplicationForLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 449);
            this.Controls.Add(this.btnCloseSerial);
            this.Controls.Add(this.btnConflimLeave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximumSize = new System.Drawing.Size(557, 487);
            this.MinimumSize = new System.Drawing.Size(557, 487);
            this.Name = "FrmManagamentApplicationForLeave";
            this.Text = "请假管理";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.Button btnConflimLeave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RtxtLeaveReason;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.TextBox txtLeaveTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccessID;
        private System.Windows.Forms.Label label1;
    }
}