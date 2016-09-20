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
    public class HistorialViajesMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_CODIGO = "ID";
        private const string DB_COL_LINEA = "LINEA";
        private const string DB_COL_TREN = "TREN";
        private const string DB_COL_ESTACION_ANTERIOR = "ESTACION_ANTERIOR";
        private const string DB_COL_ESTACION_SIGUIENTE = "ESTACION_SIGUIENTE";
        private const string DB_COL_TIEMPO_ESTIMADO = "TIEMPO_ESTIMADO";
        private const string DB_COL_ACCION = "ACCION";
        private const string DB_COL_FECHA = "FECHA";
        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var historial = new HistorialViajes
            {
                Linea = GetStringValue(row, DB_COL_LINEA),
                Tren = GetStringValue(row, DB_COL_TREN),
                EstacionAnterior = GetStringValue(row, DB_COL_ESTACION_ANTERIOR),
                EstacionSiguiente = GetStringValue(row, DB_COL_ESTACION_SIGUIENTE),
                TiempoEstimado = GetStringValue(row, DB_COL_TIEMPO_ESTIMADO),
                Accion = GetStringValue(row, DB_COL_ACCION),
                Fecha = GetStringValue(row, DB_COL_FECHA)
            };

            return historial;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var historial = new HistorialViajes
                {
                    Linea = GetStringValue(row, DB_COL_LINEA),
                    Tren = GetStringValue(row, DB_COL_TREN),
                    EstacionAnterior = GetStringValue(row, DB_COL_ESTACION_ANTERIOR),
                    EstacionSiguiente = GetStringValue(row, DB_COL_ESTACION_SIGUIENTE),
                    TiempoEstimado = GetStringValue(row, DB_COL_TIEMPO_ESTIMADO),
                    Accion = GetStringValue(row, DB_COL_ACCION),
                    Fecha = GetStringValue(row, DB_COL_FECHA)
                };

                lstResults.Add(historial);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_HISTORIALVIAJE_PR" };

            var i = (HistorialViajes)entidad;
            
            operation.AddVarcharParam(DB_COL_LINEA, i.Linea);
            operation.AddVarcharParam(DB_COL_TREN, i.Tren);
            operation.AddVarcharParam(DB_COL_ESTACION_ANTERIOR, i.EstacionAnterior);
            operation.AddVarcharParam(DB_COL_ESTACION_SIGUIENTE, i.EstacionSiguiente);
            operation.AddVarcharParam(DB_COL_TIEMPO_ESTIMADO, i.TiempoEstimado);
            operation.AddVarcharParam(DB_COL_ACCION, i.Accion);
            operation.AddVarcharParam(DB_COL_FECHA, i.Fecha);

            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_HISTORIALVIAJES_PR" };

            var i = (HistorialViajes)entidad;

            operation.AddIntParam(DB_COL_CODIGO, i.Id);

            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            return new SqlOperation { ProcedureName = "RET_ALL_HISTORIALVIAJES_PR" };
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
