namespace Mini_Calculator
{
    partial class Calculator
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txnDigit = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPerc = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnSqr = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum00 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txnDigit
            // 
            this.txnDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txnDigit.Location = new System.Drawing.Point(12, 12);
            this.txnDigit.MaxLength = 10;
            this.txnDigit.Name = "txnDigit";
            this.txnDigit.Size = new System.Drawing.Size(274, 32);
            this.txnDigit.TabIndex = 0;
            this.txnDigit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(12, 60);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "→";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDiv.Location = new System.Drawing.Point(236, 60);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(50, 40);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnPerc
            // 
            this.btnPerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPerc.Location = new System.Drawing.Point(12, 113);
            this.btnPerc.Name = "btnPerc";
            this.btnPerc.Size = new System.Drawing.Size(50, 40);
            this.btnPerc.TabIndex = 3;
            this.btnPerc.Text = "%";
            this.btnPerc.UseVisualStyleBackColor = true;
            this.btnPerc.Click += new System.EventHandler(this.btnPerc_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNum7.Location = new System.Drawing.Point(68, 113);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(50, 40);
            this.btnNum7.TabIndex = 4;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMult.Location = new System.Drawing.Point(236, 113);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(50, 40);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNum8.Location = new System.Drawing.Point(124, 113);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(50, 40);
            this.btnNum8.TabIndex = 6;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNum5.Location = new System.Drawing.Point(124, 172);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(50, 40);
            this.btnNum5.TabIndex = 10;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMinus.Location = new System.Drawing.Point(236, 172);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(50, 40);
            this.btnMinus.TabIndex = 9;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNum4.Location = new System.Drawing.Point(68, 172);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(50, 40);
            this.btnNum4.TabIndex = 8;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnSqr
            // 
            this.btnSqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSqr.Location = new System.Drawing.Point(12, 172);
            this.btnSqr.Name = "btnSqr";
            this.btnSqr.Size = new System.Drawing.Size(50, 40);
            this.btnSqr.TabIndex = 7;
            this.btnSqr.Text = "√";
            this.btnSqr.UseVisualStyleBackColor = true;
            this.btnSqr.Click += new System.EventHandler(this.btnSqr_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNum2.Location = new System.Drawing.Point(126, 231);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(50, 40);
            this.btnNum2.TabIndex = 14;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPlus.Location = new System.Drawing.Point(236, 231);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 104);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNum1.Location = new System.Drawing.Point(68, 231);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(50, 40);
            this.btnNum1.TabIndex = 12;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(12, 231);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 40);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNum0.Location = new System.Drawing.Point(126, 295);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(50, 40);
            this.btnNum0.TabIndex = 18;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum00
            // 
            this.btnNum00.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNum00.Location = new System.Drawing.Point(68, 295);
            this.btnNum00.Name = "btnNum00";
            this.btnNum00.Size = new System.Drawing.Size(50, 40);
            this.btnNum00.TabIndex = 16;
            this.btnNum00.Text = "00";
            this.btnNum00.UseVisualStyleBackColor = true;
            this.btnNum00.Click += new System.EventHandler(this.btnNum00_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDot.Location = new System.Drawing.Point(12, 295);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(50, 40);
            this.btnDot.TabIndex = 15;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEnter.Location = new System.Drawing.Point(182, 295);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(50, 40);
            this.btnEnter.TabIndex = 22;
            this.btnEnter.Text = "=";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNum3.Location = new System.Drawing.Point(182, 231);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(50, 40);
            this.btnNum3.TabIndex = 21;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNum6.Location = new System.Drawing.Point(180, 172);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(50, 40);
            this.btnNum6.TabIndex = 20;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNum9.Location = new System.Drawing.Point(180, 113);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(50, 40);
            this.btnNum9.TabIndex = 19;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 353);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum00);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnSqr);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnPerc);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txnDigit);
            this.Name = "Calculator";
            this.Text = "Mini-Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txnDigit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPerc;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnSqr;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNum00;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum9;
    }
}

