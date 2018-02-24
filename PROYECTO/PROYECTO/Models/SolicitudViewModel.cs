using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTO.Models
{
    public class SolicitudViewModel
    {
        public NOTICIAS noticias { get; set; }
        public TIPS tip { get; set; }
        public MENU menu { get; set; }
    }
}