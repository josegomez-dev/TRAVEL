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
    public class IncidenciaMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_CODIGO = "CODIGO";
        private const string DB_COL_DESCRIPCION = "DESCRIPCION";
        private const string DB_COL_DETALLE = "DETALLE";
        private const string DB_COL_TIPO = "TIPO";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var incidencia = new Incidencia
            {
                Codigo = GetStringValue(row, DB_COL_CODIGO),
                Descripcion = GetStringValue(row, DB_COL_DESCRIPCION),
                Detalle = GetStringValue(row, DB_COL_DETALLE),
                Tipo = GetStringValue(row, DB_COL_TIPO)
            };

            return incidencia;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var incidencia = new Incidencia
                {
                    Codigo = GetStringValue(row, DB_COL_CODIGO),
                    Descripcion = GetStringValue(row, DB_COL_DESCRIPCION),
                    Detalle = GetStringValue(row, DB_COL_DETALLE),
                    Tipo = GetStringValue(row, DB_COL_TIPO)
                };

                lstResults.Add(incidencia);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_INCIDENCIA_PR" };

            var i = (Incidencia)entidad;

            operation.AddVarcharParam(DB_COL_CODIGO, i.Codigo);
            operation.AddVarcharParam(DB_COL_DESCRIPCION, i.Descripcion);
            operation.AddVarcharParam(DB_COL_DETALLE, i.Detalle);
            operation.AddVarcharParam(DB_COL_TIPO, i.Tipo);

            return operation;
        }

        public SqlOperation GetRCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "RCRE_INCIDENCIA_PR" };

            var i = (Incidencia)entidad;

            operation.AddVarcharParam(DB_COL_CODIGO, i.Codigo);
            operation.AddVarcharParam(DB_COL_DESCRIPCION, i.Descripcion);
            operation.AddVarcharParam(DB_COL_DETALLE, i.Detalle);
            operation.AddVarcharParam(DB_COL_TIPO, i.Tipo);

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_INCIDENCIA_PR" };

            operation.AddVarcharParam(DB_COL_CODIGO, id);

            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            return new SqlOperation { ProcedureName = "RET_ALL_INCIDENCIAS_PR" };
        }

        public SqlOperation GetRetrieveByallByTipoStatement(string tipo)
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_INCIDENCIAS_POR_TIPO_PR" };

            operation.AddVarcharParam(DB_COL_TIPO, tipo);

            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_INCIDENCIA_PR" };

            var i = (Incidencia)entidad;

            operation.AddVarcharParam(DB_COL_CODIGO, i.Codigo);
            operation.AddVarcharParam(DB_COL_DESCRIPCION, i.Descripcion);
            operation.AddVarcharParam(DB_COL_DETALLE, i.Detalle);
            operation.AddVarcharParam(DB_COL_TIPO, i.Tipo);

            return operation;

        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_INCIDENCIA_PR" };

            var i = (Incidencia)entidad;

            operation.AddVarcharParam(DB_COL_CODIGO, i.Codigo);

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }

    }
}
