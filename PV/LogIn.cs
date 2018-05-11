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
    public partial class Login : Form
    {
        public string usuario;
        public string password;
        public string categoria;

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.usuario = txtUsuario.Text;
            this.password = txtContrasena.Text;
            Validar val = new Validar();
            categoria = val.ValidarUsuario(usuario, password);
            if (categoria.Equals("Administrador"))
            {
                Administrador abrir = new Administrador();
                abrir.Show();
                this.Hide();
            }
            else if (categoria.Equals("Cajero"))
            {
                AbrirCorte abrir = new AbrirCorte();
                PuenteDeDatos Buscador = new PuenteDeDatos();
                int idusuario = Buscador.BuscarId(usuario);
                //MessageBox.Show("El Id del Usuario es: " + idusuario);
                abrir.idusuario = idusuario;

                abrir.Show();
                this.Hide();
            }

            if (categoria.Equals("Ninguno"))
            {
                MessageBox.Show("El Usuario es incorrecto o no existe");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
