using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.API.UTIL.Base;
using TRV.Entidades;

namespace TRV.API.UTIL
{
    public class ReporteriaUtil : Util
    {
        Usuario UsuarioAuth;
        public ReporteriaUtil(Usuario usuario) : base(usuario)
        {
            UsuarioAuth = usuario;
        }

    }
}
