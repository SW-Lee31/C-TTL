
namespace HeadLamp_Manufacture0909.UI.DelUI
{
    partial class Add_del
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
            this.memview = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.seq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.input_admin = new Sunny.UI.UIComboBox();
            this.input_inv_seq = new Sunny.UI.UIComboBox();
            this.submit_but = new Sunny.UI.UISymbolButton();
            this.but_refresh = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // memview
            // 
            this.memview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.seq,
            this.name,
            this.dest});
            this.memview.Font = new System.Drawing.Font("굴림체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memview.FullRowSelect = true;
            this.memview.HideSelection = false;
            this.memview.Location = new System.Drawing.Point(12, 76);
            this.memview.Name = "memview";
            this.memview.Size = new System.Drawing.Size(528, 119);
            this.memview.TabIndex = 90;
            this.memview.UseCompatibleStateImageBehavior = false;
            this.memview.View = System.Windows.Forms.View.Details;
            // 
            // num
            // 
            this.num.Text = "번호";
            this.num.Width = 45;
            // 
            // seq
            // 
            this.seq.Text = "고객번호";
            this.seq.Width = 76;
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.Width = 103;
            // 
            // dest
            // 
            this.dest.Text = "배송목적지";
            this.dest.Width = 299;
            // 
            // input_admin
            // 
            this.input_admin.DataSource = null;
            this.input_admin.FillColor = System.Drawing.Color.White;
            this.input_admin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_admin.Location = new System.Drawing.Point(13, 218);
            this.input_admin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_admin.MinimumSize = new System.Drawing.Size(63, 0);
            this.input_admin.Name = "input_admin";
            this.input_admin.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.input_admin.RectColor = System.Drawing.Color.Silver;
            this.input_admin.Size = new System.Drawing.Size(150, 29);
            this.input_admin.Style = Sunny.UI.UIStyle.Custom;
            this.input_admin.TabIndex = 91;
            this.input_admin.Text = "담당자명";
            this.input_admin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_inv_seq
            // 
            this.input_inv_seq.DataSource = null;
            this.input_inv_seq.FillColor = System.Drawing.Color.White;
            this.input_inv_seq.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_inv_seq.Location = new System.Drawing.Point(190, 218);
            this.input_inv_seq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_inv_seq.MinimumSize = new System.Drawing.Size(63, 0);
            this.input_inv_seq.Name = "input_inv_seq";
            this.input_inv_seq.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.input_inv_seq.RectColor = System.Drawing.Color.Silver;
            this.input_inv_seq.Size = new System.Drawing.Size(350, 29);
            this.input_inv_seq.Style = Sunny.UI.UIStyle.Custom;
            this.input_inv_seq.TabIndex = 92;
            this.input_inv_seq.Text = "배송 물품 번호";
            this.input_inv_seq.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // submit_but
            // 
            this.submit_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_but.FillColor = System.Drawing.Color.White;
            this.submit_but.FillHoverColor = System.Drawing.Color.Silver;
            this.submit_but.FillPressColor = System.Drawing.Color.Gray;
            this.submit_but.FillSelectedColor = System.Drawing.Color.Gray;
            this.submit_but.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.submit_but.ForeColor = System.Drawing.Color.DimGray;
            this.submit_but.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.submit_but.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.submit_but.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.submit_but.Location = new System.Drawing.Point(181, 269);
            this.submit_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.submit_but.Name = "submit_but";
            this.submit_but.RectColor = System.Drawing.Color.Transparent;
            this.submit_but.RectHoverColor = System.Drawing.Color.Transparent;
            this.submit_but.RectPressColor = System.Drawing.Color.Transparent;
            this.submit_but.RectSelectedColor = System.Drawing.Color.Transparent;
            this.submit_but.Size = new System.Drawing.Size(164, 58);
            this.submit_but.Style = Sunny.UI.UIStyle.Custom;
            this.submit_but.TabIndex = 93;
            this.submit_but.Text = "배송정보추가";
            this.submit_but.Click += new System.EventHandler(this.submit_but_Click);
            // 
            // but_refresh
            // 
            this.but_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_refresh.FillColor = System.Drawing.Color.White;
            this.but_refresh.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.but_refresh.FillPressColor = System.Drawing.Color.Silver;
            this.but_refresh.FillSelectedColor = System.Drawing.Color.Silver;
            this.but_refresh.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_refresh.ForeColor = System.Drawing.Color.Silver;
            this.but_refresh.ForeHoverColor = System.Drawing.Color.Black;
            this.but_refresh.ForePressColor = System.Drawing.Color.Black;
            this.but_refresh.ForeSelectedColor = System.Drawing.Color.Black;
            this.but_refresh.Location = new System.Drawing.Point(509, 77);
            this.but_refresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_refresh.Name = "but_refresh";
            this.but_refresh.RectColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectPressColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectSelectedColor = System.Drawing.Color.Transparent;
            this.but_refresh.Size = new System.Drawing.Size(30, 26);
            this.but_refresh.Style = Sunny.UI.UIStyle.Custom;
            this.but_refresh.Symbol = 61473;
            this.but_refresh.TabIndex = 79;
            this.but_refresh.Click += new System.EventHandler(this.but_refresh_Click);
            // 
            // Add_del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 353);
            this.Controls.Add(this.but_refresh);
            this.Controls.Add(this.submit_but);
            this.Controls.Add(this.input_inv_seq);
            this.Controls.Add(this.input_admin);
            this.Controls.Add(this.memview);
            this.Name = "Add_del";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_del";
            this.Load += new System.EventHandler(this.Add_del_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView memview;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader seq;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader dest;
        private Sunny.UI.UIComboBox input_admin;
        private Sunny.UI.UIComboBox input_inv_seq;
        private Sunny.UI.UISymbolButton submit_but;
        private Sunny.UI.UISymbolButton but_refresh;
    }
}