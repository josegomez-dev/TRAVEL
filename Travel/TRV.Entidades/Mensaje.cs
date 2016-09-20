using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TRV.Entidades.TRV_Exception;

namespace TRV.Entidades
{
    public class Mensaje : EntidadBase
    {
        public ExceptionCode Codigo { get; set; }
        public string Msj { get; set; }

        public Mensaje() { }

        public Mensaje(ExceptionCode pcodigo, string pmensaje)
        {
            Codigo = pcodigo;
            Msj = pmensaje;
        }

    }
}
