//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROYECTO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MENU
    {
        public decimal ID_M { get; set; }
        public string LUNES { get; set; }
        public string MARTES { get; set; }
        public string MIERCOLES { get; set; }
        public string JUEVES { get; set; }
        public string VIERNES { get; set; }
        public Nullable<System.DateTime> FECHA_INI { get; set; }
        public Nullable<System.DateTime> FECHA_FIN { get; set; }
        public string USER1 { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
    }
}
