using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.AccesoDatos.CRUD;
using TRV.API.CORE.Gestores.Base;
using TRV.Entidades;

namespace TRV.API.CORE.Gestores
{
    public class GestorTren : GestorAPI
    {
        private TrenCrudFactory _crudFactory;

        private GestorAccion gestorAccion;
        private const string AccionPara = "tren";

        public GestorTren(Usuario usuario) : base(usuario)
        {
            _crudFactory = new TrenCrudFactory();
            gestorAccion = new GestorAccion(usuario);
        }

        public void CreateTren(Tren tren)
        {
            if (!string.IsNullOrEmpty(tren.Matricula))
            {
                _crudFactory.Create(tren);
                //gestorAccion.Create(AccionPara);
            }
            else
            {
                throw new Exception();
            }
        }

        public void UpdateTren(Tren tren)
        {
            if (!string.IsNullOrEmpty(tren.Matricula))
            {
                _crudFactory.Update(tren);
                gestorAccion.update(AccionPara);
            }
            else
            {
                //throw gestor.ControlarExcepcion(new ErpException(ErpException.ExceptionCode.CedulaNotNull));
            }
        }

        public void DeleteTren(Tren tren)
        {
            if (!string.IsNullOrEmpty(tren.Matricula))
            {
                _crudFactory.Delete(tren);
                //gestorAccion.delete(AccionPara);
            }
            else
            {
                //throw gestor.ControlarExcepcion(new ErpException(ErpException.ExceptionCode.NoHaSeleccionadoCliente));
            }
        }

        public Tren RetrievTrenPorMatricula(string matricula)
        {

            return _crudFactory.Retrieve<Tren>(matricula);
        }

        public List<Tren> RetrieveAllTren()
        {
            return _crudFactory.RetrieveAll<Tren>();
        }
        public List<Tren> RetrieveAllTrenByLinea(Linea linea)
        {
            return _crudFactory.RetrieveAllByLinea<Tren>(linea);
        }

        public void asignarTrenALinea(Tren tren)
        {
            _crudFactory.asignarTrenALinea(tren);
        }
    }
}
