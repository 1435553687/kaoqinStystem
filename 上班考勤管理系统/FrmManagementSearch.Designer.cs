namespace 上班考勤管理系统
{
    partial class FrmManagementSearch
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
            this.dgvCheckInOrOutInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCheckStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCheckingInOrOut = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TimerOne = new System.Windows.Forms.Timer(this.components);
            this.Timertwo = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInOrOutInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCheckInOrOutInfo);
            this.groupBox2.Location = new System.Drawing.Point(69, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(667, 276);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "签到/签退信息";
            // 
            // dgvCheckInOrOutInfo
            // 
            this.dgvCheckInOrOutInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckInOrOutInfo.Location = new System.Drawing.Point(24, 31);
            this.dgvCheckInOrOutInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCheckInOrOutInfo.Name = "dgvCheckInOrOutInfo";
            this.dgvCheckInOrOutInfo.RowHeadersWidth = 51;
            this.dgvCheckInOrOutInfo.RowTemplate.Height = 23;
            this.dgvCheckInOrOutInfo.Size = new System.Drawing.Size(585, 222);
            this.dgvCheckInOrOutInfo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDateSearch);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSum);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCheckStatus);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblCheckingInOrOut);
            this.groupBox1.Location = new System.Drawing.Point(69, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(667, 161);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询签到/签退信息";
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.Location = new System.Drawing.Point(439, 114);
            this.btnDateSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(100, 29);
            this.btnDateSearch.TabIndex = 11;
            this.btnDateSearch.Text = "查询当天";
            this.btnDateSearch.UseVisualStyleBackColor = true;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(251, 114);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(160, 25);
            this.dateTimePicker.TabIndex = 10;
            this.dateTimePicker.Value = new System.DateTime(2019, 12, 6, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "需查询日期";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(439, 74);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(100, 29);
            this.btnSum.TabIndex = 8;
            this.btnSum.Text = "统计";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 25);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "当前情况统计";
            // 
            // cmbCheckStatus
            // 
            this.cmbCheckStatus.FormattingEnabled = true;
            this.cmbCheckStatus.Items.AddRange(new object[] {
            "已签到",
            "已签退",
            "迟到",
            "早退",
            "缺勤",
            "已请假"});
            this.cmbCheckStatus.Location = new System.Drawing.Point(251, 38);
            this.cmbCheckStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCheckStatus.Name = "cmbCheckStatus";
            this.cmbCheckStatus.Size = new System.Drawing.Size(160, 23);
            this.cmbCheckStatus.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(439, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 29);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCheckingInOrOut
            // 
            this.lblCheckingInOrOut.AutoSize = true;
            this.lblCheckingInOrOut.Location = new System.Drawing.Point(100, 41);
            this.lblCheckingInOrOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckingInOrOut.Name = "lblCheckingInOrOut";
            this.lblCheckingInOrOut.Size = new System.Drawing.Size(135, 15);
            this.lblCheckingInOrOut.TabIndex = 0;
            this.lblCheckingInOrOut.Text = "签到/签退情况查询";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(617, 498);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 38);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "全部清除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TimerOne
            // 
            this.TimerOne.Interval = 500;
            this.TimerOne.Tick += new System.EventHandler(this.TimerOne_Tick);
            // 
            // Timertwo
            // 
            this.Timertwo.Tick += new System.EventHandler(this.Timertwo_Tick);
            // 
            // FrmManagementSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 550);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(818, 571);
            this.Name = "FrmManagementSearch";
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCheckStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCheckingInOrOut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Timer TimerOne;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timertwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnDateSearch;
    }
}