using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class Puesto : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Puesto()
        {
            
        }

        public Puesto(int pId, string pnombre)
        {
            Id = pId;
            Nombre = pnombre;
        }
    }
}
