using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class Horario : EntidadBase
    {
        public string Id { get; set; }
        public string HoraArrivo { get; set; }
        public string HoraSalida { get; set; }
        public string Tren { get; set; }
        public string Linea { get; set; }

        public Horario()
        {
                
        }

    }
}
