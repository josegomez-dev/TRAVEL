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
    public class GestorConvenio : GestorAPI
    {
        private ConvenioCrudFactory _crudFactory;

        private GestorAccion gestorAccion;
        private const string AccionPara = "Convenio";

        public GestorConvenio(Usuario usuario) : base(usuario)
        {
            _crudFactory = new ConvenioCrudFactory();
            gestorAccion = new GestorAccion(usuario);
        }

        public void Create(Convenio tipo)
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
        public void update(Convenio convenio)
        {
            try
            {
                _crudFactory.Update(convenio);
                gestorAccion.update(AccionPara);
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }
        }

        public void delete(Convenio convenio)
        {
            try
            {
                _crudFactory.Delete(convenio);
                gestorAccion.delete(AccionPara);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public Convenio RetrieveByName(string pconvenio)
        {
            var tipo = new Convenio();
            try
            {
                tipo = _crudFactory.Retrieve<Convenio>(pconvenio);

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

        public List<Convenio> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Convenio>();
        }
    }
}
