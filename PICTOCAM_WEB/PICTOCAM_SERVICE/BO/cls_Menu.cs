using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_WEB.Models
{
    public class cls_Menu
    {
        private int id;
        private string lunes;
        private string martes;
        private string miercoles;
        private string jueves;
        private string viernes;
        private DateTime fecha_ini;
        private DateTime fecha_fin;
        private int usuario;

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

        public string Lunes
        {
            get
            {
                return lunes;
            }

            set
            {
                lunes = value;
            }
        }

        public string Martes
        {
            get
            {
                return martes;
            }

            set
            {
                martes = value;
            }
        }

        public string Miercoles
        {
            get
            {
                return miercoles;
            }

            set
            {
                miercoles = value;
            }
        }

        public string Jueves
        {
            get
            {
                return jueves;
            }

            set
            {
                jueves = value;
            }
        }

        public string Viernes
        {
            get
            {
                return viernes;
            }

            set
            {
                viernes = value;
            }
        }

        public DateTime Fecha_ini
        {
            get
            {
                return fecha_ini;
            }

            set
            {
                fecha_ini = value;
            }
        }

        public DateTime Fecha_fin
        {
            get
            {
                return fecha_fin;
            }

            set
            {
                fecha_fin = value;
            }
        }

        public int Usuario
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