
namespace CarManager0811.UI
{
    partial class ValeoOrder
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
            this.lstbox_make = new Sunny.UI.UIListBox();
            this.but_close = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // lstbox_make
            // 
            this.lstbox_make.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lstbox_make.FormatString = "";
            this.lstbox_make.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lstbox_make.Location = new System.Drawing.Point(13, 14);
            this.lstbox_make.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstbox_make.MinimumSize = new System.Drawing.Size(1, 1);
            this.lstbox_make.Name = "lstbox_make";
            this.lstbox_make.Padding = new System.Windows.Forms.Padding(2);
            this.lstbox_make.Size = new System.Drawing.Size(542, 180);
            this.lstbox_make.TabIndex = 0;
            this.lstbox_make.Text = "uiListBox1";
            // 
            // but_close
            // 
            this.but_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_close.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_close.Location = new System.Drawing.Point(130, 215);
            this.but_close.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(307, 61);
            this.but_close.TabIndex = 1;
            this.but_close.Text = "검사중입니다...";
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // ValeoOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(568, 298);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.lstbox_make);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ValeoOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrderCheck";
            this.Load += new System.EventHandler(this.ValeoOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIListBox lstbox_make;
        private Sunny.UI.UIButton but_close;
    }
}