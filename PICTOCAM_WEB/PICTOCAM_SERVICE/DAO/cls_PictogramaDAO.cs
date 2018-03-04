using PICTOCAM_SERVICE.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PICTOCAM_SERVICE.DAO
{
    public class cls_PictogramaDAO
    {
        cls_ConexionDAO conn;

        public class PICTOGRAMACON
        {
           public static String ConsultaPrincipal        = "1";
            public static String ConsultaPictograma       = "2";
        }


        public DataSet ver_Pictograma_Con01(object obj)
        {
            cls_Pictograma pictogramaBO = (cls_Pictograma)obj;

            conn = new cls_ConexionDAO();
            String sql = "EXEC PICTOGRAMACON " + pictogramaBO.Id + "," + PICTOGRAMACON.ConsultaPrincipal;
            return conn.TablaDS(sql);
        }

        public DataSet ver_Pictograma_Con02(object obj)
        {
            cls_Pictograma pictogramaBO = (cls_Pictograma)obj;

            conn = new cls_ConexionDAO();
            String sql = "EXEC PICTOGRAMACON " + pictogramaBO.Id + "," + PICTOGRAMACON.ConsultaPictograma;
            return conn.TablaDS(sql);
        }

    }
}