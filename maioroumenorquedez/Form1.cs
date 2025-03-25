using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maioroumenorquedez
{
    public partial class frmMaiorOuMenorQueDez : Form
    {
        public frmMaiorOuMenorQueDez()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string letra = txtEntradaDeNumero.Text;
            bool sucesso = int.TryParse(letra, out int numero);

            if (sucesso)
            {
                if (numero > 10)
                {
                    MessageBox.Show("O número digitado é maior que 10!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (numero < 10)
                {
                    MessageBox.Show("O número digitado é menor que 10!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O número digitado é 10!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Digite um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
