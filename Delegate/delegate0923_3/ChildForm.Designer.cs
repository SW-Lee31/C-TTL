
namespace delegate0923_3
{
    partial class ChildForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.set_data = new System.Windows.Forms.Button();
            this.input_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // set_data
            // 
            this.set_data.Location = new System.Drawing.Point(158, 168);
            this.set_data.Name = "set_data";
            this.set_data.Size = new System.Drawing.Size(120, 35);
            this.set_data.TabIndex = 5;
            this.set_data.Text = "데이터 전송";
            this.set_data.UseVisualStyleBackColor = true;
            this.set_data.Click += new System.EventHandler(this.set_data_Click);
            // 
            // input_text
            // 
            this.input_text.Location = new System.Drawing.Point(102, 64);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(219, 21);
            this.input_text.TabIndex = 3;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 267);
            this.Controls.Add(this.set_data);
            this.Controls.Add(this.input_text);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button set_data;
        private System.Windows.Forms.TextBox input_text;
    }
}