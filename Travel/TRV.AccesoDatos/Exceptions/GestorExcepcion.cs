using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.Entidades;

namespace TRV.AccesoDatos.Exceptions
{
    public class GestorExcepcion
    {
        private static GestorExcepcion _instance;

        public GestorExcepcion() { }

        public static GestorExcepcion GetInstance()
        {
            return _instance ?? (_instance = new GestorExcepcion());
        }

        public TRV_Exception ControlarExcepcion(Exception pex)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\TRAVEL\Log_Exceptions.txt", true))
            {
                file.WriteLine("--------------");
                file.WriteLine("Hora: " + DateTime.Now.ToString("h:mm:ss tt"));
                file.WriteLine("Fecha: " + DateTime.Now.ToString("M/d/yyyy"));
                file.WriteLine("Excepcion: " + pex.Message);
                file.WriteLine("--------------");
            }

            return default(TRV_Exception);
        }

    }
}
