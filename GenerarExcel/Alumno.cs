using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarExcel
{
    class Alumno
    {
        public string DOC { get; set; }
        public string CURSO { get; set; }
        public string DIV { get; set; }
        public string REPITE { get; set; }
        public string ORDEN { get; set; }
        public string NOMBRE { get; set; }        
        public string FECNAC { get; set; }
        public string LIBRO { get; set; }
        public string FOLIO { get; set; }
        public string LEG1 { get; set; }
        public string ANIO { get; set; }
        public string DOMICILIO { get; set; }
        public string DEPAR { get; set; }
        public string TELEFONO { get; set; }
        public string PROMEDIO { get; set; }






        public string FullInfo
        {
            get { return $"{DOC} {CURSO} {DIV} {REPITE} {ORDEN} {NOMBRE} {FECNAC} {LIBRO} {FOLIO} {LEG1} {ANIO} {DOMICILIO} {DEPAR} {TELEFONO} {PROMEDIO}"; }
        }

    }
}
