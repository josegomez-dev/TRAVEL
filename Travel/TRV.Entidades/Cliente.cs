using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class Cliente : EntidadBase
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Telefono { get; set; }
        public string Residencia { get; set; }
        public List<string> Tarjetas { get; set; }
        //public List<Tarjeta> LstTarjetas { get; set; }


        public Cliente()
        {

        }

    }
}
