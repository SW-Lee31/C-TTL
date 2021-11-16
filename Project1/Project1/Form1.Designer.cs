
namespace Project1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.LineMap = new Sunny.UI.UIPanel();
            this.Close = new Sunny.UI.UISymbolButton();
            this.Minimized = new Sunny.UI.UISymbolButton();
            this.HelpBT = new Sunny.UI.UISymbolButton();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.carList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.NowTime = new System.Windows.Forms.Label();
            this.ListCarCondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListCarLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListCarTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListAItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListBItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListComplete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListItemsTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RefreshBT = new Sunny.UI.UISymbolButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiPanel2.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.uiPanel2.Controls.Add(this.RefreshBT);
            this.uiPanel2.Controls.Add(this.HelpBT);
            this.uiPanel2.Controls.Add(this.Minimized);
            this.uiPanel2.Controls.Add(this.Close);
            this.uiPanel2.FillColor = System.Drawing.Color.White;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Radius = 0;
            this.uiPanel2.RectColor = System.Drawing.Color.Black;
            this.uiPanel2.RectDisableColor = System.Drawing.Color.White;
            this.uiPanel2.Size = new System.Drawing.Size(1201, 64);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
            this.uiPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseMove);
            this.uiPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseUp);
            // 
            // LineMap
            // 
            this.LineMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LineMap.BackgroundImage")));
            this.LineMap.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.LineMap.Location = new System.Drawing.Point(0, 0);
            this.LineMap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LineMap.MinimumSize = new System.Drawing.Size(1, 1);
            this.LineMap.Name = "LineMap";
            this.LineMap.Radius = 0;
            this.LineMap.RectColor = System.Drawing.Color.Black;
            this.LineMap.Size = new System.Drawing.Size(478, 629);
            this.LineMap.Style = Sunny.UI.UIStyle.Custom;
            this.LineMap.TabIndex = 2;
            this.LineMap.Text = null;
            this.LineMap.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FillColor = System.Drawing.SystemColors.Control;
            this.Close.FillHoverColor = System.Drawing.Color.Silver;
            this.Close.FillPressColor = System.Drawing.Color.Silver;
            this.Close.FillSelectedColor = System.Drawing.Color.Silver;
            this.Close.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Close.ForeColor = System.Drawing.Color.Silver;
            this.Close.ForeHoverColor = System.Drawing.Color.DarkGray;
            this.Close.ForePressColor = System.Drawing.Color.Silver;
            this.Close.ForeSelectedColor = System.Drawing.Color.DarkGray;
            this.Close.Location = new System.Drawing.Point(1162, 5);
            this.Close.MinimumSize = new System.Drawing.Size(1, 1);
            this.Close.Name = "Close";
            this.Close.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Close.RectHoverColor = System.Drawing.Color.DarkGray;
            this.Close.RectPressColor = System.Drawing.Color.Silver;
            this.Close.RectSelectedColor = System.Drawing.Color.DarkGray;
            this.Close.Size = new System.Drawing.Size(35, 35);
            this.Close.Style = Sunny.UI.UIStyle.Custom;
            this.Close.Symbol = 61453;
            this.Close.SymbolSize = 35;
            this.Close.TabIndex = 4;
            this.Close.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // Minimized
            // 
            this.Minimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimized.FillColor = System.Drawing.SystemColors.Control;
            this.Minimized.FillHoverColor = System.Drawing.Color.Silver;
            this.Minimized.FillPressColor = System.Drawing.Color.Silver;
            this.Minimized.FillSelectedColor = System.Drawing.Color.Silver;
            this.Minimized.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Minimized.ForeColor = System.Drawing.Color.Silver;
            this.Minimized.ForeHoverColor = System.Drawing.Color.DarkGray;
            this.Minimized.ForePressColor = System.Drawing.Color.Silver;
            this.Minimized.ForeSelectedColor = System.Drawing.Color.DarkGray;
            this.Minimized.Location = new System.Drawing.Point(1121, 5);
            this.Minimized.MinimumSize = new System.Drawing.Size(1, 1);
            this.Minimized.Name = "Minimized";
            this.Minimized.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Minimized.RectHoverColor = System.Drawing.Color.DarkGray;
            this.Minimized.RectPressColor = System.Drawing.Color.Silver;
            this.Minimized.RectSelectedColor = System.Drawing.Color.DarkGray;
            this.Minimized.Size = new System.Drawing.Size(35, 35);
            this.Minimized.Style = Sunny.UI.UIStyle.Custom;
            this.Minimized.Symbol = 61544;
            this.Minimized.SymbolSize = 35;
            this.Minimized.TabIndex = 5;
            this.Minimized.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // HelpBT
            // 
            this.HelpBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpBT.FillColor = System.Drawing.SystemColors.Control;
            this.HelpBT.FillHoverColor = System.Drawing.Color.Silver;
            this.HelpBT.FillPressColor = System.Drawing.Color.Silver;
            this.HelpBT.FillSelectedColor = System.Drawing.Color.Silver;
            this.HelpBT.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.HelpBT.ForeColor = System.Drawing.Color.Silver;
            this.HelpBT.ForeHoverColor = System.Drawing.Color.DarkGray;
            this.HelpBT.ForePressColor = System.Drawing.Color.Silver;
            this.HelpBT.ForeSelectedColor = System.Drawing.Color.DarkGray;
            this.HelpBT.Location = new System.Drawing.Point(1080, 5);
            this.HelpBT.MinimumSize = new System.Drawing.Size(1, 1);
            this.HelpBT.Name = "HelpBT";
            this.HelpBT.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HelpBT.RectHoverColor = System.Drawing.Color.DarkGray;
            this.HelpBT.RectPressColor = System.Drawing.Color.Silver;
            this.HelpBT.RectSelectedColor = System.Drawing.Color.DarkGray;
            this.HelpBT.Size = new System.Drawing.Size(35, 35);
            this.HelpBT.Style = Sunny.UI.UIStyle.Custom;
            this.HelpBT.Symbol = 61736;
            this.HelpBT.SymbolSize = 35;
            this.HelpBT.TabIndex = 6;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.NowTime);
            this.uiPanel3.Controls.Add(this.label3);
            this.uiPanel3.Controls.Add(this.itemList);
            this.uiPanel3.Controls.Add(this.label2);
            this.uiPanel3.Controls.Add(this.label1);
            this.uiPanel3.Controls.Add(this.carList);
            this.uiPanel3.FillColor = System.Drawing.Color.White;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(477, 44);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Radius = 0;
            this.uiPanel3.RectColor = System.Drawing.Color.Black;
            this.uiPanel3.RectDisableColor = System.Drawing.Color.White;
            this.uiPanel3.Size = new System.Drawing.Size(724, 585);
            this.uiPanel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel3.TabIndex = 3;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carList
            // 
            this.carList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListCarCondition,
            this.ListCarLocation,
            this.ListCarTime});
            this.carList.HideSelection = false;
            this.carList.Location = new System.Drawing.Point(14, 43);
            this.carList.Name = "carList";
            this.carList.Size = new System.Drawing.Size(692, 229);
            this.carList.TabIndex = 0;
            this.carList.UseCompatibleStateImageBehavior = false;
            this.carList.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "차량 상태 View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.label2.Location = new System.Drawing.Point(15, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "물품 상태 View";
            // 
            // itemList
            // 
            this.itemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListAItems,
            this.ListBItems,
            this.ListComplete,
            this.ListItemsTime});
            this.itemList.HideSelection = false;
            this.itemList.Location = new System.Drawing.Point(14, 313);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(692, 229);
            this.itemList.TabIndex = 3;
            this.itemList.UseCompatibleStateImageBehavior = false;
            this.itemList.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.label3.Location = new System.Drawing.Point(15, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "현재 시간 : ";
            // 
            // NowTime
            // 
            this.NowTime.AutoSize = true;
            this.NowTime.BackColor = System.Drawing.Color.White;
            this.NowTime.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.NowTime.Location = new System.Drawing.Point(126, 550);
            this.NowTime.Name = "NowTime";
            this.NowTime.Size = new System.Drawing.Size(0, 27);
            this.NowTime.TabIndex = 5;
            // 
            // ListCarCondition
            // 
            this.ListCarCondition.Text = "차량 상태";
            this.ListCarCondition.Width = 122;
            // 
            // ListCarLocation
            // 
            this.ListCarLocation.Text = "차량 위치";
            this.ListCarLocation.Width = 125;
            // 
            // ListCarTime
            // 
            this.ListCarTime.Text = "시간";
            this.ListCarTime.Width = 288;
            // 
            // ListAItems
            // 
            this.ListAItems.Text = "A구역 수량";
            this.ListAItems.Width = 122;
            // 
            // ListBItems
            // 
            this.ListBItems.Text = "B구역 수량";
            this.ListBItems.Width = 132;
            // 
            // ListComplete
            // 
            this.ListComplete.Text = "적재 완료";
            this.ListComplete.Width = 119;
            // 
            // ListItemsTime
            // 
            this.ListItemsTime.Text = "시간";
            this.ListItemsTime.Width = 287;
            // 
            // RefreshBT
            // 
            this.RefreshBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBT.FillColor = System.Drawing.SystemColors.Control;
            this.RefreshBT.FillHoverColor = System.Drawing.Color.Silver;
            this.RefreshBT.FillPressColor = System.Drawing.Color.Silver;
            this.RefreshBT.FillSelectedColor = System.Drawing.Color.Silver;
            this.RefreshBT.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.RefreshBT.ForeColor = System.Drawing.Color.Silver;
            this.RefreshBT.ForeHoverColor = System.Drawing.Color.DarkGray;
            this.RefreshBT.ForePressColor = System.Drawing.Color.Silver;
            this.RefreshBT.ForeSelectedColor = System.Drawing.Color.DarkGray;
            this.RefreshBT.Location = new System.Drawing.Point(1039, 5);
            this.RefreshBT.MinimumSize = new System.Drawing.Size(1, 1);
            this.RefreshBT.Name = "RefreshBT";
            this.RefreshBT.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RefreshBT.RectHoverColor = System.Drawing.Color.DarkGray;
            this.RefreshBT.RectPressColor = System.Drawing.Color.Silver;
            this.RefreshBT.RectSelectedColor = System.Drawing.Color.DarkGray;
            this.RefreshBT.Size = new System.Drawing.Size(35, 35);
            this.RefreshBT.Style = Sunny.UI.UIStyle.Custom;
            this.RefreshBT.Symbol = 61473;
            this.RefreshBT.SymbolSize = 35;
            this.RefreshBT.TabIndex = 7;
            this.RefreshBT.Click += new System.EventHandler(this.RefreshBT_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 990;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 630);
            this.Controls.Add(this.uiPanel3);
            this.Controls.Add(this.LineMap);
            this.Controls.Add(this.uiPanel2);
            this.Name = "Form1";
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.uiPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel LineMap;
        private Sunny.UI.UISymbolButton HelpBT;
        private Sunny.UI.UISymbolButton Minimized;
        private Sunny.UI.UISymbolButton Close;
        private Sunny.UI.UISymbolButton RefreshBT;
        private Sunny.UI.UIPanel uiPanel3;
        private System.Windows.Forms.Label NowTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView itemList;
        private System.Windows.Forms.ColumnHeader ListAItems;
        private System.Windows.Forms.ColumnHeader ListBItems;
        private System.Windows.Forms.ColumnHeader ListComplete;
        private System.Windows.Forms.ColumnHeader ListItemsTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView carList;
        private System.Windows.Forms.ColumnHeader ListCarCondition;
        private System.Windows.Forms.ColumnHeader ListCarLocation;
        private System.Windows.Forms.ColumnHeader ListCarTime;
        private System.Windows.Forms.Timer timer1;
    }
}

