using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_WEB.Models
{
    public class cls_Escuela
    {
        private string clave;
        private string historia;
        private string mision;
        private string vision;
        private string imagen;
        private string direccion;
        private string usuario;

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
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

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }
    }
}