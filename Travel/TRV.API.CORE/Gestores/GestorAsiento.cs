using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.AccesoDatos.CRUD;
using TRV.API.CORE.Gestores.Base;
using TRV.Entidades;

namespace TRV.API.CORE.Gestores
{
    public class GestorAsiento : GestorAPI
    {
        private AsientoCrudFactory _crudFactory;

        private GestorAccion gestorAccion;

        public GestorAsiento(Usuario usuario) : base(usuario)
        {
            _crudFactory = new AsientoCrudFactory();
        }

        public void CreateAsiento(Asiento asiento)
        {
            if (!string.IsNullOrEmpty(asiento.IdVagon+""))
            {
                _crudFactory.Create(asiento);
            }
            else
            {
                throw new Exception();
            }
        }

        public List<int> obtenerCantidadPorTipo(int id)
        {
            List<int> lista = _crudFactory.obtenerCantidadPorTipo(id);

            return lista;
        }
    }
}
