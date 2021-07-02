namespace 上班考勤管理系统
{
    partial class FrmLeaveSearch
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
            this.btnAllLeave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComflict = new System.Windows.Forms.Button();
            this.txtAccessID = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInOrOutInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCheckInOrOutInfo);
            this.groupBox2.Location = new System.Drawing.Point(41, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(667, 394);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请假信息";
            // 
            // dgvCheckInOrOutInfo
            // 
            this.dgvCheckInOrOutInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckInOrOutInfo.Location = new System.Drawing.Point(26, 38);
            this.dgvCheckInOrOutInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCheckInOrOutInfo.Name = "dgvCheckInOrOutInfo";
            this.dgvCheckInOrOutInfo.RowHeadersWidth = 51;
            this.dgvCheckInOrOutInfo.RowTemplate.Height = 23;
            this.dgvCheckInOrOutInfo.Size = new System.Drawing.Size(618, 327);
            this.dgvCheckInOrOutInfo.TabIndex = 0;
            // 
            // btnAllLeave
            // 
            this.btnAllLeave.Location = new System.Drawing.Point(574, 423);
            this.btnAllLeave.Name = "btnAllLeave";
            this.btnAllLeave.Size = new System.Drawing.Size(134, 35);
            this.btnAllLeave.TabIndex = 14;
            this.btnAllLeave.Text = "检索请假信息";
            this.btnAllLeave.UseVisualStyleBackColor = true;
            this.btnAllLeave.Click += new System.EventHandler(this.btnAllLeave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnComflict);
            this.groupBox1.Controls.Add(this.txtAccessID);
            this.groupBox1.Location = new System.Drawing.Point(41, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 93);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询请假是否通过";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "请假卡号：";
            // 
            // btnComflict
            // 
            this.btnComflict.Location = new System.Drawing.Point(337, 27);
            this.btnComflict.Name = "btnComflict";
            this.btnComflict.Size = new System.Drawing.Size(103, 35);
            this.btnComflict.TabIndex = 12;
            this.btnComflict.Text = "确认查询";
            this.btnComflict.UseVisualStyleBackColor = true;
            this.btnComflict.Click += new System.EventHandler(this.btnComflict_Click);
            // 
            // txtAccessID
            // 
            this.txtAccessID.Location = new System.Drawing.Point(111, 34);
            this.txtAccessID.Name = "txtAccessID";
            this.txtAccessID.Size = new System.Drawing.Size(198, 25);
            this.txtAccessID.TabIndex = 9;
            // 
            // FrmLeaveSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAllLeave);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximumSize = new System.Drawing.Size(760, 586);
            this.MinimumSize = new System.Drawing.Size(760, 586);
            this.Name = "FrmLeaveSearch";
            this.Text = "请假查询";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInOrOutInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvCheckInOrOutInfo;
        private System.Windows.Forms.Button btnAllLeave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComflict;
        private System.Windows.Forms.TextBox txtAccessID;
    }
}