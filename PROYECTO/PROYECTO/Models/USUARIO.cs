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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.ALUMNO = new HashSet<ALUMNO>();
            this.GRUPO = new HashSet<GRUPO>();
            this.MENU = new HashSet<MENU>();
            this.PICTOGRAMA = new HashSet<PICTOGRAMA>();
            this.TIPS = new HashSet<TIPS>();
            this.ESCUELA = new HashSet<ESCUELA>();
            this.NOTICIAS = new HashSet<NOTICIAS>();
        }
    
        public string CORREO { get; set; }
        public string CONTRASEÑA { get; set; }
        public string NOMBRES { get; set; }
        public string APATERNO { get; set; }
        public string AMATERNO { get; set; }
        public string IMAGEN { get; set; }
        public Nullable<decimal> TELEFONO { get; set; }
        public string TIPO_USUARIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALUMNO> ALUMNO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUPO> GRUPO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MENU> MENU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PICTOGRAMA> PICTOGRAMA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIPS> TIPS { get; set; }
        public virtual TIPUSU TIPUSU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESCUELA> ESCUELA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTICIAS> NOTICIAS { get; set; }
    }
}
