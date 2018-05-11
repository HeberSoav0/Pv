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
    public partial class AltaDeProductos : Form
    {
        OpenFileDialog BuscarFoto = new OpenFileDialog();
        ManejoDeDatos cargar = new ManejoDeDatos();
        PuenteDeDatos enviar = new PuenteDeDatos();
        string imagenDePaso;

        public AltaDeProductos()
        {
            InitializeComponent();
        }

        public void CargarProducto()
        {
            DataSet copia;
            copia = cargar.CargarDatosProducto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                this.BuscarFoto.ShowDialog();
                if (this.BuscarFoto.FileName.Equals("") == false)
                {
                    pbFoto.Load(this.BuscarFoto.FileName);
                    imagenDePaso = this.BuscarFoto.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede cargar la imagen: " + ex.ToString());
            }
        }

        private void AltaDeProductos_Load(object sender, EventArgs e)
        {
            CargarProducto();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string validar = enviar.EnviarProducto(txtNombre.Text, txtCantidad.Text, txtPrecio.Text, txtDescripcion.Text, imagenDePaso);

            if (validar.Equals("S"))
            {
                MessageBox.Show("Elementos agregados correctamente");
            }
        }
    }
}
