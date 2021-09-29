
namespace CarManager0827
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
            this.uiLine2 = new Sunny.UI.UILine();
            this.panel2 = new CarManager0827.DoubleBufferPanel();
            this.addCustWin = new Sunny.UI.UIHeaderButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiSymbolButton4 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton5 = new Sunny.UI.UISymbolButton();
            this.helpWin = new Sunny.UI.UIHeaderButton();
            this.adminWin = new Sunny.UI.UIHeaderButton();
            this.salesWin = new Sunny.UI.UIHeaderButton();
            this.addCarWin = new Sunny.UI.UIHeaderButton();
            this.uiSymbolButton9 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton8 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton6 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton7 = new Sunny.UI.UISymbolButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.mainMin = new Sunny.UI.UISymbolButton();
            this.topLayout = new CarManager0827.DoubleBufferPanel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.centerLayout = new CarManager0827.DoubleBufferPanel();
            this.panel2.SuspendLayout();
            this.topLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLine2
            // 
            this.uiLine2.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.LineColor = System.Drawing.Color.Silver;
            this.uiLine2.Location = new System.Drawing.Point(224, 65);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(2, 767);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 6;
            this.uiLine2.Text = "uiLine2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.addCustWin);
            this.panel2.Controls.Add(this.uiLine1);
            this.panel2.Controls.Add(this.uiSymbolButton4);
            this.panel2.Controls.Add(this.uiSymbolButton5);
            this.panel2.Controls.Add(this.helpWin);
            this.panel2.Controls.Add(this.adminWin);
            this.panel2.Controls.Add(this.salesWin);
            this.panel2.Controls.Add(this.addCarWin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 768);
            this.panel2.TabIndex = 5;
            // 
            // addCustWin
            // 
            this.addCustWin.BackColor = System.Drawing.Color.Transparent;
            this.addCustWin.CircleColor = System.Drawing.Color.Transparent;
            this.addCustWin.FillColor = System.Drawing.Color.White;
            this.addCustWin.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addCustWin.FillPressColor = System.Drawing.Color.Silver;
            this.addCustWin.FillSelectedColor = System.Drawing.Color.DarkTurquoise;
            this.addCustWin.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustWin.ForeColor = System.Drawing.Color.DimGray;
            this.addCustWin.ForeHoverColor = System.Drawing.Color.Black;
            this.addCustWin.ForePressColor = System.Drawing.Color.Black;
            this.addCustWin.Location = new System.Drawing.Point(3, 3);
            this.addCustWin.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCustWin.Name = "addCustWin";
            this.addCustWin.Padding = new System.Windows.Forms.Padding(0, 40, 0, 10);
            this.addCustWin.Radius = 0;
            this.addCustWin.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addCustWin.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addCustWin.Size = new System.Drawing.Size(219, 132);
            this.addCustWin.Style = Sunny.UI.UIStyle.Custom;
            this.addCustWin.Symbol = 62004;
            this.addCustWin.SymbolColor = System.Drawing.Color.Black;
            this.addCustWin.SymbolSize = 60;
            this.addCustWin.TabIndex = 33;
            this.addCustWin.Text = "고객 등록";
            this.addCustWin.Click += new System.EventHandler(this.addCustWin_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Silver;
            this.uiLine1.Location = new System.Drawing.Point(0, 680);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(225, 2);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 2;
            // 
            // uiSymbolButton4
            // 
            this.uiSymbolButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton4.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton4.ForeColor = System.Drawing.Color.DarkGray;
            this.uiSymbolButton4.ForeHoverColor = System.Drawing.Color.DimGray;
            this.uiSymbolButton4.ForePressColor = System.Drawing.Color.DeepSkyBlue;
            this.uiSymbolButton4.Location = new System.Drawing.Point(143, 699);
            this.uiSymbolButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton4.Name = "uiSymbolButton4";
            this.uiSymbolButton4.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.Size = new System.Drawing.Size(57, 55);
            this.uiSymbolButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton4.Symbol = 61459;
            this.uiSymbolButton4.SymbolSize = 48;
            this.uiSymbolButton4.TabIndex = 5;
            // 
            // uiSymbolButton5
            // 
            this.uiSymbolButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton5.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton5.ForeColor = System.Drawing.Color.DarkGray;
            this.uiSymbolButton5.ForeHoverColor = System.Drawing.Color.DimGray;
            this.uiSymbolButton5.ForePressColor = System.Drawing.Color.DeepSkyBlue;
            this.uiSymbolButton5.Location = new System.Drawing.Point(29, 699);
            this.uiSymbolButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton5.Name = "uiSymbolButton5";
            this.uiSymbolButton5.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton5.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton5.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton5.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton5.Size = new System.Drawing.Size(57, 55);
            this.uiSymbolButton5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton5.Symbol = 61462;
            this.uiSymbolButton5.SymbolSize = 48;
            this.uiSymbolButton5.TabIndex = 4;
            this.uiSymbolButton5.Click += new System.EventHandler(this.uiSymbolButton5_Click);
            // 
            // helpWin
            // 
            this.helpWin.BackColor = System.Drawing.Color.Transparent;
            this.helpWin.CircleColor = System.Drawing.Color.Transparent;
            this.helpWin.FillColor = System.Drawing.Color.White;
            this.helpWin.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.helpWin.FillPressColor = System.Drawing.Color.Silver;
            this.helpWin.FillSelectedColor = System.Drawing.Color.DarkTurquoise;
            this.helpWin.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpWin.ForeColor = System.Drawing.Color.DimGray;
            this.helpWin.ForeHoverColor = System.Drawing.Color.Black;
            this.helpWin.ForePressColor = System.Drawing.Color.Black;
            this.helpWin.Location = new System.Drawing.Point(3, 528);
            this.helpWin.MinimumSize = new System.Drawing.Size(1, 1);
            this.helpWin.Name = "helpWin";
            this.helpWin.Padding = new System.Windows.Forms.Padding(0, 40, 0, 10);
            this.helpWin.Radius = 0;
            this.helpWin.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.helpWin.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.helpWin.Size = new System.Drawing.Size(219, 132);
            this.helpWin.Style = Sunny.UI.UIStyle.Custom;
            this.helpWin.Symbol = 62069;
            this.helpWin.SymbolColor = System.Drawing.Color.Black;
            this.helpWin.SymbolSize = 60;
            this.helpWin.TabIndex = 32;
            this.helpWin.Text = "작업시작";
            this.helpWin.Click += new System.EventHandler(this.helpWin_Click);
            // 
            // adminWin
            // 
            this.adminWin.BackColor = System.Drawing.Color.Transparent;
            this.adminWin.CircleColor = System.Drawing.Color.Transparent;
            this.adminWin.FillColor = System.Drawing.Color.White;
            this.adminWin.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adminWin.FillPressColor = System.Drawing.Color.Silver;
            this.adminWin.FillSelectedColor = System.Drawing.Color.DarkTurquoise;
            this.adminWin.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminWin.ForeColor = System.Drawing.Color.DimGray;
            this.adminWin.ForeHoverColor = System.Drawing.Color.Black;
            this.adminWin.ForePressColor = System.Drawing.Color.Black;
            this.adminWin.Location = new System.Drawing.Point(3, 396);
            this.adminWin.MinimumSize = new System.Drawing.Size(1, 1);
            this.adminWin.Name = "adminWin";
            this.adminWin.Padding = new System.Windows.Forms.Padding(0, 40, 0, 10);
            this.adminWin.Radius = 0;
            this.adminWin.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.adminWin.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.adminWin.Size = new System.Drawing.Size(219, 132);
            this.adminWin.Style = Sunny.UI.UIStyle.Custom;
            this.adminWin.Symbol = 62142;
            this.adminWin.SymbolColor = System.Drawing.Color.Black;
            this.adminWin.SymbolSize = 60;
            this.adminWin.TabIndex = 31;
            this.adminWin.Text = "관리자";
            this.adminWin.Click += new System.EventHandler(this.adminWin_Click);
            // 
            // salesWin
            // 
            this.salesWin.BackColor = System.Drawing.Color.Transparent;
            this.salesWin.CircleColor = System.Drawing.Color.Transparent;
            this.salesWin.FillColor = System.Drawing.Color.White;
            this.salesWin.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.salesWin.FillPressColor = System.Drawing.Color.Silver;
            this.salesWin.FillSelectedColor = System.Drawing.Color.DarkTurquoise;
            this.salesWin.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesWin.ForeColor = System.Drawing.Color.DimGray;
            this.salesWin.ForeHoverColor = System.Drawing.Color.Black;
            this.salesWin.ForePressColor = System.Drawing.Color.Black;
            this.salesWin.Location = new System.Drawing.Point(3, 264);
            this.salesWin.MinimumSize = new System.Drawing.Size(1, 1);
            this.salesWin.Name = "salesWin";
            this.salesWin.Padding = new System.Windows.Forms.Padding(0, 40, 0, 10);
            this.salesWin.Radius = 0;
            this.salesWin.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.salesWin.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.salesWin.Size = new System.Drawing.Size(219, 132);
            this.salesWin.Style = Sunny.UI.UIStyle.Custom;
            this.salesWin.Symbol = 61568;
            this.salesWin.SymbolColor = System.Drawing.Color.Black;
            this.salesWin.SymbolSize = 60;
            this.salesWin.TabIndex = 30;
            this.salesWin.Text = "매출 정보";
            this.salesWin.Click += new System.EventHandler(this.salesWin_Click);
            // 
            // addCarWin
            // 
            this.addCarWin.BackColor = System.Drawing.Color.Transparent;
            this.addCarWin.CircleColor = System.Drawing.Color.Transparent;
            this.addCarWin.FillColor = System.Drawing.Color.White;
            this.addCarWin.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addCarWin.FillPressColor = System.Drawing.Color.Silver;
            this.addCarWin.FillSelectedColor = System.Drawing.Color.DarkTurquoise;
            this.addCarWin.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarWin.ForeColor = System.Drawing.Color.DimGray;
            this.addCarWin.ForeHoverColor = System.Drawing.Color.Black;
            this.addCarWin.ForePressColor = System.Drawing.Color.Black;
            this.addCarWin.Location = new System.Drawing.Point(3, 132);
            this.addCarWin.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarWin.Name = "addCarWin";
            this.addCarWin.Padding = new System.Windows.Forms.Padding(0, 40, 0, 10);
            this.addCarWin.Radius = 0;
            this.addCarWin.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addCarWin.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addCarWin.Size = new System.Drawing.Size(219, 132);
            this.addCarWin.Style = Sunny.UI.UIStyle.Custom;
            this.addCarWin.Symbol = 61881;
            this.addCarWin.SymbolColor = System.Drawing.Color.Black;
            this.addCarWin.SymbolSize = 60;
            this.addCarWin.TabIndex = 29;
            this.addCarWin.Text = "차량 등록";
            this.addCarWin.Click += new System.EventHandler(this.addCarWin_Click);
            // 
            // uiSymbolButton9
            // 
            this.uiSymbolButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton9.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton9.ForeColor = System.Drawing.Color.Gainsboro;
            this.uiSymbolButton9.ForeHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.uiSymbolButton9.ForePressColor = System.Drawing.Color.Gainsboro;
            this.uiSymbolButton9.Location = new System.Drawing.Point(662, 7);
            this.uiSymbolButton9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton9.Name = "uiSymbolButton9";
            this.uiSymbolButton9.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton9.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton9.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton9.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton9.Size = new System.Drawing.Size(57, 55);
            this.uiSymbolButton9.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton9.Symbol = 57445;
            this.uiSymbolButton9.SymbolSize = 56;
            this.uiSymbolButton9.TabIndex = 9;
            this.uiSymbolButton9.TipsText = "카카오톡";
            // 
            // uiSymbolButton8
            // 
            this.uiSymbolButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton8.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton8.ForeColor = System.Drawing.Color.Gainsboro;
            this.uiSymbolButton8.ForeHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.uiSymbolButton8.ForePressColor = System.Drawing.Color.Gainsboro;
            this.uiSymbolButton8.Location = new System.Drawing.Point(788, 7);
            this.uiSymbolButton8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton8.Name = "uiSymbolButton8";
            this.uiSymbolButton8.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton8.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton8.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton8.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton8.Size = new System.Drawing.Size(57, 55);
            this.uiSymbolButton8.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton8.Symbol = 57538;
            this.uiSymbolButton8.SymbolSize = 56;
            this.uiSymbolButton8.TabIndex = 8;
            // 
            // uiSymbolButton6
            // 
            this.uiSymbolButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton6.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton6.ForeColor = System.Drawing.Color.Gainsboro;
            this.uiSymbolButton6.ForeHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.uiSymbolButton6.ForePressColor = System.Drawing.Color.Gainsboro;
            this.uiSymbolButton6.Location = new System.Drawing.Point(851, 7);
            this.uiSymbolButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton6.Name = "uiSymbolButton6";
            this.uiSymbolButton6.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton6.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton6.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton6.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton6.Size = new System.Drawing.Size(57, 55);
            this.uiSymbolButton6.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton6.Symbol = 57540;
            this.uiSymbolButton6.SymbolSize = 56;
            this.uiSymbolButton6.TabIndex = 7;
            // 
            // uiSymbolButton7
            // 
            this.uiSymbolButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton7.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton7.ForeColor = System.Drawing.Color.Gainsboro;
            this.uiSymbolButton7.ForeHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.uiSymbolButton7.ForePressColor = System.Drawing.Color.Gainsboro;
            this.uiSymbolButton7.Location = new System.Drawing.Point(725, 7);
            this.uiSymbolButton7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton7.Name = "uiSymbolButton7";
            this.uiSymbolButton7.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton7.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton7.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton7.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton7.Size = new System.Drawing.Size(57, 55);
            this.uiSymbolButton7.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton7.Symbol = 57537;
            this.uiSymbolButton7.SymbolSize = 56;
            this.uiSymbolButton7.TabIndex = 6;
            // 
            // mainExit
            // 
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Transparent;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.ForeHoverColor = System.Drawing.Color.DarkRed;
            this.mainExit.ForePressColor = System.Drawing.Color.LightSkyBlue;
            this.mainExit.Location = new System.Drawing.Point(1061, 12);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Transparent;
            this.mainExit.RectHoverColor = System.Drawing.Color.Transparent;
            this.mainExit.RectPressColor = System.Drawing.Color.Transparent;
            this.mainExit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.mainExit.Size = new System.Drawing.Size(38, 35);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61453;
            this.mainExit.SymbolSize = 32;
            this.mainExit.TabIndex = 3;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // mainMin
            // 
            this.mainMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainMin.FillColor = System.Drawing.Color.Transparent;
            this.mainMin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainMin.ForeHoverColor = System.Drawing.Color.DarkRed;
            this.mainMin.ForePressColor = System.Drawing.Color.LightSkyBlue;
            this.mainMin.Location = new System.Drawing.Point(1017, 12);
            this.mainMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainMin.Name = "mainMin";
            this.mainMin.RectColor = System.Drawing.Color.Transparent;
            this.mainMin.RectHoverColor = System.Drawing.Color.Transparent;
            this.mainMin.RectPressColor = System.Drawing.Color.Transparent;
            this.mainMin.RectSelectedColor = System.Drawing.Color.Transparent;
            this.mainMin.Size = new System.Drawing.Size(38, 35);
            this.mainMin.Style = Sunny.UI.UIStyle.Custom;
            this.mainMin.Symbol = 61544;
            this.mainMin.SymbolSize = 32;
            this.mainMin.TabIndex = 2;
            this.mainMin.Click += new System.EventHandler(this.mainMin_Click);
            // 
            // topLayout
            // 
            this.topLayout.BackColor = System.Drawing.Color.Transparent;
            this.topLayout.Controls.Add(this.uiSymbolLabel1);
            this.topLayout.Controls.Add(this.uiSymbolButton9);
            this.topLayout.Controls.Add(this.uiSymbolButton8);
            this.topLayout.Controls.Add(this.uiSymbolButton6);
            this.topLayout.Controls.Add(this.uiSymbolButton7);
            this.topLayout.Controls.Add(this.mainExit);
            this.topLayout.Controls.Add(this.mainMin);
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayout.Location = new System.Drawing.Point(0, 0);
            this.topLayout.Name = "topLayout";
            this.topLayout.Size = new System.Drawing.Size(1111, 65);
            this.topLayout.TabIndex = 4;
            this.topLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLayout_MouseMove);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 12);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(303, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61881;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.TabIndex = 16;
            this.uiSymbolLabel1.Text = "고객 차량 관리 프로그램 3.0";
            // 
            // centerLayout
            // 
            this.centerLayout.BackColor = System.Drawing.Color.Transparent;
            this.centerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerLayout.Location = new System.Drawing.Point(225, 65);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(886, 768);
            this.centerLayout.TabIndex = 7;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 833);
            this.ControlBox = false;
            this.Controls.Add(this.centerLayout);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topLayout);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.Resize += new System.EventHandler(this.MainUI_Resize);
            this.panel2.ResumeLayout(false);
            this.topLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolButton uiSymbolButton4;
        private Sunny.UI.UISymbolButton uiSymbolButton5;
        private Sunny.UI.UIHeaderButton helpWin;
        private Sunny.UI.UIHeaderButton adminWin;
        private Sunny.UI.UIHeaderButton salesWin;
        private Sunny.UI.UIHeaderButton addCarWin;
        private Sunny.UI.UISymbolButton uiSymbolButton9;
        private Sunny.UI.UISymbolButton uiSymbolButton8;
        private Sunny.UI.UISymbolButton uiSymbolButton6;
        private Sunny.UI.UISymbolButton uiSymbolButton7;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolButton mainMin;
        private Sunny.UI.UIHeaderButton addCustWin;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private DoubleBufferPanel panel2;
        private DoubleBufferPanel topLayout;
        private DoubleBufferPanel centerLayout;
    }
}

