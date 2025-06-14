using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion_de_dolar_a_pesos_mexicanos
{
    public partial class conversi: Form
    {
        public conversi()
        {
            InitializeComponent();
            lblError.Text= "";
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            double pesos, dolares;
            if (double.TryParse(txtDolares.Text,out dolares))
            {
                if (dolares<=0)
                {
                    lblError.Text = "Esto no es posible ingrese un dato numerico";
                    txtPesos.Text=string.Empty;
                }
                else 
                {
                    pesos = dolares * 18;
                    txtPesos.Text = pesos.ToString("N2");
                    lblError.Text=string.Empty;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPesos.Text=string.Empty;
            txtDolares.Text=string.Empty;
            lblError.Text=string.Empty ;
        }
    }
}
