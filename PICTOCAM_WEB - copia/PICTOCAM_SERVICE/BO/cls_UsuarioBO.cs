using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_SERVICE.BO
{
    public class cls_UsuarioBO
    {
        private string correo;
        private string contrasenia;
        private string nombre;
        private string apaterno;
        private string amaterno;
        private string imagen;
        private int grupo_FK;
        private int tipo_FK;

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

        public string Contrasenia
        {
            get
            {
                return contrasenia;
            }

            set
            {
                contrasenia = value;
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

        public string Apaterno
        {
            get
            {
                return apaterno;
            }

            set
            {
                apaterno = value;
            }
        }

        public string Amaterno
        {
            get
            {
                return amaterno;
            }

            set
            {
                amaterno = value;
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

        public int Grupo_FK
        {
            get
            {
                return grupo_FK;
            }

            set
            {
                grupo_FK = value;
            }
        }

        public int Tipo_FK
        {
            get
            {
                return tipo_FK;
            }

            set
            {
                tipo_FK = value;
            }
        }
    }
}