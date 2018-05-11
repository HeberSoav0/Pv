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
    public partial class ModificacionDeUsuarios : Form
    {
        ManejoDeDatos cargar = new ManejoDeDatos();
        PuenteDeDatos objeto = new PuenteDeDatos();
        OpenFileDialog BuscarFoto = new OpenFileDialog();
        string ImagenDePaso;

        public ModificacionDeUsuarios()
        {
            InitializeComponent();
        }

        public void cargarUsuarios()
        {
            DataSet copia;
            copia = cargar.CargarDatosUsuario();
            //Llena los datos del DataGridView con un DataSet de la Logica de Negocio
            dgvUsuarios.DataSource = copia;
            dgvUsuarios.DataMember = "Usuarios";
        }

        private void ModificacionDeUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //TextFields editables y PictureBox
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpleado.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["idUsuario"].Value.ToString();
            txtNombre.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["Nombre"].Value.ToString();
            txtApellidos.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["Apellidos"].Value.ToString();
            txtTelefono.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["Telefono"].Value.ToString();
            txtCorreo.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["Correo"].Value.ToString();
            txtTipoUsuario.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["TipoUsuario"].Value.ToString();
            txtContrasena.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["Contrasena"].Value.ToString();
            pbUsuario.Load(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["Foto"].Value.ToString());
            ImagenDePaso = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["Foto"].Value.ToString();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                this.BuscarFoto.ShowDialog();
                if (this.BuscarFoto.FileName.Equals("") == false)
                {
                    pbUsuario.Load(this.BuscarFoto.FileName);
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
            int idusuario = int.Parse(txtEmpleado.Text);
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            long telefono = long.Parse(txtTelefono.Text);
            string correo = txtCorreo.Text;
            string tipoU = txtTipoUsuario.Text;
            string contrasena = txtContrasena.Text;
            string foto = ImagenDePaso;

            if (objeto.ModificarUsuario(idusuario, nombre,apellidos, telefono, correo, tipoU, contrasena, foto))
            {
                MessageBox.Show("Usuario modificado correctamente");
                cargarUsuarios();
            }
            else
            {
                MessageBox.Show("El Usuario NO se modifico");
            }
        }
    }
}
