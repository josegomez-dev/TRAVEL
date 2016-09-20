
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class Tren : EntidadBase
    {
        public string CodTren { get; set; }
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string FechaCompra { get; set; }
        public decimal Costo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string CodLinea { get; set; }
        public int Kilometro { get; set; }
        //public Linea linea {get;set;} 
        public List<Vagon> listaVagones;

        public Tren() { }

        public Tren(string codTren,string modelo,string matricula,string nombre,string fechaCompra,decimal costo,string descripcion,string estado)
        {
            CodTren = codTren;
            Modelo = modelo;
            Matricula = matricula;
            Nombre = nombre;
            FechaCompra = fechaCompra;
            Costo = costo;
            Descripcion = descripcion;
            Estado = estado;
            listaVagones = null;
        }

        public void agregarLinea(string codLinea)
        {
            CodLinea = codLinea;
        }

        public bool iniciarTren()
        {
            if (CodLinea != null)
            {
                Estado = "Activo";
                return true;
            }
            return false;
        }
        public bool detenerTren()
        {
            if (CodLinea != null)
            {
                Estado = "Inactivo";
                return true;
            }
            return false;
        }

    }
}
