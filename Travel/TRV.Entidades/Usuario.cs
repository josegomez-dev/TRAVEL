using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.Entidades;

namespace TRV.Entidades
{
    public class Usuario : EntidadBase
    {
        //Probando
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public int Puesto { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Contrasena { get; set; }
        public string PuestoNombre { get; set; }


        public Usuario()
        {

            /*
             * 
                PROBANDO 2
             */

        }

        public Usuario(string nombre, string cedula,int puesto, string correo, string telefono, string contrasena)
        {
            Nombre = nombre;
            Cedula = cedula;
            Puesto = puesto;
            Correo = correo;
            Telefono = telefono;
            Contrasena = contrasena;



        }

    }
}
