namespace 上班考勤管理系统
{
    partial class FrmManagementMenu
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
            this.lblSearchInformation = new System.Windows.Forms.Label();
            this.lblMeettingCard = new System.Windows.Forms.Label();
            this.lblTravel = new System.Windows.Forms.Label();
            this.lblPunch = new System.Windows.Forms.Label();
            this.lblDeleteCard = new System.Windows.Forms.Label();
            this.lblAddInformation = new System.Windows.Forms.Label();
            this.lblSearchLeaveOrConflict = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSearchInformation
            // 
            this.lblSearchInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSearchInformation.Image = global::KV_ISO15693.Properties.Resources.Search;
            this.lblSearchInformation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSearchInformation.Location = new System.Drawing.Point(39, 534);
            this.lblSearchInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchInformation.Name = "lblSearchInformation";
            this.lblSearchInformation.Size = new System.Drawing.Size(60, 57);
            this.lblSearchInformation.TabIndex = 11;
            this.lblSearchInformation.Text = "考勤查询";
            this.lblSearchInformation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSearchInformation.Click += new System.EventHandler(this.lblSearchInformation_Click);
            // 
            // lblMeettingCard
            // 
            this.lblMeettingCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMeettingCard.Image = global::KV_ISO15693.Properties.Resources.People;
            this.lblMeettingCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMeettingCard.Location = new System.Drawing.Point(39, 227);
            this.lblMeettingCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeettingCard.Name = "lblMeettingCard";
            this.lblMeettingCard.Size = new System.Drawing.Size(60, 57);
            this.lblMeettingCard.TabIndex = 10;
            this.lblMeettingCard.Text = "会议签到";
            this.lblMeettingCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMeettingCard.Click += new System.EventHandler(this.lblMeettingCard_Click);
            // 
            // lblTravel
            // 
            this.lblTravel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTravel.Image = global::KV_ISO15693.Properties.Resources.Travel;
            this.lblTravel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTravel.Location = new System.Drawing.Point(39, 334);
            this.lblTravel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTravel.Name = "lblTravel";
            this.lblTravel.Size = new System.Drawing.Size(60, 57);
            this.lblTravel.TabIndex = 9;
            this.lblTravel.Text = "请假管理";
            this.lblTravel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTravel.Click += new System.EventHandler(this.lblTravel_Click);
            // 
            // lblPunch
            // 
            this.lblPunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPunch.Image = global::KV_ISO15693.Properties.Resources.PunchCard;
            this.lblPunch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPunch.Location = new System.Drawing.Point(39, 129);
            this.lblPunch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPunch.Name = "lblPunch";
            this.lblPunch.Size = new System.Drawing.Size(60, 57);
            this.lblPunch.TabIndex = 8;
            this.lblPunch.Text = "打卡签到";
            this.lblPunch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPunch.Click += new System.EventHandler(this.lblPunch_Click);
            // 
            // lblDeleteCard
            // 
            this.lblDeleteCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDeleteCard.Image = global::KV_ISO15693.Properties.Resources.Delete;
            this.lblDeleteCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDeleteCard.Location = new System.Drawing.Point(134, 25);
            this.lblDeleteCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteCard.Name = "lblDeleteCard";
            this.lblDeleteCard.Size = new System.Drawing.Size(60, 57);
            this.lblDeleteCard.TabIndex = 7;
            this.lblDeleteCard.Text = "注销卡号";
            this.lblDeleteCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDeleteCard.Click += new System.EventHandler(this.lblDeleteCard_Click);
            // 
            // lblAddInformation
            // 
            this.lblAddInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddInformation.Image = global::KV_ISO15693.Properties.Resources.information;
            this.lblAddInformation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAddInformation.Location = new System.Drawing.Point(39, 25);
            this.lblAddInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddInformation.Name = "lblAddInformation";
            this.lblAddInformation.Size = new System.Drawing.Size(60, 57);
            this.lblAddInformation.TabIndex = 6;
            this.lblAddInformation.Text = "信息录入";
            this.lblAddInformation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblAddInformation.Click += new System.EventHandler(this.lblAddInformation_Click);
            // 
            // lblSearchLeaveOrConflict
            // 
            this.lblSearchLeaveOrConflict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSearchLeaveOrConflict.Image = global::KV_ISO15693.Properties.Resources.conflict;
            this.lblSearchLeaveOrConflict.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSearchLeaveOrConflict.Location = new System.Drawing.Point(39, 436);
            this.lblSearchLeaveOrConflict.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchLeaveOrConflict.Name = "lblSearchLeaveOrConflict";
            this.lblSearchLeaveOrConflict.Size = new System.Drawing.Size(60, 57);
            this.lblSearchLeaveOrConflict.TabIndex = 12;
            this.lblSearchLeaveOrConflict.Text = "请假查询及批假";
            this.lblSearchLeaveOrConflict.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSearchLeaveOrConflict.Click += new System.EventHandler(this.lblSearchLeaveOrConflict_Click);
            // 
            // FrmManagementMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 600);
            this.Controls.Add(this.lblSearchLeaveOrConflict);
            this.Controls.Add(this.lblSearchInformation);
            this.Controls.Add(this.lblMeettingCard);
            this.Controls.Add(this.lblTravel);
            this.Controls.Add(this.lblPunch);
            this.Controls.Add(this.lblDeleteCard);
            this.Controls.Add(this.lblAddInformation);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmManagementMenu";
            this.Text = "菜单栏";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSearchInformation;
        private System.Windows.Forms.Label lblMeettingCard;
        private System.Windows.Forms.Label lblTravel;
        private System.Windows.Forms.Label lblPunch;
        private System.Windows.Forms.Label lblDeleteCard;
        private System.Windows.Forms.Label lblAddInformation;
        private System.Windows.Forms.Label lblSearchLeaveOrConflict;
    }
}