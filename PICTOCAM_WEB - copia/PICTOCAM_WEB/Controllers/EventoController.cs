using PICTOCAM_SERVICE.BO;
using PICTOCAM_SERVICE.DAO;
using PICTOCAM_SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data;

namespace PICTOCAM_WEB.Controllers
{
    [Authorize]
    public class EventoController : Controller
    {
        cls_EventoBO bo = new cls_EventoBO();
        cls_EventoDAO dao = new cls_EventoDAO();
        CtrlEvento ctrl = new CtrlEvento();

        // GET: Evento
        [AllowAnonymous]
        public ActionResult Lista()
        {
            if (Session["UserName"] != null)
            {
                clsEventosModel ClsEventosModel = new clsEventosModel();
                ctrl = new CtrlEvento();
                bo = new cls_EventoBO();
                bo.Id = 0;
                DataSet dsEvento = new DataSet();
                dsEvento = ctrl.consultarEvento(bo);
                DataTable tableNoticias = dsEvento.Tables[0];
                List<cls_EventoBO> listaNoticia = new List<cls_EventoBO>();
                listaNoticia = (from DataRow dr in tableNoticias.Rows
                                select new cls_EventoBO()
                                {
                                    Id = Convert.ToInt32(dr["ID"]),
                                    Imagen = Convert.ToString(dr["IMAGEN"]),
                                    Titulo = dr["TITULO"].ToString(),
                                    Descripcion = dr["DESCRIPCION"].ToString(),
                                    Contenido = dr["CONTENIDO"].ToString(),
                                    Tipo = Convert.ToInt32(dr["TIPO"]),
                                    Usu_FK = dr["USUARIO"].ToString()
                                }).ToList();
                ClsEventosModel.ListaEvento = listaNoticia;
                return View(ClsEventosModel);
            }
            return RedirectToAction("Inicio", "Home");
        }

        [AllowAnonymous]
        public ActionResult Logout()
        {
            Session.Remove("UserName");
            FormsAuthentication.SignOut();
            return RedirectToAction("Inicio", "Home");
        }

        public ActionResult agregar(clsEventosModel evento)
        {
            ctrl = new CtrlEvento();
            int x = ctrl.AgregarEvento(evento);
            return RedirectToAction("Lista", "Evento");
        }

        public JsonResult cargar(int ID)
        {
            var datosUser = dao.lista().Find(x => x.Id.Equals(ID));
            //var datosUser = oUsus.obtener_Usuario(ID);
            return Json(datosUser, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Eliminar(int id)
        {

            ctrl = new CtrlEvento();
            ctrl.EliminarEvento(id);
            return Json("Datos eliminados correctamente.", JsonRequestBehavior.AllowGet);
        }


    }
}