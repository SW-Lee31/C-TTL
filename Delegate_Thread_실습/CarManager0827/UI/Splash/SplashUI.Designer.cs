
namespace CarManager0811.UI.Splash
{
    partial class SplashUI
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spsh_lebel = new Sunny.UI.UILabel();
            this.uiProgressIndicator1 = new Sunny.UI.UIProgressIndicator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarManager0811.Properties.Resources.splash;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // spsh_lebel
            // 
            this.spsh_lebel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(118)))));
            this.spsh_lebel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spsh_lebel.ForeColor = System.Drawing.Color.White;
            this.spsh_lebel.Location = new System.Drawing.Point(-1, 236);
            this.spsh_lebel.Name = "spsh_lebel";
            this.spsh_lebel.Size = new System.Drawing.Size(556, 23);
            this.spsh_lebel.TabIndex = 2;
            this.spsh_lebel.Text = "MES 시스템에 접속 중입니다.";
            this.spsh_lebel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiProgressIndicator1
            // 
            this.uiProgressIndicator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(9)))), ((int)(((byte)(118)))));
            this.uiProgressIndicator1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiProgressIndicator1.ForeColor = System.Drawing.Color.White;
            this.uiProgressIndicator1.Location = new System.Drawing.Point(-3, -1);
            this.uiProgressIndicator1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiProgressIndicator1.Name = "uiProgressIndicator1";
            this.uiProgressIndicator1.Size = new System.Drawing.Size(556, 54);
            this.uiProgressIndicator1.Style = Sunny.UI.UIStyle.Custom;
            this.uiProgressIndicator1.TabIndex = 3;
            this.uiProgressIndicator1.Text = "uiProgressIndicator1";
            // 
            // SplashUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.uiProgressIndicator1);
            this.Controls.Add(this.spsh_lebel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UILabel spsh_lebel;
        private Sunny.UI.UIProgressIndicator uiProgressIndicator1;
    }
}