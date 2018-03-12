using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_SERVICE.BO
{
    public class cls_EscuelaBO
    {
        private string claveEsc;
        private string historia;
        private string mision;
        private string vision;
        private string imagen;
        private string direccion;
        private string usuario_FK;


        public string ClaveEsc
        {
            get
            {
                return claveEsc;
            }

            set
            {
                claveEsc = value;
            }
        }

        public string Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Mision
        {
            get
            {
                return mision;
            }

            set
            {
                mision = value;
            }
        }

        public string Vision
        {
            get
            {
                return vision;
            }

            set
            {
                vision = value;
            }
        }

        public string Historia
        {
            get
            {
                return historia;
            }

            set
            {
                historia = value;
            }
        }

        public string Usuario_FK
        {
            get
            {
                return usuario_FK;
            }

            set
            {
                usuario_FK = value;
            }
        }
    }
}