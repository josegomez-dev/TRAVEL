using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class TipoTiquete: EntidadBase
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }

        public TipoTiquete()
        {

        }
        public TipoTiquete(int pid, string pnombre, decimal pprecio)
        {
            Id=pid;
            Tipo = pnombre;
            Precio = pprecio;
        }
    }
}
