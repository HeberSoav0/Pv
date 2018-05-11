using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace PV
{
    public partial class BuscarProducto : Form
    {
        ManejoDeDatos carga = new ManejoDeDatos();
        DataTable copia;
        public string codigo2;

        public BuscarProducto()
        {
            InitializeComponent();
        }

        public void cargarproductos()
        {

            copia = ManejoDeDatos.DatosP();
            //Llena los datos del DataGridView con un DataSet de la Logica de Negocio
            dgvBuscarProducto.DataSource = copia;
            dgvBuscarProducto.DataMember = "Productos";
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            //cargarproductos();
            txtProducto.Select();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(copia);
            DV.RowFilter = String.Format("Nombre LIKE '%{0}%'", txtProducto.Text);
            dgvBuscarProducto.DataSource = DV;
        }

        private void dgvBuscarProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string codigo = dgvBuscarProducto.Rows[dgvBuscarProducto.CurrentRow.Index - 1].Cells["Codigo"].Value.ToString();
                codigo2 = codigo;
                this.Dispose();
            }
        }
    }
}
