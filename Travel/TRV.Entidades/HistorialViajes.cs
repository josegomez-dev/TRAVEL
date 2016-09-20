using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class HistorialViajes : EntidadBase
    {
        public int Id { get; set; }
        public string Tren { get; set; }
        public string Linea { get; set; }
        public string EstacionAnterior { get; set; }
        public string EstacionSiguiente { get; set; }
        public string TiempoEstimado { get; set; }
        public string Accion { get; set; }
        public string Fecha { get; set; }

        public HistorialViajes()
        {

        }

    }
}
