namespace 上班考勤管理系统
{
    partial class FrmMenu
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
            this.lblSearchLeave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSearchInformation
            // 
            this.lblSearchInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSearchInformation.Image = global::KV_ISO15693.Properties.Resources.Search;
            this.lblSearchInformation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSearchInformation.Location = new System.Drawing.Point(169, 161);
            this.lblSearchInformation.Name = "lblSearchInformation";
            this.lblSearchInformation.Size = new System.Drawing.Size(80, 71);
            this.lblSearchInformation.TabIndex = 5;
            this.lblSearchInformation.Text = "考勤查询";
            this.lblSearchInformation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSearchInformation.Click += new System.EventHandler(this.lblSearchInformation_Click);
            // 
            // lblMeettingCard
            // 
            this.lblMeettingCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMeettingCard.Image = global::KV_ISO15693.Properties.Resources.People;
            this.lblMeettingCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMeettingCard.Location = new System.Drawing.Point(39, 161);
            this.lblMeettingCard.Name = "lblMeettingCard";
            this.lblMeettingCard.Size = new System.Drawing.Size(80, 71);
            this.lblMeettingCard.TabIndex = 4;
            this.lblMeettingCard.Text = "会议签到";
            this.lblMeettingCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMeettingCard.Click += new System.EventHandler(this.lblMeettingCard_Click);
            // 
            // lblTravel
            // 
            this.lblTravel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTravel.Image = global::KV_ISO15693.Properties.Resources.Travel;
            this.lblTravel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTravel.Location = new System.Drawing.Point(169, 30);
            this.lblTravel.Name = "lblTravel";
            this.lblTravel.Size = new System.Drawing.Size(80, 71);
            this.lblTravel.TabIndex = 3;
            this.lblTravel.Text = "请假管理";
            this.lblTravel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTravel.Click += new System.EventHandler(this.lblTravel_Click);
            // 
            // lblPunch
            // 
            this.lblPunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPunch.Image = global::KV_ISO15693.Properties.Resources.PunchCard;
            this.lblPunch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPunch.Location = new System.Drawing.Point(39, 30);
            this.lblPunch.Name = "lblPunch";
            this.lblPunch.Size = new System.Drawing.Size(80, 71);
            this.lblPunch.TabIndex = 2;
            this.lblPunch.Text = "打卡签到";
            this.lblPunch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPunch.Click += new System.EventHandler(this.lblPunch_Click);
            // 
            // lblSearchLeave
            // 
            this.lblSearchLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSearchLeave.Image = global::KV_ISO15693.Properties.Resources.Leave;
            this.lblSearchLeave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSearchLeave.Location = new System.Drawing.Point(39, 279);
            this.lblSearchLeave.Name = "lblSearchLeave";
            this.lblSearchLeave.Size = new System.Drawing.Size(80, 71);
            this.lblSearchLeave.TabIndex = 6;
            this.lblSearchLeave.Text = "请假查询";
            this.lblSearchLeave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSearchLeave.Click += new System.EventHandler(this.lblSearchLeave_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(297, 634);
            this.Controls.Add(this.lblSearchLeave);
            this.Controls.Add(this.lblSearchInformation);
            this.Controls.Add(this.lblMeettingCard);
            this.Controls.Add(this.lblTravel);
            this.Controls.Add(this.lblPunch);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenu";
            this.Text = "菜单栏";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTravel;
        private System.Windows.Forms.Label lblPunch;
        private System.Windows.Forms.Label lblSearchInformation;
        private System.Windows.Forms.Label lblMeettingCard;
        private System.Windows.Forms.Label lblSearchLeave;
    }
}