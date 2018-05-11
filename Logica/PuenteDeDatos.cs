using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class PuenteDeDatos
    {
        CRUD_Usuarios objeto = new CRUD_Usuarios();
        CRUD_Productos obj = new CRUD_Productos();

        //Metodo para tomar los datos del Usuario y enviarlos a la vista
        public string EnviarUsuario(string nombre, string apellidos, int telefono, string correo, string tipoUsuario, string contrasena, string foto)
        {
            string enviar = "";

            objeto.Nombres1 = nombre;
            objeto.Apellidos1 = apellidos;
            objeto.Telefono1 = telefono;
            objeto.Correo1 = correo;
            objeto.TipoUsuario1 = tipoUsuario;
            objeto.Contrasena1 = contrasena;
            objeto.Foto1 = foto;

            int resultado = CRUD_Usuarios.AltaUsuarios(objeto);

            if (resultado == 1)
            {
                enviar = "S";
            }

            return enviar;

        }

        //Metodo para Eliminar un Usuario
        public Boolean BajaUsuario(int idusuario)
        {
            int bandera = objeto.BajaUsuarios(idusuario);
            if (bandera == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo para modificar datos del Usuario
        public Boolean ModificarUsuario(int idusuario, string nombre, string apellidos, long telefono, string correo, string tipoUsuario, string contrasena, string foto)
        {
            objeto.IdUsuario = idusuario;
            objeto.Nombres1 = nombre;
            objeto.Apellidos1 = apellidos;
            objeto.Telefono1 = telefono;
            objeto.Correo1 = correo;
            objeto.TipoUsuario1 = tipoUsuario;
            objeto.Contrasena1 = contrasena;
            objeto.Foto1 = foto;

            //Llamada al metodo ModificacionUsuarios de la capa de Datos
            int resultado = CRUD_Usuarios.ModificacionUsuarios(objeto);

            if (resultado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Metodo que captura el id desde el metodo BuscarId de la capa de Datos
        public int BuscarId(string usuario)
        {
            int idusuario = objeto.BuscarId(usuario);
            return idusuario;
        }

        //Metodo que captura la Foto del Usuario desde el metodo BuscarFoto de la capa de Datos
        public string BuscarFoto(int idusuario)
        {
            string fotousuario = objeto.BuscarFoto(idusuario);
            return fotousuario;
        }

        //Metodo que envia la informacion del Producto
        public string EnviarProducto(string nombre, string cantidad, string precio, string descripcion, string foto)
        {
            string enviar = "";

            obj.Nombre = nombre;
            obj.Cantidad = cantidad;
            obj.Precio = precio;
            obj.Descripcion = descripcion;
            obj.Foto = foto;

            int resultado = CRUD_Productos.AltaProductos(obj);

            if (resultado == 1)
            {
                enviar = "S";
            }

            return enviar;

        }

        //Metodo para Eliminar un Producto
        public Boolean BajaProducto(int Codigo)
        {
            int bandera = obj.BajaProductos(Codigo);
            if (bandera == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo para modificar datos del Producto
        public Boolean ModificarProductos(int codigo, string nombre, string cantidad, string price, string descripcion, string foto)
        {
            obj.Codigo = codigo;
            obj.Nombre = nombre;
            obj.Cantidad = cantidad;
            obj.Precio = price;
            obj.Descripcion = descripcion;
            obj.Foto = foto;

            //Llamada al metodo ModificacionProducto de la capa de Datos
            int resultado = CRUD_Productos.ModificacionProducto(obj);

            if (resultado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo que captura la Foto del Producto desde el metodo BuscarFoto de la capa de Datos
        public string BuscarFotoProducto(int idproducto)
        {
            CRUD_Productos obj2 = new CRUD_Productos();
            string fotoproducto = obj2.BuscarFoto(idproducto);
            return fotoproducto;
        }

        //Metodo que captura el Nombre del Usuario desde el metodo BuscarNombre de la clase Turno en la capa de Datos
        public string BuscarNombre(int idusuario)
        {
            Turno buscador = new Turno();
            string nombreusuario = buscador.BuscarNombre(idusuario);
            return nombreusuario;
        }

        //Metodo que abre corte de Caja con el metodo IngresarTurno de la clase Turno en la capa de Datos
        public int agregarturno(int idusuario, double deposito, string turno, string fecha, string horaEntrada)
        {
            Turno objetoturno = new Turno();
            int resultado = objetoturno.IngresarTurno(idusuario, deposito, turno, fecha, horaEntrada);
            return resultado;
        }

        //Metodo que captura la informacion del Producto y lo inserta en una tabla
        public static Tuple<string, double> buscainfoP(int idproducto)
        {
            Tuple<string, double> resultado;
            resultado = CRUD_Productos.BuscarCamposP(idproducto);
            return resultado;
        }

        //Metodo que envia los datos del Producto a la Tabla Temporal para tomarlo en el Cierre de Corte
        public Boolean AgregaDatosTablaTemp(int idproducto, string nombrevendedor, int cantidad, double total, double ivalist)
        {
            CRUD_Productos obj3 = new CRUD_Productos();
            Boolean resultado = false;
            int bandera;
            bandera = obj3.AgregarVentaTemporal(idproducto, nombrevendedor, cantidad, total, ivalist);
            if (bandera >= 1)
            {
                resultado = true;
            }

            return resultado;
        }

        //Metodo para Cerrar el Corte
        public double VentaTotalDeTurno(string nombrevendedor, string fechacorte)
        {
            Turno PT = new Turno();
            double VTT = PT.VentaTotalDeTurno(nombrevendedor, fechacorte);
            return VTT;
        }
    }
}