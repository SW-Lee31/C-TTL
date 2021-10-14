
namespace HeadLamp_Manufacture0909.UI.MenuUI
{
    partial class Home
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.temp_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.temp_meter4 = new Sunny.UI.UIAnalogMeter();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.temp_meter5 = new Sunny.UI.UIAnalogMeter();
            this.temp_meter1 = new Sunny.UI.UIAnalogMeter();
            this.temp_meter2 = new Sunny.UI.UIAnalogMeter();
            this.temp_meter3 = new Sunny.UI.UIAnalogMeter();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine3 = new Sunny.UI.UILine();
            this.uiLine4 = new Sunny.UI.UILine();
            this.but_refresh = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.temp_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(3, 261);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(153, 41);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61573;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.TabIndex = 2;
            this.uiSymbolLabel1.Text = "프로세스 1";
            this.uiSymbolLabel1.Click += new System.EventHandler(this.uiSymbolLabel1_Click);
            // 
            // temp_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.temp_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.temp_chart.Legends.Add(legend1);
            this.temp_chart.Location = new System.Drawing.Point(3, 3);
            this.temp_chart.Name = "temp_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Process1_temp";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Process2_temp";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Process3_temp";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Process4_temp";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Process5_temp";
            this.temp_chart.Series.Add(series1);
            this.temp_chart.Series.Add(series2);
            this.temp_chart.Series.Add(series3);
            this.temp_chart.Series.Add(series4);
            this.temp_chart.Series.Add(series5);
            this.temp_chart.Size = new System.Drawing.Size(769, 258);
            this.temp_chart.TabIndex = 3;
            this.temp_chart.Text = "chart1";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(156, 261);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(153, 41);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 61573;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel2.TabIndex = 5;
            this.uiSymbolLabel2.Text = "프로세스 2";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Black;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(309, 261);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(153, 41);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 61573;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel3.TabIndex = 7;
            this.uiSymbolLabel3.Text = "프로세스 3";
            this.uiSymbolLabel3.Click += new System.EventHandler(this.uiSymbolLabel3_Click);
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Black;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel4.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel4.Location = new System.Drawing.Point(462, 261);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(153, 41);
            this.uiSymbolLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel4.Symbol = 61573;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel4.TabIndex = 9;
            this.uiSymbolLabel4.Text = "프로세스 4";
            // 
            // temp_meter4
            // 
            this.temp_meter4.BackColor = System.Drawing.Color.Black;
            this.temp_meter4.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.temp_meter4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.temp_meter4.Location = new System.Drawing.Point(462, 308);
            this.temp_meter4.MaxValue = 100D;
            this.temp_meter4.MinimumSize = new System.Drawing.Size(1, 1);
            this.temp_meter4.MinValue = 0D;
            this.temp_meter4.Name = "temp_meter4";
            this.temp_meter4.Renderer = null;
            this.temp_meter4.Size = new System.Drawing.Size(153, 146);
            this.temp_meter4.Style = Sunny.UI.UIStyle.Custom;
            this.temp_meter4.TabIndex = 8;
            this.temp_meter4.Text = "uiAnalogMeter1";
            this.temp_meter4.Value = 0D;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Black;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel5.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel5.Location = new System.Drawing.Point(615, 261);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(153, 41);
            this.uiSymbolLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel5.Symbol = 61573;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel5.TabIndex = 11;
            this.uiSymbolLabel5.Text = "프로세스 5";
            // 
            // temp_meter5
            // 
            this.temp_meter5.BackColor = System.Drawing.Color.Black;
            this.temp_meter5.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.temp_meter5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.temp_meter5.Location = new System.Drawing.Point(615, 308);
            this.temp_meter5.MaxValue = 100D;
            this.temp_meter5.MinimumSize = new System.Drawing.Size(1, 1);
            this.temp_meter5.MinValue = 0D;
            this.temp_meter5.Name = "temp_meter5";
            this.temp_meter5.Renderer = null;
            this.temp_meter5.Size = new System.Drawing.Size(153, 146);
            this.temp_meter5.Style = Sunny.UI.UIStyle.Custom;
            this.temp_meter5.TabIndex = 10;
            this.temp_meter5.Text = "uiAnalogMeter1";
            this.temp_meter5.Value = 0D;
            // 
            // temp_meter1
            // 
            this.temp_meter1.BackColor = System.Drawing.Color.Black;
            this.temp_meter1.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.temp_meter1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.temp_meter1.Location = new System.Drawing.Point(3, 308);
            this.temp_meter1.MaxValue = 100D;
            this.temp_meter1.MinimumSize = new System.Drawing.Size(1, 1);
            this.temp_meter1.MinValue = 0D;
            this.temp_meter1.Name = "temp_meter1";
            this.temp_meter1.Renderer = null;
            this.temp_meter1.Size = new System.Drawing.Size(153, 146);
            this.temp_meter1.Style = Sunny.UI.UIStyle.Custom;
            this.temp_meter1.TabIndex = 0;
            this.temp_meter1.Text = "uiAnalogMeter1";
            this.temp_meter1.Value = 0D;
            // 
            // temp_meter2
            // 
            this.temp_meter2.BackColor = System.Drawing.Color.Black;
            this.temp_meter2.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.temp_meter2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.temp_meter2.Location = new System.Drawing.Point(156, 308);
            this.temp_meter2.MaxValue = 100D;
            this.temp_meter2.MinimumSize = new System.Drawing.Size(1, 1);
            this.temp_meter2.MinValue = 0D;
            this.temp_meter2.Name = "temp_meter2";
            this.temp_meter2.Renderer = null;
            this.temp_meter2.Size = new System.Drawing.Size(153, 146);
            this.temp_meter2.Style = Sunny.UI.UIStyle.Custom;
            this.temp_meter2.TabIndex = 4;
            this.temp_meter2.Text = "uiAnalogMeter1";
            this.temp_meter2.Value = 0D;
            // 
            // temp_meter3
            // 
            this.temp_meter3.BackColor = System.Drawing.Color.Black;
            this.temp_meter3.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.temp_meter3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.temp_meter3.Location = new System.Drawing.Point(309, 308);
            this.temp_meter3.MaxValue = 100D;
            this.temp_meter3.MinimumSize = new System.Drawing.Size(1, 1);
            this.temp_meter3.MinValue = 0D;
            this.temp_meter3.Name = "temp_meter3";
            this.temp_meter3.Renderer = null;
            this.temp_meter3.Size = new System.Drawing.Size(153, 146);
            this.temp_meter3.Style = Sunny.UI.UIStyle.Custom;
            this.temp_meter3.TabIndex = 6;
            this.temp_meter3.Text = "uiAnalogMeter1";
            this.temp_meter3.Value = 0D;
            // 
            // uiLine1
            // 
            this.uiLine1.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Silver;
            this.uiLine1.Location = new System.Drawing.Point(153, 267);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(2, 230);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 12;
            // 
            // uiLine2
            // 
            this.uiLine2.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.LineColor = System.Drawing.Color.Silver;
            this.uiLine2.Location = new System.Drawing.Point(306, 266);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(2, 230);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 13;
            // 
            // uiLine3
            // 
            this.uiLine3.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine3.LineColor = System.Drawing.Color.Silver;
            this.uiLine3.Location = new System.Drawing.Point(459, 267);
            this.uiLine3.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(2, 230);
            this.uiLine3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine3.TabIndex = 14;
            // 
            // uiLine4
            // 
            this.uiLine4.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine4.LineColor = System.Drawing.Color.Silver;
            this.uiLine4.Location = new System.Drawing.Point(612, 267);
            this.uiLine4.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine4.Name = "uiLine4";
            this.uiLine4.Size = new System.Drawing.Size(2, 230);
            this.uiLine4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine4.TabIndex = 15;
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
            this.but_refresh.Location = new System.Drawing.Point(691, 97);
            this.but_refresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_refresh.Name = "but_refresh";
            this.but_refresh.RectColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectPressColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectSelectedColor = System.Drawing.Color.Transparent;
            this.but_refresh.Size = new System.Drawing.Size(42, 26);
            this.but_refresh.Style = Sunny.UI.UIStyle.Custom;
            this.but_refresh.Symbol = 61473;
            this.but_refresh.TabIndex = 77;
            this.but_refresh.Click += new System.EventHandler(this.but_refresh_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.but_refresh);
            this.Controls.Add(this.uiLine4);
            this.Controls.Add(this.uiLine3);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.temp_meter5);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.temp_meter4);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.temp_meter3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.temp_meter2);
            this.Controls.Add(this.temp_chart);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.temp_meter1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(767, 460);
            ((System.ComponentModel.ISupportInitialize)(this.temp_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart temp_chart;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UIAnalogMeter temp_meter4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UIAnalogMeter temp_meter5;
        private Sunny.UI.UIAnalogMeter temp_meter1;
        private Sunny.UI.UIAnalogMeter temp_meter2;
        private Sunny.UI.UIAnalogMeter temp_meter3;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UILine uiLine4;
        private Sunny.UI.UISymbolButton but_refresh;
    }
}
