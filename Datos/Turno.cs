using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Turno
    {
        Conexion conector = new Conexion();

        //Clase para mandar Abrir Corte
        public int IngresarTurno(int idUsuario, double Deposito, string Turno, string Fecha, string HoraEntrada)
        {
            SqlCommand comando;
            string sql = string.Format(@"Insert into Turno(idUsuario, Deposito, Turno, Fecha, Hora)
                values ({0},{1},'{2}','{3}','{4}')",
                idUsuario, Deposito, Turno, Fecha, HoraEntrada, conector.cnn);
            comando = new SqlCommand(sql, conector.cnn);
            conector.conectar();
            int retorno = comando.ExecuteNonQuery();
            conector.desconectar();
            return retorno;
        }

        //Metodo para seleccionar Nombre de Usuario
        public string BuscarNombre(int idusuario)
        {
            SqlCommand comando;
            string nombre = null;
            Conexion conector = new Conexion();
            conector.conectar();
            String sql = string.Format(@"Select Nombre From Usuarios where idUsuario ={0}", idusuario, conector.cnn);
            comando = new SqlCommand(sql, conector.cnn);
            SqlDataReader reg = null;
            reg = comando.ExecuteReader();

            while (reg.Read())
            {
                nombre = reg["Nombre"].ToString();

            }
            conector.desconectar();
            reg.Close();
            return nombre;

        }

        //Metodo para Cerrar Corte de Caja
        public double VentaTotalDeTurno(String NombreCajero, string FechaCorte)
        {
            SqlCommand comando;
            Conexion conector = new Conexion();
            double VTT = 0.0;
            string sql = string.Format("Select ventatotal=SUM(VentaTotal) from Ventas where NombreVendedor='{0}' AND FechaVenta='{1}'", NombreCajero, FechaCorte);
            comando = new SqlCommand(sql, conector.cnn);
            conector.conectar();
            SqlDataReader reg = null;
            reg = comando.ExecuteReader();

            while (reg.Read())
            {
                string venta = reg["ventatotal"].ToString();
                VTT = double.Parse(venta);
            }
            conector.desconectar();
            return VTT;
        }
    }
}
