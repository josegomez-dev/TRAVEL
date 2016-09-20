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
    public class VagonMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_COD_VAGON = "Id";
        private const string DB_COL_COD_CANT_ASIENTOS= "CANT_ASIENTOS";
        private const string DB_COL_COD_TREN = "ID_TREN";


        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var vagon = new Vagon
            {
                IdVagon = GetIntValue(row, DB_COL_COD_VAGON),
                CantAsientos = GetIntValue(row, DB_COL_COD_CANT_ASIENTOS),
                IdTren = GetIntValue(row, DB_COL_COD_TREN)
            };

            return vagon;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var vagon = new Vagon
                {
                    IdVagon = GetIntValue(row, DB_COL_COD_VAGON),
                    CantAsientos = GetIntValue(row, DB_COL_COD_CANT_ASIENTOS),
                    IdTren = GetIntValue(row, DB_COL_COD_TREN)
                };

                lstResults.Add(vagon);
            }

            return lstResults;
        }

        public SqlOperation obtenerUltimoVagonRegistrado()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ULTIMO_VAGON_REG_PR" };

            return operation;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_VAGON_PR" };

            var v = (Vagon)entidad;
            operation.AddIntParam(DB_COL_COD_CANT_ASIENTOS, v.CantAsientos);
            operation.AddIntParam(DB_COL_COD_TREN, v.IdTren);

            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_VAGON_PR" };

            var v = (Vagon)entidad;
            operation.AddIntParam(DB_COL_COD_VAGON, v.IdVagon);

            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            return new SqlOperation { ProcedureName = "RET_VAGON_PR" };
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveByIdTren(string codTren)
        {
            var operation = new SqlOperation { ProcedureName = "RET_VAGONES_POR_TREN_PR" };

            operation.AddVarcharParam(DB_COL_COD_TREN, codTren);

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_VAGON_BY_ID_PR" };

            operation.AddVarcharParam(DB_COL_COD_VAGON, id);

            return operation;
            
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPDT_VAGON_PR" };

            var v = (Vagon)entidad;

            //operation.AddVarcharParam(DB_COL_, V.);


            return operation;
        }
    }
}

