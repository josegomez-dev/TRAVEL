using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.Entidades;
using TRV.AccesoDatos.CRUD;
using TRV.API.CORE.Gestores.Base;

namespace TRV.API.CORE.Gestores
{
    public class GestorEmpresa : GestorAPI  // como solo es una empresa no se busca con filtro ni se crea ni se elimina
    {
        private EmpresaCrudFactory _crudFactory;

        private GestorAccion gestorAccion;
        private const string AccionPara = "empresa";

        public GestorEmpresa(Usuario usuario) : base(usuario)
        {
            _crudFactory = new EmpresaCrudFactory();
            gestorAccion = new GestorAccion(usuario);
        }

        public void update(Empresa empresa)
        {
            try
            { 
            _crudFactory.Update(empresa);
            gestorAccion.update(AccionPara);
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }
        }

        public List<Empresa> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Empresa>();
        }
    }
}
