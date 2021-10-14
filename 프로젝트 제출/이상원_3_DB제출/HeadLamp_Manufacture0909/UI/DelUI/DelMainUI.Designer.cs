
namespace HeadLamp_Manufacture0909.UI.DelUI
{
    partial class DelMainUI
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemview = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.del_seq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mem_seq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inv_seq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.curr_loc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.admin_seq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.condition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.del_create_but = new Sunny.UI.UIHeaderButton();
            this.but_refresh = new Sunny.UI.UISymbolButton();
            this.currpb = new System.Windows.Forms.PictureBox();
            this.destinationpb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemview
            // 
            this.itemview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.del_seq,
            this.mem_seq,
            this.inv_seq,
            this.curr_loc,
            this.dest,
            this.admin_seq,
            this.condition});
            this.itemview.Font = new System.Drawing.Font("굴림체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.itemview.FullRowSelect = true;
            this.itemview.HideSelection = false;
            this.itemview.Location = new System.Drawing.Point(8, 44);
            this.itemview.Name = "itemview";
            this.itemview.Size = new System.Drawing.Size(461, 421);
            this.itemview.TabIndex = 89;
            this.itemview.UseCompatibleStateImageBehavior = false;
            this.itemview.View = System.Windows.Forms.View.Details;
            this.itemview.SelectedIndexChanged += new System.EventHandler(this.itemview_SelectedIndexChanged);
            this.itemview.DoubleClick += new System.EventHandler(this.itemview_DoubleClick);
            // 
            // num
            // 
            this.num.Text = "번호";
            this.num.Width = 44;
            // 
            // del_seq
            // 
            this.del_seq.Text = "배송번호";
            this.del_seq.Width = 68;
            // 
            // mem_seq
            // 
            this.mem_seq.Text = "고객번호";
            this.mem_seq.Width = 68;
            // 
            // inv_seq
            // 
            this.inv_seq.Text = "물품번호";
            this.inv_seq.Width = 70;
            // 
            // curr_loc
            // 
            this.curr_loc.Text = "현위치";
            this.curr_loc.Width = 118;
            // 
            // dest
            // 
            this.dest.Text = "목적지";
            this.dest.Width = 108;
            // 
            // admin_seq
            // 
            this.admin_seq.Text = "담당자번호";
            // 
            // condition
            // 
            this.condition.Text = "배송현황";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.del_create_but);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 38);
            this.panel1.TabIndex = 90;
            // 
            // del_create_but
            // 
            this.del_create_but.CircleColor = System.Drawing.Color.White;
            this.del_create_but.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.del_create_but.CircleSize = 0;
            this.del_create_but.Dock = System.Windows.Forms.DockStyle.Left;
            this.del_create_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.del_create_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.del_create_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.del_create_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.del_create_but.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.del_create_but.Location = new System.Drawing.Point(0, 0);
            this.del_create_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.del_create_but.Name = "del_create_but";
            this.del_create_but.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.del_create_but.Radius = 0;
            this.del_create_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.del_create_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.del_create_but.Size = new System.Drawing.Size(292, 38);
            this.del_create_but.Style = Sunny.UI.UIStyle.Custom;
            this.del_create_but.Symbol = 0;
            this.del_create_but.SymbolColor = System.Drawing.Color.Black;
            this.del_create_but.SymbolSize = 25;
            this.del_create_but.TabIndex = 76;
            this.del_create_but.Text = "배송정보 등록";
            this.del_create_but.Click += new System.EventHandler(this.del_create_but_Click);
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
            this.but_refresh.Location = new System.Drawing.Point(480, 45);
            this.but_refresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_refresh.Name = "but_refresh";
            this.but_refresh.RectColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectPressColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectSelectedColor = System.Drawing.Color.Transparent;
            this.but_refresh.Size = new System.Drawing.Size(30, 26);
            this.but_refresh.Style = Sunny.UI.UIStyle.Custom;
            this.but_refresh.Symbol = 61473;
            this.but_refresh.TabIndex = 91;
            this.but_refresh.Click += new System.EventHandler(this.but_refresh_Click);
            // 
            // currpb
            // 
            this.currpb.BackColor = System.Drawing.Color.Black;
            this.currpb.Image = global::HeadLamp_Manufacture0909.Properties.Resources.check;
            this.currpb.Location = new System.Drawing.Point(544, 372);
            this.currpb.Name = "currpb";
            this.currpb.Size = new System.Drawing.Size(20, 25);
            this.currpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currpb.TabIndex = 93;
            this.currpb.TabStop = false;
            // 
            // destinationpb
            // 
            this.destinationpb.BackColor = System.Drawing.Color.Black;
            this.destinationpb.Image = global::HeadLamp_Manufacture0909.Properties.Resources.destcheck;
            this.destinationpb.Location = new System.Drawing.Point(656, 231);
            this.destinationpb.Name = "destinationpb";
            this.destinationpb.Size = new System.Drawing.Size(20, 25);
            this.destinationpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.destinationpb.TabIndex = 92;
            this.destinationpb.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = global::HeadLamp_Manufacture0909.Properties.Resources.Korea_icon;
            this.pictureBox1.Location = new System.Drawing.Point(479, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel6.Location = new System.Drawing.Point(616, 370);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(135, 23);
            this.uiSymbolLabel6.SymbolColor = System.Drawing.Color.Red;
            this.uiSymbolLabel6.TabIndex = 94;
            this.uiSymbolLabel6.Text = ": 배송 예정지";
            this.uiSymbolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(617, 391);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(135, 23);
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel1.TabIndex = 95;
            this.uiSymbolLabel1.Text = ": 현재 위치";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DelMainUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.currpb);
            this.Controls.Add(this.destinationpb);
            this.Controls.Add(this.but_refresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.itemview);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DelMainUI";
            this.Size = new System.Drawing.Size(767, 468);
            this.Load += new System.EventHandler(this.DelMainUI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView itemview;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIHeaderButton del_create_but;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader del_seq;
        private System.Windows.Forms.ColumnHeader mem_seq;
        private System.Windows.Forms.ColumnHeader inv_seq;
        private System.Windows.Forms.ColumnHeader curr_loc;
        private System.Windows.Forms.ColumnHeader dest;
        private System.Windows.Forms.ColumnHeader admin_seq;
        private System.Windows.Forms.ColumnHeader condition;
        private Sunny.UI.UISymbolButton but_refresh;
        private System.Windows.Forms.PictureBox destinationpb;
        private System.Windows.Forms.PictureBox currpb;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}
