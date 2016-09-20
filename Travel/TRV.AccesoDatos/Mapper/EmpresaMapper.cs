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
    public class EmpresaMapper : EntityMapper, ISqlStament, IObjectMapper
    {
        private const string DB_COL_CED_JURIDICA = "CED_JURIDICA";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_DIRRECCION = "DIRECCION";
        private const string DB_COL_TELEFONO = "TELEFONO";
        private const string DB_COL_CORREO = "CORREO";
        private const string DB_COL_IMPUESTO = "IMPUESTO";

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_EMPRESA_PR" };

            var c = (Empresa)entidad;
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);
            operation.AddVarcharParam(DB_COL_DIRRECCION, c.Direccion);
            operation.AddVarcharParam(DB_COL_TELEFONO, c.Telefono);
            operation.AddVarcharParam(DB_COL_CED_JURIDICA, c.Cedula);
            operation.AddVarcharParam(DB_COL_CORREO, c.Correo);
            operation.AddVarcharParam(DB_COL_IMPUESTO, c.Impuesto);

            return operation;

        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad) // La empresa es unica, no debe borrarse, solo editarse
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_EMPRESA_PR" };
            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_EMPRESA_PR" };

            operation.AddVarcharParam(DB_COL_CED_JURIDICA, id);
            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_EMPRESA_PR" };

            var c = (Empresa)entidad;
            operation.AddVarcharParam(DB_COL_CED_JURIDICA, c.Cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE, c.Nombre);
            operation.AddVarcharParam(DB_COL_DIRRECCION, c.Direccion);
            operation.AddVarcharParam(DB_COL_TELEFONO, c.Telefono);       
            operation.AddVarcharParam(DB_COL_CORREO, c.Correo);
            operation.AddVarcharParam(DB_COL_IMPUESTO, c.Impuesto);

            return operation;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var empresa = new Empresa
                {
                    Cedula = GetStringValue(row, DB_COL_CED_JURIDICA),
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    Direccion = GetStringValue(row, DB_COL_DIRRECCION),
                    Telefono = GetStringValue(row, DB_COL_TELEFONO),
                    Correo = GetStringValue(row, DB_COL_CORREO),
                    Impuesto = GetStringValue(row, DB_COL_IMPUESTO)
                };
                lstResults.Add(empresa);
            }
            return lstResults;
        }

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var empresa = new Empresa
            {
                Cedula = GetStringValue(row, DB_COL_CED_JURIDICA),
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                Direccion = GetStringValue(row, DB_COL_DIRRECCION),
                Telefono = GetStringValue(row, DB_COL_TELEFONO),              
                Correo = GetStringValue(row, DB_COL_CORREO),
                Impuesto = GetStringValue(row, DB_COL_IMPUESTO)
            };

            return empresa;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }
    }
}
