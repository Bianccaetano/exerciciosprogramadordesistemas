using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculodedesconto
{
    public partial class frmCalculodesconto : Form
    {
        public frmCalculodesconto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float valorcompra = float.Parse(txtValorCompra.Text);
            float desconto = float.Parse(txtDesconto.Text);

            float valordesconto = valorcompra * desconto / 100;

            float resultado = valorcompra - valordesconto;

            lblResultado.Text = resultado.ToString();
        }
    }
}
