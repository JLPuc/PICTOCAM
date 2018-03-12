using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PICTOCAM_SERVICE.DAO;

namespace PICTOCAM_SERVICE.Services
{
    public class CtrlEvento
    {
        cls_EventoDAO dao = new cls_EventoDAO();

        public int AgregarEvento(object obj)
        {
            dao = new DAO.cls_EventoDAO();
            return dao.AgregarEvento(obj);
        }

        public int ActualizarEvento(object obj)
        {
            dao = new DAO.cls_EventoDAO();
            return dao.ActualizarEvento(obj);
        }

        public int EliminarEvento(int obj)
        {
            dao = new DAO.cls_EventoDAO();
            return dao.EliminarEvento(obj);
        }

        public DataSet consultarEvento(object obj)
        {
            dao = new DAO.cls_EventoDAO();
            return dao.ConsutarEventos(obj);
        }
    }
}