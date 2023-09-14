namespace Calculadora
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
            this.Nota1 = new System.Windows.Forms.Label();
            this.Nota2 = new System.Windows.Forms.Label();
            this.Nota3 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.Nota4 = new System.Windows.Forms.Label();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nota1
            // 
            this.Nota1.AutoSize = true;
            this.Nota1.Location = new System.Drawing.Point(69, 91);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(45, 15);
            this.Nota1.TabIndex = 0;
            this.Nota1.Text = "Nota 1:";
            this.Nota1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nota2
            // 
            this.Nota2.AutoSize = true;
            this.Nota2.Location = new System.Drawing.Point(69, 142);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(45, 15);
            this.Nota2.TabIndex = 0;
            this.Nota2.Text = "Nota 2:";
            // 
            // Nota3
            // 
            this.Nota3.AutoSize = true;
            this.Nota3.Location = new System.Drawing.Point(68, 192);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(45, 15);
            this.Nota3.TabIndex = 0;
            this.Nota3.Text = "Nota 3:";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(52, 290);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(62, 15);
            this.Resultado.TabIndex = 0;
            this.Resultado.Text = "Resultado:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(68, 354);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(74, 32);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(148, 354);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(74, 32);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(228, 354);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 32);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(129, 83);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(172, 23);
            this.txtNota1.TabIndex = 2;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(130, 134);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(172, 23);
            this.txtNota2.TabIndex = 2;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(130, 184);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(172, 23);
            this.txtNota3.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(130, 282);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(172, 23);
            this.txtResultado.TabIndex = 2;
            // 
            // Nota4
            // 
            this.Nota4.AutoSize = true;
            this.Nota4.Location = new System.Drawing.Point(69, 237);
            this.Nota4.Name = "Nota4";
            this.Nota4.Size = new System.Drawing.Size(45, 15);
            this.Nota4.TabIndex = 0;
            this.Nota4.Text = "Nota 4:";
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(130, 229);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(172, 23);
            this.txtNota4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Nota4);
            this.Controls.Add(this.Nota3);
            this.Controls.Add(this.Nota2);
            this.Controls.Add(this.Nota1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Nota1;
        private Label Nota2;
        private Label Nota3;
        private Label Resultado;
        private Button btnCalcular;
        private Button btnLimpar;
        private Button btnSair;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtResultado;
        private Label Nota4;
        private TextBox txtNota4;
    }
}