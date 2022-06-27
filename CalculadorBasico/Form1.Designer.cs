namespace CalculadorBasico
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
            this.resultsBOX = new System.Windows.Forms.TextBox();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.DOT = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN7 = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultsBOX
            // 
            this.resultsBOX.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resultsBOX.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsBOX.Location = new System.Drawing.Point(12, 12);
            this.resultsBOX.Name = "resultsBOX";
            this.resultsBOX.ReadOnly = true;
            this.resultsBOX.Size = new System.Drawing.Size(329, 45);
            this.resultsBOX.TabIndex = 37;
            this.resultsBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultsBOX.TextChanged += new System.EventHandler(this.resultsBOX_TextChanged);
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnigual.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnigual.Location = new System.Drawing.Point(263, 237);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(78, 100);
            this.btnigual.TabIndex = 36;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRetroceder.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRetroceder.Location = new System.Drawing.Point(263, 184);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(78, 47);
            this.btnRetroceder.TabIndex = 35;
            this.btnRetroceder.Text = "←";
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(263, 133);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 47);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button16_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDivision.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivision.Location = new System.Drawing.Point(263, 79);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(78, 47);
            this.btnDivision.TabIndex = 33;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // DOT
            // 
            this.DOT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DOT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOT.Location = new System.Drawing.Point(179, 290);
            this.DOT.Name = "DOT";
            this.DOT.Size = new System.Drawing.Size(78, 47);
            this.DOT.TabIndex = 32;
            this.DOT.Text = ".";
            this.DOT.UseVisualStyleBackColor = false;
            this.DOT.Click += new System.EventHandler(this.DOT_Click);
            // 
            // btnN0
            // 
            this.btnN0.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnN0.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnN0.Location = new System.Drawing.Point(12, 290);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(161, 47);
            this.btnN0.TabIndex = 31;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = false;
            this.btnN0.Click += new System.EventHandler(this.btnN0_Click);
            // 
            // btnN3
            // 
            this.btnN3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnN3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnN3.Location = new System.Drawing.Point(179, 237);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(78, 47);
            this.btnN3.TabIndex = 30;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = false;
            this.btnN3.Click += new System.EventHandler(this.btnN3_Click);
            // 
            // btnN6
            // 
            this.btnN6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnN6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnN6.Location = new System.Drawing.Point(179, 184);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(78, 47);
            this.btnN6.TabIndex = 29;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = false;
            this.btnN6.Click += new System.EventHandler(this.btnN6_Click);
            // 
            // btnN9
            // 
            this.btnN9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnN9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnN9.Location = new System.Drawing.Point(179, 133);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(78, 47);
            this.btnN9.TabIndex = 28;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = false;
            this.btnN9.Click += new System.EventHandler(this.btnN9_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSumar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSumar.Location = new System.Drawing.Point(179, 79);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(78, 47);
            this.btnSumar.TabIndex = 27;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnN2
            // 
            this.btnN2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnN2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnN2.Location = new System.Drawing.Point(95, 237);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(78, 47);
            this.btnN2.TabIndex = 26;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = false;
            this.btnN2.Click += new System.EventHandler(this.btnN2_Click);
            // 
            // btnN5
            // 
            this.btnN5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnN5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnN5.Location = new System.Drawing.Point(95, 184);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(78, 47);
            this.btnN5.TabIndex = 25;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = false;
            this.btnN5.Click += new System.EventHandler(this.btnN5_Click);
            // 
            // btnN8
            // 
            this.btnN8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnN8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnN8.Location = new System.Drawing.Point(95, 133);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(78, 47);
            this.btnN8.TabIndex = 24;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = false;
            this.btnN8.Click += new System.EventHandler(this.btnN8_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRestar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestar.Location = new System.Drawing.Point(95, 79);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(78, 47);
            this.btnRestar.TabIndex = 23;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnN1
            // 
            this.btnN1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnN1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnN1.Location = new System.Drawing.Point(12, 237);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(78, 47);
            this.btnN1.TabIndex = 22;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = false;
            this.btnN1.Click += new System.EventHandler(this.btnN1_Click);
            // 
            // btnN4
            // 
            this.btnN4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnN4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnN4.Location = new System.Drawing.Point(12, 184);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(78, 47);
            this.btnN4.TabIndex = 21;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = false;
            this.btnN4.Click += new System.EventHandler(this.btnN4_Click);
            // 
            // btnN7
            // 
            this.btnN7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnN7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnN7.Location = new System.Drawing.Point(12, 133);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(78, 47);
            this.btnN7.TabIndex = 20;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = false;
            this.btnN7.Click += new System.EventHandler(this.btnN7_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMultiplicar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.Location = new System.Drawing.Point(12, 79);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(78, 47);
            this.btnMultiplicar.TabIndex = 19;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 388);
            this.Controls.Add(this.resultsBOX);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.DOT);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.btnMultiplicar);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox resultsBOX;
        private Button btnigual;
        private Button btnRetroceder;
        private Button btnClear;
        private Button btnDivision;
        private Button DOT;
        private Button btnN0;
        private Button btnN3;
        private Button btnN6;
        private Button btnN9;
        private Button btnSumar;
        private Button btnN2;
        private Button btnN5;
        private Button btnN8;
        private Button btnRestar;
        private Button btnN1;
        private Button btnN4;
        private Button btnN7;
        private Button btnMultiplicar;
    }
}