
namespace CarManager0827
{
    partial class SalesUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.custListView = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insuDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jupsuDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custGridView = new Sunny.UI.UIDataGridView();
            this.hbNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custHobby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.searchCar = new Sunny.UI.UITextBox();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.searchCust = new Sunny.UI.UITextBox();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.searchManager = new Sunny.UI.UITextBox();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.searchJupsu = new Sunny.UI.UITextBox();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.searchUnion = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.custGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // custListView
            // 
            this.custListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.carName,
            this.carPrice,
            this.insuDate,
            this.custName,
            this.custTel,
            this.jupsuDate,
            this.manager});
            this.custListView.Font = new System.Drawing.Font("굴림체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custListView.FullRowSelect = true;
            this.custListView.HideSelection = false;
            this.custListView.Location = new System.Drawing.Point(3, 57);
            this.custListView.Name = "custListView";
            this.custListView.Size = new System.Drawing.Size(664, 170);
            this.custListView.TabIndex = 4;
            this.custListView.UseCompatibleStateImageBehavior = false;
            this.custListView.View = System.Windows.Forms.View.Details;
            this.custListView.SelectedIndexChanged += new System.EventHandler(this.custListView_SelectedIndexChanged);
            // 
            // number
            // 
            this.number.Text = "번호";
            this.number.Width = 30;
            // 
            // carName
            // 
            this.carName.Text = "차종";
            // 
            // carPrice
            // 
            this.carPrice.Text = "가격";
            this.carPrice.Width = 55;
            // 
            // insuDate
            // 
            this.insuDate.Text = "인수날짜";
            this.insuDate.Width = 90;
            // 
            // custName
            // 
            this.custName.Text = "고객명";
            this.custName.Width = 100;
            // 
            // custTel
            // 
            this.custTel.Text = "연락처";
            this.custTel.Width = 100;
            // 
            // jupsuDate
            // 
            this.jupsuDate.Text = "접수날짜";
            this.jupsuDate.Width = 84;
            // 
            // manager
            // 
            this.manager.Text = "담당자";
            this.manager.Width = 98;
            // 
            // custGridView
            // 
            this.custGridView.AllowUserToAddRows = false;
            this.custGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.custGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.custGridView.BackgroundColor = System.Drawing.Color.White;
            this.custGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.custGridView.ColumnHeadersHeight = 32;
            this.custGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.custGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hbNum,
            this.custHobby});
            this.custGridView.EnableHeadersVisualStyles = false;
            this.custGridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.custGridView.Location = new System.Drawing.Point(673, 57);
            this.custGridView.Name = "custGridView";
            this.custGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.custGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.custGridView.RowTemplate.Height = 23;
            this.custGridView.SelectedIndex = -1;
            this.custGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custGridView.ShowGridLine = true;
            this.custGridView.Size = new System.Drawing.Size(197, 170);
            this.custGridView.TabIndex = 5;
            // 
            // hbNum
            // 
            this.hbNum.HeaderText = "번 호";
            this.hbNum.Name = "hbNum";
            this.hbNum.ReadOnly = true;
            this.hbNum.Width = 60;
            // 
            // custHobby
            // 
            this.custHobby.HeaderText = "취 미";
            this.custHobby.Name = "custHobby";
            this.custHobby.ReadOnly = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 387);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(867, 72);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(3, 16);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(174, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61508;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.SymbolSize = 40;
            this.uiSymbolLabel1.TabIndex = 60;
            this.uiSymbolLabel1.Text = "접수 현황";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(3, 346);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(174, 35);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 62139;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.SymbolSize = 40;
            this.uiSymbolLabel2.TabIndex = 61;
            this.uiSymbolLabel2.Text = "고객 상세 정보";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(3, 555);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(174, 35);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 61881;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel3.SymbolSize = 40;
            this.uiSymbolLabel3.TabIndex = 63;
            this.uiSymbolLabel3.Text = "차량 상세 정보";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 596);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(867, 72);
            this.listView2.TabIndex = 62;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox1.Items.AddRange(new object[] {
            "차종",
            "고객명"});
            this.uiComboBox1.Location = new System.Drawing.Point(168, 20);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox1.TabIndex = 64;
            this.uiComboBox1.Text = "선택하세요";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(326, 20);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox1.TabIndex = 65;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(483, 20);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(118, 29);
            this.uiSymbolButton1.Symbol = 61442;
            this.uiSymbolButton1.TabIndex = 66;
            this.uiSymbolButton1.Text = "검 색";
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel4.Location = new System.Drawing.Point(673, 14);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(129, 35);
            this.uiSymbolLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel4.Symbol = 61958;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel4.SymbolSize = 40;
            this.uiSymbolLabel4.TabIndex = 67;
            this.uiSymbolLabel4.Text = "고객 취미";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchCar
            // 
            this.searchCar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchCar.FillColor = System.Drawing.Color.White;
            this.searchCar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchCar.Location = new System.Drawing.Point(132, 247);
            this.searchCar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchCar.Maximum = 2147483647D;
            this.searchCar.Minimum = -2147483648D;
            this.searchCar.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchCar.Name = "searchCar";
            this.searchCar.Size = new System.Drawing.Size(169, 35);
            this.searchCar.TabIndex = 69;
            this.searchCar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel5.Location = new System.Drawing.Point(3, 247);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(122, 35);
            this.uiSymbolLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel5.Symbol = 61456;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel5.SymbolSize = 40;
            this.uiSymbolLabel5.TabIndex = 68;
            this.uiSymbolLabel5.Text = "차량이름";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchCust
            // 
            this.searchCust.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchCust.FillColor = System.Drawing.Color.White;
            this.searchCust.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchCust.Location = new System.Drawing.Point(462, 247);
            this.searchCust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchCust.Maximum = 2147483647D;
            this.searchCust.Minimum = -2147483648D;
            this.searchCust.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchCust.Name = "searchCust";
            this.searchCust.Size = new System.Drawing.Size(169, 35);
            this.searchCust.TabIndex = 71;
            this.searchCust.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel6.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel6.Location = new System.Drawing.Point(349, 247);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(106, 35);
            this.uiSymbolLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel6.Symbol = 61456;
            this.uiSymbolLabel6.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel6.SymbolSize = 40;
            this.uiSymbolLabel6.TabIndex = 70;
            this.uiSymbolLabel6.Text = "고객명";
            this.uiSymbolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchManager
            // 
            this.searchManager.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchManager.FillColor = System.Drawing.Color.White;
            this.searchManager.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchManager.Location = new System.Drawing.Point(462, 288);
            this.searchManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchManager.Maximum = 2147483647D;
            this.searchManager.Minimum = -2147483648D;
            this.searchManager.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchManager.Name = "searchManager";
            this.searchManager.Size = new System.Drawing.Size(169, 35);
            this.searchManager.TabIndex = 75;
            this.searchManager.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel7.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel7.Location = new System.Drawing.Point(349, 288);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(106, 35);
            this.uiSymbolLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel7.Symbol = 61456;
            this.uiSymbolLabel7.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel7.SymbolSize = 40;
            this.uiSymbolLabel7.TabIndex = 74;
            this.uiSymbolLabel7.Text = "담당자";
            this.uiSymbolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchJupsu
            // 
            this.searchJupsu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchJupsu.FillColor = System.Drawing.Color.White;
            this.searchJupsu.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchJupsu.Location = new System.Drawing.Point(132, 288);
            this.searchJupsu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchJupsu.Maximum = 2147483647D;
            this.searchJupsu.Minimum = -2147483648D;
            this.searchJupsu.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchJupsu.Name = "searchJupsu";
            this.searchJupsu.Size = new System.Drawing.Size(169, 35);
            this.searchJupsu.TabIndex = 73;
            this.searchJupsu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel8.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel8.Location = new System.Drawing.Point(3, 288);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(122, 35);
            this.uiSymbolLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel8.Symbol = 61456;
            this.uiSymbolLabel8.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel8.SymbolSize = 40;
            this.uiSymbolLabel8.TabIndex = 72;
            this.uiSymbolLabel8.Text = "접수날짜";
            this.uiSymbolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchUnion
            // 
            this.searchUnion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchUnion.FillColor = System.Drawing.Color.Teal;
            this.searchUnion.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUnion.Location = new System.Drawing.Point(671, 247);
            this.searchUnion.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchUnion.Name = "searchUnion";
            this.searchUnion.Size = new System.Drawing.Size(199, 76);
            this.searchUnion.Style = Sunny.UI.UIStyle.Custom;
            this.searchUnion.Symbol = 61454;
            this.searchUnion.SymbolSize = 30;
            this.searchUnion.TabIndex = 76;
            this.searchUnion.Text = "통합 검색";
            this.searchUnion.Click += new System.EventHandler(this.searchUnion_Click);
            // 
            // SalesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.searchUnion);
            this.Controls.Add(this.searchManager);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.searchJupsu);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.searchCust);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.searchCar);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.custListView);
            this.Controls.Add(this.custGridView);
            this.DoubleBuffered = true;
            this.Name = "SalesUI";
            this.Size = new System.Drawing.Size(886, 683);
            this.Load += new System.EventHandler(this.SalesUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView custListView;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader carName;
        private System.Windows.Forms.ColumnHeader carPrice;
        private System.Windows.Forms.ColumnHeader insuDate;
        private System.Windows.Forms.ColumnHeader custName;
        private System.Windows.Forms.ColumnHeader custTel;
        private System.Windows.Forms.ColumnHeader jupsuDate;
        private Sunny.UI.UIDataGridView custGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn hbNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn custHobby;
        private System.Windows.Forms.ColumnHeader manager;
        private System.Windows.Forms.ListView listView1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private System.Windows.Forms.ListView listView2;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox searchCar;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UITextBox searchCust;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UITextBox searchManager;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UITextBox searchJupsu;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UISymbolButton searchUnion;
    }
}
