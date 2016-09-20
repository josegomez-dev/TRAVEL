using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.AccesoDatos.CRUD;
using TRV.Entidades;
using static TRV.Entidades.TRV_Exception;

namespace TRV.API.CORE.Gestores
{
    public class GestorMensaje
    {
        private MensajeCrudFactory _crudFactory;

        public GestorMensaje()
        {
            _crudFactory = new MensajeCrudFactory();
        }

        public List<Mensaje> getMensajesException()
        {
            return _crudFactory.RetrieveAll<Mensaje>();
        }

    }
}
