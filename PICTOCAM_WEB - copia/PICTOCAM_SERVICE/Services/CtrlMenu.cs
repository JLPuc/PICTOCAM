using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PICTOCAM_SERVICE.DAO;
using System.Data;

namespace PICTOCAM_SERVICE.Services
{
    public class CtrlMenu
    {
        cls_MenuDAO dao = new cls_MenuDAO();

        public int AgregarMenu(object obj)
        {
            dao = new DAO.cls_MenuDAO();
            return dao.AgregarMenu(obj);
        }

        public int ActualizarMenu(object obj)
        {
            dao = new DAO.cls_MenuDAO();
            return dao.ActualizarMenu(obj);
        }

        public int EliminarMenu(int obj)
        {
            dao = new DAO.cls_MenuDAO();
            return dao.EliminarMenu(obj);

        }
        public DataSet consultarMenu(object obj)
        {
            dao = new DAO.cls_MenuDAO();
            return dao.ConsutarMenu(obj);
        }
    }
}