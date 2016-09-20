using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class TRV_SMS : EntidadBase
    {
        public string Telefono { get; set; }
        public string Message { get; set; }

        public TRV_SMS()
        {

        }

    }
}
