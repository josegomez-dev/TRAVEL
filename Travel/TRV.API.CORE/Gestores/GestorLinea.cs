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
    public class GestorLinea : GestorAPI
    {
        private LineaCrudFactory _crudFactory;

        private GestorAccion gestorAccion;
        private const string AccionPara = "línea";

        public GestorLinea(Usuario usuario) : base(usuario)
        {
            _crudFactory = new LineaCrudFactory();
            gestorAccion = new GestorAccion(usuario);
        }

        public void CreateLinea(Linea linea)
        {
            try
            {
                _crudFactory.Create(linea);
                gestorAccion.Create(AccionPara);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteLinea(Linea linea)
        {
            try
            {
                _crudFactory.Delete(linea);
                gestorAccion.delete(AccionPara);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateLinea(Linea linea)
        {
            try
            {
                _crudFactory.Update(linea);
                gestorAccion.update(AccionPara);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public List<Linea> RetrieveAllLineas()
        {
            try
            {
                return _crudFactory.RetrieveAll<Linea>();
            }
            catch (Exception ex)
            {
                //throw gestorEx.ControlarExcepcion(new TRV_Exception(TRV_Exception.ExceptionCode.NoData));
                throw ex;
            }
        }

        public Linea RetrieveLineaPorCodigo(string codigo)
        {
            var linea = new Linea { Codigo = codigo };

            return _crudFactory.Retrieve<Linea>(linea.Codigo);
        }

        public Linea RetrieveLineaPorNombre(string nombre)
        {
            var linea = new Linea { Nombre = nombre };

            return _crudFactory.RetrieveByName<Linea>(linea.Nombre);
        }

        public void CreateEstacionesPorLinea(string nomEstacion, string nomLinea)
        {
            try
            {
                EstacionCrudFactory _estacionCrudFactory = new EstacionCrudFactory();

                var linea = new Linea { Nombre = nomLinea };
                linea = _crudFactory.RetrieveByName<Linea>(linea.Nombre);

                var estacion = new Estacion { Nombre = nomEstacion };
                estacion = _estacionCrudFactory.RetrieveByName<Estacion>(estacion.Nombre);
                
                _crudFactory.CreateEstacionByLinea(estacion.Codigo, linea.Codigo);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateEstacionesPorLinea(string nomEstacion, string nomLinea)
        {
            try
            {
                EstacionCrudFactory _estacionCrudFactory = new EstacionCrudFactory();

                var linea = new Linea { Nombre = nomLinea };
                linea = _crudFactory.RetrieveByName<Linea>(linea.Nombre);

                var estacion = new Estacion { Nombre = nomEstacion };
                estacion = _estacionCrudFactory.RetrieveByName<Estacion>(estacion.Nombre);

                _crudFactory.CreateEstacionByLinea(estacion.Codigo, linea.Codigo);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public List<Estacion> RetrieveEstacionesPorLinea(string linea)
        {
            try
            {
                return _crudFactory.RetrieveEstacionesByLinea(linea);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteEstacionesPorLinea(string linea)
        {
            try
            {
                _crudFactory.DeleteEstacionesByLinea(linea);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }
    }
}
