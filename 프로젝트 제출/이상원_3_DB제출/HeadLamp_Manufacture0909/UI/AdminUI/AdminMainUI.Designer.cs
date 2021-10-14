
namespace HeadLamp_Manufacture0909.UI.AdminUI
{
    partial class AdminMainUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.compare_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.allstop_but = new Sunny.UI.UIHeaderButton();
            this.pro1_but = new Sunny.UI.UIHeaderButton();
            this.but_controller = new Sunny.UI.UIHeaderButton();
            this.all_act_but = new Sunny.UI.UIHeaderButton();
            this.pro5_but = new Sunny.UI.UIHeaderButton();
            this.pro4_but = new Sunny.UI.UIHeaderButton();
            this.pro3_but = new Sunny.UI.UIHeaderButton();
            this.pro2_but = new Sunny.UI.UIHeaderButton();
            this.utput_pro_fail = new Sunny.UI.UILabel();
            this.output_pro_fair = new Sunny.UI.UILabel();
            this.uiSymbolLabel9 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.but_refresh = new Sunny.UI.UISymbolButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)(this.compare_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // compare_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.compare_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.compare_chart.Legends.Add(legend1);
            this.compare_chart.Location = new System.Drawing.Point(3, 14);
            this.compare_chart.Name = "compare_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "process_success_amount";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "process_fail_amount";
            this.compare_chart.Series.Add(series1);
            this.compare_chart.Series.Add(series2);
            this.compare_chart.Size = new System.Drawing.Size(486, 334);
            this.compare_chart.TabIndex = 67;
            this.compare_chart.Text = "chart1";
            title1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            title1.Name = "Title";
            title1.Text = "양률 / 불량률 대조 차트 ";
            this.compare_chart.Titles.Add(title1);
            // 
            // allstop_but
            // 
            this.allstop_but.CircleColor = System.Drawing.Color.White;
            this.allstop_but.CircleHoverColor = System.Drawing.Color.Red;
            this.allstop_but.CircleSize = 0;
            this.allstop_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.allstop_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.allstop_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.allstop_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.allstop_but.Font = new System.Drawing.Font("맑은 고딕", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allstop_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.allstop_but.Location = new System.Drawing.Point(503, 377);
            this.allstop_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.allstop_but.Name = "allstop_but";
            this.allstop_but.Padding = new System.Windows.Forms.Padding(0, 30, 0, 3);
            this.allstop_but.Radius = 0;
            this.allstop_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.allstop_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.allstop_but.Size = new System.Drawing.Size(261, 86);
            this.allstop_but.Style = Sunny.UI.UIStyle.LightRed;
            this.allstop_but.Symbol = 61527;
            this.allstop_but.SymbolColor = System.Drawing.Color.Red;
            this.allstop_but.SymbolSize = 60;
            this.allstop_but.TabIndex = 69;
            this.allstop_but.Text = "모든 프로세스 작동중단";
            this.allstop_but.Click += new System.EventHandler(this.allstop_but_Click);
            // 
            // pro1_but
            // 
            this.pro1_but.CircleColor = System.Drawing.Color.White;
            this.pro1_but.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pro1_but.CircleSize = 0;
            this.pro1_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.pro1_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.pro1_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.pro1_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.pro1_but.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pro1_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.pro1_but.Location = new System.Drawing.Point(505, 4);
            this.pro1_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.pro1_but.Name = "pro1_but";
            this.pro1_but.Padding = new System.Windows.Forms.Padding(0, 35, 0, 3);
            this.pro1_but.Radius = 0;
            this.pro1_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pro1_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pro1_but.Size = new System.Drawing.Size(125, 88);
            this.pro1_but.Style = Sunny.UI.UIStyle.LightGreen;
            this.pro1_but.Symbol = 61573;
            this.pro1_but.SymbolColor = System.Drawing.Color.Black;
            this.pro1_but.TabIndex = 70;
            this.pro1_but.Text = "프로세스1 작동";
            this.pro1_but.Click += new System.EventHandler(this.pro1_but_Click);
            // 
            // but_controller
            // 
            this.but_controller.CircleColor = System.Drawing.Color.White;
            this.but_controller.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.but_controller.CircleSize = 0;
            this.but_controller.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.but_controller.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.but_controller.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.but_controller.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.but_controller.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but_controller.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_controller.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_controller.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_controller.Location = new System.Drawing.Point(639, 248);
            this.but_controller.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_controller.Name = "but_controller";
            this.but_controller.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.but_controller.Radius = 0;
            this.but_controller.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_controller.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_controller.Size = new System.Drawing.Size(125, 32);
            this.but_controller.Style = Sunny.UI.UIStyle.Black;
            this.but_controller.Symbol = 0;
            this.but_controller.SymbolColor = System.Drawing.Color.Black;
            this.but_controller.TabIndex = 75;
            this.but_controller.Text = "컨트롤러";
            this.but_controller.Click += new System.EventHandler(this.but_controller_Click);
            // 
            // all_act_but
            // 
            this.all_act_but.CircleColor = System.Drawing.Color.White;
            this.all_act_but.CircleHoverColor = System.Drawing.Color.Green;
            this.all_act_but.CircleSize = 0;
            this.all_act_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.all_act_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.all_act_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.all_act_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.all_act_but.Font = new System.Drawing.Font("맑은 고딕", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.all_act_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.all_act_but.Location = new System.Drawing.Point(503, 286);
            this.all_act_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.all_act_but.Name = "all_act_but";
            this.all_act_but.Padding = new System.Windows.Forms.Padding(0, 30, 0, 3);
            this.all_act_but.Radius = 0;
            this.all_act_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.all_act_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.all_act_but.Size = new System.Drawing.Size(261, 86);
            this.all_act_but.Style = Sunny.UI.UIStyle.LightGreen;
            this.all_act_but.Symbol = 61515;
            this.all_act_but.SymbolColor = System.Drawing.Color.Green;
            this.all_act_but.SymbolSize = 60;
            this.all_act_but.TabIndex = 72;
            this.all_act_but.Text = "모든 프로세스 가동";
            this.all_act_but.Click += new System.EventHandler(this.all_act_but_Click);
            // 
            // pro5_but
            // 
            this.pro5_but.CircleColor = System.Drawing.Color.White;
            this.pro5_but.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pro5_but.CircleSize = 0;
            this.pro5_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.pro5_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.pro5_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.pro5_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.pro5_but.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pro5_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.pro5_but.Location = new System.Drawing.Point(505, 192);
            this.pro5_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.pro5_but.Name = "pro5_but";
            this.pro5_but.Padding = new System.Windows.Forms.Padding(0, 35, 0, 3);
            this.pro5_but.Radius = 0;
            this.pro5_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pro5_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pro5_but.Size = new System.Drawing.Size(125, 88);
            this.pro5_but.Style = Sunny.UI.UIStyle.LightGreen;
            this.pro5_but.Symbol = 61573;
            this.pro5_but.SymbolColor = System.Drawing.Color.Black;
            this.pro5_but.TabIndex = 74;
            this.pro5_but.Text = "프로세스5 작동";
            this.pro5_but.Click += new System.EventHandler(this.pro5_but_Click);
            // 
            // pro4_but
            // 
            this.pro4_but.CircleColor = System.Drawing.Color.White;
            this.pro4_but.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pro4_but.CircleSize = 0;
            this.pro4_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.pro4_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.pro4_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.pro4_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.pro4_but.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pro4_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.pro4_but.Location = new System.Drawing.Point(639, 98);
            this.pro4_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.pro4_but.Name = "pro4_but";
            this.pro4_but.Padding = new System.Windows.Forms.Padding(0, 35, 0, 3);
            this.pro4_but.Radius = 0;
            this.pro4_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pro4_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pro4_but.Size = new System.Drawing.Size(125, 88);
            this.pro4_but.Style = Sunny.UI.UIStyle.LightGreen;
            this.pro4_but.Symbol = 61573;
            this.pro4_but.SymbolColor = System.Drawing.Color.Black;
            this.pro4_but.TabIndex = 73;
            this.pro4_but.Text = "프로세스4 작동";
            this.pro4_but.Click += new System.EventHandler(this.pro4_but_Click);
            // 
            // pro3_but
            // 
            this.pro3_but.CircleColor = System.Drawing.Color.White;
            this.pro3_but.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pro3_but.CircleSize = 0;
            this.pro3_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.pro3_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.pro3_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.pro3_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.pro3_but.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pro3_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.pro3_but.Location = new System.Drawing.Point(505, 98);
            this.pro3_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.pro3_but.Name = "pro3_but";
            this.pro3_but.Padding = new System.Windows.Forms.Padding(0, 35, 0, 3);
            this.pro3_but.Radius = 0;
            this.pro3_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pro3_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pro3_but.Size = new System.Drawing.Size(125, 88);
            this.pro3_but.Style = Sunny.UI.UIStyle.LightGreen;
            this.pro3_but.Symbol = 61573;
            this.pro3_but.SymbolColor = System.Drawing.Color.Black;
            this.pro3_but.TabIndex = 72;
            this.pro3_but.Text = "프로세스3 작동";
            this.pro3_but.Click += new System.EventHandler(this.pro3_but_Click);
            // 
            // pro2_but
            // 
            this.pro2_but.CircleColor = System.Drawing.Color.White;
            this.pro2_but.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pro2_but.CircleSize = 0;
            this.pro2_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.pro2_but.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.pro2_but.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.pro2_but.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.pro2_but.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pro2_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.pro2_but.Location = new System.Drawing.Point(639, 4);
            this.pro2_but.MinimumSize = new System.Drawing.Size(1, 1);
            this.pro2_but.Name = "pro2_but";
            this.pro2_but.Padding = new System.Windows.Forms.Padding(0, 35, 0, 3);
            this.pro2_but.Radius = 0;
            this.pro2_but.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pro2_but.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pro2_but.Size = new System.Drawing.Size(125, 88);
            this.pro2_but.Style = Sunny.UI.UIStyle.LightGreen;
            this.pro2_but.Symbol = 61573;
            this.pro2_but.SymbolColor = System.Drawing.Color.Black;
            this.pro2_but.TabIndex = 71;
            this.pro2_but.Text = "프로세스2 작동";
            this.pro2_but.Click += new System.EventHandler(this.upro2_but_Click);
            // 
            // utput_pro_fail
            // 
            this.utput_pro_fail.BackColor = System.Drawing.Color.Maroon;
            this.utput_pro_fail.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.utput_pro_fail.ForeColor = System.Drawing.Color.White;
            this.utput_pro_fail.Location = new System.Drawing.Point(254, 413);
            this.utput_pro_fail.Name = "utput_pro_fail";
            this.utput_pro_fail.Size = new System.Drawing.Size(231, 43);
            this.utput_pro_fail.Style = Sunny.UI.UIStyle.Custom;
            this.utput_pro_fail.TabIndex = 75;
            this.utput_pro_fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_pro_fair
            // 
            this.output_pro_fair.BackColor = System.Drawing.Color.Green;
            this.output_pro_fair.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_pro_fair.ForeColor = System.Drawing.Color.White;
            this.output_pro_fair.Location = new System.Drawing.Point(14, 413);
            this.output_pro_fair.Name = "output_pro_fair";
            this.output_pro_fair.Size = new System.Drawing.Size(231, 43);
            this.output_pro_fair.Style = Sunny.UI.UIStyle.Custom;
            this.output_pro_fair.TabIndex = 74;
            this.output_pro_fair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel9
            // 
            this.uiSymbolLabel9.BackColor = System.Drawing.Color.Maroon;
            this.uiSymbolLabel9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel9.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel9.Location = new System.Drawing.Point(254, 367);
            this.uiSymbolLabel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel9.Name = "uiSymbolLabel9";
            this.uiSymbolLabel9.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.uiSymbolLabel9.Size = new System.Drawing.Size(231, 43);
            this.uiSymbolLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel9.Symbol = 61533;
            this.uiSymbolLabel9.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel9.SymbolSize = 35;
            this.uiSymbolLabel9.TabIndex = 73;
            this.uiSymbolLabel9.Text = "불량품 누적 개수";
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.BackColor = System.Drawing.Color.Green;
            this.uiSymbolLabel8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel8.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel8.Location = new System.Drawing.Point(14, 367);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(231, 43);
            this.uiSymbolLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel8.Symbol = 61533;
            this.uiSymbolLabel8.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel8.SymbolSize = 35;
            this.uiSymbolLabel8.TabIndex = 72;
            this.uiSymbolLabel8.Text = "양품 누적 개수";
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
            this.but_refresh.Location = new System.Drawing.Point(405, 31);
            this.but_refresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_refresh.Name = "but_refresh";
            this.but_refresh.RectColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectPressColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectSelectedColor = System.Drawing.Color.Transparent;
            this.but_refresh.Size = new System.Drawing.Size(42, 26);
            this.but_refresh.Style = Sunny.UI.UIStyle.Custom;
            this.but_refresh.Symbol = 61473;
            this.but_refresh.TabIndex = 76;
            this.but_refresh.Click += new System.EventHandler(this.but_refresh_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(499, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(268, 468);
            this.uiLabel1.TabIndex = 77;
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(49, 22);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(49, 47);
            this.uiSymbolLabel1.Symbol = 61530;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.DarkGreen;
            this.uiSymbolLabel1.SymbolSize = 40;
            this.uiSymbolLabel1.TabIndex = 68;
            // 
            // AdminMainUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.but_controller);
            this.Controls.Add(this.but_refresh);
            this.Controls.Add(this.allstop_but);
            this.Controls.Add(this.utput_pro_fail);
            this.Controls.Add(this.all_act_but);
            this.Controls.Add(this.output_pro_fair);
            this.Controls.Add(this.pro5_but);
            this.Controls.Add(this.uiSymbolLabel9);
            this.Controls.Add(this.pro4_but);
            this.Controls.Add(this.pro3_but);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.pro2_but);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.pro1_but);
            this.Controls.Add(this.compare_chart);
            this.Controls.Add(this.uiLabel1);
            this.Name = "AdminMainUI";
            this.Size = new System.Drawing.Size(767, 468);
            this.Load += new System.EventHandler(this.AdminMainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compare_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart compare_chart;
        private Sunny.UI.UIHeaderButton allstop_but;
        private Sunny.UI.UIHeaderButton pro1_but;
        private Sunny.UI.UIHeaderButton all_act_but;
        private Sunny.UI.UIHeaderButton pro5_but;
        private Sunny.UI.UIHeaderButton pro4_but;
        private Sunny.UI.UIHeaderButton pro3_but;
        private Sunny.UI.UIHeaderButton pro2_but;
        private Sunny.UI.UILabel utput_pro_fail;
        private Sunny.UI.UILabel output_pro_fair;
        private Sunny.UI.UISymbolLabel uiSymbolLabel9;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UISymbolButton but_refresh;
        private Sunny.UI.UIHeaderButton but_controller;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}
