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
    public class ConvenioMapper : EntityMapper, ISqlStament, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_DESCUENTO = "DESCUENTO";

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CONVENIO_PR" };

            var c = (Convenio)entidad;
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);
            operation.AddDecimalParam(DB_COL_DESCUENTO, c.Descuento);

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string pnombre)         // esta funcion es por Nombre, no por id
        {
            var operation = new SqlOperation { ProcedureName = "RET_CONVENIO_PR" };

            operation.AddVarcharParam(DB_COL_NOMBRE, pnombre);
            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_CONVENIO_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CONVENIO_PR" };

            var c = (Convenio)entidad;
            operation.AddIntParam(DB_COL_ID, c.Id);
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);
            operation.AddDecimalParam(DB_COL_DESCUENTO, c.Descuento);

            return operation;
        }


        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CONVENIO_PR" };

            var c = (Convenio)entidad;
            operation.AddIntParam(DB_COL_ID, c.Id);
            return operation;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var convenio = new Convenio
                {
                    Id = GetIntValue(row, DB_COL_ID),
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    Descuento = GetDecimalValue(row, DB_COL_DESCUENTO)
                };
                lstResults.Add(convenio);
            }
            return lstResults;
        }

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var convenio = new Convenio
            {
                Id = GetIntValue(row, DB_COL_ID),
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                Descuento = GetDecimalValue(row, DB_COL_DESCUENTO)
            };

            return convenio;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }
    }
}