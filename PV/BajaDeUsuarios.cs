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
    public partial class BajaDeUsuarios : Form
    {
        ManejoDeDatos carga = new ManejoDeDatos();
        PuenteDeDatos MIobjeto = new PuenteDeDatos();

        public BajaDeUsuarios()
        {
            InitializeComponent();
        }
        public void cargarUsuarios()
        {
            DataSet copia;
            copia = carga.CargarDatosUsuario();
            //Llena los datos del DataGridView con un DataSet de la Logica de Negocio
            dgvUsuarios.DataSource = copia;
            dgvUsuarios.DataMember = "Usuarios";

        }

        private void BajaDeUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpleado.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["idUsuario"].Value.ToString();
            pbUsuario.Load(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["Foto"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idusuario = int.Parse(txtEmpleado.Text);

            if (MIobjeto.BajaUsuario(idusuario))
            {
                MessageBox.Show("Usuario dado de Baja Correctamente");
                cargarUsuarios();
            }
            else
            {
                MessageBox.Show("El Usuario no se pudo dar de baja");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
