using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.API.CORE.Excepciones;
using TRV.API.CORE.Gestores;
using TRV.Entidades;

namespace TRV.API.CORE.Gestores.Base
{
    public class GestorAPI
    {
        protected Usuario UsuarioAuth { get; set; }
        //private GestorExcepcion gestor;
        
        protected GestorExcepciones gestorEx { get; set; }

        public GestorAPI(Usuario usuario)
        {
            UsuarioAuth = usuario;
            gestorEx = new GestorExcepciones(usuario);

        }

        public Exception ControlarExcepcion(TRV_Exception code)
        {
            if (gestorEx == null)
            {
                gestorEx = new GestorExcepciones(UsuarioAuth);

            }
            return gestorEx.controlarExcepcion(code);
        }
        public Exception ControlarExcepcion(Exception excepcion)
        {
            if (gestorEx == null)
            {
                this.gestorEx = new GestorExcepciones(UsuarioAuth);
            }
            return gestorEx.controlarExcepcion(excepcion);
        }

        //public Usuario validarUsuario(Usuario usuario)
        //{
        //    if (gestorU == null)
        //    {
        //       this.gestorU = new GestorUsuario(UsuarioAuth);
        //    }
        //     return gestorU.validarUsuario(UsuarioAuth);
        //}

    }
}
