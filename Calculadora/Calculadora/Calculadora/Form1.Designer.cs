namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.bu2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.bSuma = new System.Windows.Forms.Button();
            this.bResta = new System.Windows.Forms.Button();
            this.bMultiplicar = new System.Windows.Forms.Button();
            this.bDividir = new System.Windows.Forms.Button();
            this.bIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResultado
            // 
            this.tbResultado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbResultado.Location = new System.Drawing.Point(12, 12);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(297, 49);
            this.tbResultado.TabIndex = 1;
            this.tbResultado.TextChanged += new System.EventHandler(this.tbResultado_TextChanged);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b1.Location = new System.Drawing.Point(12, 80);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(60, 23);
            this.b1.TabIndex = 2;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // bu2
            // 
            this.bu2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bu2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bu2.Location = new System.Drawing.Point(82, 80);
            this.bu2.Name = "bu2";
            this.bu2.Size = new System.Drawing.Size(60, 23);
            this.bu2.TabIndex = 3;
            this.bu2.Text = "2";
            this.bu2.UseVisualStyleBackColor = false;
            this.bu2.Click += new System.EventHandler(this.bu2_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b3.Location = new System.Drawing.Point(158, 80);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(60, 23);
            this.b3.TabIndex = 4;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b4.Location = new System.Drawing.Point(224, 80);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(60, 23);
            this.b4.TabIndex = 5;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b5.Location = new System.Drawing.Point(12, 119);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(60, 23);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b6.Location = new System.Drawing.Point(82, 119);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(60, 23);
            this.b6.TabIndex = 7;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b7.Location = new System.Drawing.Point(158, 119);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(60, 23);
            this.b7.TabIndex = 8;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b8.Location = new System.Drawing.Point(224, 119);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(60, 23);
            this.b8.TabIndex = 9;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b9.Location = new System.Drawing.Point(12, 161);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(60, 23);
            this.b9.TabIndex = 10;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b10
            // 
            this.b10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b10.Location = new System.Drawing.Point(82, 161);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(60, 23);
            this.b10.TabIndex = 11;
            this.b10.Text = "0";
            this.b10.UseVisualStyleBackColor = false;
            this.b10.Click += new System.EventHandler(this.b10_Click);
            // 
            // bSuma
            // 
            this.bSuma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bSuma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSuma.Location = new System.Drawing.Point(158, 161);
            this.bSuma.Name = "bSuma";
            this.bSuma.Size = new System.Drawing.Size(60, 23);
            this.bSuma.TabIndex = 12;
            this.bSuma.Text = "+";
            this.bSuma.UseVisualStyleBackColor = false;
            this.bSuma.Click += new System.EventHandler(this.bSuma_Click);
            // 
            // bResta
            // 
            this.bResta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bResta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bResta.Location = new System.Drawing.Point(224, 161);
            this.bResta.Name = "bResta";
            this.bResta.Size = new System.Drawing.Size(60, 23);
            this.bResta.TabIndex = 13;
            this.bResta.Text = "-";
            this.bResta.UseVisualStyleBackColor = false;
            this.bResta.Click += new System.EventHandler(this.bResta_Click);
            // 
            // bMultiplicar
            // 
            this.bMultiplicar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bMultiplicar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bMultiplicar.Location = new System.Drawing.Point(12, 205);
            this.bMultiplicar.Name = "bMultiplicar";
            this.bMultiplicar.Size = new System.Drawing.Size(60, 23);
            this.bMultiplicar.TabIndex = 14;
            this.bMultiplicar.Text = "X";
            this.bMultiplicar.UseVisualStyleBackColor = false;
            this.bMultiplicar.Click += new System.EventHandler(this.bMultiplicar_Click);
            // 
            // bDividir
            // 
            this.bDividir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bDividir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bDividir.Location = new System.Drawing.Point(85, 205);
            this.bDividir.Name = "bDividir";
            this.bDividir.Size = new System.Drawing.Size(57, 23);
            this.bDividir.TabIndex = 15;
            this.bDividir.Text = "/";
            this.bDividir.UseVisualStyleBackColor = false;
            this.bDividir.Click += new System.EventHandler(this.bDividir_Click);
            // 
            // bIgual
            // 
            this.bIgual.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bIgual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bIgual.Location = new System.Drawing.Point(158, 205);
            this.bIgual.Name = "bIgual";
            this.bIgual.Size = new System.Drawing.Size(60, 23);
            this.bIgual.TabIndex = 16;
            this.bIgual.Text = "=";
            this.bIgual.UseVisualStyleBackColor = false;
            this.bIgual.Click += new System.EventHandler(this.bIgual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 242);
            this.Controls.Add(this.bIgual);
            this.Controls.Add(this.bDividir);
            this.Controls.Add(this.bMultiplicar);
            this.Controls.Add(this.bResta);
            this.Controls.Add(this.bSuma);
            this.Controls.Add(this.b10);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.bu2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.tbResultado);
            this.Name = "Form1";
            this.Text = "calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button bu2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Button bSuma;
        private System.Windows.Forms.Button bResta;
        private System.Windows.Forms.Button bMultiplicar;
        private System.Windows.Forms.Button bDividir;
        private System.Windows.Forms.Button bIgual;
    }
}

