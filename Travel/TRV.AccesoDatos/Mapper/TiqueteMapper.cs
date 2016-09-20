using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.AccesoDatos.Dao;
using TRV.AccesoDatos.Mapper.Base;
using TRV.Entidades;

namespace TRV.AccesoDatos.Mapper
{
    public class TiqueteMapper : EntityMapper, ISqlStament, IObjectMapper
    {

        private const string DB_COL_Id = "Id";
        private const string DB_COL_NumeroAsiento = "NumeroAsiento";
        private const string DB_COL_IdViaje = "IdViaje";
        private const string DB_COL_HoraSalida = "HoraSalida";
        private const string DB_COL_HoraArrivo = "HoraArrivo";
        private const string DB_COL_Tipo = "Tipo";

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> values)
        {
            throw new NotImplementedException();
        }

        public EntidadBase BuildObject(Dictionary<string, object> values)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }
    }
}