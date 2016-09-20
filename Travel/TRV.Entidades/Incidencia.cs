using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class Incidencia : EntidadBase
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; } // Averia / Notifiacion / Incidencia
        public string Detalle { get; set; }
        public string Tipo { get; set; }

        public Incidencia()
        {

        }

        public Incidencia(string codigo)
        {
            Codigo = codigo;
        }

    }
}
