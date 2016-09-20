using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.AccesoDatos.Dao;
using TRV.AccesoDatos.Mapper;
using TRV.Entidades;

namespace TRV.AccesoDatos.CRUD.Base
{
    public class HistorialViajesCrudFactory : CrudFactory
    {
        private HistorialViajesMapper _mapper;

        public HistorialViajesCrudFactory()
        {
            _mapper = new HistorialViajesMapper();
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
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(int id)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(string id)
        {
            throw new NotImplementedException();
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

        public override bool Update(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }
    }
}
