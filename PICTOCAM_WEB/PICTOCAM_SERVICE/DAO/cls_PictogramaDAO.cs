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

        public DataSet ver_Pictograma(object obj)
        {
            cls_Pictograma pictogramaBO = (cls_Pictograma)obj;

            conn = new cls_ConexionDAO();
            String sql = "EXEC PICTOGRAMACON "+pictogramaBO.Id;
            return conn.TablaDS(sql);
        }

    }
}