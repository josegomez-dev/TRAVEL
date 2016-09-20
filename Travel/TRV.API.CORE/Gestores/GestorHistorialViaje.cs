using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.AccesoDatos.CRUD.Base;
using TRV.API.CORE.Gestores.Base;
using TRV.Entidades;

namespace TRV.API.CORE.Gestores
{
    public class GestorHistorialViaje : GestorAPI
    {
        private HistorialViajesCrudFactory _crudFactory;

        public GestorHistorialViaje(Usuario usuario) : base(usuario)
        {
            _crudFactory = new HistorialViajesCrudFactory();
        }

        public void Create(HistorialViajes historial)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(historial.Id)))
            {
                _crudFactory.Create(historial);
            }
            else
            {
                throw new Exception();
            }
        }

        public List<HistorialViajes> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<HistorialViajes>();
        }

        public void Delete(HistorialViajes historial)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(historial.Id)))
            {
                _crudFactory.Delete(historial);
            }
            else
            {
                throw new Exception();
            }

        }

    }
}
