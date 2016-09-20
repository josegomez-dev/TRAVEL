using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TRV.API.CORE.Gestores.Base;
using TRV.AccesoDatos.CRUD;
using TRV.Entidades;
using System.Data.SqlClient;

namespace TRV.API.CORE.Gestores
{
    public class GestorUsuario : GestorAPI
    {
        private UsuarioCrudFactory _crudFactory;
        private string HashedPass = "";
        private Usuario usr;

        private GestorAccion gestorAccion;
        private const string AccionPara = "usuario";

        public GestorUsuario(Usuario usuario) : base(usuario)
        {
            _crudFactory = new UsuarioCrudFactory();
            gestorAccion = new GestorAccion(usuario);
        }

        public void Create(Usuario usuario)
        {
            try
            {
                HashedPass = GetMD5(usuario.Contrasena);
                usuario.Contrasena = HashedPass;
                _crudFactory.Create(usuario);
                gestorAccion.Create(AccionPara);
            }
            catch (TRV_Exception ex)
            {
                throw ex;

            }
            catch (SqlException sqlEx)
            {

                if (sqlEx.Number == 2627) //2627, es para llaves duplicadas.
                    throw gestorEx.controlarExcepcion(new TRV_Exception(TRV_Exception.ExceptionCode.CedulaDuplicada));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void delete(Usuario usuario)
        {
            try
            {
                _crudFactory.Delete(usuario);
                gestorAccion.delete(AccionPara);
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Usuario usuario)
        {
            try
            {
                HashedPass = GetMD5(usuario.Contrasena);
                usuario.Contrasena = HashedPass;
                _crudFactory.Update(usuario);
                gestorAccion.update(AccionPara);
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }
        }

        public List<Usuario> RetrieveAll()
        {
            try
            {
                return _crudFactory.RetrieveAll<Usuario>();
            }
            catch (TRV_Exception ex)
            {

                throw ex;
            }

        }

        public Usuario RetrieveUsuario(string pcedula)
        {
            var usuario = new Usuario { Cedula = pcedula };
            return _crudFactory.Retrieve<Usuario>(usuario.Cedula);

        }
        public Usuario RetrievePorAutentificacion(Usuario usuario, string contraseña)
        {

            try
            {
                HashedPass = GetMD5(contraseña);
                contraseña = HashedPass;
                usr = _crudFactory.RetrieveAutentificacion<Usuario>(usuario);

                if (usr != null)
                {

                    if (ValidarContraseñas(HashedPass, usr.Contrasena) == true)
                    {
                        return usr;
                    }
                    else
                    {
                        throw gestorEx.controlarExcepcion(new TRV_Exception(TRV_Exception.ExceptionCode.ContrasenaNotMatch));
                    }
                }
                else
                {
                  throw gestorEx.controlarExcepcion(new TRV_Exception(TRV_Exception.ExceptionCode.CorreoNotExist));
                }
            }
            catch (TRV_Exception ex)
            {
                throw ControlarExcepcion(ex);
            }

        }
        private static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        private static bool ValidarContraseñas(string conInput, string conOuput)
        {
            if (conInput.Equals(conOuput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }







    }
}
