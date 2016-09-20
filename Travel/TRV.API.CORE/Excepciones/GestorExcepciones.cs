using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.API.CORE.Gestores;
using TRV.Entidades;
using static TRV.Entidades.TRV_Exception;

namespace TRV.API.CORE.Excepciones
{
    public class GestorExcepciones
    {
        public GestorMensaje mensaje;

        public static List<Mensaje> lista;

        public GestorExcepciones(Usuario usuario)
        {
            mensaje = new GestorMensaje();
           
        }

        public TRV_Exception controlarExcepcion(TRV_Exception pexception)
        {

            TRV_Exception exception = pexception;
            if (lista == null)
            {
                cargarMensajes();

            }
            for (var i = 0; i < lista.Count; i++)
            {
                if (exception.Codigo == lista[i].Codigo)
                {
                    exception.Mensaje = lista[i].Msj;
                }
            }

            return exception;
        }

        public Exception controlarExcepcion(Exception pexception)
        {
            Exception exception = pexception;
            return exception;

        }
        public Exception ControlarException(Exception exception)
        {
            return new Exception();
        }

        public void cargarMensajes()
        {

            lista = mensaje.getMensajesException();

        }
    }
}
