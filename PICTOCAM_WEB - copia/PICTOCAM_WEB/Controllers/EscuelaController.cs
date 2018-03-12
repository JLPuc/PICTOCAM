using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data;
using PICTOCAM_SERVICE.BO;
using PICTOCAM_SERVICE.DAO;
using PICTOCAM_SERVICE.Services;

namespace PICTOCAM_WEB.Controllers
{
    [Authorize]
    public class EscuelaController : Controller
    {

        cls_EscuelaBO bo = new cls_EscuelaBO();
        Cls_EscuelaDAO dao = new Cls_EscuelaDAO();
        CtrLEscuela ctrl = new CtrLEscuela();
        // GET: Escuela
        public ActionResult Detalles()
        {
            if (Session["UserName"] != null)
            {

                clsEscuelaModel ClsEscuelaModel = new clsEscuelaModel();
                ctrl = new CtrLEscuela();
                bo = new cls_EscuelaBO();
                bo.ClaveEsc = "";
                DataSet dsEscuela = new DataSet();
                dsEscuela = ctrl.ConsultarEscuela(bo);
                DataTable tableNoticias = dsEscuela.Tables[0];
                List<cls_EscuelaBO> listaEscuela = new List<cls_EscuelaBO>();
                listaEscuela= (from DataRow dr in tableNoticias.Rows
                               select new cls_EscuelaBO()
                               {
                                     ClaveEsc= dr["CLAVE"].ToString(),
                                   Historia = dr["HISTORIA"].ToString(),
                                   Mision = dr["MISION"].ToString(),
                                   Vision = dr["VISION"].ToString(),
                                   Imagen = Convert.ToString(dr["IMAGEN"]),
                                   Direccion = dr["DIRECCION"].ToString(),
                                   Usuario_FK = dr["USUARIO"].ToString()
                               }).ToList();
                ClsEscuelaModel.ListaEscuela = listaEscuela;
                return View(ClsEscuelaModel);
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
        public ActionResult agregar(clsEventosModel escuela)
        {
            ctrl = new CtrLEscuela();
            int x = ctrl.AgregarEscuela(escuela);
            return RedirectToAction("Lista", "Escuela");
        }

        public JsonResult cargar(string Clave)
        {
            var datosUser = dao.lista().Find(x => x.ClaveEsc.Equals(Clave));
            return Json(datosUser, JsonRequestBehavior.AllowGet);
        }


        public JsonResult Eliminar(string Clave)
        {
            ctrl = new CtrLEscuela();
            ctrl.EliminarEscuela(Clave);
            return Json("Los datos fueron  eliminados correctamente.", JsonRequestBehavior.AllowGet);
        }




        public ActionResult DetallesEscuela()
        {
            return View();
        }
    }
}