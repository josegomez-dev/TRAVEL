using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.API.CORE.Excepciones;
using TRV.Entidades;

namespace TRV.API.UTIL.Base
{
    public class Util
    {
        protected Usuario UsuarioAuth { get; set; }
        protected GestorExcepciones gestor { get; set; }

        public Util(Usuario usuario)
        {
            UsuarioAuth = usuario;
            gestor = new GestorExcepciones(usuario);
        }

    }
}
