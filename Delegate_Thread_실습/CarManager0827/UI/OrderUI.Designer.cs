
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
            this.radio_double = new Sunny.UI.UIRadioButton();
            this.ddc_int_val = new Sunny.UI.UIIntegerUpDown();
            this.radio_actuater = new Sunny.UI.UIRadioButton();
            this.radio_external = new Sunny.UI.UIRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_cmc = new Sunny.UI.UIRadioButton();
            this.radio_damper = new Sunny.UI.UIRadioButton();
            this.hp_int_val = new Sunny.UI.UIIntegerUpDown();
            this.radio_csc = new Sunny.UI.UIRadioButton();
            this.radio_crc = new Sunny.UI.UIRadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chck_cdmf = new Sunny.UI.UICheckBox();
            this.chck_pdmf = new Sunny.UI.UICheckBox();
            this.chck_dmdap = new Sunny.UI.UICheckBox();
            this.dmf_int_val = new Sunny.UI.UIIntegerUpDown();
            this.but_order = new Sunny.UI.UIButton();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.but_delete = new Sunny.UI.UIButton();
            this.but_close = new Sunny.UI.UIButton();
            this.order_listview = new MaterialSkin.Controls.MaterialListView();
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
            this.groupBox1.Controls.Add(this.radio_external);
            this.groupBox1.Controls.Add(this.radio_actuater);
            this.groupBox1.Controls.Add(this.ddc_int_val);
            this.groupBox1.Controls.Add(this.radio_double);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(3, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 85);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dry Double Clutch (DDC)";
            // 
            // radio_double
            // 
            this.radio_double.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_double.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.radio_double.Location = new System.Drawing.Point(6, 34);
            this.radio_double.MinimumSize = new System.Drawing.Size(1, 1);
            this.radio_double.Name = "radio_double";
            this.radio_double.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.radio_double.Size = new System.Drawing.Size(212, 29);
            this.radio_double.TabIndex = 0;
            this.radio_double.Text = "더블 클러치 (100,000원)";
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
            // radio_actuater
            // 
            this.radio_actuater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_actuater.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.radio_actuater.Location = new System.Drawing.Point(219, 34);
            this.radio_actuater.MinimumSize = new System.Drawing.Size(1, 1);
            this.radio_actuater.Name = "radio_actuater";
            this.radio_actuater.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.radio_actuater.Size = new System.Drawing.Size(266, 29);
            this.radio_actuater.TabIndex = 2;
            this.radio_actuater.Text = "클러치 액츄에이터 (110,000원)";
            // 
            // radio_external
            // 
            this.radio_external.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_external.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.radio_external.Location = new System.Drawing.Point(486, 34);
            this.radio_external.MinimumSize = new System.Drawing.Size(1, 1);
            this.radio_external.Name = "radio_external";
            this.radio_external.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.radio_external.Size = new System.Drawing.Size(249, 29);
            this.radio_external.TabIndex = 3;
            this.radio_external.Text = "External Damper (120,000원)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_crc);
            this.groupBox2.Controls.Add(this.radio_cmc);
            this.groupBox2.Controls.Add(this.radio_damper);
            this.groupBox2.Controls.Add(this.hp_int_val);
            this.groupBox2.Controls.Add(this.radio_csc);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(3, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 85);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HyDrautic Products";
            // 
            // radio_cmc
            // 
            this.radio_cmc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_cmc.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.radio_cmc.Location = new System.Drawing.Point(393, 34);
            this.radio_cmc.MinimumSize = new System.Drawing.Size(1, 1);
            this.radio_cmc.Name = "radio_cmc";
            this.radio_cmc.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.radio_cmc.Size = new System.Drawing.Size(157, 29);
            this.radio_cmc.TabIndex = 3;
            this.radio_cmc.Text = "CMC (80,000원)";
            // 
            // radio_damper
            // 
            this.radio_damper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_damper.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.radio_damper.Location = new System.Drawing.Point(185, 34);
            this.radio_damper.MinimumSize = new System.Drawing.Size(1, 1);
            this.radio_damper.Name = "radio_damper";
            this.radio_damper.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.radio_damper.Size = new System.Drawing.Size(189, 29);
            this.radio_damper.TabIndex = 2;
            this.radio_damper.Text = "Damper (70,000원)";
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
            // radio_csc
            // 
            this.radio_csc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_csc.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.radio_csc.Location = new System.Drawing.Point(6, 34);
            this.radio_csc.MinimumSize = new System.Drawing.Size(1, 1);
            this.radio_csc.Name = "radio_csc";
            this.radio_csc.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.radio_csc.Size = new System.Drawing.Size(160, 29);
            this.radio_csc.TabIndex = 0;
            this.radio_csc.Text = "CSC (50,000원)";
            // 
            // radio_crc
            // 
            this.radio_crc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_crc.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.radio_crc.Location = new System.Drawing.Point(569, 34);
            this.radio_crc.MinimumSize = new System.Drawing.Size(1, 1);
            this.radio_crc.Name = "radio_crc";
            this.radio_crc.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.radio_crc.Size = new System.Drawing.Size(157, 29);
            this.radio_crc.TabIndex = 4;
            this.radio_crc.Text = "CRC (90,000원)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dmf_int_val);
            this.groupBox3.Controls.Add(this.chck_dmdap);
            this.groupBox3.Controls.Add(this.chck_pdmf);
            this.groupBox3.Controls.Add(this.chck_cdmf);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(3, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 132);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DMF 시스템";
            // 
            // chck_cdmf
            // 
            this.chck_cdmf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chck_cdmf.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chck_cdmf.Location = new System.Drawing.Point(6, 25);
            this.chck_cdmf.MinimumSize = new System.Drawing.Size(1, 1);
            this.chck_cdmf.Name = "chck_cdmf";
            this.chck_cdmf.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chck_cdmf.Size = new System.Drawing.Size(197, 29);
            this.chck_cdmf.TabIndex = 5;
            this.chck_cdmf.Text = "C - DMF (50,000원)";
            // 
            // chck_pdmf
            // 
            this.chck_pdmf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chck_pdmf.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chck_pdmf.Location = new System.Drawing.Point(6, 60);
            this.chck_pdmf.MinimumSize = new System.Drawing.Size(1, 1);
            this.chck_pdmf.Name = "chck_pdmf";
            this.chck_pdmf.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chck_pdmf.Size = new System.Drawing.Size(252, 29);
            this.chck_pdmf.TabIndex = 6;
            this.chck_pdmf.Text = "Pendulum DMF (60,000원)";
            // 
            // chck_dmdap
            // 
            this.chck_dmdap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chck_dmdap.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chck_dmdap.Location = new System.Drawing.Point(6, 95);
            this.chck_dmdap.MinimumSize = new System.Drawing.Size(1, 1);
            this.chck_dmdap.Name = "chck_dmdap";
            this.chck_dmdap.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chck_dmdap.Size = new System.Drawing.Size(279, 29);
            this.chck_dmdap.TabIndex = 7;
            this.chck_dmdap.Text = "Dual Mass Damper (70,000원)";
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
            // but_order
            // 
            this.but_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_order.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_order.Location = new System.Drawing.Point(736, 527);
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
            this.uiSymbolLabel2.Location = new System.Drawing.Point(-58, 483);
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
            this.but_delete.Location = new System.Drawing.Point(736, 592);
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
            this.but_close.Location = new System.Drawing.Point(736, 657);
            this.but_close.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(140, 50);
            this.but_close.TabIndex = 68;
            this.but_close.Text = "닫기";
            // 
            // order_listview
            // 
            this.order_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.order_listview.Depth = 0;
            this.order_listview.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.order_listview.FullRowSelect = true;
            this.order_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.order_listview.HideSelection = false;
            this.order_listview.Location = new System.Drawing.Point(3, 527);
            this.order_listview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.order_listview.MouseState = MaterialSkin.MouseState.OUT;
            this.order_listview.Name = "order_listview";
            this.order_listview.OwnerDraw = true;
            this.order_listview.Size = new System.Drawing.Size(716, 180);
            this.order_listview.TabIndex = 69;
            this.order_listview.UseCompatibleStateImageBehavior = false;
            this.order_listview.View = System.Windows.Forms.View.Details;
            // 
            // OrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.order_listview);
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
        private Sunny.UI.UIRadioButton radio_external;
        private Sunny.UI.UIRadioButton radio_actuater;
        private Sunny.UI.UIIntegerUpDown ddc_int_val;
        private Sunny.UI.UIRadioButton radio_double;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UIRadioButton radio_cmc;
        private Sunny.UI.UIRadioButton radio_damper;
        private Sunny.UI.UIIntegerUpDown hp_int_val;
        private Sunny.UI.UIRadioButton radio_csc;
        private Sunny.UI.UIRadioButton radio_crc;
        private System.Windows.Forms.GroupBox groupBox3;
        private Sunny.UI.UIIntegerUpDown dmf_int_val;
        private Sunny.UI.UICheckBox chck_dmdap;
        private Sunny.UI.UICheckBox chck_pdmf;
        private Sunny.UI.UICheckBox chck_cdmf;
        private Sunny.UI.UIButton but_order;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIButton but_delete;
        private Sunny.UI.UIButton but_close;
        private MaterialSkin.Controls.MaterialListView order_listview;
    }
}
