using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_WEB.Models
{
    public class cls_Alumno
    {
        private int id;
        private string nombre;
        private string aPaterno;
        private string aMaterno;
        private DateTime fecha_nac;
        private int telefono;
        private string foto;
        private string usuario;
        private int grupo;

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

        public string APaerno
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

        public DateTime Fecha_nac
        {
            get
            {
                return fecha_nac;
            }

            set
            {
                fecha_nac = value;
            }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
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