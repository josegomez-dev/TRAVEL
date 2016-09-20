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
    public class GestorVagon : GestorAPI
    {
        private VagonCrudFactory _crudFactory;
        private GestorAsiento _gestorAsiento;
        private GestorAccion gestorAccion;
        private const string AccionPara = "vagón";

        public GestorVagon(Usuario usuario) : base(usuario)
        {
            _crudFactory = new VagonCrudFactory();
            _gestorAsiento = new GestorAsiento(usuario);
            gestorAccion = new GestorAccion(usuario);
        }

        public void CreateVagon(Vagon vagon)
        {
            if (!string.IsNullOrEmpty(vagon.IdTren+""))
            {
                _crudFactory.Create(vagon);
                Vagon v = obtenerUltimoVagonRegistrado();
                v.crearAsientos();

                for (int i= 0; i < vagon.CantAsientos; i++)
                {
                    _gestorAsiento.CreateAsiento(v.listaAsientos.ElementAt(i));
                }
                gestorAccion.Create(AccionPara);
            }
            else
            {
                throw new Exception();
            }
        }

        private Vagon obtenerUltimoVagonRegistrado()
        {
            Vagon v = _crudFactory.obtenerUltimoVagonRegistrado();
                
            return v;
        }

        public void DeleteVagon(Vagon vagon)
        {
            if (!string.IsNullOrEmpty(vagon.IdVagon+""))
            {
                _crudFactory.Delete(vagon);
                gestorAccion.delete(AccionPara);
            }
            else
            {
                //throw gestor.ControlarExcepcion(new ErpException(ErpException.ExceptionCode.NoHaSeleccionadoCliente));
            }
        }

        public List<Vagon> RetrievVagonPorIdTren(string codTren)
        {

            return _crudFactory.RetrieveAllByIdTren<Vagon>(codTren);
        }
    }
}
