namespace 上班考勤管理系统
{
    partial class FrmSearch
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCheckInOrOutInfo = new System.Windows.Forms.DataGridView();
            this.lblCheckingInOrOut = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbCheckStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccessID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInOrOutInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCheckInOrOutInfo);
            this.groupBox2.Location = new System.Drawing.Point(50, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 271);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "签到/签退信息";
            // 
            // dgvCheckInOrOutInfo
            // 
            this.dgvCheckInOrOutInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckInOrOutInfo.Location = new System.Drawing.Point(31, 20);
            this.dgvCheckInOrOutInfo.Name = "dgvCheckInOrOutInfo";
            this.dgvCheckInOrOutInfo.RowHeadersWidth = 51;
            this.dgvCheckInOrOutInfo.RowTemplate.Height = 23;
            this.dgvCheckInOrOutInfo.Size = new System.Drawing.Size(439, 225);
            this.dgvCheckInOrOutInfo.TabIndex = 0;
            // 
            // lblCheckingInOrOut
            // 
            this.lblCheckingInOrOut.AutoSize = true;
            this.lblCheckingInOrOut.Location = new System.Drawing.Point(88, 40);
            this.lblCheckingInOrOut.Name = "lblCheckingInOrOut";
            this.lblCheckingInOrOut.Size = new System.Drawing.Size(107, 12);
            this.lblCheckingInOrOut.TabIndex = 0;
            this.lblCheckingInOrOut.Text = "签到/签退情况查询";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(345, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbCheckStatus
            // 
            this.cmbCheckStatus.FormattingEnabled = true;
            this.cmbCheckStatus.Items.AddRange(new object[] {
            "已签到",
            "已签退",
            "迟到",
            "早退",
            "缺勤"});
            this.cmbCheckStatus.Location = new System.Drawing.Point(201, 37);
            this.cmbCheckStatus.Name = "cmbCheckStatus";
            this.cmbCheckStatus.Size = new System.Drawing.Size(121, 20);
            this.cmbCheckStatus.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAccessID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEndTime);
            this.groupBox1.Controls.Add(this.txtStartTime);
            this.groupBox1.Controls.Add(this.btnDateSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCheckStatus);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblCheckingInOrOut);
            this.groupBox1.Location = new System.Drawing.Point(50, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询签到/签退信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "结束日期";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(201, 118);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(121, 21);
            this.txtEndTime.TabIndex = 14;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(201, 91);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(121, 21);
            this.txtStartTime.TabIndex = 13;
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.Location = new System.Drawing.Point(345, 115);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(75, 23);
            this.btnDateSearch.TabIndex = 12;
            this.btnDateSearch.Text = "具体查询";
            this.btnDateSearch.UseVisualStyleBackColor = true;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "起始日期";
            // 
            // txtAccessID
            // 
            this.txtAccessID.Location = new System.Drawing.Point(201, 64);
            this.txtAccessID.Name = "txtAccessID";
            this.txtAccessID.Size = new System.Drawing.Size(121, 21);
            this.txtAccessID.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "身份证号";
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(618, 405);
            this.Name = "FrmSearch";
            this.Text = "考勤情况查询";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInOrOutInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvCheckInOrOutInfo;
        private System.Windows.Forms.Label lblCheckingInOrOut;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbCheckStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccessID;
    }
}