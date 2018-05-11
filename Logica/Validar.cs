using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class Validar
    {
        //Metodo para Confirmar el Tipo de Usuario que esta ingresando
        public string ValidarUsuario(string Usuario, string Contrasena)
        {
            int comparacion = 0;
            string puesto = "";
            Conexion conecta = new Conexion();
            comparacion = conecta.Validar(Usuario, Contrasena);
            if (comparacion == 1)
            {
                puesto = "Administrador";
            }
            else if(comparacion == 2)
            {
                puesto = "Cajero";
            }
            if (comparacion != 1 && comparacion != 2)
            {
                puesto = "Ninguno";
            }

            return puesto;
        }
    }
}
