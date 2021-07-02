namespace 上班考勤管理系统
{
    partial class FrmDeleteCard
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxDeleteCard = new System.Windows.Forms.GroupBox();
            this.txtAccessID = new System.Windows.Forms.TextBox();
            this.lblDeteteCard = new System.Windows.Forms.Label();
            this.btnSearchInformation = new System.Windows.Forms.Button();
            this.gpbDeleteInformation = new System.Windows.Forms.GroupBox();
            this.dgvCheckOutInfo = new System.Windows.Forms.DataGridView();
            this.btnCloseSerial = new System.Windows.Forms.Button();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxDeleteCard.SuspendLayout();
            this.gpbDeleteInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOutInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(184, 346);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "确认注销";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBoxDeleteCard
            // 
            this.groupBoxDeleteCard.Controls.Add(this.txtAccessID);
            this.groupBoxDeleteCard.Controls.Add(this.lblDeteteCard);
            this.groupBoxDeleteCard.Location = new System.Drawing.Point(25, 30);
            this.groupBoxDeleteCard.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDeleteCard.Name = "groupBoxDeleteCard";
            this.groupBoxDeleteCard.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDeleteCard.Size = new System.Drawing.Size(464, 79);
            this.groupBoxDeleteCard.TabIndex = 1;
            this.groupBoxDeleteCard.TabStop = false;
            this.groupBoxDeleteCard.Text = "注销卡号及查询销卡信息";
            // 
            // txtAccessID
            // 
            this.txtAccessID.Location = new System.Drawing.Point(230, 31);
            this.txtAccessID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccessID.Name = "txtAccessID";
            this.txtAccessID.Size = new System.Drawing.Size(137, 21);
            this.txtAccessID.TabIndex = 1;
            // 
            // lblDeteteCard
            // 
            this.lblDeteteCard.AutoSize = true;
            this.lblDeteteCard.Location = new System.Drawing.Point(98, 39);
            this.lblDeteteCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeteteCard.Name = "lblDeteteCard";
            this.lblDeteteCard.Size = new System.Drawing.Size(125, 12);
            this.lblDeteteCard.TabIndex = 0;
            this.lblDeteteCard.Text = "请输入要注销的卡号：";
            // 
            // btnSearchInformation
            // 
            this.btnSearchInformation.Location = new System.Drawing.Point(296, 123);
            this.btnSearchInformation.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchInformation.Name = "btnSearchInformation";
            this.btnSearchInformation.Size = new System.Drawing.Size(80, 30);
            this.btnSearchInformation.TabIndex = 4;
            this.btnSearchInformation.Text = "查询信息";
            this.btnSearchInformation.UseVisualStyleBackColor = true;
            this.btnSearchInformation.Click += new System.EventHandler(this.btnSearchInformation_Click);
            // 
            // gpbDeleteInformation
            // 
            this.gpbDeleteInformation.Controls.Add(this.dgvCheckOutInfo);
            this.gpbDeleteInformation.Location = new System.Drawing.Point(25, 158);
            this.gpbDeleteInformation.Name = "gpbDeleteInformation";
            this.gpbDeleteInformation.Size = new System.Drawing.Size(485, 174);
            this.gpbDeleteInformation.TabIndex = 3;
            this.gpbDeleteInformation.TabStop = false;
            this.gpbDeleteInformation.Text = "将注销的卡号信息";
            // 
            // dgvCheckOutInfo
            // 
            this.dgvCheckOutInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckOutInfo.Location = new System.Drawing.Point(25, 32);
            this.dgvCheckOutInfo.Name = "dgvCheckOutInfo";
            this.dgvCheckOutInfo.RowHeadersWidth = 51;
            this.dgvCheckOutInfo.RowTemplate.Height = 23;
            this.dgvCheckOutInfo.Size = new System.Drawing.Size(439, 107);
            this.dgvCheckOutInfo.TabIndex = 0;
            // 
            // btnCloseSerial
            // 
            this.btnCloseSerial.Location = new System.Drawing.Point(296, 346);
            this.btnCloseSerial.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseSerial.Name = "btnCloseSerial";
            this.btnCloseSerial.Size = new System.Drawing.Size(80, 30);
            this.btnCloseSerial.TabIndex = 14;
            this.btnCloseSerial.Text = "关闭串口";
            this.btnCloseSerial.UseVisualStyleBackColor = true;
            this.btnCloseSerial.Click += new System.EventHandler(this.btnCloseSerial_Click);
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.Location = new System.Drawing.Point(184, 123);
            this.btnOpenSerial.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(80, 30);
            this.btnOpenSerial.TabIndex = 13;
            this.btnOpenSerial.Text = "打开串口";
            this.btnOpenSerial.UseVisualStyleBackColor = true;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDeleteCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 393);
            this.Controls.Add(this.btnSearchInformation);
            this.Controls.Add(this.btnCloseSerial);
            this.Controls.Add(this.btnOpenSerial);
            this.Controls.Add(this.gpbDeleteInformation);
            this.Controls.Add(this.groupBoxDeleteCard);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximumSize = new System.Drawing.Size(570, 431);
            this.MinimumSize = new System.Drawing.Size(570, 431);
            this.Name = "FrmDeleteCard";
            this.Text = "注销卡号";
            this.groupBoxDeleteCard.ResumeLayout(false);
            this.groupBoxDeleteCard.PerformLayout();
            this.gpbDeleteInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOutInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBoxDeleteCard;
        private System.Windows.Forms.TextBox txtAccessID;
        private System.Windows.Forms.Label lblDeteteCard;
        private System.Windows.Forms.Button btnSearchInformation;
        public System.Windows.Forms.GroupBox gpbDeleteInformation;
        public System.Windows.Forms.DataGridView dgvCheckOutInfo;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.Timer timer1;
    }
}