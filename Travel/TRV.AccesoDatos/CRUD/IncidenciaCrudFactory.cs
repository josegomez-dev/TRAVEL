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
    public class IncidenciaCrudFactory : CrudFactory
    {
        private IncidenciaMapper _mapper;

        public IncidenciaCrudFactory()
        {
            _mapper = new IncidenciaMapper();
        }

        public override bool Create(EntidadBase entidad)
        {
            try
            {
                SqlDao.ExecuteProcedure(_mapper.GetCreateStatement(entidad));

                return true;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override T Retrieve<T>(string id)
        {
            try
            {
                var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetriveByIdStatement(id));
                var dic = new Dictionary<string, object>();
                if (lstResult.Count > 0)
                {
                    dic = lstResult[0];

                    var objs = _mapper.BuildObject(dic);
                    return (T)Convert.ChangeType(objs, typeof(T));
                }

                return default(T);
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override bool Update(EntidadBase entidad)
        {
            try
            {
                return SqlDao.CanExecuteQueryProcedure(_mapper.GetUpdateStatement(entidad));
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
                return SqlDao.CanExecuteQueryProcedure(_mapper.GetDeleteStatement(entidad));
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override EntidadBase RCreate(EntidadBase entidad)
        {
            try
            {
                var registro = SqlDao.ExecuteQueryProcedure(_mapper.GetRCreateStatement(entidad));
                var dic = new Dictionary<string, object>();

                if (registro.Count > 0)
                {
                    dic = registro[0];

                    var objs = _mapper.BuildObject(dic);
                    return (Incidencia)Convert.ChangeType(objs, typeof(Incidencia));
                }

                return null;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }
        
        public List<T> RetrieveAllByTipo<T>(string tipo)
        {
            try
            {
                var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetrieveByallByTipoStatement(tipo));
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
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override List<T> RetrieveAll<T>()
        {
            try
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
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override T Retrieve<T>(int id)
        {
            throw new NotImplementedException();
        }
    }
}
