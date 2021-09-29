
namespace CarManager0811.UI
{
    partial class DyeingUI
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.process_num = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.but_start = new Sunny.UI.UIButton();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.lb_show = new Sunny.UI.UIListBox();
            ((System.ComponentModel.ISupportInitialize)(this.process_num)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(0, 36);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(886, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61947;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Blue;
            this.uiSymbolLabel1.SymbolSize = 40;
            this.uiSymbolLabel1.TabIndex = 87;
            this.uiSymbolLabel1.Text = "염색 작업 공정";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(26, 58);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(172, 29);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 61573;
            this.uiSymbolLabel2.SymbolSize = 25;
            this.uiSymbolLabel2.TabIndex = 88;
            this.uiSymbolLabel2.Text = "작업 시작 개수";
            // 
            // process_num
            // 
            this.process_num.Location = new System.Drawing.Point(299, 58);
            this.process_num.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.process_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.process_num.Name = "process_num";
            this.process_num.Size = new System.Drawing.Size(116, 29);
            this.process_num.TabIndex = 89;
            this.process_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.process_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(161, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 21);
            this.label1.TabIndex = 90;
            this.label1.Text = "방직 -> 제직 -> 염색 -> 후가공 -> 봉제";
            // 
            // but_start
            // 
            this.but_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_start.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_start.Location = new System.Drawing.Point(608, 58);
            this.but_start.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(169, 133);
            this.but_start.Style = Sunny.UI.UIStyle.Custom;
            this.but_start.TabIndex = 91;
            this.but_start.Text = "작업 시작";
            this.but_start.Click += new System.EventHandler(this.but_start_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiSymbolLabel3);
            this.uiGroupBox1.Controls.Add(this.uiSymbolLabel2);
            this.uiGroupBox1.Controls.Add(this.but_start);
            this.uiGroupBox1.Controls.Add(this.process_num);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(44, 88);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.Black;
            this.uiGroupBox1.Size = new System.Drawing.Size(798, 216);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 92;
            this.uiGroupBox1.Text = "uiGroupBox1";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(38, 171);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(117, 21);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 61518;
            this.uiSymbolLabel3.SymbolSize = 25;
            this.uiSymbolLabel3.TabIndex = 92;
            this.uiSymbolLabel3.Text = "작업내용 :";
            // 
            // lb_show
            // 
            this.lb_show.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lb_show.FormatString = "";
            this.lb_show.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lb_show.Location = new System.Drawing.Point(44, 348);
            this.lb_show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_show.MinimumSize = new System.Drawing.Size(1, 1);
            this.lb_show.Name = "lb_show";
            this.lb_show.Padding = new System.Windows.Forms.Padding(2);
            this.lb_show.RectColor = System.Drawing.Color.Black;
            this.lb_show.Size = new System.Drawing.Size(798, 222);
            this.lb_show.Style = Sunny.UI.UIStyle.Custom;
            this.lb_show.TabIndex = 93;
            this.lb_show.Text = "uiListBox1";
            // 
            // DyeingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_show);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "DyeingUI";
            this.Size = new System.Drawing.Size(886, 768);
            ((System.ComponentModel.ISupportInitialize)(this.process_num)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private System.Windows.Forms.NumericUpDown process_num;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton but_start;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UIListBox lb_show;
    }
}
