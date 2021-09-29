
namespace CarManager0811.UI.Dyeing_thread
{
    partial class ProcessUI
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
            this.process_lev = new Sunny.UI.UILabel();
            this.process_con = new Sunny.UI.UILabel();
            this.process_per = new Sunny.UI.UILabel();
            this.but_stop = new Sunny.UI.UIButton();
            this.process_progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // process_lev
            // 
            this.process_lev.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.process_lev.Location = new System.Drawing.Point(23, 25);
            this.process_lev.Name = "process_lev";
            this.process_lev.Size = new System.Drawing.Size(52, 23);
            this.process_lev.TabIndex = 0;
            this.process_lev.Text = "공정";
            this.process_lev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // process_con
            // 
            this.process_con.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.process_con.Location = new System.Drawing.Point(93, 25);
            this.process_con.Name = "process_con";
            this.process_con.Size = new System.Drawing.Size(174, 23);
            this.process_con.TabIndex = 1;
            this.process_con.Text = "공정이 진행 중입니다.";
            this.process_con.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // process_per
            // 
            this.process_per.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.process_per.Location = new System.Drawing.Point(284, 25);
            this.process_per.Name = "process_per";
            this.process_per.Size = new System.Drawing.Size(250, 23);
            this.process_per.TabIndex = 2;
            this.process_per.Text = "진행 상황 : 0%";
            this.process_per.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // but_stop
            // 
            this.but_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_stop.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_stop.Location = new System.Drawing.Point(472, 57);
            this.but_stop.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_stop.Name = "but_stop";
            this.but_stop.Size = new System.Drawing.Size(118, 29);
            this.but_stop.TabIndex = 3;
            this.but_stop.Text = "작업 중지";
            this.but_stop.Click += new System.EventHandler(this.but_stop_Click);
            // 
            // process_progress
            // 
            this.process_progress.Location = new System.Drawing.Point(27, 57);
            this.process_progress.Name = "process_progress";
            this.process_progress.Size = new System.Drawing.Size(414, 29);
            this.process_progress.TabIndex = 4;
            // 
            // ProcessUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(603, 104);
            this.Controls.Add(this.process_progress);
            this.Controls.Add(this.but_stop);
            this.Controls.Add(this.process_per);
            this.Controls.Add(this.process_con);
            this.Controls.Add(this.process_lev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProcessUI";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel process_lev;
        private Sunny.UI.UILabel process_con;
        private Sunny.UI.UILabel process_per;
        private Sunny.UI.UIButton but_stop;
        private System.Windows.Forms.ProgressBar process_progress;
    }
}