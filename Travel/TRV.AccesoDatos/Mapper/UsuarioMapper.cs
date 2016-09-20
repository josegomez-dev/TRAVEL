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
    class UsuarioMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const  string DB_COL_NOMBRE = "NOMBRE";
        private const  string DB_COL_CEDULA = "CEDULA";
        private const  string DB_COL_ID_PUESTO = "ID_PUESTO";
        private const string DB_COL_CORREO = "CORREO";
        private const string DB_COL_CONTRASENA = "CONTRASENA";
        private const string DB_COL_TELEFONO = "TELEFONO";
        private const string DB_COL_PUESTO = "PUESTO";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var usuario = new Usuario
            {
                Nombre = GetStringValue(row,DB_COL_NOMBRE),
                Cedula = GetStringValue(row,DB_COL_CEDULA),
                Puesto = GetIntValue(row,DB_COL_ID_PUESTO),
                Telefono =  GetStringValue(row,DB_COL_TELEFONO),
                Correo = GetStringValue(row,DB_COL_CORREO),
                Contrasena = GetStringValue(row,DB_COL_CONTRASENA)
            };
            return usuario;
        }
        public EntidadBase BuildObjectVerify(Dictionary<string, object> row)
        {
            var usuario = new Usuario
            {
                Puesto = GetIntValue(row,DB_COL_ID_PUESTO),
                Nombre = GetStringValue(row,DB_COL_NOMBRE),
                Correo = GetStringValue(row, DB_COL_CORREO),
                Contrasena = GetStringValue(row, DB_COL_CONTRASENA)
            };
            return usuario;
        }
        public List<EntidadBase> BuildObjectsPuesto(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var usuario = new Usuario
                {
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    Cedula = GetStringValue(row, DB_COL_CEDULA),
                    PuestoNombre = GetStringValue(row, DB_COL_PUESTO),
                    Telefono = GetStringValue(row, DB_COL_TELEFONO),
                    Correo = GetStringValue(row, DB_COL_CORREO),
                    //Contrasena = GetStringValue(row, DB_COL_CONTRASENA)
                };
                lstResults.Add(usuario);
            }

            return lstResults;

        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var usuario = new Usuario
                {
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    Cedula = GetStringValue(row, DB_COL_CEDULA),
                    Puesto = GetIntValue(row, DB_COL_ID_PUESTO),
                    Telefono = GetStringValue(row, DB_COL_TELEFONO),
                    Correo = GetStringValue(row, DB_COL_CORREO),
                    Contrasena = GetStringValue(row, DB_COL_CONTRASENA)
                };
                lstResults.Add(usuario);
            }

            return lstResults;

        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_USUARIO_PR" };

            var u = (Usuario) entidad;
            operation.AddVarcharParam(DB_COL_CEDULA,u.Cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE,u.Nombre);
            operation.AddVarcharParam(DB_COL_TELEFONO,u.Telefono);
            operation.AddIntParam(DB_COL_ID_PUESTO,u.Puesto);
            operation.AddVarcharParam(DB_COL_CONTRASENA,u.Contrasena);
            operation.AddVarcharParam(DB_COL_CORREO,u.Correo);
            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_USUARIO_PR" };
            var u = (Usuario)entidad;
            operation.AddVarcharParam(DB_COL_CEDULA, u.Cedula);
            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_USUARIO_PR" };
            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_USUARIO_PR" };
            operation.AddVarcharParam(DB_COL_CEDULA,id);
            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation {ProcedureName = "UPD_USUARIO_PR"};
            var u = (Usuario)entidad;
            operation.AddVarcharParam(DB_COL_CEDULA, u.Cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddVarcharParam(DB_COL_TELEFONO, u.Telefono);
            operation.AddIntParam(DB_COL_ID_PUESTO,u.Puesto);
            operation.AddVarcharParam(DB_COL_CONTRASENA, u.Contrasena);
            operation.AddVarcharParam(DB_COL_CORREO, u.Correo);
            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }
        public SqlOperation RetrievePorAutentificacion(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "RETAUTENTIFICA_USUARIO_PR" };
            var u = (Usuario)entidad;
            operation.AddVarcharParam(DB_COL_CORREO, u.Correo);
            return operation;
        }
    }
}
