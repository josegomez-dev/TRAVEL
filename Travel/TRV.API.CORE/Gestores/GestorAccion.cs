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
    public class GestorAccion : GestorAPI
    {
        private AccionCrudFactory _crudFactory;
        private Usuario usuarioActual;

        public GestorAccion(Usuario usuario) : base(usuario)
        {
            _crudFactory = new AccionCrudFactory();
            usuarioActual = usuario;
        }

        public void Create(string pnombreEntidad)
        {
            const string NombreAccion = "Creación de ";
            Accion accion = new Accion();
            accion.IdUsuario = usuarioActual.Nombre;
            accion.TipoAccion = NombreAccion + pnombreEntidad;
            accion.Fecha = DateTime.Now;
            _crudFactory.Create(accion);

        }
        public void update(string pnombreEntidad)
        {
            const string NombreAccion = "Modificación de ";
            Accion accion = new Accion();
            accion.IdUsuario = usuarioActual.Nombre;
            accion.TipoAccion = NombreAccion + pnombreEntidad;
            accion.Fecha = DateTime.Now;
            _crudFactory.Create(accion);
        }

        public void delete(string pnombreEntidad)
        {
            const string NombreAccion = "Eliminación de ";
            Accion accion = new Accion();
            accion.IdUsuario = usuarioActual.Nombre;
            accion.TipoAccion = NombreAccion + pnombreEntidad;
            accion.Fecha = DateTime.Now;
            _crudFactory.Create(accion);
        }

        public Accion RetrieveById(string pid)
        {
            var tipo = new Accion();
            tipo = _crudFactory.Retrieve<Accion>(pid);
            return tipo;
        }

        public List<Accion> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Accion>();
        }
    }
}
