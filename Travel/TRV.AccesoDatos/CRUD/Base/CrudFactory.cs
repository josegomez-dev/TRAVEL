using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.AccesoDatos.Dao;
using TRV.AccesoDatos.Exceptions;
using TRV.AccesoDatos.Mapper.Base;
using TRV.Entidades;

namespace TRV.AccesoDatos.CRUD.Base
{
    public abstract class CrudFactory
    {
        protected SqlDao SqlSqlDao;
        protected EntityMapper EntityMapper { get; set; }

        public abstract bool Create(EntidadBase entidad);
        public abstract T Retrieve<T>(String id);
        public abstract T Retrieve<T>(int id);
        public abstract bool Update(EntidadBase entidad);
        public abstract bool Delete(EntidadBase entidad);
        public abstract EntidadBase RCreate(EntidadBase entidad);
        public abstract List<T> RetrieveAll<T>();

        protected void AdministrarExcepcion(Exception ex)
        {
            var gestor = GestorExcepcion.GetInstance();
            gestor.ControlarExcepcion(ex);

            throw ex;
        }

    }
}
