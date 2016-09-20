using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public  class Permiso : EntidadBase
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public Permiso(string descripcion)
        {
            
            Descripcion = descripcion;

        }

        public Permiso()
        {
            
        }
    }
}
