using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class exame : Form
    {
        public exame()
        {
            InitializeComponent();
        }

        private void iblSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja realmente sair? ", "Atenção", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                Close();
            }

        }

        private void iblLimpar_Click(object sender, EventArgs e)
        {
            {

               txtExame.Clear();
               txtMedia.Clear();

                txtExame.Focus();

            }

        }

        private void iblCalcular_Click(object sender, EventArgs e)
        {
            double exame, media, Resultado;

            exame = Convert.ToDouble(txtExame.Text);
            media = Convert.ToDouble(txtMedia.Text);

            Resultado = (exame + media) /2;

            if (Resultado >= 5) { MessageBox.Show("Aluno Aprovado!!!" + Resultado); }
            else { MessageBox.Show("Aluno Reprovado."); }
        }
    }
}
