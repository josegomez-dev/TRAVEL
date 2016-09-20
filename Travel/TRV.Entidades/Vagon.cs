
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class Vagon : EntidadBase
    {
        public int IdVagon { get; set; }
        public int CantAsientos { get; set; }
        public int IdTren { get; set; }
        public List<Asiento> listaAsientos { get; set; }

        public Vagon() { }

        public Vagon(int idVagon, int cantAsientos, int idTren)
        {
            IdVagon = idVagon;
            CantAsientos = cantAsientos;
            IdTren = idTren;
        }

        public void crearAsientos()
        {

            listaAsientos = new List<Asiento>();

            for (int i = 0; i < CantAsientos; i++)
            {
                Asiento a = new Asiento
                {
                   IdVagon = IdVagon,
                   Tipo = "Adulto"
                };
                listaAsientos.Add(a);
            }

        }
    }
}
