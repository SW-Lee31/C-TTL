
namespace CarManager0811.UI
{
    partial class LoginUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLine2 = new Sunny.UI.UILine();
            this.loginOK = new System.Windows.Forms.Button();
            this.loginCancel = new System.Windows.Forms.Button();
            this.user = new Sunny.UI.UITextBox();
            this.passwd = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(271, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "관리자 모드";
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Silver;
            this.uiLine1.Location = new System.Drawing.Point(144, 194);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(520, 2);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 2;
            // 
            // uiLine2
            // 
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.LineColor = System.Drawing.Color.Silver;
            this.uiLine2.Location = new System.Drawing.Point(144, 282);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(520, 2);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 3;
            // 
            // loginOK
            // 
            this.loginOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginOK.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginOK.Location = new System.Drawing.Point(144, 356);
            this.loginOK.Name = "loginOK";
            this.loginOK.Size = new System.Drawing.Size(221, 51);
            this.loginOK.TabIndex = 4;
            this.loginOK.Text = "로그인";
            this.loginOK.UseVisualStyleBackColor = true;
            this.loginOK.Click += new System.EventHandler(this.loginOK_Click);
            // 
            // loginCancel
            // 
            this.loginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginCancel.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginCancel.Location = new System.Drawing.Point(443, 356);
            this.loginCancel.Name = "loginCancel";
            this.loginCancel.Size = new System.Drawing.Size(221, 51);
            this.loginCancel.TabIndex = 5;
            this.loginCancel.Text = "취 소";
            this.loginCancel.UseVisualStyleBackColor = true;
            this.loginCancel.Click += new System.EventHandler(this.loginCancel_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.user.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.user.Location = new System.Drawing.Point(144, 151);
            this.user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user.Maximum = 2147483647D;
            this.user.Minimum = -2147483648D;
            this.user.MinimumSize = new System.Drawing.Size(1, 1);
            this.user.Name = "user";
            this.user.RectColor = System.Drawing.Color.Transparent;
            this.user.Size = new System.Drawing.Size(355, 43);
            this.user.Style = Sunny.UI.UIStyle.Custom;
            this.user.TabIndex = 6;
            this.user.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwd
            // 
            this.passwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwd.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwd.Location = new System.Drawing.Point(144, 240);
            this.passwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwd.Maximum = 2147483647D;
            this.passwd.Minimum = -2147483648D;
            this.passwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwd.Name = "passwd";
            this.passwd.PasswordChar = '●';
            this.passwd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwd.Size = new System.Drawing.Size(355, 43);
            this.passwd.Style = Sunny.UI.UIStyle.Custom;
            this.passwd.TabIndex = 7;
            this.passwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.user);
            this.Controls.Add(this.loginCancel);
            this.Controls.Add(this.loginOK);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
        private System.Windows.Forms.Button loginOK;
        private System.Windows.Forms.Button loginCancel;
        private Sunny.UI.UITextBox user;
        private Sunny.UI.UITextBox passwd;
    }
}