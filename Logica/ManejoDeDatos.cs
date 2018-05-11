using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Data.SqlClient;


namespace Logica
{
    public class ManejoDeDatos
    {
        //Abrir Conexion
        Conexion conecta = new Conexion();

        //Llenar DataSet con datos del Usuario
        public DataSet CargarDatosUsuario()
        {
            conecta.conectar();
            SqlDataAdapter daUsuarios = new SqlDataAdapter("Select *From Usuarios", conecta.cnn);
            DataSet dsUsuarios = new DataSet();
            daUsuarios.Fill(dsUsuarios, "Usuarios");
            conecta.cnn.Close();
            return dsUsuarios;

        }

        //Capturar Nombre del Usuario y enviarlo al DataSet
        public DataSet carganombreusuario(string nombre)
        {
            conecta.conectar();
            string sql = string.Format(@"Select *From Usuarios where Nombre = '{0}'", nombre);
            SqlDataAdapter daUsuarios = new SqlDataAdapter(sql, conecta.cnn);
            DataSet dsUsuarios = new DataSet();
            daUsuarios.Fill(dsUsuarios, "Usuarios");
            conecta.cnn.Close();
            return dsUsuarios;
        }

        //Seleccionar todos los datos del Usuario y enviar a la Tabla
        public static DataTable Datos()
        {
            Conexion conector = new Conexion();
            DataTable dt = new DataTable();
            conector.conectar();
            SqlDataAdapter adap = new SqlDataAdapter("Select *From Usuarios", conector.cnn);
            adap.Fill(dt);
            return dt;
        }

        public DataSet CargarDatosProducto()
        {
            conecta.conectar();
            SqlDataAdapter daProducto = new SqlDataAdapter("Select *From Productos", conecta.cnn);
            DataSet dsProductos = new DataSet();
            daProducto.Fill(dsProductos, "Productos");
            conecta.cnn.Close();
            return dsProductos;

        }

        //Cargar los datos de la tabla Productos y enviarlo a la Tabla
        public static DataTable DatosP()
        {
            Conexion conector = new Conexion();
            DataTable dt = new DataTable();
            conector.conectar();
            SqlDataAdapter adaptador = new SqlDataAdapter("Select *From Productos", conector.cnn);
            adaptador.Fill(dt);
            return dt;
        }
    }
}
