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
        private const  string DB_COL_PUESTO = "PUESTO";
        private const string DB_COL_CORREO = "CORREO";
        private const string DB_COL_CONTRASEÑA = "CONTRASENA";
        private const string DB_COL_TELEFONO = "TELEFONO";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var usuario = new Usuario
            {
                Nombre = GetStringValue(row,DB_COL_NOMBRE),
                Cedula = GetStringValue(row,DB_COL_CEDULA),
                Puesto = GetStringValue(row,DB_COL_PUESTO),
                Telefono =  GetStringValue(row,DB_COL_TELEFONO),
                Correo = GetStringValue(row,DB_COL_CORREO),
                Contraseña = GetStringValue(row,DB_COL_CONTRASEÑA)

              
            };
            return usuario;
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
                    Puesto = GetStringValue(row, DB_COL_PUESTO),
                    Telefono = GetStringValue(row, DB_COL_TELEFONO),
                    Correo = GetStringValue(row, DB_COL_CORREO),
                    Contraseña = GetStringValue(row, DB_COL_CONTRASEÑA)


                };
                lstResults.Add(usuario);
            }

            return lstResults;

        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetrieveByallStatement()
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
