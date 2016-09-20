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
    public class TipoTiqueteCrudFactory : CrudFactory
    {
        private TipoTiqueteMapper _mapper;

        public TipoTiqueteCrudFactory()
        {
            _mapper = new TipoTiqueteMapper();
        }
        public override bool Create(EntidadBase entidad)
        {
            try
            {
                SqlDao.ExecuteProcedure(_mapper.GetCreateStatement(entidad));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(EntidadBase entidad)
        {
            try
            {
                SqlDao.ExecuteProcedure(_mapper.GetDeleteStatement(entidad));
                return true;
            }
            catch (Exception)
            {
                return false;
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

        public override T Retrieve<T>(string ptipo)
        {
            try
            {
                var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetriveByIdStatement(ptipo));
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
                throw ex;
            }
        }

        public override List<T> RetrieveAll<T>()
        {
            try
            {
                var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetrieveByallStatement());
                var dic = new Dictionary<string, object>();
                List<T> lista = new List<T>();

                if (lstResult.Count > 0)
                {
                    for (int i = 0; i < lstResult.Count; i++)
                    {
                        dic = lstResult[i];
                        var objs = _mapper.BuildObject(dic);

                        lista.Add((T)Convert.ChangeType(objs, typeof(T)));
                    }
                    return lista;
                }
                return default(List<T>);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Update(EntidadBase entidad)
        {
            try
            {
                SqlDao.ExecuteProcedure(_mapper.GetUpdateStatement(entidad));
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }
    }
}

