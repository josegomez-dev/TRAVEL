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
    public class GestorTipoTiquete : GestorAPI
    {
        private TipoTiqueteCrudFactory _crudFactory;

        private GestorAccion gestorAccion;
        private const string AccionPara = "tipo de tiquete";

        public GestorTipoTiquete(Usuario usuario) : base(usuario)
        {
            _crudFactory = new TipoTiqueteCrudFactory();
            gestorAccion = new GestorAccion(usuario);
    }

        public void Create(TipoTiquete tipo)
        {
            try
            { 
                _crudFactory.Create(tipo);
                gestorAccion.Create(AccionPara);
             }
            catch (TRV_Exception ex)
            {

                throw ex;
            }

        }
        public void update(TipoTiquete tipo)
        {
           try
            {
                _crudFactory.Update(tipo);
                gestorAccion.update(AccionPara);
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }
        }

        public void delete(TipoTiquete tipo)
        {
            try
            {
                _crudFactory.Delete(tipo);
                gestorAccion.delete(AccionPara);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public TipoTiquete RetrieveByName(string ptipo)
        {
            var tipo = new TipoTiquete() ;
            try
            {
                    tipo = _crudFactory.Retrieve<TipoTiquete>(ptipo);

                    if (tipo != null)
                    {
                        return tipo;
                    }
                    else
                    {
                        throw gestorEx.controlarExcepcion(new TRV_Exception(TRV_Exception.ExceptionCode.NoData));
                    }
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }
        }

        public List<TipoTiquete> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<TipoTiquete>();
        }
    }
}
