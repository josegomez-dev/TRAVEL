using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class TRV_Mail : EntidadBase
    {
        public string Addressee { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public TRV_Mail()
        {

        }

    }
}
