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
    public partial class BajaDeProductos : Form
    {
        ManejoDeDatos cargar = new ManejoDeDatos();
        PuenteDeDatos obj = new PuenteDeDatos();

        public BajaDeProductos()
        {
            InitializeComponent();
        }

        public void cargarProductos()
        {
            DataSet copia;
            copia = cargar.CargarDatosProducto();
            //Llena los datos del DataGridView con un DataSet de la Logica de Negocio
            dgvProductos.DataSource = copia;
            dgvProductos.DataMember = "Productos";

        }
        private void BajaDeProductos_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells["Codigo"].Value.ToString();
            pbProducto.Load(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells["Foto"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);

            if (obj.BajaProducto(codigo))
            {
                MessageBox.Show("Producto dado de Baja Correctamente");
                cargarProductos();
            }
            else
            {
                MessageBox.Show("El Producto no se pudo dar de baja");
            }
        }
    }
}
