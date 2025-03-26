using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrizbidimensional
{
    public partial class frmMatrizBidimensional : Form
    {
        int[,] matriz =
        {
            {1, 5,-2},
            {8, 3, 0},
            {4,-1, 2}
        };

        int i;
        int j;
        public frmMatrizBidimensional()
        {
            InitializeComponent();
        }

        private void frmMatrizBidimensional_Load(object sender, EventArgs e)
        {
            for (i = 0; i <=2; i++)
            {
                for (j=0; j <= 2; j++)
                {
                    txtMatrizBidimensional.Text += matriz[i, j].ToString() + " ";

                }
                txtMatrizBidimensional.Text += Environment.NewLine;
            }
        }

        private void btnExibirValor_Click(object sender, EventArgs e)
        {
            int maior = matriz[0, 0];

            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    if( matriz[i,j] > maior)
                    {
                       maior = matriz[i,j];
                        
                    }
                    
                }
               
            }
            MessageBox.Show("O maior valor da matriz é: " + maior);
        }
    }
}
