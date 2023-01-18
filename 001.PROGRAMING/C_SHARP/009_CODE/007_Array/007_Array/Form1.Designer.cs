namespace _007_Array
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgDay = new System.Windows.Forms.DataGridView();
            this.colDay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDay3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDay4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDay5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDay6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDay7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblArrayCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "매장 방문 수";
            // 
            // dgDay
            // 
            this.dgDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDay1,
            this.ColDay2,
            this.ColDay3,
            this.ColDay4,
            this.ColDay5,
            this.ColDay6,
            this.ColDay7});
            this.dgDay.Location = new System.Drawing.Point(15, 37);
            this.dgDay.Name = "dgDay";
            this.dgDay.RowHeadersWidth = 51;
            this.dgDay.RowTemplate.Height = 27;
            this.dgDay.Size = new System.Drawing.Size(928, 150);
            this.dgDay.TabIndex = 1;
            // 
            // colDay1
            // 
            this.colDay1.HeaderText = "월";
            this.colDay1.MinimumWidth = 6;
            this.colDay1.Name = "colDay1";
            this.colDay1.Width = 125;
            // 
            // ColDay2
            // 
            this.ColDay2.HeaderText = "화";
            this.ColDay2.MinimumWidth = 6;
            this.ColDay2.Name = "ColDay2";
            this.ColDay2.Width = 125;
            // 
            // ColDay3
            // 
            this.ColDay3.HeaderText = "수";
            this.ColDay3.MinimumWidth = 6;
            this.ColDay3.Name = "ColDay3";
            this.ColDay3.Width = 125;
            // 
            // ColDay4
            // 
            this.ColDay4.HeaderText = "목";
            this.ColDay4.MinimumWidth = 6;
            this.ColDay4.Name = "ColDay4";
            this.ColDay4.Width = 125;
            // 
            // ColDay5
            // 
            this.ColDay5.HeaderText = "금";
            this.ColDay5.MinimumWidth = 6;
            this.ColDay5.Name = "ColDay5";
            this.ColDay5.Width = 125;
            // 
            // ColDay6
            // 
            this.ColDay6.HeaderText = "토";
            this.ColDay6.MinimumWidth = 6;
            this.ColDay6.Name = "ColDay6";
            this.ColDay6.Width = 125;
            // 
            // ColDay7
            // 
            this.ColDay7.HeaderText = "일";
            this.ColDay7.MinimumWidth = 6;
            this.ColDay7.Name = "ColDay7";
            this.ColDay7.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "일주일간";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "이주일간";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblArrayCount
            // 
            this.lblArrayCount.AutoSize = true;
            this.lblArrayCount.Location = new System.Drawing.Point(224, 217);
            this.lblArrayCount.Name = "lblArrayCount";
            this.lblArrayCount.Size = new System.Drawing.Size(110, 15);
            this.lblArrayCount.TabIndex = 5;
            this.lblArrayCount.Text = "전체 자료수 : 0";
            this.lblArrayCount.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 283);
            this.Controls.Add(this.lblArrayCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgDay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblArrayCount;
    }
}

