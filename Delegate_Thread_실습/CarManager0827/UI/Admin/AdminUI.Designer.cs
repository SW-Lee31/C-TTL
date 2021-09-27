
namespace CarManager0811.UI
{
    partial class AdminUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.custHobby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.hbNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jupsuDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insuDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custListView = new System.Windows.Forms.ListView();
            this.custGridView = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.custGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel4.Location = new System.Drawing.Point(680, 26);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(129, 35);
            this.uiSymbolLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel4.Symbol = 61958;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel4.SymbolSize = 40;
            this.uiSymbolLabel4.TabIndex = 78;
            this.uiSymbolLabel4.Text = "고객 취미";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(333, 32);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox1.TabIndex = 76;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox1.Items.AddRange(new object[] {
            "차종",
            "고객명"});
            this.uiComboBox1.Location = new System.Drawing.Point(175, 32);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox1.TabIndex = 75;
            this.uiComboBox1.Text = "선택하세요";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(10, 463);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(174, 35);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 61881;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel3.SymbolSize = 40;
            this.uiSymbolLabel3.TabIndex = 74;
            this.uiSymbolLabel3.Text = "차량 상세 정보";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(10, 504);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(867, 152);
            this.listView2.TabIndex = 73;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(10, 254);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(174, 35);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 62139;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.SymbolSize = 40;
            this.uiSymbolLabel2.TabIndex = 72;
            this.uiSymbolLabel2.Text = "고객 상세 정보";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(10, 28);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(174, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61508;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel1.SymbolSize = 40;
            this.uiSymbolLabel1.TabIndex = 71;
            this.uiSymbolLabel1.Text = "관리자 모드";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 295);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(867, 152);
            this.listView1.TabIndex = 70;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // custHobby
            // 
            this.custHobby.HeaderText = "취 미";
            this.custHobby.Name = "custHobby";
            this.custHobby.ReadOnly = true;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(490, 32);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(118, 29);
            this.uiSymbolButton1.Symbol = 61442;
            this.uiSymbolButton1.TabIndex = 77;
            this.uiSymbolButton1.Text = "검 색";
            // 
            // hbNum
            // 
            this.hbNum.HeaderText = "번 호";
            this.hbNum.Name = "hbNum";
            this.hbNum.ReadOnly = true;
            this.hbNum.Width = 60;
            // 
            // manager
            // 
            this.manager.Text = "담당자";
            this.manager.Width = 98;
            // 
            // jupsuDate
            // 
            this.jupsuDate.Text = "접수날짜";
            this.jupsuDate.Width = 84;
            // 
            // custTel
            // 
            this.custTel.Text = "연락처";
            this.custTel.Width = 100;
            // 
            // custName
            // 
            this.custName.Text = "고객명";
            this.custName.Width = 100;
            // 
            // insuDate
            // 
            this.insuDate.Text = "인수날짜";
            this.insuDate.Width = 90;
            // 
            // carPrice
            // 
            this.carPrice.Text = "가격";
            this.carPrice.Width = 55;
            // 
            // carName
            // 
            this.carName.Text = "차종";
            // 
            // number
            // 
            this.number.Text = "번호";
            this.number.Width = 30;
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
            this.custListView.Location = new System.Drawing.Point(10, 69);
            this.custListView.Name = "custListView";
            this.custListView.Size = new System.Drawing.Size(664, 170);
            this.custListView.TabIndex = 68;
            this.custListView.UseCompatibleStateImageBehavior = false;
            this.custListView.View = System.Windows.Forms.View.Details;
            // 
            // custGridView
            // 
            this.custGridView.AllowUserToAddRows = false;
            this.custGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.custGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.custGridView.BackgroundColor = System.Drawing.Color.White;
            this.custGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.custGridView.ColumnHeadersHeight = 32;
            this.custGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.custGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hbNum,
            this.custHobby});
            this.custGridView.EnableHeadersVisualStyles = false;
            this.custGridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.custGridView.Location = new System.Drawing.Point(680, 69);
            this.custGridView.Name = "custGridView";
            this.custGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.custGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.custGridView.RowTemplate.Height = 23;
            this.custGridView.SelectedIndex = -1;
            this.custGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custGridView.ShowGridLine = true;
            this.custGridView.Size = new System.Drawing.Size(197, 170);
            this.custGridView.TabIndex = 69;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.custListView);
            this.Controls.Add(this.custGridView);
            this.Name = "AdminUI";
            this.Size = new System.Drawing.Size(886, 683);
            ((System.ComponentModel.ISupportInitialize)(this.custGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private System.Windows.Forms.ListView listView2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn custHobby;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hbNum;
        private System.Windows.Forms.ColumnHeader manager;
        private System.Windows.Forms.ColumnHeader jupsuDate;
        private System.Windows.Forms.ColumnHeader custTel;
        private System.Windows.Forms.ColumnHeader custName;
        private System.Windows.Forms.ColumnHeader insuDate;
        private System.Windows.Forms.ColumnHeader carPrice;
        private System.Windows.Forms.ColumnHeader carName;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ListView custListView;
        private Sunny.UI.UIDataGridView custGridView;
    }
}
