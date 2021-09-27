
namespace CarManager0827
{
    partial class AddCustUI
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
            this.custDay = new Sunny.UI.UIComboBox();
            this.custMonth = new Sunny.UI.UIComboBox();
            this.custYear = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.uiLine2 = new Sunny.UI.UILine();
            this.custHb6 = new Sunny.UI.UICheckBox();
            this.custHb5 = new Sunny.UI.UICheckBox();
            this.custHb4 = new Sunny.UI.UICheckBox();
            this.custHb3 = new Sunny.UI.UICheckBox();
            this.custHb2 = new Sunny.UI.UICheckBox();
            this.custHb1 = new Sunny.UI.UICheckBox();
            this.custWoman = new Sunny.UI.UIRadioButton();
            this.custMan = new Sunny.UI.UIRadioButton();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.custAddr = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.custTel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.custName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.custAddOK = new Sunny.UI.UISymbolButton();
            this.custAddClear = new Sunny.UI.UISymbolButton();
            this.custDate = new Sunny.UI.UIDatePicker();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // custDay
            // 
            this.custDay.DataSource = null;
            this.custDay.FillColor = System.Drawing.Color.White;
            this.custDay.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custDay.Location = new System.Drawing.Point(586, 416);
            this.custDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custDay.MinimumSize = new System.Drawing.Size(63, 0);
            this.custDay.Name = "custDay";
            this.custDay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custDay.Size = new System.Drawing.Size(85, 29);
            this.custDay.TabIndex = 83;
            this.custDay.Text = "일";
            this.custDay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custMonth
            // 
            this.custMonth.DataSource = null;
            this.custMonth.FillColor = System.Drawing.Color.White;
            this.custMonth.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.custMonth.Location = new System.Drawing.Point(485, 416);
            this.custMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custMonth.MinimumSize = new System.Drawing.Size(63, 0);
            this.custMonth.Name = "custMonth";
            this.custMonth.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custMonth.Size = new System.Drawing.Size(85, 29);
            this.custMonth.TabIndex = 82;
            this.custMonth.Text = "월";
            this.custMonth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custYear
            // 
            this.custYear.DataSource = null;
            this.custYear.FillColor = System.Drawing.Color.White;
            this.custYear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custYear.Location = new System.Drawing.Point(353, 416);
            this.custYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custYear.MinimumSize = new System.Drawing.Size(63, 0);
            this.custYear.Name = "custYear";
            this.custYear.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custYear.Size = new System.Drawing.Size(119, 29);
            this.custYear.TabIndex = 81;
            this.custYear.Text = "년도";
            this.custYear.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel8.Location = new System.Drawing.Point(176, 416);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel8.Symbol = 61949;
            this.uiSymbolLabel8.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel8.SymbolSize = 32;
            this.uiSymbolLabel8.TabIndex = 80;
            this.uiSymbolLabel8.Text = "생  일";
            this.uiSymbolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.Location = new System.Drawing.Point(193, 643);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(527, 2);
            this.uiLine2.TabIndex = 79;
            // 
            // custHb6
            // 
            this.custHb6.BackColor = System.Drawing.Color.Transparent;
            this.custHb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custHb6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custHb6.Location = new System.Drawing.Point(521, 581);
            this.custHb6.MinimumSize = new System.Drawing.Size(1, 1);
            this.custHb6.Name = "custHb6";
            this.custHb6.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.custHb6.Size = new System.Drawing.Size(150, 29);
            this.custHb6.TabIndex = 78;
            this.custHb6.Text = "멍때리기";
            // 
            // custHb5
            // 
            this.custHb5.BackColor = System.Drawing.Color.Transparent;
            this.custHb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custHb5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custHb5.Location = new System.Drawing.Point(353, 581);
            this.custHb5.MinimumSize = new System.Drawing.Size(1, 1);
            this.custHb5.Name = "custHb5";
            this.custHb5.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.custHb5.Size = new System.Drawing.Size(150, 29);
            this.custHb5.TabIndex = 77;
            this.custHb5.Text = "잠자기";
            // 
            // custHb4
            // 
            this.custHb4.BackColor = System.Drawing.Color.Transparent;
            this.custHb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custHb4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custHb4.Location = new System.Drawing.Point(521, 546);
            this.custHb4.MinimumSize = new System.Drawing.Size(1, 1);
            this.custHb4.Name = "custHb4";
            this.custHb4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.custHb4.Size = new System.Drawing.Size(150, 29);
            this.custHb4.TabIndex = 76;
            this.custHb4.Text = "술마시기";
            // 
            // custHb3
            // 
            this.custHb3.BackColor = System.Drawing.Color.Transparent;
            this.custHb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custHb3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custHb3.Location = new System.Drawing.Point(353, 546);
            this.custHb3.MinimumSize = new System.Drawing.Size(1, 1);
            this.custHb3.Name = "custHb3";
            this.custHb3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.custHb3.Size = new System.Drawing.Size(150, 29);
            this.custHb3.TabIndex = 75;
            this.custHb3.Text = "공부";
            // 
            // custHb2
            // 
            this.custHb2.BackColor = System.Drawing.Color.Transparent;
            this.custHb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custHb2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custHb2.Location = new System.Drawing.Point(521, 511);
            this.custHb2.MinimumSize = new System.Drawing.Size(1, 1);
            this.custHb2.Name = "custHb2";
            this.custHb2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.custHb2.Size = new System.Drawing.Size(150, 29);
            this.custHb2.TabIndex = 74;
            this.custHb2.Text = "게임";
            // 
            // custHb1
            // 
            this.custHb1.BackColor = System.Drawing.Color.Transparent;
            this.custHb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custHb1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custHb1.Location = new System.Drawing.Point(353, 511);
            this.custHb1.MinimumSize = new System.Drawing.Size(1, 1);
            this.custHb1.Name = "custHb1";
            this.custHb1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.custHb1.Size = new System.Drawing.Size(150, 29);
            this.custHb1.TabIndex = 73;
            this.custHb1.Text = "운동";
            // 
            // custWoman
            // 
            this.custWoman.BackColor = System.Drawing.Color.Transparent;
            this.custWoman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custWoman.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custWoman.Location = new System.Drawing.Point(521, 467);
            this.custWoman.MinimumSize = new System.Drawing.Size(1, 1);
            this.custWoman.Name = "custWoman";
            this.custWoman.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.custWoman.Size = new System.Drawing.Size(150, 29);
            this.custWoman.TabIndex = 72;
            this.custWoman.Text = "여";
            // 
            // custMan
            // 
            this.custMan.BackColor = System.Drawing.Color.Transparent;
            this.custMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custMan.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custMan.Location = new System.Drawing.Point(353, 467);
            this.custMan.MinimumSize = new System.Drawing.Size(1, 1);
            this.custMan.Name = "custMan";
            this.custMan.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.custMan.Size = new System.Drawing.Size(150, 29);
            this.custMan.TabIndex = 71;
            this.custMan.Text = "남";
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel6.Location = new System.Drawing.Point(176, 511);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel6.Symbol = 61692;
            this.uiSymbolLabel6.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel6.SymbolSize = 32;
            this.uiSymbolLabel6.TabIndex = 70;
            this.uiSymbolLabel6.Text = "취  미";
            this.uiSymbolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel7.Location = new System.Drawing.Point(176, 465);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel7.Symbol = 57483;
            this.uiSymbolLabel7.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel7.SymbolSize = 32;
            this.uiSymbolLabel7.TabIndex = 69;
            this.uiSymbolLabel7.Text = "성  별";
            this.uiSymbolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.Location = new System.Drawing.Point(193, 385);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(527, 2);
            this.uiLine1.TabIndex = 68;
            // 
            // custAddr
            // 
            this.custAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custAddr.FillColor = System.Drawing.Color.White;
            this.custAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddr.Location = new System.Drawing.Point(353, 251);
            this.custAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custAddr.Maximum = 2147483647D;
            this.custAddr.Minimum = -2147483648D;
            this.custAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddr.Name = "custAddr";
            this.custAddr.Size = new System.Drawing.Size(318, 35);
            this.custAddr.TabIndex = 65;
            this.custAddr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel4.Location = new System.Drawing.Point(176, 251);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel4.Symbol = 61461;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel4.SymbolSize = 38;
            this.uiSymbolLabel4.TabIndex = 64;
            this.uiSymbolLabel4.Text = "주  소";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custTel
            // 
            this.custTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custTel.FillColor = System.Drawing.Color.White;
            this.custTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custTel.Location = new System.Drawing.Point(353, 187);
            this.custTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custTel.Maximum = 2147483647D;
            this.custTel.Minimum = -2147483648D;
            this.custTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custTel.Name = "custTel";
            this.custTel.Size = new System.Drawing.Size(318, 35);
            this.custTel.TabIndex = 63;
            this.custTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(176, 187);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel3.Symbol = 62112;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel3.SymbolSize = 32;
            this.uiSymbolLabel3.TabIndex = 62;
            this.uiSymbolLabel3.Text = "전  화";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custName
            // 
            this.custName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custName.FillColor = System.Drawing.Color.White;
            this.custName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custName.Location = new System.Drawing.Point(353, 121);
            this.custName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custName.Maximum = 2147483647D;
            this.custName.Minimum = -2147483648D;
            this.custName.MinimumSize = new System.Drawing.Size(1, 1);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(318, 35);
            this.custName.TabIndex = 61;
            this.custName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(176, 121);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel2.Symbol = 62141;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel2.SymbolSize = 32;
            this.uiSymbolLabel2.TabIndex = 60;
            this.uiSymbolLabel2.Text = "고객명";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(338, 34);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(261, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 62004;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.SymbolSize = 40;
            this.uiSymbolLabel1.TabIndex = 59;
            this.uiSymbolLabel1.Text = "고객 정보 등록";
            // 
            // custAddOK
            // 
            this.custAddOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custAddOK.FillColor = System.Drawing.Color.DarkGreen;
            this.custAddOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAddOK.Location = new System.Drawing.Point(252, 672);
            this.custAddOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddOK.Name = "custAddOK";
            this.custAddOK.Size = new System.Drawing.Size(164, 72);
            this.custAddOK.Style = Sunny.UI.UIStyle.Custom;
            this.custAddOK.Symbol = 61508;
            this.custAddOK.SymbolSize = 36;
            this.custAddOK.TabIndex = 57;
            this.custAddOK.Text = "등록";
            this.custAddOK.Click += new System.EventHandler(this.custAddOK_Click);
            // 
            // custAddClear
            // 
            this.custAddClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custAddClear.FillColor = System.Drawing.Color.Tomato;
            this.custAddClear.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAddClear.Location = new System.Drawing.Point(485, 672);
            this.custAddClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddClear.Name = "custAddClear";
            this.custAddClear.Size = new System.Drawing.Size(164, 72);
            this.custAddClear.Style = Sunny.UI.UIStyle.Custom;
            this.custAddClear.Symbol = 61453;
            this.custAddClear.SymbolSize = 36;
            this.custAddClear.TabIndex = 58;
            this.custAddClear.Text = "다시 입력";
            this.custAddClear.Click += new System.EventHandler(this.custAddClear_Click);
            // 
            // custDate
            // 
            this.custDate.FillColor = System.Drawing.Color.White;
            this.custDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custDate.Location = new System.Drawing.Point(355, 310);
            this.custDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custDate.MaxLength = 10;
            this.custDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.custDate.Name = "custDate";
            this.custDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custDate.Size = new System.Drawing.Size(318, 29);
            this.custDate.SymbolDropDown = 61555;
            this.custDate.SymbolNormal = 61555;
            this.custDate.TabIndex = 112;
            this.custDate.Text = "2021-07-28";
            this.custDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.custDate.Value = new System.DateTime(2021, 7, 28, 14, 17, 36, 251);
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel5.Location = new System.Drawing.Point(176, 310);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel5.Symbol = 62068;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel5.SymbolSize = 38;
            this.uiSymbolLabel5.TabIndex = 111;
            this.uiSymbolLabel5.Text = "접수날짜";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddCustUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.custDate);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.custDay);
            this.Controls.Add(this.custMonth);
            this.Controls.Add(this.custYear);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.custHb6);
            this.Controls.Add(this.custHb5);
            this.Controls.Add(this.custHb4);
            this.Controls.Add(this.custHb3);
            this.Controls.Add(this.custHb2);
            this.Controls.Add(this.custHb1);
            this.Controls.Add(this.custWoman);
            this.Controls.Add(this.custMan);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.custAddr);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.custTel);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.custAddClear);
            this.Controls.Add(this.custAddOK);
            this.DoubleBuffered = true;
            this.Name = "AddCustUI";
            this.Size = new System.Drawing.Size(886, 768);
            this.Load += new System.EventHandler(this.AddCustUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox custDay;
        private Sunny.UI.UIComboBox custMonth;
        private Sunny.UI.UIComboBox custYear;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UICheckBox custHb6;
        private Sunny.UI.UICheckBox custHb5;
        private Sunny.UI.UICheckBox custHb4;
        private Sunny.UI.UICheckBox custHb3;
        private Sunny.UI.UICheckBox custHb2;
        private Sunny.UI.UICheckBox custHb1;
        private Sunny.UI.UIRadioButton custWoman;
        private Sunny.UI.UIRadioButton custMan;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UITextBox custAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox custTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox custName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton custAddOK;
        private Sunny.UI.UISymbolButton custAddClear;
        private Sunny.UI.UIDatePicker custDate;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
    }
}
