using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.AccesoDatos.CRUD.Base;
using TRV.AccesoDatos.Dao;
using TRV.AccesoDatos.Mapper;
using TRV.Entidades;

namespace TRV.AccesoDatos.CRUD
{
    public class ClienteCrudFactory : CrudFactory
    {
        private ClienteMapper _mapper;

        public ClienteCrudFactory()
        {
            _mapper = new ClienteMapper();
        }
        public override bool Create(EntidadBase entidad)
        {
            try
            {
                SqlDao.ExecuteQueryProcedureBoolean(_mapper.GetCreateStatement(entidad));
                return true;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override bool Delete(EntidadBase entidad)
        {
            try
            {
                SqlDao.ExecuteQueryProcedureBoolean(_mapper.GetDeleteStatement(entidad));
                return true;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override EntidadBase RCreate(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(int id)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(string cedula)
        {
            try
            {
                var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetriveByIdStatement(cedula));
                var dic = new Dictionary<string, object>();
                if (lstResult.Count > 0)
                {
                    dic = lstResult[0];

                    return (T)Convert.ChangeType(_mapper.BuildObject(dic), typeof(T));
                }

                return default(T);
            }
            catch (Exception ex)
            {
                //Administrar Conexion Data Base

                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetrieveByallStatement());
            var dic = new List<Dictionary<string, object>>();
            List<T> list = new List<T>();

            if (lstResult.Count > 0)
            {
                for (int i = 0; i < lstResult.Count; i++)
                {
                    dic.Add(lstResult[i]);
                }

                var objs = _mapper.BuildObjects(dic);

                for (int i = 0; i < lstResult.Count; i++)
                {
                    list.Add((T)Convert.ChangeType(objs[i], typeof(T)));
                }

                return list;
            }

            return default(List<T>);
        }

        public override bool Update(EntidadBase entidad)
        {
            try
            {
                SqlDao.CanExecuteQueryProcedure(_mapper.GetUpdateStatement(entidad));
                return true;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public  bool CreateNoFrecuente(EntidadBase entidad)
        {
            try
            {
                SqlDao.ExecuteQueryProcedureBoolean(_mapper.GetCreateStatementNoFrecuente(entidad));
                return true;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public  bool DeleteNoFrecuente(EntidadBase entidad)
        {
            try
            {
                SqlDao.ExecuteQueryProcedureBoolean(_mapper.GetDeleteStatementNoFrecuente(entidad));
                return true;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

       
        public  T RetrieveNoFrecuente<T>(string cedula)
        {
            try
            {
                var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetriveByIdStatementNoFrecuente(cedula));
                var dic = new Dictionary<string, object>();
                if (lstResult.Count > 0)
                {
                    dic = lstResult[0];

                    return (T)Convert.ChangeType(_mapper.BuildObjectNoFrecuente(dic), typeof(T));
                }

                return default(T);
            }
            catch (Exception ex)
            {
                //Administrar Conexion Data Base

                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public  List<T> RetrieveAllNoFrecuente<T>()
        {
            var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetrieveByallStatementNoFrecuente());
            var dic = new List<Dictionary<string, object>>();
            List<T> list = new List<T>();

            if (lstResult.Count > 0)
            {
                for (int i = 0; i < lstResult.Count; i++)
                {
                    dic.Add(lstResult[i]);
                }

                var objs = _mapper.BuildObjectsNoFrecuente(dic);

                for (int i = 0; i < lstResult.Count; i++)
                {
                    list.Add((T)Convert.ChangeType(objs[i], typeof(T)));
                }

                return list;
            }

            return default(List<T>);
        }

        public  bool UpdateNoFrecuente(EntidadBase entidad)
        {
            try
            {
                SqlDao.CanExecuteQueryProcedure(_mapper.GetUpdateStatementNoFrecuente(entidad));
                return true;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

    }
}
