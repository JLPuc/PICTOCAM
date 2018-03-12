using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PICTOCAM_SERVICE.DAO;

namespace PICTOCAM_SERVICE.Services
{
    public class CtrLEscuela
    {

        Cls_EscuelaDAO dao = new Cls_EscuelaDAO();
        public int AgregarEscuela(object obj)
        {
            dao = new DAO.Cls_EscuelaDAO();
            return dao.AgregarEscuela(obj);
        }
        public int ActualizarEscuela(object obj)
        {
            dao = new DAO.Cls_EscuelaDAO();
            return dao.ActualizarEscuela(obj);
        }

        public int EliminarEscuela(object obj)
        {
            dao = new DAO.Cls_EscuelaDAO();
            return dao.EliminarEscuela(obj);
        }

        public DataSet ConsultarEscuela(object obj)
        {
            dao = new DAO.Cls_EscuelaDAO();
            return dao.ConsultarInformacioEscuela(obj);
        }

    }
}