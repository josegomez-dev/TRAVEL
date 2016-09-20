using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.Entidades;

namespace TRV.API.UTIL.Gestores
{
    public class GestorSMS
    {
        Usuario UsuarioAuth;
        MensajeriaUtil Mensajeria;
        public GestorSMS(Usuario usuario)
        {
            UsuarioAuth = usuario;
            Mensajeria = new MensajeriaUtil(UsuarioAuth);
        }

        public string SendNotify(Usuario user, string message)
        {
            string result;

            TRV_SMS sms = new TRV_SMS();
            sms.Telefono = user.Telefono;

            sms.Message = message;

            result = Mensajeria.SendMessage(sms);

            Console.Write(result);

            return result;
        }

        public string SendMassiveNotify(List<Usuario> lstUser, string message)
        {
            string result = "";

            foreach (Usuario user in lstUser)
            {
                TRV_SMS sms = new TRV_SMS();
                sms.Telefono = user.Telefono;

                sms.Message = message;

                result = Mensajeria.SendMessage(sms);

                Console.Write(result);
            }

            return result;
        }

    }
}
