
namespace CarManager0811.UI
{
    partial class OrderUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddc_3 = new Sunny.UI.UIRadioButton();
            this.ddc_2 = new Sunny.UI.UIRadioButton();
            this.ddc_int_val = new Sunny.UI.UIIntegerUpDown();
            this.ddc_1 = new Sunny.UI.UIRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hp_4 = new Sunny.UI.UIRadioButton();
            this.hp_3 = new Sunny.UI.UIRadioButton();
            this.hp_2 = new Sunny.UI.UIRadioButton();
            this.hp_int_val = new Sunny.UI.UIIntegerUpDown();
            this.hp_1 = new Sunny.UI.UIRadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dmf_int_val = new Sunny.UI.UIIntegerUpDown();
            this.d_dmf = new Sunny.UI.UICheckBox();
            this.p_dmf = new Sunny.UI.UICheckBox();
            this.c_dmf = new Sunny.UI.UICheckBox();
            this.but_order = new Sunny.UI.UIButton();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.but_delete = new Sunny.UI.UIButton();
            this.but_close = new Sunny.UI.UIButton();
            this.detail_order = new Sunny.UI.UIListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(311, 32);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(279, 51);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61687;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.SymbolSize = 40;
            this.uiSymbolLabel1.TabIndex = 60;
            this.uiSymbolLabel1.Text = "평화발레오 제품 발주";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddc_3);
            this.groupBox1.Controls.Add(this.ddc_2);
            this.groupBox1.Controls.Add(this.ddc_int_val);
            this.groupBox1.Controls.Add(this.ddc_1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(3, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 85);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dry Double Clutch (DDC)";
            // 
            // ddc_3
            // 
            this.ddc_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddc_3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ddc_3.Location = new System.Drawing.Point(486, 34);
            this.ddc_3.MinimumSize = new System.Drawing.Size(1, 1);
            this.ddc_3.Name = "ddc_3";
            this.ddc_3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ddc_3.Size = new System.Drawing.Size(249, 29);
            this.ddc_3.TabIndex = 3;
            this.ddc_3.Text = "External Damper (120,000원)";
            // 
            // ddc_2
            // 
            this.ddc_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddc_2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ddc_2.Location = new System.Drawing.Point(219, 34);
            this.ddc_2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ddc_2.Name = "ddc_2";
            this.ddc_2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ddc_2.Size = new System.Drawing.Size(266, 29);
            this.ddc_2.TabIndex = 2;
            this.ddc_2.Text = "클러치 액츄에이터 (110,000원)";
            // 
            // ddc_int_val
            // 
            this.ddc_int_val.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ddc_int_val.Location = new System.Drawing.Point(757, 34);
            this.ddc_int_val.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddc_int_val.MinimumSize = new System.Drawing.Size(100, 0);
            this.ddc_int_val.Name = "ddc_int_val";
            this.ddc_int_val.Size = new System.Drawing.Size(116, 29);
            this.ddc_int_val.TabIndex = 1;
            this.ddc_int_val.Text = "uiIntegerUpDown1";
            this.ddc_int_val.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ddc_1
            // 
            this.ddc_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddc_1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ddc_1.Location = new System.Drawing.Point(6, 34);
            this.ddc_1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ddc_1.Name = "ddc_1";
            this.ddc_1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ddc_1.Size = new System.Drawing.Size(212, 29);
            this.ddc_1.TabIndex = 0;
            this.ddc_1.Text = "더블 클러치 (100,000원)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hp_4);
            this.groupBox2.Controls.Add(this.hp_3);
            this.groupBox2.Controls.Add(this.hp_2);
            this.groupBox2.Controls.Add(this.hp_int_val);
            this.groupBox2.Controls.Add(this.hp_1);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(3, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 85);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HyDrautic Products";
            // 
            // hp_4
            // 
            this.hp_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hp_4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.hp_4.Location = new System.Drawing.Point(569, 34);
            this.hp_4.MinimumSize = new System.Drawing.Size(1, 1);
            this.hp_4.Name = "hp_4";
            this.hp_4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.hp_4.Size = new System.Drawing.Size(157, 29);
            this.hp_4.TabIndex = 4;
            this.hp_4.Text = "CRC (90,000원)";
            // 
            // hp_3
            // 
            this.hp_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hp_3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.hp_3.Location = new System.Drawing.Point(393, 34);
            this.hp_3.MinimumSize = new System.Drawing.Size(1, 1);
            this.hp_3.Name = "hp_3";
            this.hp_3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.hp_3.Size = new System.Drawing.Size(157, 29);
            this.hp_3.TabIndex = 3;
            this.hp_3.Text = "CMC (80,000원)";
            // 
            // hp_2
            // 
            this.hp_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hp_2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.hp_2.Location = new System.Drawing.Point(185, 34);
            this.hp_2.MinimumSize = new System.Drawing.Size(1, 1);
            this.hp_2.Name = "hp_2";
            this.hp_2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.hp_2.Size = new System.Drawing.Size(189, 29);
            this.hp_2.TabIndex = 2;
            this.hp_2.Text = "Damper (70,000원)";
            // 
            // hp_int_val
            // 
            this.hp_int_val.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.hp_int_val.Location = new System.Drawing.Point(757, 34);
            this.hp_int_val.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hp_int_val.MinimumSize = new System.Drawing.Size(100, 0);
            this.hp_int_val.Name = "hp_int_val";
            this.hp_int_val.Size = new System.Drawing.Size(116, 29);
            this.hp_int_val.TabIndex = 1;
            this.hp_int_val.Text = "uiIntegerUpDown1";
            this.hp_int_val.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hp_1
            // 
            this.hp_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hp_1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.hp_1.Location = new System.Drawing.Point(6, 34);
            this.hp_1.MinimumSize = new System.Drawing.Size(1, 1);
            this.hp_1.Name = "hp_1";
            this.hp_1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.hp_1.Size = new System.Drawing.Size(160, 29);
            this.hp_1.TabIndex = 0;
            this.hp_1.Text = "CSC (50,000원)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dmf_int_val);
            this.groupBox3.Controls.Add(this.d_dmf);
            this.groupBox3.Controls.Add(this.p_dmf);
            this.groupBox3.Controls.Add(this.c_dmf);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(3, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 132);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DMF 시스템";
            // 
            // dmf_int_val
            // 
            this.dmf_int_val.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dmf_int_val.Location = new System.Drawing.Point(384, 60);
            this.dmf_int_val.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dmf_int_val.MinimumSize = new System.Drawing.Size(100, 0);
            this.dmf_int_val.Name = "dmf_int_val";
            this.dmf_int_val.Size = new System.Drawing.Size(116, 29);
            this.dmf_int_val.TabIndex = 3;
            this.dmf_int_val.Text = "uiIntegerUpDown1";
            this.dmf_int_val.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_dmf
            // 
            this.d_dmf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d_dmf.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.d_dmf.Location = new System.Drawing.Point(6, 95);
            this.d_dmf.MinimumSize = new System.Drawing.Size(1, 1);
            this.d_dmf.Name = "d_dmf";
            this.d_dmf.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.d_dmf.Size = new System.Drawing.Size(279, 29);
            this.d_dmf.TabIndex = 7;
            this.d_dmf.Text = "Dual Mass Damper (70,000원)";
            // 
            // p_dmf
            // 
            this.p_dmf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_dmf.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.p_dmf.Location = new System.Drawing.Point(6, 60);
            this.p_dmf.MinimumSize = new System.Drawing.Size(1, 1);
            this.p_dmf.Name = "p_dmf";
            this.p_dmf.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.p_dmf.Size = new System.Drawing.Size(252, 29);
            this.p_dmf.TabIndex = 6;
            this.p_dmf.Text = "Pendulum DMF (60,000원)";
            // 
            // c_dmf
            // 
            this.c_dmf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_dmf.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.c_dmf.Location = new System.Drawing.Point(6, 25);
            this.c_dmf.MinimumSize = new System.Drawing.Size(1, 1);
            this.c_dmf.Name = "c_dmf";
            this.c_dmf.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.c_dmf.Size = new System.Drawing.Size(197, 29);
            this.c_dmf.TabIndex = 5;
            this.c_dmf.Text = "C - DMF (50,000원)";
            // 
            // but_order
            // 
            this.but_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_order.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_order.Location = new System.Drawing.Point(736, 544);
            this.but_order.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_order.Name = "but_order";
            this.but_order.Size = new System.Drawing.Size(140, 50);
            this.but_order.TabIndex = 65;
            this.but_order.Text = "주문하기";
            this.but_order.Click += new System.EventHandler(this.but_order_Click);
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(-58, 500);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(279, 36);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 61462;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.SymbolSize = 30;
            this.uiSymbolLabel2.TabIndex = 66;
            this.uiSymbolLabel2.Text = "주문 상세 내역";
            // 
            // but_delete
            // 
            this.but_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_delete.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_delete.Location = new System.Drawing.Point(736, 609);
            this.but_delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(140, 50);
            this.but_delete.TabIndex = 67;
            this.but_delete.Text = "내역삭제";
            // 
            // but_close
            // 
            this.but_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_close.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_close.Location = new System.Drawing.Point(736, 674);
            this.but_close.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(140, 50);
            this.but_close.TabIndex = 68;
            this.but_close.Text = "닫기";
            // 
            // detail_order
            // 
            this.detail_order.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.detail_order.FormatString = "";
            this.detail_order.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.detail_order.Location = new System.Drawing.Point(9, 544);
            this.detail_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detail_order.MinimumSize = new System.Drawing.Size(1, 1);
            this.detail_order.Name = "detail_order";
            this.detail_order.Padding = new System.Windows.Forms.Padding(2);
            this.detail_order.Size = new System.Drawing.Size(720, 180);
            this.detail_order.TabIndex = 69;
            this.detail_order.Text = "uiListBox1";
            // 
            // OrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detail_order);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.but_order);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "OrderUI";
            this.Size = new System.Drawing.Size(886, 768);
            this.Load += new System.EventHandler(this.but_close_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UIRadioButton ddc_3;
        private Sunny.UI.UIRadioButton ddc_2;
        private Sunny.UI.UIIntegerUpDown ddc_int_val;
        private Sunny.UI.UIRadioButton ddc_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UIRadioButton hp_3;
        private Sunny.UI.UIRadioButton hp_2;
        private Sunny.UI.UIIntegerUpDown hp_int_val;
        private Sunny.UI.UIRadioButton hp_1;
        private Sunny.UI.UIRadioButton hp_4;
        private System.Windows.Forms.GroupBox groupBox3;
        private Sunny.UI.UIIntegerUpDown dmf_int_val;
        private Sunny.UI.UICheckBox d_dmf;
        private Sunny.UI.UICheckBox p_dmf;
        private Sunny.UI.UICheckBox c_dmf;
        private Sunny.UI.UIButton but_order;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIButton but_delete;
        private Sunny.UI.UIButton but_close;
        private Sunny.UI.UIListBox detail_order;
    }
}
