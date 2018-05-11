using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class CRUD_Usuarios
    {
        private int idUsuario;
        private string Nombres;
        private string Apellidos;
        private long Telefono;
        private string Correo;
        private string TipoUsuario;
        private string Contrasena;
        private string Foto;
        
        // Encapsulamiento de Variables
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombres1 { get => Nombres; set => Nombres = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public long Telefono1 { get => Telefono; set => Telefono = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string TipoUsuario1 { get => TipoUsuario; set => TipoUsuario = value; }
        public string Contrasena1 { get => Contrasena; set => Contrasena = value; }
        public string Foto1 { get => Foto; set => Foto = value; }

        //Constructor Vacio
        public CRUD_Usuarios()
        {

        }

        //Constructor con Parametros
        public CRUD_Usuarios(string nomb, string apell, long tel, string email, string tipo, string contra, string photo)
        {
            this.Nombres = nomb;
            this.Apellidos = apell;
            this.Telefono = tel;
            this.Correo = email;
            this.TipoUsuario = tipo;
            this.Contrasena = contra;
            this.Foto = photo;
        }

        // Metodo para dar de Alta a un Usuario
        public static int AltaUsuarios(CRUD_Usuarios pUsuario)
        {
            Conexion conector = new Conexion();

            string sql;
            int retorno;

            sql = String.Format(@"Insert into Usuarios (Nombre, Apellidos, Telefono , Correo, TipoUsuario, Contrasena, Foto)values('{0}','{1}','{2}','{3}','{4}', '{5}', '{6}')",
                pUsuario.Nombres, pUsuario.Apellidos, pUsuario.Telefono, pUsuario.Correo, pUsuario.TipoUsuario, pUsuario.Contrasena, pUsuario.Foto ,conector.cnn);

            SqlCommand comando = new SqlCommand(sql, conector.cnn);
            conector.conectar();
            retorno = comando.ExecuteNonQuery();
            conector.cnn.Close();
            return retorno;
        }

         // Metodo para dar de Baja a un Usuario
        public int BajaUsuarios(int idusuario)
        {
            SqlCommand comando;
            int retorno;
            Conexion conector = new Conexion();
            conector.conectar();

            string sql = string.Format(@"Delete from Usuarios Where idUsuario =" + idusuario);
            comando = new SqlCommand(sql, conector.cnn);
            retorno = comando.ExecuteNonQuery();
            conector.cnn.Close();
            conector.desconectar();
            return retorno;
        }

        //Metodo para hacer Modificaciones en el Usuario
        public static int ModificacionUsuarios(CRUD_Usuarios Obj)
        {
            SqlCommand comando;
            int retorno;
            Conexion conector = new Conexion();
            conector.conectar();

            string sql = string.Format(@"update Usuarios set Nombre = '{0}', Apellidos = '{1}', Telefono = '{2}', Correo = '{3}', TipoUsuario = '{4}' , Contrasena = '{5}' , Foto = '{6}' where idUsuario ={7}",
                Obj.Nombres, Obj.Apellidos, Obj.Telefono, Obj.Correo, Obj.TipoUsuario, Obj.Contrasena, Obj.Foto, Obj.idUsuario, conector.cnn);
            comando = new SqlCommand(sql, conector.cnn);
            retorno = comando.ExecuteNonQuery();
            conector.cnn.Close();
            conector.desconectar();
            return retorno;
        }

        //Metodo para mostrar el Numero de Identificacion del Usuario
        public int BuscarId(string Nombre)
        {
            SqlCommand comando;
            int idusuario = 0;
            Conexion conector = new Conexion();
            conector.conectar();
            String sql = string.Format(@"Select idUsuario From Usuarios where Nombre ='{0}'", Nombre, conector.cnn);
            comando = new SqlCommand(sql, conector.cnn);
            SqlDataReader reg = null;
            reg = comando.ExecuteReader();

            while (reg.Read())
            {
                string idusuario2 = reg["idUsuario"].ToString();
                idusuario = int.Parse(idusuario2);
            }
            conector.desconectar();
            reg.Close();
            return idusuario;
        }

        //Metodo que selecciona la Foto del Usuario desde la BD
        public string BuscarFoto(int idusuario)
        {
            string foto = "";

            SqlCommand comando;
            Conexion conector = new Conexion();
            conector.conectar();
            String sql = string.Format(@"Select Foto From Usuarios where idUsuario = {0}", idusuario, conector.cnn);
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
    }
}
