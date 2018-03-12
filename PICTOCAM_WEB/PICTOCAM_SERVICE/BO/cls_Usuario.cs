using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_WEB.Models
{
    public class cls_Usuario
    {
        private string correo;
        private string contraseNia;
        private string nombre;
        private string aPaterno;
        private string aMaterno;
        private string imagen;
        private int grupo;
        private int tipusu;

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string ContraseNia
        {
            get
            {
                return contraseNia;
            }

            set
            {
                contraseNia = value;
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

        public string APaterno
        {
            get
            {
                return aPaterno;
            }

            set
            {
                aPaterno = value;
            }
        }

        public string AMaterno
        {
            get
            {
                return aMaterno;
            }

            set
            {
                aMaterno = value;
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

        public int Grupo
        {
            get
            {
                return grupo;
            }

            set
            {
                grupo = value;
            }
        }

        public int Tipusu
        {
            get
            {
                return tipusu;
            }

            set
            {
                tipusu = value;
            }
        }
    }
}