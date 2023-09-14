namespace Calculadora
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Nota1, Nota2, Nota3, Nota4, Resultado;

            Nota1 = Convert.ToDouble(txtNota1.Text);
            Nota2 = Convert.ToDouble(txtNota2.Text);
            Nota3 = Convert.ToDouble(txtNota3.Text);
            Nota4 = Convert.ToDouble(txtNota4.Text);

           Resultado = ((Nota1 + Nota2 + Nota3 + Nota4) /4);

            if (Resultado >= 5)
            {
                MessageBox.Show("Aluno Aprovado: " + Resultado);
            }
            else { MessageBox.Show("Aluno Reprovado, Por favor insira a nota do seu Exame: ");

                // Crie uma instância do Form2
                exame form2 = new exame();

                // Exiba o Form2
                form2.Show();

                // Opcionalmente, oculte o Form1
                this.Hide();
            }

            txtResultado.Text = Resultado.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtResultado.Clear();

            txtNota1.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            
            DialogResult sair = MessageBox.Show("Deseja realmente sair? ", "Atenção", MessageBoxButtons.YesNo);

            if (sair == DialogResult.Yes)
            {
                Close();
            }

        }
    }
}