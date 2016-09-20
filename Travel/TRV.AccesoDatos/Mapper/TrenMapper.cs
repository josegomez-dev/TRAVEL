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
    public class TrenMapper : EntityMapper, IObjectMapper, ISqlStament
    {

        private const string DB_COL_COD_TREN = "ID";
        private const string DB_COL_MODELO = "MODELO";
        private const string DB_COL_MATRICULA = "MATRICULA";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_FECHA_COMPRA = "FECHA_COMPRA";
        private const string DB_COL_COSTO = "COSTO";
        private const string DB_COL_DESCRIPCION = "DESCRIPCION";
        private const string DB_COL_ESTADO = "ESTADO";
        private const string DB_COL_COD_LINEA = "COD_LINEA";
        private const string DB_COL_KILOMETRO = "KILOMETRO";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var Tren = new Tren
            {
                CodTren = GetIntValue(row, DB_COL_COD_TREN)+"",
                Modelo = GetStringValue(row, DB_COL_MODELO),
                Matricula = GetStringValue(row, DB_COL_MATRICULA),
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                FechaCompra = GetStringValue(row, DB_COL_FECHA_COMPRA),
                Costo = GetDecimalValue(row, DB_COL_COSTO),
                Descripcion = GetStringValue(row, DB_COL_DESCRIPCION),
                Estado = GetStringValue(row, DB_COL_ESTADO),
                CodLinea = GetIntValue(row, DB_COL_COD_LINEA)+"",
                Kilometro = GetIntValue(row, DB_COL_KILOMETRO)
            };

            return Tren;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var Tren = new Tren
                {
                    CodTren = GetIntValue(row, DB_COL_COD_TREN) + "",
                    Modelo = GetStringValue(row, DB_COL_MODELO),
                    Matricula = GetStringValue(row, DB_COL_MATRICULA),
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    FechaCompra = GetStringValue(row, DB_COL_FECHA_COMPRA),
                    Costo = GetDecimalValue(row, DB_COL_COSTO),
                    Descripcion = GetStringValue(row, DB_COL_DESCRIPCION),
                    Estado = GetStringValue(row, DB_COL_ESTADO),
                    CodLinea = GetIntValue(row, DB_COL_COD_LINEA) + "",
                    Kilometro = GetIntValue(row, DB_COL_KILOMETRO)
                };

                lstResults.Add(Tren);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_TREN_PR" };

            var t = (Tren)entidad;

            operation.AddVarcharParam(DB_COL_MODELO, t.Modelo);
            operation.AddVarcharParam(DB_COL_MATRICULA, t.Matricula);
            operation.AddVarcharParam(DB_COL_NOMBRE, t.Nombre);
            operation.AddVarcharParam(DB_COL_FECHA_COMPRA, t.FechaCompra);
            operation.AddDecimalParam(DB_COL_COSTO, t.Costo);
            operation.AddVarcharParam(DB_COL_DESCRIPCION, t.Descripcion);
            operation.AddVarcharParam(DB_COL_ESTADO, t.Estado);


            return operation;
        }

        public SqlOperation asignarTrenALinea(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_LINEA_TREN_PR" };

            var t = (Tren)entidad;

            operation.AddIntParam(DB_COL_KILOMETRO, t.Kilometro);
            operation.AddVarcharParam(DB_COL_COD_LINEA, t.CodLinea);
            operation.AddVarcharParam(DB_COL_MATRICULA, t.Matricula);

            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_TREN_PR" };

            var t = (Tren)entidad;

            operation.AddVarcharParam(DB_COL_MATRICULA, t.Matricula);

            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            return new SqlOperation { ProcedureName = "RETALL_TRENES_PR" };
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_TREN_PR" };

            operation.AddVarcharParam(DB_COL_MATRICULA, id);

            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_TREN_PR" };

            var t = (Tren)entidad;

            operation.AddVarcharParam(DB_COL_MODELO, t.Modelo);
            operation.AddVarcharParam(DB_COL_MATRICULA, t.Matricula);
            operation.AddVarcharParam(DB_COL_NOMBRE, t.Nombre);
            operation.AddVarcharParam(DB_COL_FECHA_COMPRA, t.FechaCompra);
            operation.AddDecimalParam(DB_COL_COSTO, t.Costo);
            operation.AddVarcharParam(DB_COL_DESCRIPCION, t.Descripcion);
            operation.AddVarcharParam(DB_COL_ESTADO, t.Estado);

            return operation;
        }

        public SqlOperation GetRetrieveByallByLineaStatement(string codigo)
        {

            var operation = new SqlOperation { ProcedureName = "RETALL_TRENES_POR_LINEA_PR" };
            operation.AddIntParam(DB_COL_COD_LINEA, int.Parse(codigo));

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }
    }
}
