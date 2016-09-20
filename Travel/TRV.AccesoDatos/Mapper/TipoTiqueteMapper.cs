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
    public class TipoTiqueteMapper : EntityMapper, ISqlStament, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_TIPO = "TIPO";
        private const string DB_COL_PRECIO = "PRECIO";

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_TIPO_TIQUETE_PR" };

            var c = (TipoTiquete)entidad;
            operation.AddVarcharParam(DB_COL_TIPO, c.Tipo);
            operation.AddDecimalParam(DB_COL_PRECIO, c.Precio);

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string ptipo)         // esta funcion es por tipo, no por id
        {
            var operation = new SqlOperation { ProcedureName = "RET_TIPO_TIQUETE_PR" };

            operation.AddVarcharParam(DB_COL_TIPO, ptipo);
            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_TIPO_TIQUETE_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_TIPO_TIQUETE_PR" };

            var c = (TipoTiquete)entidad;
            operation.AddIntParam(DB_COL_ID, c.Id);
            operation.AddVarcharParam(DB_COL_TIPO, c.Tipo);
            operation.AddDecimalParam(DB_COL_PRECIO, c.Precio);

            return operation;
        }


        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_TIPO_TIQUETE_PR" };

            var c = (TipoTiquete)entidad;
            operation.AddIntParam(DB_COL_ID, c.Id);
            return operation;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var tiquete = new TipoTiquete
                {
                    Id = GetIntValue(row, DB_COL_ID),
                    Tipo = GetStringValue(row, DB_COL_TIPO),
                    Precio = GetDecimalValue(row, DB_COL_PRECIO)
                };
                lstResults.Add(tiquete);
            }
            return lstResults;
        }

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var Tipo = new TipoTiquete
            {
                Id = GetIntValue(row, DB_COL_ID),
                Tipo = GetStringValue(row, DB_COL_TIPO),
                Precio = GetDecimalValue(row, DB_COL_PRECIO)
            };

            return Tipo;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }
    }
}