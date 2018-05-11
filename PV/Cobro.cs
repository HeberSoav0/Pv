using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV
{
    public partial class Cobro : Form
    {
        public double CantidadxPagar;
        public double efectivo = 0.0;

        public Cobro()
        {
            InitializeComponent();
        }

        private void Cobro_Load(object sender, EventArgs e)
        {
            txtEfectivo.Select();
            txtCantidadAPagar.Text = CantidadxPagar.ToString("$" + "0.00");
        }   

        private void txtEfectivo_TextChange(object sender, EventArgs e)
        {
            double efectivotemp = double.Parse(txtEfectivo.Text);
            efectivo = (CantidadxPagar - efectivotemp) * -1;
            txtCambio.Text = efectivo.ToString("0.00");
        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar.Select();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
