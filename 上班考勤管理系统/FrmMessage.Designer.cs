namespace 上班考勤管理系统
{
    partial class FrmMessage
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
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnConflict = new System.Windows.Forms.Button();
            this.TimerOne = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(109, 31);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(53, 12);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "签到信息";
            // 
            // btnConflict
            // 
            this.btnConflict.Location = new System.Drawing.Point(99, 86);
            this.btnConflict.Name = "btnConflict";
            this.btnConflict.Size = new System.Drawing.Size(75, 34);
            this.btnConflict.TabIndex = 1;
            this.btnConflict.Text = "确认";
            this.btnConflict.UseVisualStyleBackColor = true;
            this.btnConflict.Click += new System.EventHandler(this.btnConflict_Click);
            // 
            // TimerOne
            // 
            this.TimerOne.Interval = 1500;
            this.TimerOne.Tick += new System.EventHandler(this.TimerOne_Tick);
            // 
            // FrmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.btnConflict);
            this.Controls.Add(this.lblInformation);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 170);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 170);
            this.Name = "FrmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提示";
            this.Load += new System.EventHandler(this.FrmMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnConflict;
        private System.Windows.Forms.Timer TimerOne;
    }
}