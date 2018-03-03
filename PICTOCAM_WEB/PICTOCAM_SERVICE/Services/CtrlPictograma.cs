using PICTOCAM_SERVICE.BO;
using PICTOCAM_SERVICE.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PICTOCAM_SERVICE.Services
{
    public class CtrlPictograma
    {
        cls_PictogramaDAO pictogramaDAO;
        cls_Pictograma pictogramaBO;

        #region "Servicios para la web"
        //--------------Web--------------------------------
       


        #endregion

        #region "Servicios para el movil"
        //--------------Móvil--------------------------------
        public DataSet ver_Pictograma(object pictogramaBO)
        {
            pictogramaDAO = new cls_PictogramaDAO();
            return pictogramaDAO.ver_Pictograma(pictogramaBO);
        }


        #endregion

    }
}