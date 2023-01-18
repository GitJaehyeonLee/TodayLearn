namespace _004_Method
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
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.tboxNumber1 = new System.Windows.Forms.MaskedTextBox();
            this.tboxNumber2 = new System.Windows.Forms.MaskedTextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnGop = new System.Windows.Forms.Button();
            this.btnNanugi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxResult
            // 
            this.tboxResult.Enabled = false;
            this.tboxResult.Location = new System.Drawing.Point(12, 12);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(206, 25);
            this.tboxResult.TabIndex = 0;
            this.tboxResult.Text = "0";
            this.tboxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxNumber1
            // 
            this.tboxNumber1.Location = new System.Drawing.Point(12, 43);
            this.tboxNumber1.Name = "tboxNumber1";
            this.tboxNumber1.Size = new System.Drawing.Size(100, 25);
            this.tboxNumber1.TabIndex = 1;
            this.tboxNumber1.Text = "0";
            this.tboxNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxNumber2
            // 
            this.tboxNumber2.Location = new System.Drawing.Point(118, 43);
            this.tboxNumber2.Name = "tboxNumber2";
            this.tboxNumber2.Size = new System.Drawing.Size(100, 25);
            this.tboxNumber2.TabIndex = 2;
            this.tboxNumber2.Text = "0";
            this.tboxNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 83);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(48, 47);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(66, 83);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(48, 47);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnGop
            // 
            this.btnGop.Location = new System.Drawing.Point(120, 83);
            this.btnGop.Name = "btnGop";
            this.btnGop.Size = new System.Drawing.Size(48, 47);
            this.btnGop.TabIndex = 5;
            this.btnGop.Text = "*";
            this.btnGop.UseVisualStyleBackColor = true;
            this.btnGop.Click += new System.EventHandler(this.btnGop_Click);
            // 
            // btnNanugi
            // 
            this.btnNanugi.Location = new System.Drawing.Point(174, 83);
            this.btnNanugi.Name = "btnNanugi";
            this.btnNanugi.Size = new System.Drawing.Size(48, 47);
            this.btnNanugi.TabIndex = 6;
            this.btnNanugi.Text = "/";
            this.btnNanugi.UseVisualStyleBackColor = true;
            this.btnNanugi.Click += new System.EventHandler(this.btnNanugi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 154);
            this.Controls.Add(this.btnNanugi);
            this.Controls.Add(this.btnGop);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.tboxNumber2);
            this.Controls.Add(this.tboxNumber1);
            this.Controls.Add(this.tboxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.MaskedTextBox tboxNumber1;
        private System.Windows.Forms.MaskedTextBox tboxNumber2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnGop;
        private System.Windows.Forms.Button btnNanugi;
    }
}

