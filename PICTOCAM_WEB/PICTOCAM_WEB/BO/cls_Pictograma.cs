using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_WEB.Models
{
    public class cls_Pictograma
    {
        private int id;
        private string ruta;
        private string nombre;
        private string sonido;
        private string usuario;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Ruta
        {
            get
            {
                return ruta;
            }

            set
            {
                ruta = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Sonido
        {
            get
            {
                return sonido;
            }

            set
            {
                sonido = value;
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