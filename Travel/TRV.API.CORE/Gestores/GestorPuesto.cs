using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.AccesoDatos.CRUD;
using TRV.API.CORE.Gestores;
using TRV.API.CORE.Gestores.Base;
using TRV.Entidades;

namespace TRV.API.CORE
{
    public class GestorPuesto : GestorAPI
    {
        private PuestoCrudFactory _crudFactory;

        private GestorAccion gestorAccion;
        private const string AccionPara = "puesto";

        public GestorPuesto(Usuario usuario) : base(usuario)
        {
            _crudFactory = new PuestoCrudFactory();
            gestorAccion = new GestorAccion(usuario);
        }
       

        public void Create(Puesto puesto)
        {
            try
            {
                _crudFactory.Create(puesto);
                gestorAccion.Create(AccionPara);
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }
        }

        public void delete(Puesto puesto)
        {
            try
            {
                _crudFactory.Delete(puesto);
                gestorAccion.delete(AccionPara);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
               
            }
            catch (SqlException sqlEx)
            {

                if (sqlEx.Number == 547) // 2627, es para llaves duplicadas.
                    throw gestorEx.controlarExcepcion(new TRV_Exception(TRV_Exception.ExceptionCode.PuestoConPermiso));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Puesto puesto)
        {
            try
            {
                _crudFactory.Update(puesto);
                gestorAccion.update(AccionPara);
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }
        }

        public List<Puesto> RetrieveAll()
        {
            try
            {
                return _crudFactory.RetrieveAll<Puesto>();
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }

        }

        public Puesto RetrievePuestoById(int id)
        {
            var puesto = new Puesto { Id = id };
            return _crudFactory.Retrieve<Puesto>(puesto.Id);

        }
        public Puesto RetrievePuestoByNombre(String nombre)
        {
            var puesto = new Puesto { Nombre = nombre };
            return _crudFactory.Retrieve<Puesto>(puesto.Nombre);

        }

        public void CreatePuestosPorPermisos(Permiso permiso, Puesto puesto)
        {
            try
            {
                _crudFactory.CreatePermisosPorPuesto(permiso, puesto);
            }
            catch (TRV_Exception ex)
            {
                throw ex;

            }
            catch (SqlException sqlEx)
            {

                if (sqlEx.Number == 2627) //2627, es para llaves duplicadas.
                    throw gestorEx.controlarExcepcion(new TRV_Exception(TRV_Exception.ExceptionCode.PermisoYaIngreso));
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void DeletePermisosPorPuestos(Permiso permiso)
        {
            try
            {
                _crudFactory.DeletePermisoPorPuesto(permiso);
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }
        }
     
    }
}
