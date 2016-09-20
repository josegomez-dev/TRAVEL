using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class Tiquete : EntidadBase
    {
        public int Id { get; set; }
        public string NumAsiento { get; set; }
        public string Salida { get; set; }
        public string Arrivo { get; set; }
        public TipoTiquete Tipo { get; set; }

        public Tiquete()
        {
        }

        public Tiquete(int pid, string pnumAsiento, string psalida, string parrivo, TipoTiquete ptipo)
        {
            Id = pid;
            NumAsiento = pnumAsiento;
            Salida = psalida;
            Arrivo = parrivo;
            Tipo = ptipo;
        }
    }
}
