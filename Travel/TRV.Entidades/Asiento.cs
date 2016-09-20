
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class Asiento : EntidadBase
    {
        public int IdAsiento { get; set; }
        public int IdVagon { get; set; }
        public string Tipo { get; set; } = "Adulto";
        public string Estado { get; set; } = "Disponible";

        public Asiento() { }
        
        public Asiento(int idAsiento,int idVagon)
        {
            IdAsiento = idAsiento;
            IdVagon = idVagon;
            Tipo = "Adulto";
            Estado = "Disponible";
        }
    }
}
