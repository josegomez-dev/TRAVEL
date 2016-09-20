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
    public class GestorCliente : GestorAPI
    {
        private ClienteCrudFactory _crudFactory;
        public GestorCliente(Usuario usuario) : base(usuario)
        {
            _crudFactory = new ClienteCrudFactory();
            gestorAccion = new GestorAccion(usuario);
        }

        private GestorAccion gestorAccion;
        private const string AccionPara = "Cliente";
        

        public void Create(Cliente cliente)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(cliente.Cedula)))
            {
                _crudFactory.Create(cliente);
                gestorAccion.Create(AccionPara);
            }
            else
            {
                throw new Exception();
            }
        }

        public void Update(Cliente cliente)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(cliente.Cedula)))
            {
                _crudFactory.Update(cliente);
                gestorAccion.update(AccionPara);
            }
            else
            {
                throw new Exception();
            }

        }

        public void Delete(Cliente cliente)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(cliente.Cedula)))
            {
                _crudFactory.Delete(cliente);
                gestorAccion.delete(AccionPara);
            }
            else
            {
                throw new Exception();
            }

        }

        public Cliente RetrievePorId(string id)
        {
            var cliente = new Cliente { Cedula = id };

            return _crudFactory.Retrieve<Cliente>(Convert.ToString(cliente.Cedula));
        }
        
        public List<Cliente> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Cliente>();
        }

        public void CreateClienteNoFrecuente(EntidadBase entidad)
        {
            try
            {
                _crudFactory.CreateNoFrecuente(entidad);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
