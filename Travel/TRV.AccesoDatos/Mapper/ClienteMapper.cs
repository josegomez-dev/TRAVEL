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
    public class ClienteMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_CEDULA = "CEDULA";
        private const string DB_COL_APELLIDO = "APELLIDO";
        private const string DB_COL_EDAD = "EDAD";
        private const string DB_COL_CORREO = "CORREO";
        private const string DB_COL_CLAVE = "CLAVE";
        private const string DB_COL_TELEFONO = "TELEFONO";
        private const string DB_COL_RESIDENCIA = "RESIDENCIA";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var cliente = new Cliente
            {
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                Cedula = GetStringValue(row, DB_COL_CEDULA),
                Apellido = GetStringValue(row,DB_COL_APELLIDO),
                Edad = GetIntValue(row, DB_COL_EDAD),
                Correo = GetStringValue(row, DB_COL_CORREO),
                Clave = GetStringValue(row, DB_COL_CLAVE),
                Telefono = GetStringValue(row, DB_COL_TELEFONO),
                Residencia = GetStringValue(row, DB_COL_RESIDENCIA)
            };
            return cliente;
        }

        public EntidadBase BuildObjectNoFrecuente(Dictionary<string, object> row)
        {
            var cliente = new Cliente
            {
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                Cedula = GetStringValue(row, DB_COL_CEDULA),
                Apellido = GetStringValue(row, DB_COL_APELLIDO),
                Correo = GetStringValue(row, DB_COL_CORREO),
                Telefono = GetStringValue(row, DB_COL_TELEFONO),
                Residencia = GetStringValue(row, DB_COL_RESIDENCIA)
            };
            return cliente;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var cliente = new Cliente
                {
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    Cedula = GetStringValue(row, DB_COL_CEDULA),
                    Edad = GetIntValue(row, DB_COL_EDAD),
                    Correo = GetStringValue(row, DB_COL_CORREO),
                    Clave = GetStringValue(row, DB_COL_CLAVE),
                    Telefono = GetStringValue(row, DB_COL_TELEFONO),
                    Residencia = GetStringValue(row, DB_COL_RESIDENCIA)
                };
                lstResults.Add(cliente);
            }

            return lstResults;
        }

        public List<EntidadBase> BuildObjectsNoFrecuente(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var cliente = new Cliente
                {
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    Cedula = GetStringValue(row, DB_COL_CEDULA),
                    Apellido = GetStringValue(row, DB_COL_APELLIDO),
                    Correo = GetStringValue(row, DB_COL_CORREO),
                    Telefono = GetStringValue(row, DB_COL_TELEFONO),
                    Residencia = GetStringValue(row, DB_COL_RESIDENCIA)
                };
                lstResults.Add(cliente);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CLIENTE_PR" };

            var u = (Cliente)entidad;

            operation.AddVarcharParam(DB_COL_CEDULA, u.Cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddIntParam(DB_COL_EDAD, u.Edad);
            operation.AddVarcharParam(DB_COL_CORREO, u.Correo);
            operation.AddVarcharParam(DB_COL_CLAVE, u.Clave);
            operation.AddVarcharParam(DB_COL_TELEFONO, u.Telefono);
            operation.AddVarcharParam(DB_COL_RESIDENCIA, u.Residencia);
            
            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CLIENTE_PR" };

            var u = (Cliente)entidad;

            operation.AddVarcharParam(DB_COL_CEDULA, u.Cedula);

            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_CLIENTE_PR" };

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CLIENTE_PR" };

            operation.AddVarcharParam(DB_COL_CEDULA, Convert.ToString(id));

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CLIENTE_PR" };

            operation.AddVarcharParam(DB_COL_CEDULA, id);

            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CLIENTE_PR" };

            var u = (Cliente)entidad;

            operation.AddVarcharParam(DB_COL_CEDULA, u.Cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddIntParam(DB_COL_EDAD, u.Edad);
            operation.AddVarcharParam(DB_COL_CORREO, u.Correo);
            operation.AddVarcharParam(DB_COL_CLAVE, u.Clave);
            operation.AddVarcharParam(DB_COL_TELEFONO, u.Telefono);
            operation.AddVarcharParam(DB_COL_RESIDENCIA, u.Residencia);

            return operation;
        }

        public SqlOperation GetCreateStatementNoFrecuente(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CLIENTE_NO_FRECUENTE_PR" };

            var u = (Cliente)entidad;

            operation.AddVarcharParam(DB_COL_CEDULA, u.Cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddVarcharParam(DB_COL_APELLIDO,u.Apellido);
            operation.AddVarcharParam(DB_COL_CORREO, u.Correo);
            operation.AddVarcharParam(DB_COL_TELEFONO, u.Telefono);
            operation.AddVarcharParam(DB_COL_RESIDENCIA, u.Residencia);

            return operation;
        }

        public SqlOperation GetDeleteStatementNoFrecuente(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CLIENTE_NO_FRECUENTE_PR" };

            var u = (Cliente)entidad;

            operation.AddVarcharParam(DB_COL_CEDULA, u.Cedula);

            return operation;
        }

        public SqlOperation GetRetrieveByallStatementNoFrecuente()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_CLIENTE_NO_FRECUENTE_PR" };

            return operation;
        }
        public SqlOperation GetRetriveByIdStatementNoFrecuente(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CLIENTE_NO_FRECUENTE_PR" };

            operation.AddVarcharParam(DB_COL_CEDULA, id);

            return operation;
        }

        public SqlOperation GetUpdateStatementNoFrecuente(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CLIENTE_NO_FRECUENTE_PR" };

            var u = (Cliente)entidad;

            operation.AddVarcharParam(DB_COL_CEDULA, u.Cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddVarcharParam(DB_COL_APELLIDO, u.Apellido);
            operation.AddVarcharParam(DB_COL_CORREO, u.Correo);
            operation.AddVarcharParam(DB_COL_TELEFONO, u.Telefono);
            operation.AddVarcharParam(DB_COL_RESIDENCIA, u.Residencia);

            return operation;
        }


    }
}
