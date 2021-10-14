
namespace HeadLamp_Manufacture0909.UI.MenuUI
{
    partial class Pro2_infoUI
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
            this.utput_pro2_fail = new Sunny.UI.UILabel();
            this.output_pro2_fair = new Sunny.UI.UILabel();
            this.uiSymbolLabel9 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.output_pro2_timer = new Sunny.UI.UILabel();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.output_pro2_online = new Sunny.UI.UILabel();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.output_pro2_dust = new Sunny.UI.UILabel();
            this.output_pro2_humi = new Sunny.UI.UILabel();
            this.output_pro2_temp = new Sunny.UI.UILabel();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemview = new System.Windows.Forms.ListView();
            this.serial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.con = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.but_refresh = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // utput_pro2_fail
            // 
            this.utput_pro2_fail.BackColor = System.Drawing.Color.Maroon;
            this.utput_pro2_fail.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.utput_pro2_fail.ForeColor = System.Drawing.Color.White;
            this.utput_pro2_fail.Location = new System.Drawing.Point(533, 246);
            this.utput_pro2_fail.Name = "utput_pro2_fail";
            this.utput_pro2_fail.Size = new System.Drawing.Size(232, 43);
            this.utput_pro2_fail.Style = Sunny.UI.UIStyle.Custom;
            this.utput_pro2_fail.TabIndex = 87;
            this.utput_pro2_fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_pro2_fair
            // 
            this.output_pro2_fair.BackColor = System.Drawing.Color.Green;
            this.output_pro2_fair.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_pro2_fair.ForeColor = System.Drawing.Color.White;
            this.output_pro2_fair.Location = new System.Drawing.Point(298, 246);
            this.output_pro2_fair.Name = "output_pro2_fair";
            this.output_pro2_fair.Size = new System.Drawing.Size(230, 43);
            this.output_pro2_fair.Style = Sunny.UI.UIStyle.Custom;
            this.output_pro2_fair.TabIndex = 86;
            this.output_pro2_fair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel9
            // 
            this.uiSymbolLabel9.BackColor = System.Drawing.Color.Maroon;
            this.uiSymbolLabel9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel9.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel9.Location = new System.Drawing.Point(533, 200);
            this.uiSymbolLabel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel9.Name = "uiSymbolLabel9";
            this.uiSymbolLabel9.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.uiSymbolLabel9.Size = new System.Drawing.Size(231, 43);
            this.uiSymbolLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel9.Symbol = 61533;
            this.uiSymbolLabel9.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel9.SymbolSize = 35;
            this.uiSymbolLabel9.TabIndex = 84;
            this.uiSymbolLabel9.Text = "불량품 누적 개수";
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.BackColor = System.Drawing.Color.Green;
            this.uiSymbolLabel8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel8.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel8.Location = new System.Drawing.Point(297, 200);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(231, 43);
            this.uiSymbolLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel8.Symbol = 61533;
            this.uiSymbolLabel8.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel8.SymbolSize = 35;
            this.uiSymbolLabel8.TabIndex = 83;
            this.uiSymbolLabel8.Text = "양품 누적 개수";
            // 
            // output_pro2_timer
            // 
            this.output_pro2_timer.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_pro2_timer.Location = new System.Drawing.Point(517, 110);
            this.output_pro2_timer.Name = "output_pro2_timer";
            this.output_pro2_timer.Size = new System.Drawing.Size(220, 43);
            this.output_pro2_timer.Style = Sunny.UI.UIStyle.Custom;
            this.output_pro2_timer.TabIndex = 82;
            this.output_pro2_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel7.Location = new System.Drawing.Point(376, 110);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(135, 43);
            this.uiSymbolLabel7.Symbol = 62068;
            this.uiSymbolLabel7.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel7.TabIndex = 81;
            this.uiSymbolLabel7.Text = "작업시작시간";
            this.uiSymbolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // output_pro2_online
            // 
            this.output_pro2_online.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_pro2_online.Location = new System.Drawing.Point(517, 61);
            this.output_pro2_online.Name = "output_pro2_online";
            this.output_pro2_online.Size = new System.Drawing.Size(125, 43);
            this.output_pro2_online.Style = Sunny.UI.UIStyle.Custom;
            this.output_pro2_online.TabIndex = 80;
            this.output_pro2_online.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel6.Location = new System.Drawing.Point(376, 61);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(135, 43);
            this.uiSymbolLabel6.Symbol = 61457;
            this.uiSymbolLabel6.SymbolColor = System.Drawing.Color.Red;
            this.uiSymbolLabel6.TabIndex = 79;
            this.uiSymbolLabel6.Text = "작동상태";
            this.uiSymbolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // output_pro2_dust
            // 
            this.output_pro2_dust.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_pro2_dust.Location = new System.Drawing.Point(148, 415);
            this.output_pro2_dust.Name = "output_pro2_dust";
            this.output_pro2_dust.Size = new System.Drawing.Size(125, 43);
            this.output_pro2_dust.Style = Sunny.UI.UIStyle.Custom;
            this.output_pro2_dust.TabIndex = 78;
            this.output_pro2_dust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_pro2_humi
            // 
            this.output_pro2_humi.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_pro2_humi.Location = new System.Drawing.Point(148, 363);
            this.output_pro2_humi.Name = "output_pro2_humi";
            this.output_pro2_humi.Size = new System.Drawing.Size(125, 43);
            this.output_pro2_humi.Style = Sunny.UI.UIStyle.Custom;
            this.output_pro2_humi.TabIndex = 77;
            this.output_pro2_humi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_pro2_temp
            // 
            this.output_pro2_temp.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_pro2_temp.Location = new System.Drawing.Point(148, 314);
            this.output_pro2_temp.Name = "output_pro2_temp";
            this.output_pro2_temp.Size = new System.Drawing.Size(125, 43);
            this.output_pro2_temp.Style = Sunny.UI.UIStyle.Custom;
            this.output_pro2_temp.TabIndex = 76;
            this.output_pro2_temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel5.Location = new System.Drawing.Point(29, 415);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(101, 43);
            this.uiSymbolLabel5.Symbol = 61886;
            this.uiSymbolLabel5.TabIndex = 75;
            this.uiSymbolLabel5.Text = "미세먼지";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel4.Location = new System.Drawing.Point(29, 363);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(101, 43);
            this.uiSymbolLabel4.Symbol = 61507;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.Blue;
            this.uiSymbolLabel4.TabIndex = 74;
            this.uiSymbolLabel4.Text = "습도";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(29, 314);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(101, 43);
            this.uiSymbolLabel3.Symbol = 62152;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Red;
            this.uiSymbolLabel3.TabIndex = 73;
            this.uiSymbolLabel3.Text = "기기온도";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine1
            // 
            this.uiLine1.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Silver;
            this.uiLine1.Location = new System.Drawing.Point(293, -2);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(2, 570);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 72;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(1, 273);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(286, 35);
            this.uiSymbolLabel2.Symbol = 61530;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.DarkGreen;
            this.uiSymbolLabel2.SymbolSize = 40;
            this.uiSymbolLabel2.TabIndex = 71;
            this.uiSymbolLabel2.Text = "프로세스2 환경현황";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(293, 10);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(469, 35);
            this.uiSymbolLabel1.Symbol = 61530;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.DarkGreen;
            this.uiSymbolLabel1.SymbolSize = 40;
            this.uiSymbolLabel1.TabIndex = 70;
            this.uiSymbolLabel1.Text = "프로세스2 제조현황";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::HeadLamp_Manufacture0909.Properties.Resources.Factory_line_icon_2;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // itemview
            // 
            this.itemview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serial,
            this.time,
            this.con});
            this.itemview.Font = new System.Drawing.Font("굴림체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.itemview.FullRowSelect = true;
            this.itemview.HideSelection = false;
            this.itemview.Location = new System.Drawing.Point(301, 295);
            this.itemview.Name = "itemview";
            this.itemview.Size = new System.Drawing.Size(461, 153);
            this.itemview.TabIndex = 88;
            this.itemview.UseCompatibleStateImageBehavior = false;
            this.itemview.View = System.Windows.Forms.View.Details;
            // 
            // serial
            // 
            this.serial.Text = "시리얼";
            this.serial.Width = 121;
            // 
            // time
            // 
            this.time.Text = "제조시간";
            this.time.Width = 104;
            // 
            // con
            // 
            this.con.Text = "불량여부";
            this.con.Width = 151;
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
            this.but_refresh.Location = new System.Drawing.Point(659, 13);
            this.but_refresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_refresh.Name = "but_refresh";
            this.but_refresh.RectColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectPressColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectSelectedColor = System.Drawing.Color.Transparent;
            this.but_refresh.Size = new System.Drawing.Size(42, 26);
            this.but_refresh.Style = Sunny.UI.UIStyle.Custom;
            this.but_refresh.Symbol = 61473;
            this.but_refresh.TabIndex = 89;
            this.but_refresh.Click += new System.EventHandler(this.but_refresh_Click);
            // 
            // Pro2_infoUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.but_refresh);
            this.Controls.Add(this.itemview);
            this.Controls.Add(this.utput_pro2_fail);
            this.Controls.Add(this.output_pro2_fair);
            this.Controls.Add(this.uiSymbolLabel9);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.output_pro2_timer);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.output_pro2_online);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.output_pro2_dust);
            this.Controls.Add(this.output_pro2_humi);
            this.Controls.Add(this.output_pro2_temp);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pro2_infoUI";
            this.Size = new System.Drawing.Size(767, 460);
            this.Load += new System.EventHandler(this.Pro2_infoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel utput_pro2_fail;
        private Sunny.UI.UILabel output_pro2_fair;
        private Sunny.UI.UISymbolLabel uiSymbolLabel9;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UILabel output_pro2_timer;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UILabel output_pro2_online;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UILabel output_pro2_dust;
        private Sunny.UI.UILabel output_pro2_humi;
        private Sunny.UI.UILabel output_pro2_temp;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView itemview;
        private System.Windows.Forms.ColumnHeader serial;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader con;
        private Sunny.UI.UISymbolButton but_refresh;
    }
}
