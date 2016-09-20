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
    public class PuestoMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_NOMBRE = "NOMBRE";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var puesto = new Puesto
            {
                Id = GetIntValue(row, DB_COL_ID),
                Nombre = GetStringValue(row, DB_COL_NOMBRE)

            };
            return puesto;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var puesto = new Puesto
                {
                    Id = GetIntValue(row, DB_COL_ID),
                    Nombre = GetStringValue(row, DB_COL_NOMBRE)
                };
                lstResults.Add(puesto);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var p = (Puesto) entidad;
            var operation = new SqlOperation {ProcedureName = "CRE_PUESTO_PR"};
            operation.AddIntParam(DB_COL_ID,p.Id);
            operation.AddVarcharParam(DB_COL_NOMBRE,p.Nombre);
            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var p = (Puesto)entidad;
            var operation = new SqlOperation { ProcedureName = "DEL_PUESTO_PR" };
            operation.AddIntParam(DB_COL_ID,p.Id);
            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation {ProcedureName = "RETALL_PUESTO_PR"};
            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            var operation = new SqlOperation {ProcedureName = "RET_PUESTO_PR"};
            operation.AddIntParam(DB_COL_ID,id);
            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var p = (Puesto) entidad;
            var operation = new SqlOperation {ProcedureName = "UPD_PUESTO_PR"};
            operation.AddIntParam(DB_COL_ID,p.Id);
            operation.AddVarcharParam(DB_COL_NOMBRE,p.Nombre);
   
            return operation;
        }
    }
}
