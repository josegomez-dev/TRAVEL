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
    public class GestorEstacion : GestorAPI
    {
        private EstacionCrudFactory _crudFactory;

        private GestorAccion gestorAccion;
        private const string AccionPara = "estación";

        public GestorEstacion(Usuario usuario) : base(usuario)
        {
            _crudFactory = new EstacionCrudFactory();
            gestorAccion = new GestorAccion(usuario);
        }

        public void CreateEstacion(Estacion estacion)
        {
            try
            {
                _crudFactory.Create(estacion);
                gestorAccion.Create(AccionPara);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteEstacion(Estacion estacion)
        {
            try
            {
                _crudFactory.Delete(estacion);
                gestorAccion.delete(AccionPara);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateEstacion(Estacion estacion)
        {
            try
            {
                _crudFactory.Update(estacion);
                gestorAccion.update(AccionPara);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public List<Estacion> RetrieveAllEstaciones()
        {
            try
            {
                return _crudFactory.RetrieveAll<Estacion>();
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public List<Estacion> RetrieveAllEstacionesPorLinea(Linea linea)
        {
            try
            {
                return _crudFactory.RetrieveAllPorLinea<Estacion>(linea);
            }
            catch (TRV_Exception ex)
            {
                // Exception linea null
                throw ex;
            }
        }

        public Estacion retrieveEstacionCentral()
        {
            return _crudFactory.RetrieveEstacionCentral<Estacion>();
        }

        public Estacion RetrieveEstacionPorCodigo(string codigo)
        {
            var estacion = new Estacion { Codigo = codigo };

            return _crudFactory.Retrieve<Estacion>(estacion.Codigo);
        }

        public Estacion RetrieveEstacionPorNombre(string nombre)
        {
            var estacion = new Estacion { Nombre = nombre };

            return _crudFactory.RetrieveByName<Estacion>(estacion.Nombre);
        }
    }
}
