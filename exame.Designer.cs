namespace Calculadora
{
    partial class exame
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
            this.iblExame = new System.Windows.Forms.Label();
            this.txtExame = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.iblCalcular = new System.Windows.Forms.Button();
            this.iblSair = new System.Windows.Forms.Button();
            this.iblLimpar = new System.Windows.Forms.Button();
            this.iblResultado = new System.Windows.Forms.Label();
            this.txtresul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iblExame
            // 
            this.iblExame.AutoSize = true;
            this.iblExame.Location = new System.Drawing.Point(34, 58);
            this.iblExame.Name = "iblExame";
            this.iblExame.Size = new System.Drawing.Size(45, 15);
            this.iblExame.TabIndex = 0;
            this.iblExame.Text = "Exame:";
            // 
            // txtExame
            // 
            this.txtExame.Location = new System.Drawing.Point(92, 52);
            this.txtExame.Name = "txtExame";
            this.txtExame.Size = new System.Drawing.Size(149, 23);
            this.txtExame.TabIndex = 1;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(31, 105);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(43, 15);
            this.Resultado.TabIndex = 0;
            this.Resultado.Text = "Media:";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(92, 99);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(149, 23);
            this.txtMedia.TabIndex = 1;
            // 
            // iblCalcular
            // 
            this.iblCalcular.Location = new System.Drawing.Point(34, 194);
            this.iblCalcular.Name = "iblCalcular";
            this.iblCalcular.Size = new System.Drawing.Size(75, 23);
            this.iblCalcular.TabIndex = 2;
            this.iblCalcular.Text = "Calcular";
            this.iblCalcular.UseVisualStyleBackColor = true;
            this.iblCalcular.Click += new System.EventHandler(this.iblCalcular_Click);
            // 
            // iblSair
            // 
            this.iblSair.Location = new System.Drawing.Point(124, 194);
            this.iblSair.Name = "iblSair";
            this.iblSair.Size = new System.Drawing.Size(75, 23);
            this.iblSair.TabIndex = 2;
            this.iblSair.Text = "Sair";
            this.iblSair.UseVisualStyleBackColor = true;
            this.iblSair.Click += new System.EventHandler(this.iblSair_Click);
            // 
            // iblLimpar
            // 
            this.iblLimpar.Location = new System.Drawing.Point(221, 194);
            this.iblLimpar.Name = "iblLimpar";
            this.iblLimpar.Size = new System.Drawing.Size(75, 23);
            this.iblLimpar.TabIndex = 2;
            this.iblLimpar.Text = "Limpar";
            this.iblLimpar.UseVisualStyleBackColor = true;
            this.iblLimpar.Click += new System.EventHandler(this.iblLimpar_Click);
            // 
            // iblResultado
            // 
            this.iblResultado.AutoSize = true;
            this.iblResultado.Location = new System.Drawing.Point(31, 146);
            this.iblResultado.Name = "iblResultado";
            this.iblResultado.Size = new System.Drawing.Size(62, 15);
            this.iblResultado.TabIndex = 0;
            this.iblResultado.Text = "Resultado:";
            // 
            // txtresul
            // 
            this.txtresul.Location = new System.Drawing.Point(92, 138);
            this.txtresul.Name = "txtresul";
            this.txtresul.ReadOnly = true;
            this.txtresul.Size = new System.Drawing.Size(149, 23);
            this.txtresul.TabIndex = 1;
            // 
            // exame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 241);
            this.Controls.Add(this.iblLimpar);
            this.Controls.Add(this.iblSair);
            this.Controls.Add(this.iblCalcular);
            this.Controls.Add(this.txtresul);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtExame);
            this.Controls.Add(this.iblResultado);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.iblExame);
            this.Name = "exame";
            this.Text = "exame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label iblExame;
        private TextBox txtExame;
        private Label Resultado;
        private TextBox txtMedia;
        private Button iblCalcular;
        private Button iblSair;
        private Button iblLimpar;
        private Label iblResultado;
        private TextBox txtresul;
    }
}