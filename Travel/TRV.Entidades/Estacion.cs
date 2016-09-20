using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.Entidades;

namespace TRV.Entidades
{
    public class Estacion : EntidadBase
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public int Central { get; set; }
        public int Kilometro { get; set; }

        public Estacion()
        {

        }

        public Estacion(string codigo, string nombre, string estado, decimal latitud, 
                        decimal longitud, int central, int kilometro)
        {
            Codigo = codigo;
            Nombre = nombre;
            Estado = estado;
            Latitud = latitud;
            Longitud = longitud;
            Central = central;
            Kilometro = kilometro;
        }
    }
}
