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
    public partial class ModificacionDeProductos : Form
    {
        ManejoDeDatos cargar = new ManejoDeDatos();
        PuenteDeDatos objeto = new PuenteDeDatos();
        OpenFileDialog BuscarFoto = new OpenFileDialog();
        string ImagenDePaso;

        public ModificacionDeProductos()
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

        private void ModificacionDeProductos_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells["Codigo"].Value.ToString();
            txtNombre.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells["Nombre"].Value.ToString();
            txtCantidad.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells["Cantidad"].Value.ToString();
            txtPrecio.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells["Precio"].Value.ToString();
            txtDescripcion.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells["Descripcion"].Value.ToString();
            pbProductos.Load(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells["Foto"].Value.ToString());
            ImagenDePaso = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells["Foto"].Value.ToString();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                this.BuscarFoto.ShowDialog();
                if (this.BuscarFoto.FileName.Equals("") == false)
                {
                    pbProductos.Load(this.BuscarFoto.FileName);
                    ImagenDePaso = this.BuscarFoto.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede cargar la imagen: " + ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            string cantidad = txtCantidad.Text;
            string Precio = txtPrecio.Text;
            string Desc = txtDescripcion.Text;
            string foto = ImagenDePaso;

            if (objeto.ModificarProductos(codigo, nombre, cantidad, Precio, Desc, foto))
            {
                MessageBox.Show("Producto modificado correctamente");
                cargarProductos();
            }
            else
            {
                MessageBox.Show("El Producto NO se modifico");
            }
        }
    }
}
