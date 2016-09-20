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

    public class AsientoMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_COD_ID = "ID";
        private const string DB_COL_COD_ID_VAGON = "ID_VAGON";
        private const string DB_COL_TIPO = "TIPO";
        private const string DB_COL_ESTADO = "ESTADO";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var asiento = new Asiento
            {
                IdAsiento = GetIntValue(row, DB_COL_COD_ID),
                IdVagon = GetIntValue(row, DB_COL_COD_ID_VAGON),
                Tipo = GetStringValue(row, DB_COL_TIPO),
                Estado = GetStringValue(row, DB_COL_ESTADO)
            };

            return asiento;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var asiento = new Asiento
                {
                    IdAsiento = GetIntValue(row, DB_COL_COD_ID),
                    IdVagon = GetIntValue(row, DB_COL_COD_ID_VAGON),
                    Tipo = GetStringValue(row, DB_COL_TIPO),
                    Estado = GetStringValue(row, DB_COL_ESTADO)
                };

                lstResults.Add(asiento);
            }

            return lstResults;
        }

        public SqlOperation obtenerCantidadAsientosAdultoMayor(int id)
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_ASIENTOS_ADULTOMAYOR_PR" };

            operation.AddIntParam(DB_COL_COD_ID, id);

            return operation;
        }

        public SqlOperation obtenerCantidadAsientosVIP(int id)
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_ASIENTOS_VIP_PR" };

            operation.AddIntParam(DB_COL_COD_ID, id);

            return operation;

        }

        public SqlOperation obtenerCantidadAsientosAdulto(int id)
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_ASIENTOS_ADULTO_PR" };

            operation.AddIntParam(DB_COL_COD_ID, id);

            return operation;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_ASIENTO_PR" };

            var a = (Asiento)entidad;

            operation.AddIntParam(DB_COL_COD_ID_VAGON, a.IdVagon);
            operation.AddVarcharParam(DB_COL_TIPO, a.Tipo);
            operation.AddVarcharParam(DB_COL_ESTADO, a.Estado);

            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }
    }
}
