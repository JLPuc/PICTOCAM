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

        /*
         *Lista de todos los pictogramas
        */
        public DataSet ver_Pictogramas(object pictogramaBO)
        {
            pictogramaDAO = new cls_PictogramaDAO();
            return pictogramaDAO.ver_Pictograma_Con01(pictogramaBO);
        }

        /*
         *Retorna un pictograma
        */
        public DataSet ver_Pictograma(object pictogramaBO)
        {
            pictogramaDAO = new cls_PictogramaDAO();
            return pictogramaDAO.ver_Pictograma_Con02(pictogramaBO);
        }






    }
}