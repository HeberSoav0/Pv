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
    public partial class PuntoDeVenta : Form
    {
        PuenteDeDatos objeto = new PuenteDeDatos();
        public int idusuario;   //idUsuario traido desde el Login
        public string fecha;
        public string hora;
        float iva = 16.0F;
        double Total = 0;

        public PuntoDeVenta()
        {
            InitializeComponent();
        }

        private void PuntoDeVenta_Load(object sender, EventArgs e)
        {
            lblCajero.Text = objeto.BuscarNombre(idusuario);
            txtCantidad.Text = "1";
            txtIva.Text = "16%";
            txtCodigo.Select();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
                {
                    int idproducto = int.Parse(txtCodigo.Text);
                    string fotoproducto = objeto.BuscarFotoProducto(idproducto);
                    pbFotoProducto.Load(fotoproducto);
                    txtCantidad.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                Tuple<string, double> datos;
                int codigo = int.Parse(txtCodigo.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                // Buscar descripcion y precio en la tabla productos
                datos = PuenteDeDatos.buscainfoP(codigo);
                string nombre = datos.Item1;
                double precio = datos.Item2;

                double ivaAplicado = (precio * iva * cantidad) / 100;

                double subTotal = (precio * cantidad) + ivaAplicado;

                Total = Total + subTotal;
                txtTotal.Text = Total.ToString("0.00");

                //Mandar datos al Datatable

                DataTable dtunico = llenarlista(codigo, nombre, cantidad, precio, ivaAplicado, subTotal);

                // Llenar el Listview

                foreach (DataRow row in dtunico.Rows)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(row["Codigo"]));
                    item.SubItems.Add(Convert.ToString(row["Nombre"]));
                    item.SubItems.Add(Convert.ToString(row["Cantidad"]));
                    item.SubItems.Add(Convert.ToString(row["Precio"]));
                    item.SubItems.Add(Convert.ToString(row["Iva"]));
                    item.SubItems.Add(Convert.ToString(row["Sub-Total"]));

                    lvProductos.Items.Add(item);

                }

                // limpiar campos despues caoptura de producto
                txtCodigo.Text = "";
                pbFotoProducto.Image = null;
                txtCantidad.Text = "1";
                txtCodigo.Focus();
            }
        }

        public DataTable llenarlista(int codigo, string nombre, int cantidad, double precio, double iva, double subTotal)
        {
            //Encabezado de las columnas

            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Iva");
            dt.Columns.Add("Sub-Total");

            // los registros o renglones

            DataRow row = dt.NewRow();
            row["Codigo"] = codigo;
            row["Nombre"] = nombre;
            row["Cantidad"] = cantidad;
            row["Precio"] = precio;
            row["Iva"] = iva;
            row["Sub-Total"] = subTotal;
            dt.Rows.Add(row);


            return dt;
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                int codigo;
                int cantidad;
                string nombre;
                double precio;
                double listIva;
                double subtotal;
                int sumarArticulos = 0;
                PuenteDeDatos objeto = new PuenteDeDatos();

                Cobro abrir = new Cobro();
                abrir.CantidadxPagar = double.Parse(txtTotal.Text);
                abrir.ShowDialog();
                // Variables parsa llenar mi tabla tempopral

                foreach (ListViewItem item in lvProductos.Items)
                {
                    for (int counter = 0; counter < item.SubItems.Count; counter++)
                    {
                        if (counter == 0)
                        {
                            codigo = int.Parse(item.SubItems[counter].Text);
                            nombre = item.SubItems[counter + 1].Text;
                            cantidad = int.Parse(item.SubItems[counter + 2].Text);
                            precio = double.Parse(item.SubItems[counter + 3].Text);
                            listIva = double.Parse(item.SubItems[counter + 4].Text);
                            subtotal = double.Parse(item.SubItems[counter + 5].Text);

                            sumarArticulos = cantidad + sumarArticulos;

                            objeto.AgregaDatosTablaTemp(codigo, lblCajero.Text, cantidad, subtotal, listIva);

                            //Descontar cantidades de la tabla Productos
                        }
                    }
                }

                // Mandamos a llamar el ticket

                Ticket recibo = new Ticket();
                recibo.ShowDialog();

                // llenamos tabla ventas


                //Borrar todos los registros de la tabla temporal


                // Limpiamos todos los campos

                Total = 0.0;
                txtTotal.Text = Total.ToString("0.00");
                lvProductos.Items.Clear();


            }
            if (e.KeyCode == Keys.F2)
            {
                BuscarProducto BP = new BuscarProducto();
                BP.ShowDialog();
                txtCodigo.Text = BP.codigo2;
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                int codigo;
                int cantidad;
                string nombre;
                double precio;
                double listIva;
                double subtotal;
                int sumararticulos = 0;
                PuenteDeDatos objeto = new PuenteDeDatos();

                Cobro abrir = new Cobro();
                abrir.CantidadxPagar = double.Parse(txtTotal.Text);
                abrir.ShowDialog();
                // Variables parsa llenar mi tabla tempopral

                foreach (ListViewItem item in lvProductos.Items)
                {
                    for (int counter = 0; counter < item.SubItems.Count; counter++)
                    {
                        if (counter == 0)
                        {
                            codigo = int.Parse(item.SubItems[counter].Text);
                            nombre = item.SubItems[counter + 1].Text;
                            cantidad = int.Parse(item.SubItems[counter + 2].Text);
                            precio = double.Parse(item.SubItems[counter + 3].Text);
                            listIva = double.Parse(item.SubItems[counter + 4].Text);
                            subtotal = double.Parse(item.SubItems[counter + 5].Text);

                            sumararticulos = cantidad + sumararticulos;

                            objeto.AgregaDatosTablaTemp(codigo, lblCajero.Text, cantidad, subtotal, listIva);

                            //Descontar cantidades de la tabla Productos
                        }
                    }
                }

                // Mandamos a llamar el ticket

                Ticket recibo = new Ticket();
                recibo.ShowDialog();

                // llenamos tabla ventas


                //Borrar todos los registros de la tabla temporal


                // Limpiamos todos los campos

                Total = 0.0;
                txtTotal.Text = Total.ToString("0.00");
                lvProductos.Items.Clear();


            }
            if (e.KeyCode == Keys.F2)
            {
                BuscarProducto BP = new BuscarProducto();
                BP.Show();
                txtCodigo.Text = BP.codigo2;

            }
            if (e.KeyCode == Keys.F7)
            {
                CorteDeCaja CC = new CorteDeCaja();
                CC.ShowDialog();
                this.Close();
            }
        }
    }
}
