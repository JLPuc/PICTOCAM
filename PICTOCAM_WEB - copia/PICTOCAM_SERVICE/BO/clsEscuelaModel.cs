using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PICTOCAM_SERVICE.BO;

namespace PICTOCAM_SERVICE.BO
{
    public class clsEscuelaModel
    {
        private cls_EscuelaBO cls_EscuelaBO;
        private List<cls_EscuelaBO> listaEscuela;

        public cls_EscuelaBO Cls_EscuelaBO
        {
            get
            {
                return cls_EscuelaBO;
            }

            set
            {
                cls_EscuelaBO = value;
            }
        }

        public List<cls_EscuelaBO> ListaEscuela
        {
            get
            {
                return listaEscuela;
            }

            set
            {
                listaEscuela = value;
            }
        }
    }
}