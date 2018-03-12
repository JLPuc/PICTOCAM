using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PICTOCAM_SERVICE.BO
{
    public class clsMenuModel
    {
        private cls_MenuBO cls_MenuBo;
        private List<cls_MenuBO> listaMenu;

        public cls_MenuBO Cls_MenuBo
        {
            get
            {
                return cls_MenuBo;
            }

            set
            {
                cls_MenuBo = value;
            }
        }

        public List<cls_MenuBO> ListaMenu
        {
            get
            {
                return listaMenu;
            }

            set
            {
                listaMenu = value;
            }
        }
    }
}