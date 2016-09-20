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
    public class LineaMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_CODIGO = "COD_LINEA";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_COLOR = "COLOR";
        private const string DB_COL_DISTANCIA = "DISTANCIA";
        private const string DB_COL_ESTADO = "ESTADO";
        private const string DB_COL_ESTACION_INICIAL = "ESTACION_INICIAL";
        private const string DB_COL_ESTACION_FINAL = "ESTACION_FINAL";
        private const string DB_COL_HORA_TRABAJO = "HORA_TRABAJO";
        private const string DB_COL_HORA_INICIO = "HORA_INICIO";
        private const string DB_COL_COSTO_CIRCULACION = "COSTO_CIRCULACION";
        private const string DB_COL_COD_CENTRAL = "COD_CENTRAL";
        private const string DB_COL_DURACION_RECORRIDO = "DURACION_RECORRIDO";

        //Para tabla intermedia
        private const string DB_COL_ID_ESTACION = "ID_ESTACION";
        private const string DB_COL_ID_LINEA = "ID_LINEA";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var linea = new Linea
            {
                Codigo = GetStringValue(row, DB_COL_CODIGO),
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                Color = GetStringValue(row, DB_COL_COLOR),
                Distancia = GetIntValue(row, DB_COL_DISTANCIA),
                Estado = GetStringValue(row, DB_COL_ESTADO),
                EstacionInicial = GetIntValue(row, DB_COL_ESTACION_INICIAL),
                EstacionFinal = GetIntValue(row, DB_COL_ESTACION_FINAL),
                HoraTrabajo = GetIntValue(row, DB_COL_HORA_TRABAJO),
                HoraInicio = GetStringValue(row, DB_COL_HORA_INICIO),
                CostoCirculacion = GetDecimalValue(row, DB_COL_COSTO_CIRCULACION),
                CodCentral = GetIntValue(row, DB_COL_COD_CENTRAL),
                DuracionRecorrido = GetIntValue(row, DB_COL_DURACION_RECORRIDO)
            };
            return linea;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var linea = new Linea
                {
                    Codigo = GetStringValue(row, DB_COL_CODIGO),
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    Color = GetStringValue(row, DB_COL_COLOR),
                    Distancia = GetIntValue(row, DB_COL_DISTANCIA),
                    Estado = GetStringValue(row, DB_COL_ESTADO),
                    EstacionInicial = GetIntValue(row, DB_COL_ESTACION_INICIAL),
                    EstacionFinal = GetIntValue(row, DB_COL_ESTACION_FINAL),
                    HoraTrabajo = GetIntValue(row, DB_COL_HORA_TRABAJO),
                    HoraInicio = GetStringValue(row, DB_COL_HORA_INICIO),
                    CostoCirculacion = GetDecimalValue(row, DB_COL_COSTO_CIRCULACION),
                    CodCentral = GetIntValue(row, DB_COL_COD_CENTRAL),
                    DuracionRecorrido = GetIntValue(row, DB_COL_DURACION_RECORRIDO)
                };
                lstResults.Add(linea);
            }
            return lstResults;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_LINEA_PR" };

            var l = (Linea)entidad;
            operation.AddVarcharParam(DB_COL_NOMBRE, l.Nombre);
            operation.AddVarcharParam(DB_COL_COLOR, l.Color);
            operation.AddIntParam(DB_COL_DISTANCIA, l.Distancia);
            operation.AddVarcharParam(DB_COL_ESTADO, l.Estado);
            operation.AddIntParam(DB_COL_ESTACION_INICIAL, l.EstacionInicial);
            operation.AddIntParam(DB_COL_ESTACION_FINAL, l.EstacionFinal);
            operation.AddIntParam(DB_COL_HORA_TRABAJO, l.HoraTrabajo);
            operation.AddVarcharParam(DB_COL_HORA_INICIO, l.HoraInicio);
            operation.AddDecimalParam(DB_COL_COSTO_CIRCULACION, l.CostoCirculacion);
            operation.AddIntParam(DB_COL_COD_CENTRAL, l.CodCentral);
            operation.AddIntParam(DB_COL_DURACION_RECORRIDO, l.DuracionRecorrido);
            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_LINEA_PR" };

            var l = (Linea)entidad;
            operation.AddVarcharParam(DB_COL_CODIGO, l.Codigo);

            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_LINEAS_PR" };
            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_LINEA_PR" };

            operation.AddVarcharParam(DB_COL_CODIGO, id);

            return operation;
        }

        public SqlOperation GetRetriveByNameStatement(string nombre)
        {
            var operation = new SqlOperation { ProcedureName = "RETNAME_LINEA_PR" };

            operation.AddVarcharParam(DB_COL_NOMBRE, nombre);

            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_LINEA_PR" };

            var l = (Linea)entidad;
            operation.AddVarcharParam(DB_COL_CODIGO, l.Codigo);
            operation.AddVarcharParam(DB_COL_NOMBRE, l.Nombre);
            operation.AddVarcharParam(DB_COL_COLOR, l.Color);
            operation.AddIntParam(DB_COL_DISTANCIA, l.Distancia);
            operation.AddVarcharParam(DB_COL_ESTADO, l.Estado);
            operation.AddIntParam(DB_COL_ESTACION_INICIAL, l.EstacionInicial);
            operation.AddIntParam(DB_COL_ESTACION_FINAL, l.EstacionFinal);
            operation.AddIntParam(DB_COL_HORA_TRABAJO, l.HoraTrabajo);
            operation.AddVarcharParam(DB_COL_HORA_INICIO, l.HoraInicio);
            operation.AddDecimalParam(DB_COL_COSTO_CIRCULACION, l.CostoCirculacion);
            operation.AddIntParam(DB_COL_COD_CENTRAL, l.CodCentral);
            operation.AddIntParam(DB_COL_DURACION_RECORRIDO, l.DuracionRecorrido);
            return operation;
        }

        public SqlOperation GetCreateEstacionPorLineaStatement(string estacion, string linea)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_ESTACION_POR_LINEA_PR" };

            operation.AddVarcharParam(DB_COL_ID_ESTACION, estacion);
            operation.AddVarcharParam(DB_COL_ID_LINEA, linea);

            return operation;
        }

        public SqlOperation GetUpdateEstacionPorLineaStatement(string estacion, string linea)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_ESTACION_POR_LINEA_PR" };

            operation.AddVarcharParam(DB_COL_ID_ESTACION, estacion);
            operation.AddVarcharParam(DB_COL_ID_LINEA, linea);

            return operation;
        }

        public SqlOperation GetEstacionesRetriveByLineaStatement(string linea)
        {
            var operation = new SqlOperation { ProcedureName = "RET_ESTACIONES_POR_LINEA_PR" };

            operation.AddVarcharParam("ID_LINEA", linea);

            return operation;
        }

        public SqlOperation GetEstacionesDeleteByLineaStatement(string linea)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_ESTACION_POR_LINEA_PR" };

            operation.AddVarcharParam("ID_LINEA", linea);

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }
    }
}
