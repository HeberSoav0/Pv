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
    public partial class AbrirCorte : Form
    {
        public int idusuario; //paso el Id desde el formulario login
        public string fecha;
        public string hora;

        public AbrirCorte()
        {
            InitializeComponent();
        }

        private void TimerCorte_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PuenteDeDatos objeto = new PuenteDeDatos();     //Instancia de la clase PuenteDeDatos de la capa de Logica
            double deposito = double.Parse(txtDeposito.Text);
            string turno = cbTurno.SelectedItem.ToString();
            int resultado = objeto.agregarturno(idusuario, deposito, turno, fecha, hora);
            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados correctamente");
                PuntoDeVenta venta = new PuntoDeVenta();
                venta.Show();   //venta.idusuario = this.idusuario;
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se guardaron los datos");
            }
        }

        private void AbrirCorte_Load(object sender, EventArgs e)
        {
            PuenteDeDatos objeto = new PuenteDeDatos();
            string fotovendedor = objeto.BuscarFoto(idusuario);
            pbCajero.Load(fotovendedor);
            fecha = DateTime.Now.ToString("yyyy/MM/dd");
            hora = DateTime.Now.ToString("HH:mm:ss");
            //Igual a un = MessageBox.Show("datos" + fecha + " " + hora);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Login abrir = new Login();
            abrir.Show();
            this.Hide();
        }
    }
}
