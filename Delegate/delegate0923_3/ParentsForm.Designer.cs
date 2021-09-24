
namespace delegate0923_3
{
    partial class ParentsForm
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
            this.output_text = new System.Windows.Forms.TextBox();
            this.open_child = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output_text
            // 
            this.output_text.Location = new System.Drawing.Point(95, 74);
            this.output_text.Name = "output_text";
            this.output_text.Size = new System.Drawing.Size(219, 21);
            this.output_text.TabIndex = 0;
            // 
            // open_child
            // 
            this.open_child.Location = new System.Drawing.Point(145, 158);
            this.open_child.Name = "open_child";
            this.open_child.Size = new System.Drawing.Size(120, 35);
            this.open_child.TabIndex = 1;
            this.open_child.Text = "자식 폼 열기";
            this.open_child.UseVisualStyleBackColor = true;
            this.open_child.Click += new System.EventHandler(this.open_child_Click);
            // 
            // ParentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 267);
            this.Controls.Add(this.open_child);
            this.Controls.Add(this.output_text);
            this.Name = "ParentsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output_text;
        private System.Windows.Forms.Button open_child;
    }
}

