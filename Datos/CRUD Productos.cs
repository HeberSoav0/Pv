using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class CRUD_Productos
    {
        private string nombre;
        private string cantidad;
        private string precio;
        private string descripcion;
        private string foto;
        private int codigo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Foto { get => foto; set => foto = value; }
        public int Codigo { get => codigo; set => codigo = value; }

        public CRUD_Productos()
        {

        }

        public CRUD_Productos(int code, string nom, string canti, string price, string des, string photo)
        {
            this.codigo = code;
            this.nombre = nom;
            this.cantidad = canti;
            this.precio = price;
            this.descripcion = des;
            this.foto = photo;
        }


        // Metodo para dar de Alta un Producto
        public static int AltaProductos(CRUD_Productos product)
        {
            Conexion conector = new Conexion();

            string sql;
            int retorno;

            sql = String.Format(@"Insert into Productos (Nombre, Cantidad, Precio, Descripcion, Foto) values('{0}','{1}','{2}','{3}','{4}')",
                product.nombre, product.cantidad, product.precio, product.descripcion, product.foto ,conector.cnn);

            SqlCommand comando = new SqlCommand(sql, conector.cnn);
            conector.conectar();
            retorno = comando.ExecuteNonQuery();
            conector.cnn.Close();
            return retorno;
        }

        // Metodo para dar de Baja a un Producto
        public int BajaProductos(int codigo)
        {
            SqlCommand comando;
            int retorno;
            Conexion conector = new Conexion();
            conector.conectar();

            string sql = string.Format(@"Delete from Productos Where Codigo =" + codigo);
            comando = new SqlCommand(sql, conector.cnn);
            retorno = comando.ExecuteNonQuery();
            conector.cnn.Close();
            conector.desconectar();
            return retorno;
        }

        //Metodo para hacer Modificaciones en los Productos
        public static int ModificacionProducto(CRUD_Productos Obj)
        {
            SqlCommand comando;
            int retorno;
            Conexion conector = new Conexion();
            conector.conectar();

            string sql = string.Format(@"Update Productos set Nombre = '{0}', Cantidad = '{1}', Precio = '{2}', Descripcion = '{3}', Foto = '{4}' where Codigo = {5}",
                Obj.nombre, Obj.cantidad, Obj.precio, Obj.descripcion, Obj.foto, Obj.codigo, conector.cnn);
            comando = new SqlCommand(sql, conector.cnn);
            retorno = comando.ExecuteNonQuery();
            conector.cnn.Close();
            conector.desconectar();
            return retorno;
        }

        //Metodo para buscar Foto del producto
        public string BuscarFoto(int codigo)
        {
            string foto = "";
            SqlCommand comando;
            Conexion conector = new Conexion();
            conector.conectar();
            String sql = string.Format(@"Select Foto from Productos where Codigo = {0}", codigo, conector.cnn);
            comando = new SqlCommand(sql, conector.cnn);
            SqlDataReader reg = null;

            reg = comando.ExecuteReader();

            while (reg.Read())
            {
                foto = reg["Foto"].ToString();
            }

            conector.desconectar();
            reg.Close();
            return foto;
        }

        //Metodo para pedir la Descripcion y el Precio del Producto
        public static Tuple<string, double> BuscarCamposP(int codigo)
        {
            Conexion conector = new Conexion();
            SqlCommand comando;
            string sql;
            string descripcion = null;
            double precio = 0.0;

            sql = string.Format(@"Select Descripcion, Precio from Productos where Codigo = {0}", codigo, conector.cnn);
            comando = new SqlCommand(sql, conector.cnn);
            conector.conectar();
            SqlDataReader reg = null;
            reg = comando.ExecuteReader();

            while (reg.Read())
            {
                descripcion = reg["Descripcion"].ToString();
                precio = double.Parse(reg["Precio"].ToString());
            }

            return new Tuple<string, double>(descripcion, precio);
        }

        public int AgregarVentaTemporal(int Codigo, string NombreCajero, int Cantidad, double Total, double ListIva)
        {
            Conexion conector = new Conexion();
            SqlCommand comando;
            string sql;

            int retorno = 0;

            sql = string.Format(@"Insert into PV_TablaTemporal (Codigo,NombreVendedor, Cantidad, Precio, IvaP)
            values ({0},'{1}', {2},{3},{4})", Codigo, NombreCajero, Cantidad, Total, ListIva, conector.cnn);

            comando = new SqlCommand(sql, conector.cnn);
            conector.conectar();
            retorno = comando.ExecuteNonQuery();
            conector.desconectar();

            return retorno;

        }
    }
}
