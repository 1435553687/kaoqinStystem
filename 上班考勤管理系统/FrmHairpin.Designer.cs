namespace 上班考勤管理系统
{
    partial class FrmHairpin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPeoplePosition = new System.Windows.Forms.ComboBox();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.txtPeopleName = new System.Windows.Forms.TextBox();
            this.lblPeoplePosition = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPeopleName = new System.Windows.Forms.Label();
            this.txtAccessID = new System.Windows.Forms.TextBox();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.GpbCardInformation = new System.Windows.Forms.GroupBox();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.btnCloseSerial = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GpbCardInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLoginCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPeoplePosition);
            this.groupBox1.Controls.Add(this.lblIDCard);
            this.groupBox1.Controls.Add(this.cmbSex);
            this.groupBox1.Controls.Add(this.txtIDCard);
            this.groupBox1.Controls.Add(this.txtPeopleName);
            this.groupBox1.Controls.Add(this.lblPeoplePosition);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.lblPeopleName);
            this.groupBox1.Location = new System.Drawing.Point(36, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(316, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登记信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(110, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "权限密码：为该用户附加管理员权限！";
            // 
            // txtLoginCode
            // 
            this.txtLoginCode.Location = new System.Drawing.Point(112, 186);
            this.txtLoginCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginCode.Name = "txtLoginCode";
            this.txtLoginCode.Size = new System.Drawing.Size(152, 21);
            this.txtLoginCode.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "权限密码：";
            // 
            // cmbPeoplePosition
            // 
            this.cmbPeoplePosition.FormattingEnabled = true;
            this.cmbPeoplePosition.Items.AddRange(new object[] {
            "厨师",
            "服务员",
            "收银员",
            "管理员（领班）"});
            this.cmbPeoplePosition.Location = new System.Drawing.Point(112, 99);
            this.cmbPeoplePosition.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPeoplePosition.Name = "cmbPeoplePosition";
            this.cmbPeoplePosition.Size = new System.Drawing.Size(152, 20);
            this.cmbPeoplePosition.TabIndex = 9;
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Location = new System.Drawing.Point(46, 147);
            this.lblIDCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(65, 12);
            this.lblIDCard.TabIndex = 8;
            this.lblIDCard.Text = "身份证号：";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbSex.Location = new System.Drawing.Point(112, 61);
            this.cmbSex.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(152, 20);
            this.cmbSex.TabIndex = 7;
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(112, 139);
            this.txtIDCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(152, 21);
            this.txtIDCard.TabIndex = 6;
            // 
            // txtPeopleName
            // 
            this.txtPeopleName.Location = new System.Drawing.Point(112, 28);
            this.txtPeopleName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeopleName.Name = "txtPeopleName";
            this.txtPeopleName.Size = new System.Drawing.Size(152, 21);
            this.txtPeopleName.TabIndex = 5;
            // 
            // lblPeoplePosition
            // 
            this.lblPeoplePosition.AutoSize = true;
            this.lblPeoplePosition.Location = new System.Drawing.Point(46, 106);
            this.lblPeoplePosition.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lblPeoplePosition.Name = "lblPeoplePosition";
            this.lblPeoplePosition.Size = new System.Drawing.Size(65, 12);
            this.lblPeoplePosition.TabIndex = 3;
            this.lblPeoplePosition.Text = "人员职位：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(46, 67);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(65, 12);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "人员性别：";
            // 
            // lblPeopleName
            // 
            this.lblPeopleName.AutoSize = true;
            this.lblPeopleName.Location = new System.Drawing.Point(46, 36);
            this.lblPeopleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeopleName.Name = "lblPeopleName";
            this.lblPeopleName.Size = new System.Drawing.Size(65, 12);
            this.lblPeopleName.TabIndex = 1;
            this.lblPeopleName.Text = "人员姓名：";
            // 
            // txtAccessID
            // 
            this.txtAccessID.Location = new System.Drawing.Point(105, 52);
            this.txtAccessID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccessID.Name = "txtAccessID";
            this.txtAccessID.ReadOnly = true;
            this.txtAccessID.Size = new System.Drawing.Size(152, 21);
            this.txtAccessID.TabIndex = 4;
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Location = new System.Drawing.Point(39, 55);
            this.lblCardNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(65, 12);
            this.lblCardNum.TabIndex = 0;
            this.lblCardNum.Text = "人员卡号：";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(148, 393);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(93, 29);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "确认登记";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // GpbCardInformation
            // 
            this.GpbCardInformation.Controls.Add(this.lblCardNum);
            this.GpbCardInformation.Controls.Add(this.txtAccessID);
            this.GpbCardInformation.Location = new System.Drawing.Point(43, 24);
            this.GpbCardInformation.Name = "GpbCardInformation";
            this.GpbCardInformation.Size = new System.Drawing.Size(309, 114);
            this.GpbCardInformation.TabIndex = 6;
            this.GpbCardInformation.TabStop = false;
            this.GpbCardInformation.Text = "卡号信息";
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.Location = new System.Drawing.Point(36, 393);
            this.btnOpenSerial.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(93, 29);
            this.btnOpenSerial.TabIndex = 6;
            this.btnOpenSerial.Text = "打开串口";
            this.btnOpenSerial.UseVisualStyleBackColor = true;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // btnCloseSerial
            // 
            this.btnCloseSerial.Location = new System.Drawing.Point(259, 393);
            this.btnCloseSerial.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseSerial.Name = "btnCloseSerial";
            this.btnCloseSerial.Size = new System.Drawing.Size(93, 29);
            this.btnCloseSerial.TabIndex = 7;
            this.btnCloseSerial.Text = "关闭串口";
            this.btnCloseSerial.UseVisualStyleBackColor = true;
            this.btnCloseSerial.Click += new System.EventHandler(this.btnCloseSerial_Click);
            // 
            // FrmHairpin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 446);
            this.Controls.Add(this.btnOpenSerial);
            this.Controls.Add(this.btnCloseSerial);
            this.Controls.Add(this.GpbCardInformation);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(421, 484);
            this.MinimumSize = new System.Drawing.Size(421, 484);
            this.Name = "FrmHairpin";
            this.Text = "信息录入";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GpbCardInformation.ResumeLayout(false);
            this.GpbCardInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPeoplePosition;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.TextBox txtPeopleName;
        private System.Windows.Forms.TextBox txtAccessID;
        private System.Windows.Forms.Label lblPeoplePosition;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblPeopleName;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox GpbCardInformation;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.TextBox txtLoginCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}