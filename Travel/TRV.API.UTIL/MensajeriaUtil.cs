using Nexmo.Api;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TRV.API.UTIL.Base;
using TRV.Entidades;

namespace TRV.API.UTIL
{
    public class MensajeriaUtil : Util
    {
        public MensajeriaUtil(Usuario usuario) : base(usuario)
        {
        }
        

        public string SendMessage(EntidadBase entidad)
        {
            string result = "";

            if (entidad is TRV_SMS) // Send SMS
            {
                try
                {
                    var s = (TRV_SMS)entidad;

                    result = sendSMSWithPHPService(s);
                    //result = sendSMSwithNativeCsharp(s); CHECK THIS  
                }
                catch (TRV_Exception ex)
                {
                    // throw gestor.ControlarExcepcion(new TRV_Exception(TRV_Exception.ExceptionCode.SMSNotSend));
                }

            }
            else // SEND MAIL
            {
                try
                {
                    var c = (TRV_Mail)entidad;

                    result = sendMailwithSmtpClient(c);
                }
                catch (TRV_Exception ex)
                {
                    // Atrapar que el correo sea invalido
                    // throw gestor.ControlarExcepcion(new TRV_Exception(TRV_Exception.ExceptionCode.MailNotSend));
                }

            }

            return result;
        }

        private SmtpClient SetCredentials(string mailUser, string mailPass)
        {
            try
            {
                var clientSmtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(mailUser, mailPass),
                    EnableSsl = true
                };

                return clientSmtp;
            }
            catch (TRV_Exception ex)
            {
                throw new TRV_Exception(ex);
                // throw gestor.ControlarExcepcion(new TRV_Exception(TRV_Exception.ExceptionCode.NotFoundCredentials));
            }
        }
        
        private string sendMailwithSmtpClient(TRV_Mail c)
        {
            SmtpClient client = SetCredentials("infotravel.greencode@gmail.com", "TRAVELpr2");
            client.Send("infotravel.greencode@gmail.com", c.Addressee, c.Subject, c.Content);

            return "Done... Send MAIL!";
        }

        private string sendSMSWithPHPService(TRV_SMS s)
        {
            try
            {
                String url = "http://ecolecua.me/alego/pr2-GreenCode/services/NEXMO/SendSMS.php?";
                url += "NUM=" + s.Telefono + "&MSG=" + s.Message;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream resStream = response.GetResponseStream();
                
                // Read Response Data
                /*
                WebHeaderCollection header = response.Headers;

                string responseText;
                var encoding = ASCIIEncoding.ASCII;
                using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                {
                    responseText = reader.ReadToEnd();
                }
                */
                return "Done... Send SMS";
            }
            catch (Exception ex)
            {
                // Se excecde el tiempo de espera de respuesta
                throw ex;
            }
        }

        private string sendSMSwithNativeCsharp(TRV_SMS s)
        {
            throw new NotImplementedException();
        }

    }
}
