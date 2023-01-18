namespace _003_DataType
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblException = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(12, 12);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(662, 27);
            this.tboxNumber.TabIndex = 1;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(680, 10);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(115, 29);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "알아서 변환";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Short";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Int";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Double";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Exception";
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(105, 219);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(15, 20);
            this.lblException.TabIndex = 7;
            this.lblException.Text = "-";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Location = new System.Drawing.Point(105, 67);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(17, 20);
            this.lblShort.TabIndex = 8;
            this.lblShort.Text = "0";
            this.lblShort.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(105, 114);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(17, 20);
            this.lblInt.TabIndex = 9;
            this.lblInt.Text = "0";
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(105, 160);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(17, 20);
            this.lblDouble.TabIndex = 10;
            this.lblDouble.Text = "0";
            // 
            // btnShort
            // 
            this.btnShort.Location = new System.Drawing.Point(273, 63);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(125, 29);
            this.btnShort.TabIndex = 11;
            this.btnShort.Text = "short 변환";
            this.btnShort.UseVisualStyleBackColor = true;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(273, 114);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(125, 29);
            this.btnInt.TabIndex = 12;
            this.btnInt.Text = "Int 변환";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(273, 160);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(125, 29);
            this.btnDouble.TabIndex = 13;
            this.btnDouble.Text = "Double 변환";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.lblDouble);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.tboxNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tboxNumber;
        private Button btnAuto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblException;
        private Label lblShort;
        private Label lblInt;
        private Label lblDouble;
        private Button btnShort;
        private Button btnInt;
        private Button btnDouble;
    }
}