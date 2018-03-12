using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_SERVICE.BO
{
    public class cls_AlumnoBO
    {
        private int idAlumno;
        private string nombre;
        private string aPaterno;
        private string aMaterno;
        private DateTime FechaNac;
        private int numero;
        private string imagen;
        private int grupo;
        private string usuario_FK;

        public int IdAlumno
        {
            get
            {
                return idAlumno;
            }

            set
            {
                idAlumno = value;
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

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
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

        public DateTime FechaNac1
        {
            get
            {
                return FechaNac;
            }

            set
            {
                FechaNac = value;
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
    }
}