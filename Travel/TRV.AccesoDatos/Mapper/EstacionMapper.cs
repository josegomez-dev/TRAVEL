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
    public class EstacionMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_CODIGO = "COD_ESTACION";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_ESTADO = "ESTADO";
        private const string DB_COL_LATITUD = "LATITUD";
        private const string DB_COL_LONGITUD = "LONGITUD";
        private const string DB_COL_CENTRAL = "CENTRAL";
        private const string DB_COL_KILOMETRO = "KILOMETRO";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var estacion = new Estacion
            {
                Codigo = GetStringValue(row, DB_COL_CODIGO),
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                Estado = GetStringValue(row, DB_COL_ESTADO),
                Latitud = GetDecimalValue(row, DB_COL_LATITUD),
                Longitud = GetDecimalValue(row, DB_COL_LONGITUD),
                Central = GetIntValue(row, DB_COL_CENTRAL),
                Kilometro = GetIntValue(row, DB_COL_KILOMETRO)
            };
            return estacion;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var estacion = new Estacion
                {
                    Codigo = GetStringValue(row, DB_COL_CODIGO),
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    Estado = GetStringValue(row, DB_COL_ESTADO),
                    Latitud = GetDecimalValue(row, DB_COL_LATITUD),
                    Longitud = GetDecimalValue(row, DB_COL_LONGITUD),
                    Central = GetIntValue(row, DB_COL_CENTRAL),
                    Kilometro = GetIntValue(row, DB_COL_KILOMETRO)
                };
                lstResults.Add(estacion);
            }
            return lstResults;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_ESTACION_PR" };

            var e = (Estacion)entidad;
            operation.AddVarcharParam(DB_COL_NOMBRE, e.Nombre);
            operation.AddVarcharParam(DB_COL_ESTADO, e.Estado);
            operation.AddDecimalParam(DB_COL_LATITUD, e.Latitud);
            operation.AddDecimalParam(DB_COL_LONGITUD, e.Longitud);
            operation.AddIntParam(DB_COL_CENTRAL, e.Central);
            operation.AddIntParam(DB_COL_KILOMETRO, e.Kilometro);
            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_ESTACION_PR" };

            var e = (Estacion)entidad;
            operation.AddVarcharParam(DB_COL_CODIGO, e.Codigo);

            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_ESTACIONES_PR" };
            return operation;
        }

        public SqlOperation GetRetriveCentralStation()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ESTACION_CENTRAL" };
            return operation;
        }

        
        public SqlOperation GetRetrieveByallByLineaStatement(string cod_Linea)
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_ESTACIONES_POR_LINEA_PR" };

            operation.AddIntParam("ID_LINEA", int.Parse(cod_Linea));

            return operation;
        }

        
        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_ESTACION_PR" };

            operation.AddVarcharParam(DB_COL_CODIGO, id);

            return operation;
        }

        public SqlOperation GetRetriveByNameStatement(string nombre)
        {
            var operation = new SqlOperation { ProcedureName = "RETNAME_ESTACION_PR" };

            operation.AddVarcharParam(DB_COL_NOMBRE, nombre);

            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_ESTACION_PR" };

            var e = (Estacion)entidad;
            operation.AddVarcharParam(DB_COL_CODIGO, e.Codigo);
            operation.AddVarcharParam(DB_COL_NOMBRE, e.Nombre);
            operation.AddVarcharParam(DB_COL_ESTADO, e.Estado);
            operation.AddDecimalParam(DB_COL_LATITUD, e.Latitud);
            operation.AddDecimalParam(DB_COL_LONGITUD, e.Longitud);
            operation.AddIntParam(DB_COL_CENTRAL, e.Central);
            operation.AddIntParam(DB_COL_KILOMETRO, e.Kilometro);
            return operation;
        }
        
        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }
    }
}
