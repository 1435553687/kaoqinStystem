namespace 上班考勤管理系统
{
    partial class Frmwelcome
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
            this.PictureBoxStart = new System.Windows.Forms.PictureBox();
            this.BtnWelcomeQuit = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStart)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxStart
            // 
            this.PictureBoxStart.BackgroundImage = global::KV_ISO15693.Properties.Resources.考勤;
            this.PictureBoxStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxStart.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxStart.Name = "PictureBoxStart";
            this.PictureBoxStart.Size = new System.Drawing.Size(629, 436);
            this.PictureBoxStart.TabIndex = 0;
            this.PictureBoxStart.TabStop = false;
            // 
            // BtnWelcomeQuit
            // 
            this.BtnWelcomeQuit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnWelcomeQuit.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnWelcomeQuit.Location = new System.Drawing.Point(0, 402);
            this.BtnWelcomeQuit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnWelcomeQuit.Name = "BtnWelcomeQuit";
            this.BtnWelcomeQuit.Size = new System.Drawing.Size(629, 34);
            this.BtnWelcomeQuit.TabIndex = 1;
            this.BtnWelcomeQuit.Text = "退出";
            this.BtnWelcomeQuit.UseVisualStyleBackColor = true;
            this.BtnWelcomeQuit.Click += new System.EventHandler(this.BtnWelcomeQuit_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConfirm.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.Location = new System.Drawing.Point(0, 373);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(629, 29);
            this.BtnConfirm.TabIndex = 2;
            this.BtnConfirm.Text = "确认使用";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Image = global::KV_ISO15693.Properties.Resources.学校背景图;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(430, 315);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "是否需要进入管理员界面？";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Frmwelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 436);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnWelcomeQuit);
            this.Controls.Add(this.PictureBoxStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(647, 483);
            this.MinimumSize = new System.Drawing.Size(647, 483);
            this.Name = "Frmwelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmwelcome_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxStart;
        private System.Windows.Forms.Button BtnWelcomeQuit;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}