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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void AltaUsuarios_Click(object sender, EventArgs e)
        {
            AltaDeUsuarios alta = new AltaDeUsuarios();
            alta.MdiParent = this;
            alta.Show();
        }

        private void BajaUsuarios_Click(object sender, EventArgs e)
        {
            BajaDeUsuarios baja = new BajaDeUsuarios();
            baja.MdiParent = this;
            baja.Show();
        }

        private void ModificacionesUsuarios_Click(object sender, EventArgs e)
        {
            ModificacionDeUsuarios cambio = new ModificacionDeUsuarios();
            cambio.MdiParent = this;
            cambio.Show();
        }

        private void AltaProveedores_Click(object sender, EventArgs e)
        {
            AltaDeProveedores alta = new AltaDeProveedores();
            alta.MdiParent = this;
            alta.Show();
        }

        private void BajaProveedores_Click(object sender, EventArgs e)
        {
            BajaDeProveedores baja = new BajaDeProveedores();
            baja.MdiParent = this;
            baja.Show();
        }

        private void ModificacionesProeedores_Click(object sender, EventArgs e)
        {
            ModificacionDeProveedores modificar = new ModificacionDeProveedores();
            modificar.MdiParent = this;
            modificar.Show();
        }

        private void altaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AltaDeProductos alta = new AltaDeProductos();
            alta.MdiParent = this;
            alta.Show();
        }

        private void BajaProductos_Click(object sender, EventArgs e)
        {
            BajaDeProductos baja = new BajaDeProductos();
            baja.MdiParent = this;
            baja.Show();
        }

        private void ModificacionesProductos_Click(object sender, EventArgs e)
        {
            ModificacionDeProductos modificar = new ModificacionDeProductos();
            modificar.MdiParent = this;
            modificar.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
