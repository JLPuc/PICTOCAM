using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_SERVICE.BO
{
    public class cls_EventoBO
    {
        private int ID;
        private string IMAGEN;
        private string TITULO;
        private string DESCRIPCION;
        private string CONTENIDO;
        private DateTime FECHA;
        private TimeSpan HORA;
        private int TIPO;
        private string USUARIO;

        public int Id
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string Imagen
        {
            get
            {
                return IMAGEN;
            }

            set
            {
                IMAGEN = value;
            }
        }

        public string Titulo
        {
            get
            {
                return TITULO;
            }

            set
            {
                TITULO = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return DESCRIPCION;
            }

            set
            {
                DESCRIPCION = value;
            }
        }

        public string Contenido
        {
            get
            {
                return CONTENIDO;
            }

            set
            {
                CONTENIDO = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return FECHA;
            }

            set
            {
                FECHA = value;
            }
        }

        public TimeSpan Hora
        {
            get
            {
                return HORA;
            }

            set
            {
                HORA = value;
            }
        }

        public int Tipo
        {
            get
            {
                return TIPO;
            }

            set
            {
                TIPO = value;
            }
        }

        public string Usu_FK
        {
            get
            {
                return USUARIO;
            }

            set
            {
                USUARIO = value;
            }
        }
    }
}