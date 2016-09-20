using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{


    public class Empresa: EntidadBase
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public string Impuesto { get; set; }

        public Empresa()
        {

        }

        public Empresa(string pcedula,string pnombre, string pdireccion, string ptelefono, string pcorreo, string pimpuesto)
        {
            Cedula = pcedula;
            Nombre = pnombre;
            Direccion = pdireccion;
            Telefono = ptelefono;
            Correo = pcorreo;
            Impuesto = pimpuesto;
        }
    }
}
