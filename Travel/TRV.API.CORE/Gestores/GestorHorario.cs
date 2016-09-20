using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.AccesoDatos.CRUD;
using TRV.API.CORE.Gestores.Base;
using TRV.Entidades;

namespace TRV.API.CORE.Gestores
{
    public class GestorHorario : GestorAPI
    {
        private HorarioCrudFactory _crudFactory;
        public GestorHorario(Usuario usuario) : base(usuario)
        {
            _crudFactory = new HorarioCrudFactory();
        }

        public void CreateHorario(Horario horario)
        {
            try
            {
                _crudFactory.Create(horario);
            }
            catch (TRV_Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Horario horario)
        {
            try
            {
                _crudFactory.Delete(horario);
            }
            catch (TRV_Exception ex)
            {
                throw ex;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(string tren, string linea)
        {
            try
            {
                _crudFactory.Delete(tren, linea);
            }
            catch (TRV_Exception ex)
            {
                throw ex;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Horario> RetrieveAll()
        {
            try
            {
                return _crudFactory.RetrieveAll<Horario>();
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }

        }
        public List<Horario> RetrieveAllByTrenLinea(string tren, string linea)
        {
            try
            {
                return _crudFactory.RetrieveAllByTrenLinea<Horario>(tren, linea);
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }

        }

    }
}
