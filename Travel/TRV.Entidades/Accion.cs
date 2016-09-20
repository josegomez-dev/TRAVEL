using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class Accion : EntidadBase
    {
        public int Id { get; set; }
        public string IdUsuario { get; set; }
        public string TipoAccion { get; set; }
        public DateTime Fecha { get; set; }


        public Accion()
        {

        }

        public Accion(int pid, string pidUsuario, string ptipoAccion, DateTime pfecha)
        {
            Id = Id;
            TipoAccion = ptipoAccion;
            Fecha = pfecha;
            IdUsuario = pidUsuario;

    }
    }
}
