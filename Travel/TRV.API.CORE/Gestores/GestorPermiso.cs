using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.AccesoDatos.CRUD;
using TRV.API.CORE.Gestores.Base;
using TRV.Entidades;

namespace TRV.API.CORE.Gestores
{
    public class GestorPermiso : GestorAPI
    {
        private PermisoCrudFactory _crudFactory;

        private GestorAccion gestorAccion;
        private const string AccionPara = "permiso";

        public GestorPermiso(Usuario usuario) : base(usuario)
        {
            _crudFactory = new PermisoCrudFactory();
            gestorAccion = new GestorAccion(usuario);
        }

        public void Delete(Permiso permiso)
        {
            try
            {
                _crudFactory.Delete(permiso);
                gestorAccion.delete(AccionPara);
            }
            catch (TRV_Exception ex)
            {
                throw ex;

            }
            catch (SqlException sqlEx)
            {

                if (sqlEx.Number == 547) //2627, es para llaves duplicadas.
                    throw gestorEx.controlarExcepcion(new TRV_Exception(TRV_Exception.ExceptionCode.PermisosConPuesto));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Permiso permiso)
        {
            try
            {
                _crudFactory.Update(permiso);
                gestorAccion.update(AccionPara);
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }
        }

        public List<Permiso> RetrieveAll()
        {
            try
            {
                return _crudFactory.RetrieveAll<Permiso>();
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }

        }
        public List<Permiso> RetrieveAllPermisoPorPuesto(int id)
        {
            try
            {
                return _crudFactory.RetrieveAllPermisoPuestos<Permiso>(id);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }

        }

        public Permiso RetrievePermiso(int codigo)
        {
            var permiso = new Permiso { Codigo = codigo};
            return _crudFactory.Retrieve<Permiso>(permiso.Codigo);

        }
    }
}
