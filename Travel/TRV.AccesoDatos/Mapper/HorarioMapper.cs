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
    public class HorarioMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_ID = "COD";
        private const string DB_COL_ARRIVO = "ARRIVO";
        private const string DB_COL_SALIDA = "SALIDA";
        private const string DB_COL_COD_TREN = "TREN";
        private const string DB_COL_LINEA = "LINEA";

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var horario = new Horario
                {
                    Id = GetStringValue(row, DB_COL_ID),
                    HoraArrivo = GetStringValue(row, DB_COL_ARRIVO),
                    HoraSalida = GetStringValue(row, DB_COL_SALIDA),
                    Tren = GetStringValue(row, DB_COL_COD_TREN),
                    Linea = GetStringValue(row, DB_COL_LINEA)
                };

                lstResults.Add(horario);
            }

            return lstResults;
        }

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var horario = new Horario
            {
                Id = GetStringValue(row, DB_COL_ID),
                HoraArrivo = GetStringValue(row, DB_COL_ARRIVO),
                HoraSalida = GetStringValue(row, DB_COL_SALIDA),
                Tren = GetStringValue(row, DB_COL_COD_TREN),
                Linea = GetStringValue(row, DB_COL_LINEA)
            };
            return horario;
        }

        internal SqlOperation GetDeleteByTrenLineaStatement(string tren, string linea)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_HORARIO_PR" };
            
            operation.AddVarcharParam(DB_COL_COD_TREN, tren);
            operation.AddVarcharParam(DB_COL_LINEA, linea);

            return operation;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_HORARIO_PR" };

            var p = (Horario)entidad;

            operation.AddVarcharParam(DB_COL_ARRIVO, p.HoraArrivo);
            operation.AddVarcharParam(DB_COL_SALIDA, p.HoraSalida);
            operation.AddVarcharParam(DB_COL_COD_TREN, p.Tren);
            operation.AddVarcharParam(DB_COL_LINEA, p.Linea);

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            throw new NotImplementedException();
        }

        internal SqlOperation GetRetrieveByallByTrenLineaStatement(string matricula, string codigo)
        {
            var operation = new SqlOperation { ProcedureName = "RET_HORARIO_POR_TRENLINEA_PR" };
            
            operation.AddVarcharParam(DB_COL_COD_TREN, matricula);
            operation.AddVarcharParam(DB_COL_LINEA, codigo);

            return operation;

        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_HORARIOS_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_HORARIO_PR" };

            var p = (Horario)entidad;

            operation.AddVarcharParam(DB_COL_ID, p.Id);

            return operation;
        }
    }
}
