using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRV.Entidades;

namespace TRV.Entidades
{
    public class Linea : EntidadBase
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public int Distancia { get; set; }
        public string Estado { get; set; }
        public int EstacionInicial { get; set; }
        public int EstacionFinal { get; set; }
        public int HoraTrabajo { get; set; }
        public string HoraInicio { get; set; }
        public decimal CostoCirculacion { get; set; }
        public int CodCentral { get; set; }
        public int DuracionRecorrido { get; set; }

        public Linea()
        {

        }

        public Linea(string codigo, string nombre, string color, int distancia, string estado,
            int estacionInicial, int estacionFinal, int horaTrabajo, string horaInicio, 
            decimal costoCirculacion, int codCentral, int duracionRecorrido)
        {
            Codigo = codigo;
            Nombre = nombre;
            Color = color;
            Distancia = distancia;
            Estado = estado;
            EstacionInicial = estacionInicial;
            EstacionFinal = estacionFinal;
            HoraTrabajo = horaTrabajo;
            HoraInicio = horaInicio;
            CostoCirculacion = costoCirculacion;
            CodCentral = codCentral;
            DuracionRecorrido = duracionRecorrido;
        }
    }
}
