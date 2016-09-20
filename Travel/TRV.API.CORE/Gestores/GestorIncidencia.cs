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
    public class GestorIncidencia : GestorAPI
    {
        private IncidenciaCrudFactory _crudFactory;

        private GestorAccion gestorAccion;
        private const string AccionPara = "incidencia";

        public GestorIncidencia(Usuario usuario) : base(usuario)
        {
            _crudFactory = new IncidenciaCrudFactory();
            gestorAccion = new GestorAccion(usuario);
        }

             public void Create(Incidencia incidencia)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(incidencia.Codigo)))
            {
                _crudFactory.Create(incidencia);
                gestorAccion.Create(AccionPara);
            }
            else
            {
                throw new Exception();
            }
        }

        public void Update(Incidencia incidencia)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(incidencia.Codigo)))
            {
                _crudFactory.Update(incidencia);
                gestorAccion.update(AccionPara);
            }
            else
            {
                throw new Exception();
            }

        }

        public void Delete(Incidencia incidencia)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(incidencia.Codigo)))
            {
                _crudFactory.Delete(incidencia);
                gestorAccion.delete(AccionPara);
            }
            else
            {
                throw new Exception();
            }

        }

        public Incidencia RetrievePorId(string id)
        {
            var incidencia = new Incidencia { Codigo = id };

            return _crudFactory.Retrieve<Incidencia>(Convert.ToString(incidencia.Codigo));
        }

        public List<Incidencia> RetrieveAllPorTipo(string tipo)
        {
            return _crudFactory.RetrieveAllByTipo<Incidencia>(tipo);
        }

        public List<Incidencia> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Incidencia>();
        }
        
    }
}
