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
    public class AsientoCrudFactory : CrudFactory
    {
        private AsientoMapper _mapper;

        public AsientoCrudFactory()
        {
            _mapper = new AsientoMapper();
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


        public List<int> obtenerCantidadPorTipo(int id)
        {
            try
            {
                var lista = new List<int>();
            
                var listaAdulto = SqlDao.ExecuteQueryProcedure(_mapper.obtenerCantidadAsientosAdulto(id));
                lista.Add(listaAdulto.Count);
                var listaAdultoMayor = SqlDao.ExecuteQueryProcedure(_mapper.obtenerCantidadAsientosAdultoMayor(id));
                lista.Add(listaAdultoMayor.Count);
                var listaVIP = SqlDao.ExecuteQueryProcedure(_mapper.obtenerCantidadAsientosVIP(id));
                lista.Add(listaVIP.Count);

                return lista;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }

        }

        public override bool Delete(EntidadBase entidad)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public override bool Update(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }
    }
}
