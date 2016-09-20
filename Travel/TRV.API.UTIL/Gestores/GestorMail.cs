using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.Entidades;

namespace TRV.API.UTIL.Gestores
{
    public class GestorMail
    {
        Usuario UsuarioAuth;
        MensajeriaUtil Mensajeria;

        public GestorMail(Usuario usuario)
        {
            UsuarioAuth = usuario;
            Mensajeria = new MensajeriaUtil(UsuarioAuth);
        }

        public string SendMail(Usuario usuario, string subject, string content)
        {
            TRV_Mail mail = new TRV_Mail();

            mail.Addressee = usuario.Correo;
            mail.Subject = subject;
            mail.Content = content;

            return Mensajeria.SendMessage(mail);
        }

    }
}
