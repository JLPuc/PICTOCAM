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
    
    public partial class PALABRA_IMAGEN
    {
        public decimal ID { get; set; }
        public string PALABRA { get; set; }
        public string SONIDO { get; set; }
        public decimal PICTO { get; set; }
    
        public virtual PICTOGRAMA PICTOGRAMA { get; set; }
    }
}
