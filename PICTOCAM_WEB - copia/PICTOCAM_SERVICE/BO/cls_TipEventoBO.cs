using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_SERVICE.BO
{
    public class cls_TipEventoBO
    {
        private int id;
        private string nombre;

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
    }
}