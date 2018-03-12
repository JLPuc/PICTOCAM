using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_SERVICE.BO
{
    public class cls_MetodologiaBO
    {
        private int id;
        private string nombre;
        private string descripcion;
        private string escuela_FK;

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

        public string Escuela_FK
        {
            get
            {
                return escuela_FK;
            }

            set
            {
                escuela_FK = value;
            }
        }
    }
}