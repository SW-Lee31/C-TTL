
namespace CarManager0811.UI
{
    partial class AddCarUI
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
            this.uiLine2 = new Sunny.UI.UILine();
            this.carInDate = new Sunny.UI.UIDatePicker();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.carPrice = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.carColor = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.carName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.carAddClear = new Sunny.UI.UISymbolButton();
            this.carAddOK = new Sunny.UI.UISymbolButton();
            this.carManager = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.Location = new System.Drawing.Point(170, 536);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(527, 2);
            this.uiLine2.TabIndex = 106;
            // 
            // carInDate
            // 
            this.carInDate.FillColor = System.Drawing.Color.White;
            this.carInDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carInDate.Location = new System.Drawing.Point(347, 364);
            this.carInDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carInDate.MaxLength = 10;
            this.carInDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.carInDate.Name = "carInDate";
            this.carInDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.carInDate.Size = new System.Drawing.Size(318, 29);
            this.carInDate.SymbolDropDown = 61555;
            this.carInDate.SymbolNormal = 61555;
            this.carInDate.TabIndex = 94;
            this.carInDate.Text = "2021-07-28";
            this.carInDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.carInDate.Value = new System.DateTime(2021, 7, 28, 14, 17, 36, 251);
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel5.Location = new System.Drawing.Point(170, 364);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel5.Symbol = 62068;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel5.SymbolSize = 38;
            this.uiSymbolLabel5.TabIndex = 93;
            this.uiSymbolLabel5.Text = "인수날짜";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carPrice
            // 
            this.carPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carPrice.FillColor = System.Drawing.Color.White;
            this.carPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carPrice.Location = new System.Drawing.Point(347, 296);
            this.carPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carPrice.Maximum = 2147483647D;
            this.carPrice.Minimum = -2147483648D;
            this.carPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.carPrice.Name = "carPrice";
            this.carPrice.Size = new System.Drawing.Size(318, 35);
            this.carPrice.TabIndex = 92;
            this.carPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel4.Location = new System.Drawing.Point(170, 296);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel4.Symbol = 61781;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel4.SymbolSize = 38;
            this.uiSymbolLabel4.TabIndex = 91;
            this.uiSymbolLabel4.Text = "가  격";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carColor
            // 
            this.carColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carColor.FillColor = System.Drawing.Color.White;
            this.carColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carColor.Location = new System.Drawing.Point(347, 232);
            this.carColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carColor.Maximum = 2147483647D;
            this.carColor.Minimum = -2147483648D;
            this.carColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.carColor.Name = "carColor";
            this.carColor.Size = new System.Drawing.Size(318, 35);
            this.carColor.TabIndex = 90;
            this.carColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(170, 232);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel3.Symbol = 61502;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel3.SymbolSize = 32;
            this.uiSymbolLabel3.TabIndex = 89;
            this.uiSymbolLabel3.Text = "색  상";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carName
            // 
            this.carName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carName.FillColor = System.Drawing.Color.White;
            this.carName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carName.Location = new System.Drawing.Point(347, 166);
            this.carName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carName.Maximum = 2147483647D;
            this.carName.Minimum = -2147483648D;
            this.carName.MinimumSize = new System.Drawing.Size(1, 1);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(318, 35);
            this.carName.TabIndex = 88;
            this.carName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(170, 166);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel2.Symbol = 61881;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel2.SymbolSize = 32;
            this.uiSymbolLabel2.TabIndex = 87;
            this.uiSymbolLabel2.Text = "차량명";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(309, 61);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(261, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61881;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.SymbolSize = 40;
            this.uiSymbolLabel1.TabIndex = 86;
            this.uiSymbolLabel1.Text = "차량 정보 등록";
            // 
            // carAddClear
            // 
            this.carAddClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carAddClear.FillColor = System.Drawing.Color.Tomato;
            this.carAddClear.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carAddClear.Location = new System.Drawing.Point(481, 619);
            this.carAddClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.carAddClear.Name = "carAddClear";
            this.carAddClear.Size = new System.Drawing.Size(164, 72);
            this.carAddClear.Style = Sunny.UI.UIStyle.Custom;
            this.carAddClear.Symbol = 61453;
            this.carAddClear.SymbolSize = 36;
            this.carAddClear.TabIndex = 85;
            this.carAddClear.Text = "다시 입력";
            // 
            // carAddOK
            // 
            this.carAddOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carAddOK.FillColor = System.Drawing.Color.DarkGreen;
            this.carAddOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carAddOK.Location = new System.Drawing.Point(248, 619);
            this.carAddOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.carAddOK.Name = "carAddOK";
            this.carAddOK.Size = new System.Drawing.Size(164, 72);
            this.carAddOK.Style = Sunny.UI.UIStyle.Custom;
            this.carAddOK.Symbol = 61508;
            this.carAddOK.SymbolSize = 36;
            this.carAddOK.TabIndex = 84;
            this.carAddOK.Text = "등록";
            this.carAddOK.Click += new System.EventHandler(this.carAddOK_Click);
            // 
            // carManager
            // 
            this.carManager.DataSource = null;
            this.carManager.FillColor = System.Drawing.Color.White;
            this.carManager.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carManager.Items.AddRange(new object[] {
            "김대리",
            "박부장",
            "이과장",
            "한주임",
            "홍사원"});
            this.carManager.Location = new System.Drawing.Point(347, 432);
            this.carManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carManager.MinimumSize = new System.Drawing.Size(63, 0);
            this.carManager.Name = "carManager";
            this.carManager.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.carManager.Size = new System.Drawing.Size(318, 29);
            this.carManager.TabIndex = 108;
            this.carManager.Text = "담당자를 선택하세요";
            this.carManager.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel8.Location = new System.Drawing.Point(170, 432);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel8.Symbol = 62142;
            this.uiSymbolLabel8.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel8.SymbolSize = 32;
            this.uiSymbolLabel8.TabIndex = 107;
            this.uiSymbolLabel8.Text = "담 당 자";
            this.uiSymbolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddCarUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.carManager);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.carInDate);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.carPrice);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.carColor);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.carName);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.carAddClear);
            this.Controls.Add(this.carAddOK);
            this.Name = "AddCarUI";
            this.Size = new System.Drawing.Size(886, 768);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UIDatePicker carInDate;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UITextBox carPrice;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox carColor;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox carName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton carAddClear;
        private Sunny.UI.UISymbolButton carAddOK;
        private Sunny.UI.UIComboBox carManager;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
    }
}
