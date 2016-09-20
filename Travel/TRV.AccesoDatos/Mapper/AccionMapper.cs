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
    public class AccionMapper : EntityMapper, ISqlStament, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_IDUSUARIO = "ID_USUARIO";
        private const string DB_COL_TIPOACCION = "TIPO_ACCION";
        private const string DB_COL_FECHA = "FECHA";

        public SqlOperation GetCreateStatement(EntidadBase entidad)  //Crea una entrada de accion actualizar
        {
            var operation = new SqlOperation { ProcedureName = "CRE_ACCION_PR" };

            var c = (Accion)entidad;
            operation.AddVarcharParam(DB_COL_IDUSUARIO, c.IdUsuario);
            operation.AddVarcharParam(DB_COL_TIPOACCION, c.TipoAccion);
            operation.AddDateTimeParam(DB_COL_FECHA, c.Fecha);

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string pid)      
        {
            var operation = new SqlOperation { ProcedureName = "RET_ACCION_PR" };

            operation.AddVarcharParam(DB_COL_IDUSUARIO, pid);
            return operation;
            
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_ACCION_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }


        public SqlOperation GetDeleteStatement(EntidadBase entidad) 
        {
            throw new NotImplementedException();
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var tiquete = new Accion
                {
                    Id = GetIntValue(row, DB_COL_ID),
                    IdUsuario = GetStringValue(row, DB_COL_IDUSUARIO),
                    TipoAccion = GetStringValue(row, DB_COL_TIPOACCION),
                    Fecha = GetDateValue(row, DB_COL_FECHA)
                };
                lstResults.Add(tiquete);
            }
            return lstResults;
        }

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var Tipo = new Accion
            {
                Id = GetIntValue(row, DB_COL_ID),
                IdUsuario = GetStringValue(row, DB_COL_IDUSUARIO),
                TipoAccion = GetStringValue(row, DB_COL_TIPOACCION),
                Fecha = GetDateValue(row, DB_COL_FECHA)
            };

            return Tipo;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }
    }
}
