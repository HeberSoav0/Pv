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
    public partial class AltaDeUsuarios : Form
    {
        OpenFileDialog BuscarFoto = new OpenFileDialog();
        ManejoDeDatos cargar = new ManejoDeDatos();
        PuenteDeDatos envio = new PuenteDeDatos();
        string imagenDePaso = "";

        public AltaDeUsuarios()
        {
            InitializeComponent();
        }

        public void CargarUsuarios()
        {
            DataSet copia;
            copia = cargar.CargarDatosUsuario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                this.BuscarFoto.ShowDialog();
                if (this.BuscarFoto.FileName.Equals("") == false)
                {
                    pbFotoUsuario.Load(this.BuscarFoto.FileName);
                    imagenDePaso = this.BuscarFoto.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede cargar la imagen: " + ex.ToString());
            }
        }

        private void AltaDeUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string validar = envio.EnviarUsuario(txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtEmail.Text, cbTipoUsuario.SelectedItem.ToString(), txtContrasena.Text, imagenDePaso);

            if (validar.Equals("S"))
            {
                MessageBox.Show("Elementos agregados correctamente");
            }
        }
    }
}
