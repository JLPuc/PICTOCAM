using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_SERVICE.BO
{
    public class clsEventosModel
    {
        private cls_EventoBO cls_EventoBo;
        private List<cls_EventoBO> listaEvento;

        public cls_EventoBO Cls_EventoBo
        {
            get
            {
                return cls_EventoBo;
            }

            set
            {
                cls_EventoBo = value;
            }
        }

        public List<cls_EventoBO> ListaEvento
        {
            get
            {
                return listaEvento;
            }

            set
            {
                listaEvento = value;
            }
        }
    }
}