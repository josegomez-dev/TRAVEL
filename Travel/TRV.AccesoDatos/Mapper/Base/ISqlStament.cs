using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.AccesoDatos.Dao;
using TRV.Entidades;

namespace TRV.AccesoDatos.Mapper.Base
{
    interface ISqlStament
    {
        SqlOperation GetCreateStatement(EntidadBase entidad);
        SqlOperation GetRetriveByIdStatement(String id);
        SqlOperation GetRetriveByIdStatement(int id);
        SqlOperation GetRetrieveByallStatement();
        SqlOperation GetUpdateStatement(EntidadBase entidad);
        SqlOperation GetDeleteStatement(EntidadBase entidad);
    }
}
