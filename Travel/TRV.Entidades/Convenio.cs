using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class Convenio : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Descuento { get; set; }

        public Convenio()
        {

        }
        public Convenio(int pid, string pnombre, decimal pdescuento)
        {
            Id = pid;
            Nombre = pnombre;
            Descuento = pdescuento;
        }
    }
}