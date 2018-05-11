using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        public string cadenadeconexion;
        protected string sql;
        public SqlConnection cnn;
        protected SqlCommand comandossql;

        public Conexion()
        {
            this.cadenadeconexion = (@"Data Source=DESKTOP-DCUTEHN\SQLEXPRESS;Initial Catalog=PV;Integrated Security=True");
            this.cnn = new SqlConnection(cadenadeconexion);
        }

        // Abrir la Conexion con la BD
        public void conectar()
        {
            cnn.Open();
        }

        // Cerrar la Conexion con la BD
        public void desconectar()
        {
            cnn.Close();
        }

        // Validar el Tipo de Usuario que esta ingresando
        public int Validar(string nombre, string contrasena)
        {
            int resultado = 0;
            this.sql = string.Format(@"Select TipoUsuario From Usuarios Where Nombre ='{0}' AND Contrasena ='{1}'", nombre, contrasena);
            this.comandossql = new SqlCommand(this.sql, this.cnn);
            conectar();
            SqlDataReader reg = null;
            reg = this.comandossql.ExecuteReader();

            while (reg.Read())
            {
                string tipo = reg["TipoUsuario"].ToString();
                if (tipo == "Administrador")
                {
                    resultado = 1;
                }
                else if(tipo == "Cajero")
                {
                    resultado = 2;
                }
                else
                {
                    resultado = 3;  //NADA
                }
            }
            desconectar();
            reg.Close();
            return resultado;
        }
    }
}
