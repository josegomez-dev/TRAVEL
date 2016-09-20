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
    public class PermisoMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_CODIGO = "CODIGO";
        private const string DB_COL_DESCRIPCION = "DESCRIPCION";
        private const string DB_COL_COD_PUESTO = "COD_PUESTO";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var permiso = new Permiso
            {
                Codigo = GetIntValue(row,DB_COL_CODIGO),
                Descripcion = GetStringValue(row,DB_COL_DESCRIPCION)
            };
            return permiso;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var permiso = new Permiso
                {
                    Codigo = GetIntValue(row, DB_COL_CODIGO),
                    Descripcion = GetStringValue(row, DB_COL_DESCRIPCION)
                };
                
                lstResults.Add(permiso);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_PERMISO_PR" };

            var p = (Permiso)entidad;
           
            operation.AddVarcharParam(DB_COL_DESCRIPCION,p.Descripcion);
            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_PERMISO_PR" };

            var p = (Permiso)entidad;
            operation.AddIntParam(DB_COL_CODIGO, p.Codigo);
            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_PERMISO_PR" };
            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_PERMISO_PR" };
            operation.AddIntParam(DB_COL_CODIGO,id);
            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_PERMISO_PR" };

            var p = (Permiso)entidad;
            operation.AddIntParam(DB_COL_CODIGO, p.Codigo);
            operation.AddVarcharParam(DB_COL_DESCRIPCION, p.Descripcion);
            return operation;
        }
        public SqlOperation RetrieveAllPermisosPorUsuario(int id)
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_PERMISO_POR_PUESTO_PR" };
            operation.AddIntParam(DB_COL_COD_PUESTO, id);
            return operation;
        }
    }
}
