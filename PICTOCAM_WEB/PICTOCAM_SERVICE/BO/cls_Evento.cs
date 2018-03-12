using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_WEB.Models
{
    public class cls_Evento
    {
        private int id;
        private string imagen;
        private string titulo;
        private string descripcion;
        private string contenido;
        private DateTime fecha;
        private DateTime hora;
        private int tipo;
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

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Contenido
        {
            get
            {
                return contenido;
            }

            set
            {
                contenido = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public DateTime Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
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