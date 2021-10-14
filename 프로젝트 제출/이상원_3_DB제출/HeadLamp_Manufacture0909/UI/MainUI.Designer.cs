
namespace HeadLamp_Manufacture0909
{
    partial class MainUI
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.led_alarm = new Sunny.UI.UILedBulb();
            this.led_display = new Sunny.UI.UILedDisplay();
            this.pro1_led = new Sunny.UI.UILedBulb();
            this.pro3_led = new Sunny.UI.UILedBulb();
            this.pro4_led = new Sunny.UI.UILedBulb();
            this.pro5_led = new Sunny.UI.UILedBulb();
            this.top_panel = new Sunny.UI.UIPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.info_but = new Sunny.UI.UISymbolButton();
            this.min_but = new Sunny.UI.UISymbolButton();
            this.close_but = new Sunny.UI.UISymbolButton();
            this.monitor_but = new Sunny.UI.UIHeaderButton();
            this.admin_but = new Sunny.UI.UIHeaderButton();
            this.pro2_led = new Sunny.UI.UILedBulb();
            this.pro_5_but = new Sunny.UI.UIHeaderButton();
            this.pro_4_but = new Sunny.UI.UIHeaderButton();
            this.pro_3_but = new Sunny.UI.UIHeaderButton();
            this.pro_2_but = new Sunny.UI.UIHeaderButton();
            this.pro_1_but = new Sunny.UI.UIHeaderButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.center_panel = new Sunny.UI.UIPanel();
            this.but_6 = new Sunny.UI.UIButton();
            this.but_3 = new Sunny.UI.UIButton();
            this.but_2 = new Sunny.UI.UIButton();
            this.but_4 = new Sunny.UI.UIButton();
            this.but_5 = new Sunny.UI.UIButton();
            this.but_1 = new Sunny.UI.UIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.github_link = new Sunny.UI.UILinkLabel();
            this.top_panel.SuspendLayout();
            this.center_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // led_alarm
            // 
            this.led_alarm.BackColor = System.Drawing.Color.Transparent;
            this.led_alarm.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led_alarm.Location = new System.Drawing.Point(3, 73);
            this.led_alarm.Name = "led_alarm";
            this.led_alarm.Size = new System.Drawing.Size(69, 65);
            this.led_alarm.TabIndex = 6;
            this.led_alarm.Text = "uiLedBulb1";
            // 
            // led_display
            // 
            this.led_display.BackColor = System.Drawing.Color.Black;
            this.led_display.CharCount = 24;
            this.led_display.ForeColor = System.Drawing.Color.Lime;
            this.led_display.IntervalOn = 5;
            this.led_display.IntervalV = 10;
            this.led_display.Location = new System.Drawing.Point(82, 73);
            this.led_display.Name = "led_display";
            this.led_display.Size = new System.Drawing.Size(877, 65);
            this.led_display.TabIndex = 31;
            this.led_display.Text = "--------------------------------------------------------------------";
            // 
            // pro1_led
            // 
            this.pro1_led.BackColor = System.Drawing.Color.Transparent;
            this.pro1_led.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pro1_led.Location = new System.Drawing.Point(18, 29);
            this.pro1_led.Name = "pro1_led";
            this.pro1_led.Size = new System.Drawing.Size(39, 39);
            this.pro1_led.TabIndex = 33;
            this.pro1_led.Text = "uiLedBulb1";
            // 
            // pro3_led
            // 
            this.pro3_led.BackColor = System.Drawing.Color.Transparent;
            this.pro3_led.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pro3_led.Location = new System.Drawing.Point(18, 213);
            this.pro3_led.Name = "pro3_led";
            this.pro3_led.Size = new System.Drawing.Size(39, 39);
            this.pro3_led.TabIndex = 35;
            this.pro3_led.Text = "ㅠ";
            // 
            // pro4_led
            // 
            this.pro4_led.BackColor = System.Drawing.Color.Transparent;
            this.pro4_led.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pro4_led.Location = new System.Drawing.Point(18, 308);
            this.pro4_led.Name = "pro4_led";
            this.pro4_led.Size = new System.Drawing.Size(39, 39);
            this.pro4_led.TabIndex = 36;
            this.pro4_led.Text = "ㅠ";
            // 
            // pro5_led
            // 
            this.pro5_led.BackColor = System.Drawing.Color.Transparent;
            this.pro5_led.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pro5_led.Location = new System.Drawing.Point(18, 401);
            this.pro5_led.Name = "pro5_led";
            this.pro5_led.Size = new System.Drawing.Size(39, 39);
            this.pro5_led.TabIndex = 37;
            this.pro5_led.Text = "ㅠ";
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.White;
            this.top_panel.Controls.Add(this.uiLabel1);
            this.top_panel.Controls.Add(this.info_but);
            this.top_panel.Controls.Add(this.min_but);
            this.top_panel.Controls.Add(this.close_but);
            this.top_panel.Controls.Add(this.led_alarm);
            this.top_panel.Controls.Add(this.led_display);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.FillColor = System.Drawing.Color.White;
            this.top_panel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.top_panel.MinimumSize = new System.Drawing.Size(1, 1);
            this.top_panel.Name = "top_panel";
            this.top_panel.RectColor = System.Drawing.Color.Transparent;
            this.top_panel.Size = new System.Drawing.Size(975, 146);
            this.top_panel.Style = Sunny.UI.UIStyle.Custom;
            this.top_panel.TabIndex = 42;
            this.top_panel.Text = null;
            this.top_panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseMove);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("양재샤넬체M", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.Location = new System.Drawing.Point(3, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(216, 44);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 35;
            this.uiLabel1.Text = "(주) 헤드 램프";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
            // 
            // info_but
            // 
            this.info_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_but.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.info_but.Location = new System.Drawing.Point(868, 3);
            this.info_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.info_but.Name = "info_but";
            this.info_but.Size = new System.Drawing.Size(33, 47);
            this.info_but.Style = Sunny.UI.UIStyle.Custom;
            this.info_but.Symbol = 61736;
            this.info_but.TabIndex = 34;
            this.info_but.Click += new System.EventHandler(this.info_but_Click);
            // 
            // min_but
            // 
            this.min_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min_but.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.min_but.Location = new System.Drawing.Point(904, 3);
            this.min_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.min_but.Name = "min_but";
            this.min_but.Size = new System.Drawing.Size(33, 47);
            this.min_but.Style = Sunny.UI.UIStyle.Custom;
            this.min_but.Symbol = 62161;
            this.min_but.TabIndex = 33;
            this.min_but.Click += new System.EventHandler(this.min_but_Click);
            // 
            // close_but
            // 
            this.close_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_but.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.close_but.Location = new System.Drawing.Point(939, 3);
            this.close_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(33, 47);
            this.close_but.Style = Sunny.UI.UIStyle.Custom;
            this.close_but.Symbol = 61453;
            this.close_but.TabIndex = 32;
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // monitor_but
            // 
            this.monitor_but.CircleColor = System.Drawing.Color.White;
            this.monitor_but.CircleHoverColor = System.Drawing.Color.Gray;
            this.monitor_but.CircleSize = 0;
            this.monitor_but.FillColor = System.Drawing.Color.White;
            this.monitor_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.monitor_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.monitor_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.monitor_but.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.monitor_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.monitor_but.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.monitor_but.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.monitor_but.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.monitor_but.Location = new System.Drawing.Point(94, 468);
            this.monitor_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.monitor_but.Name = "monitor_but";
            this.monitor_but.Padding = new System.Windows.Forms.Padding(0, 20, 0, 15);
            this.monitor_but.Radius = 0;
            this.monitor_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.monitor_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.monitor_but.Size = new System.Drawing.Size(95, 72);
            this.monitor_but.Style = Sunny.UI.UIStyle.White;
            this.monitor_but.Symbol = 61649;
            this.monitor_but.SymbolColor = System.Drawing.Color.Black;
            this.monitor_but.TabIndex = 44;
            this.monitor_but.Text = "배송";
            this.monitor_but.Click += new System.EventHandler(this.monitor_but_Click);
            // 
            // admin_but
            // 
            this.admin_but.CircleColor = System.Drawing.Color.White;
            this.admin_but.CircleHoverColor = System.Drawing.Color.Gray;
            this.admin_but.CircleSize = 0;
            this.admin_but.FillColor = System.Drawing.Color.White;
            this.admin_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.admin_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.admin_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.admin_but.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.admin_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.admin_but.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.admin_but.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.admin_but.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.admin_but.Location = new System.Drawing.Point(0, 468);
            this.admin_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.admin_but.Name = "admin_but";
            this.admin_but.Padding = new System.Windows.Forms.Padding(0, 20, 0, 15);
            this.admin_but.Radius = 0;
            this.admin_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.admin_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.admin_but.Size = new System.Drawing.Size(94, 72);
            this.admin_but.Style = Sunny.UI.UIStyle.White;
            this.admin_but.Symbol = 62142;
            this.admin_but.SymbolColor = System.Drawing.Color.Black;
            this.admin_but.TabIndex = 43;
            this.admin_but.Text = "관리자";
            this.admin_but.Click += new System.EventHandler(this.admin_but_Click);
            // 
            // pro2_led
            // 
            this.pro2_led.BackColor = System.Drawing.Color.Transparent;
            this.pro2_led.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pro2_led.Location = new System.Drawing.Point(18, 120);
            this.pro2_led.Name = "pro2_led";
            this.pro2_led.Size = new System.Drawing.Size(39, 39);
            this.pro2_led.TabIndex = 34;
            this.pro2_led.Text = "uiLedBulb1";
            // 
            // pro_5_but
            // 
            this.pro_5_but.FillColor = System.Drawing.Color.White;
            this.pro_5_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_5_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_5_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_5_but.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.pro_5_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.pro_5_but.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.pro_5_but.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.pro_5_but.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.pro_5_but.Location = new System.Drawing.Point(0, 375);
            this.pro_5_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.pro_5_but.Name = "pro_5_but";
            this.pro_5_but.Padding = new System.Windows.Forms.Padding(20, 8, 0, 35);
            this.pro_5_but.Radius = 0;
            this.pro_5_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pro_5_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pro_5_but.Size = new System.Drawing.Size(189, 93);
            this.pro_5_but.Style = Sunny.UI.UIStyle.White;
            this.pro_5_but.Symbol = 0;
            this.pro_5_but.TabIndex = 42;
            this.pro_5_but.Text = "         프로세스 5";
            this.pro_5_but.Click += new System.EventHandler(this.pro_5_but_Click);
            // 
            // pro_4_but
            // 
            this.pro_4_but.FillColor = System.Drawing.Color.White;
            this.pro_4_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_4_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_4_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_4_but.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.pro_4_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.pro_4_but.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.pro_4_but.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.pro_4_but.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.pro_4_but.Location = new System.Drawing.Point(0, 282);
            this.pro_4_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.pro_4_but.Name = "pro_4_but";
            this.pro_4_but.Padding = new System.Windows.Forms.Padding(20, 8, 0, 35);
            this.pro_4_but.Radius = 0;
            this.pro_4_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pro_4_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pro_4_but.Size = new System.Drawing.Size(189, 93);
            this.pro_4_but.Style = Sunny.UI.UIStyle.White;
            this.pro_4_but.Symbol = 0;
            this.pro_4_but.TabIndex = 41;
            this.pro_4_but.Text = "         프로세스 4";
            this.pro_4_but.Click += new System.EventHandler(this.pro_4_but_Click);
            // 
            // pro_3_but
            // 
            this.pro_3_but.FillColor = System.Drawing.Color.White;
            this.pro_3_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_3_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_3_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_3_but.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.pro_3_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.pro_3_but.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.pro_3_but.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.pro_3_but.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.pro_3_but.Location = new System.Drawing.Point(0, 189);
            this.pro_3_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.pro_3_but.Name = "pro_3_but";
            this.pro_3_but.Padding = new System.Windows.Forms.Padding(20, 8, 0, 35);
            this.pro_3_but.Radius = 0;
            this.pro_3_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pro_3_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pro_3_but.Size = new System.Drawing.Size(189, 93);
            this.pro_3_but.Style = Sunny.UI.UIStyle.White;
            this.pro_3_but.Symbol = 0;
            this.pro_3_but.TabIndex = 40;
            this.pro_3_but.Text = "         프로세스 3";
            this.pro_3_but.Click += new System.EventHandler(this.pro_3_but_Click);
            // 
            // pro_2_but
            // 
            this.pro_2_but.FillColor = System.Drawing.Color.White;
            this.pro_2_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_2_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_2_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_2_but.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.pro_2_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.pro_2_but.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.pro_2_but.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.pro_2_but.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.pro_2_but.Location = new System.Drawing.Point(0, 96);
            this.pro_2_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.pro_2_but.Name = "pro_2_but";
            this.pro_2_but.Padding = new System.Windows.Forms.Padding(20, 8, 0, 35);
            this.pro_2_but.Radius = 0;
            this.pro_2_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pro_2_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pro_2_but.Size = new System.Drawing.Size(189, 93);
            this.pro_2_but.Style = Sunny.UI.UIStyle.White;
            this.pro_2_but.Symbol = 0;
            this.pro_2_but.TabIndex = 39;
            this.pro_2_but.Text = "         프로세스 2";
            this.pro_2_but.Click += new System.EventHandler(this.pro_2_but_Click);
            // 
            // pro_1_but
            // 
            this.pro_1_but.FillColor = System.Drawing.Color.White;
            this.pro_1_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_1_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_1_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pro_1_but.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.pro_1_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.pro_1_but.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.pro_1_but.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.pro_1_but.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.pro_1_but.Location = new System.Drawing.Point(0, 0);
            this.pro_1_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.pro_1_but.Name = "pro_1_but";
            this.pro_1_but.Padding = new System.Windows.Forms.Padding(20, 8, 0, 35);
            this.pro_1_but.Radius = 0;
            this.pro_1_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pro_1_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pro_1_but.Size = new System.Drawing.Size(189, 96);
            this.pro_1_but.Style = Sunny.UI.UIStyle.White;
            this.pro_1_but.Symbol = 0;
            this.pro_1_but.TabIndex = 38;
            this.pro_1_but.Text = "         프로세스 1";
            this.pro_1_but.Click += new System.EventHandler(this.pro_1_but_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Silver;
            this.uiLine1.Location = new System.Drawing.Point(186, 139);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(2, 556);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 45;
            // 
            // center_panel
            // 
            this.center_panel.Controls.Add(this.but_6);
            this.center_panel.Controls.Add(this.but_3);
            this.center_panel.Controls.Add(this.but_2);
            this.center_panel.Controls.Add(this.but_4);
            this.center_panel.Controls.Add(this.but_5);
            this.center_panel.Controls.Add(this.but_1);
            this.center_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center_panel.FillColor = System.Drawing.Color.DimGray;
            this.center_panel.FillDisableColor = System.Drawing.Color.White;
            this.center_panel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.center_panel.Location = new System.Drawing.Point(188, 146);
            this.center_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.center_panel.MinimumSize = new System.Drawing.Size(1, 1);
            this.center_panel.Name = "center_panel";
            this.center_panel.RectColor = System.Drawing.Color.Transparent;
            this.center_panel.Size = new System.Drawing.Size(787, 537);
            this.center_panel.Style = Sunny.UI.UIStyle.Custom;
            this.center_panel.TabIndex = 46;
            this.center_panel.Text = null;
            this.center_panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.center_panel.Click += new System.EventHandler(this.center_panel_Click);
            // 
            // but_6
            // 
            this.but_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_6.Location = new System.Drawing.Point(773, 499);
            this.but_6.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_6.Name = "but_6";
            this.but_6.Size = new System.Drawing.Size(100, 35);
            this.but_6.Style = Sunny.UI.UIStyle.Custom;
            this.but_6.TabIndex = 5;
            this.but_6.Text = "uiButton5";
            this.but_6.Click += new System.EventHandler(this.but_6_Click);
            // 
            // but_3
            // 
            this.but_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_3.Location = new System.Drawing.Point(455, 499);
            this.but_3.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_3.Name = "but_3";
            this.but_3.Size = new System.Drawing.Size(100, 35);
            this.but_3.Style = Sunny.UI.UIStyle.Custom;
            this.but_3.TabIndex = 2;
            this.but_3.Text = "uiButton3";
            this.but_3.Click += new System.EventHandler(this.but_3_Click);
            // 
            // but_2
            // 
            this.but_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_2.Location = new System.Drawing.Point(349, 499);
            this.but_2.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_2.Name = "but_2";
            this.but_2.Size = new System.Drawing.Size(100, 35);
            this.but_2.Style = Sunny.UI.UIStyle.Custom;
            this.but_2.TabIndex = 1;
            this.but_2.Text = "uiButton2";
            this.but_2.Click += new System.EventHandler(this.but_2_Click);
            // 
            // but_4
            // 
            this.but_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_4.Location = new System.Drawing.Point(561, 499);
            this.but_4.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_4.Name = "but_4";
            this.but_4.Size = new System.Drawing.Size(100, 35);
            this.but_4.Style = Sunny.UI.UIStyle.Custom;
            this.but_4.TabIndex = 3;
            this.but_4.Text = "uiButton4";
            this.but_4.Click += new System.EventHandler(this.but_4_Click);
            // 
            // but_5
            // 
            this.but_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_5.Location = new System.Drawing.Point(667, 499);
            this.but_5.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_5.Name = "but_5";
            this.but_5.Size = new System.Drawing.Size(100, 35);
            this.but_5.Style = Sunny.UI.UIStyle.Custom;
            this.but_5.TabIndex = 4;
            this.but_5.Text = "uiButton5";
            this.but_5.Click += new System.EventHandler(this.but_5_Click);
            // 
            // but_1
            // 
            this.but_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_1.Location = new System.Drawing.Point(243, 499);
            this.but_1.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_1.Name = "but_1";
            this.but_1.Size = new System.Drawing.Size(100, 35);
            this.but_1.Style = Sunny.UI.UIStyle.Custom;
            this.but_1.TabIndex = 0;
            this.but_1.Text = "uiButton1";
            this.but_1.Click += new System.EventHandler(this.but_1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pro1_led);
            this.panel1.Controls.Add(this.pro2_led);
            this.panel1.Controls.Add(this.pro4_led);
            this.panel1.Controls.Add(this.pro3_led);
            this.panel1.Controls.Add(this.pro5_led);
            this.panel1.Controls.Add(this.pro_1_but);
            this.panel1.Controls.Add(this.admin_but);
            this.panel1.Controls.Add(this.monitor_but);
            this.panel1.Controls.Add(this.pro_5_but);
            this.panel1.Controls.Add(this.pro_4_but);
            this.panel1.Controls.Add(this.pro_3_but);
            this.panel1.Controls.Add(this.pro_2_but);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 537);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.github_link);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(188, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 78);
            this.panel2.TabIndex = 46;
            // 
            // github_link
            // 
            this.github_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.github_link.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.github_link.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.github_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.github_link.Location = new System.Drawing.Point(619, 9);
            this.github_link.Name = "github_link";
            this.github_link.Size = new System.Drawing.Size(156, 37);
            this.github_link.TabIndex = 0;
            this.github_link.TabStop = true;
            this.github_link.Text = "회사 사이트";
            this.github_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.github_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.github_link.Click += new System.EventHandler(this.github_link_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 683);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.center_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.top_panel);
            this.Name = "MainUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.top_panel.ResumeLayout(false);
            this.center_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILedBulb led_alarm;
        private Sunny.UI.UILedDisplay led_display;
        private Sunny.UI.UILedBulb pro1_led;
        private Sunny.UI.UILedBulb pro3_led;
        private Sunny.UI.UILedBulb pro4_led;
        private Sunny.UI.UILedBulb pro5_led;
        private Sunny.UI.UIPanel top_panel;
        private Sunny.UI.UISymbolButton close_but;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIPanel center_panel;
        private Sunny.UI.UISymbolButton info_but;
        private Sunny.UI.UISymbolButton min_but;
        private Sunny.UI.UIHeaderButton monitor_but;
        private Sunny.UI.UIHeaderButton admin_but;
        private Sunny.UI.UILedBulb pro2_led;
        private Sunny.UI.UIHeaderButton pro_5_but;
        private Sunny.UI.UIHeaderButton pro_4_but;
        private Sunny.UI.UIHeaderButton pro_3_but;
        private Sunny.UI.UIHeaderButton pro_2_but;
        private Sunny.UI.UIHeaderButton pro_1_but;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIButton but_6;
        private Sunny.UI.UIButton but_3;
        private Sunny.UI.UIButton but_2;
        private Sunny.UI.UIButton but_4;
        private Sunny.UI.UIButton but_5;
        private Sunny.UI.UIButton but_1;
        private Sunny.UI.UILinkLabel github_link;
    }
}

