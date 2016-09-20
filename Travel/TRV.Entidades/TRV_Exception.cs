using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.Entidades
{
    public class TRV_Exception : Exception
    {
        public string Mensaje { get; set; }

        public enum ExceptionCode
        {
            CorreoNotMatch,
            CedulaEnBlanco,
            ColorLineaRepetido,
            ContrasenaNotMatch,
            Fatal,
            MatriculaTrenNoEncontrado,
            MatriculaTrenRepetido,
            NoData,
            NombreEstacionRepetido,
            NombreLineaRepetido,
            TrenNotAsocLinea,
            CorreoNotExist,
            PuestoConPermiso,
            PermisosConPuesto,
            CedulaDuplicada,
            PermisoYaIngreso
        }

        public ExceptionCode Codigo { get; set; }
        public string Msj { get; set; }

        public TRV_Exception(ExceptionCode code)
        {
            Codigo = code;
        }
        public TRV_Exception(Exception ex)
        {
            Codigo = ExceptionCode.Fatal;
        }

    }
}
