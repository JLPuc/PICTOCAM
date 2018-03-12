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
                ClsEscuelaModel = VerEscuela();


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
        public JsonResult agregar(cls_EscuelaBO escuela)
        {
            //Se llena el objeto que recibe el ws
            clsEscuelaModel objEsculaModel = new clsEscuelaModel();
            objEsculaModel.Cls_EscuelaBO = new cls_EscuelaBO();
            objEsculaModel.Cls_EscuelaBO.ClaveEsc = escuela.ClaveEsc;
            objEsculaModel.Cls_EscuelaBO.Historia = escuela.Historia;
            objEsculaModel.Cls_EscuelaBO.Mision = escuela.Mision;
            objEsculaModel.Cls_EscuelaBO.Vision = escuela.Vision;
            objEsculaModel.Cls_EscuelaBO.Direccion = escuela.Direccion;
            objEsculaModel.Cls_EscuelaBO.Imagen = (string)(Session["Imagen"]);


            if (objEsculaModel.Cls_EscuelaBO.Imagen != null)
            {
                ctrl = new CtrLEscuela();
                int x = ctrl.AgregarEscuela(objEsculaModel.Cls_EscuelaBO);
                if (x == 1)
                    return Json("Los datos fueron  agregados correctamente.", JsonRequestBehavior.AllowGet);
                else
                    return Json("Error al agregar la información.", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Es necesario seleccionar una imagen.", JsonRequestBehavior.AllowGet);
            }

            
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

        public JsonResult ConsultarInformacion(cls_EscuelaBO escuela)
        {           

            return Json(VerEscuela(), JsonRequestBehavior.AllowGet);     
        }

        public clsEscuelaModel VerEscuela()
        {
            clsEscuelaModel ClsEscuelaModel = new clsEscuelaModel();
            ctrl = new CtrLEscuela();
            bo = new cls_EscuelaBO();
            bo.ClaveEsc = "";
            DataSet dsEscuela = new DataSet();
            dsEscuela = ctrl.ConsultarEscuela(bo);
            DataTable tableNoticias = dsEscuela.Tables[0];
            List<cls_EscuelaBO> listaEscuela = new List<cls_EscuelaBO>();
            listaEscuela = (from DataRow dr in tableNoticias.Rows
                            select new cls_EscuelaBO()
                            {
                                ClaveEsc = dr["CLAVE"].ToString(),
                                Historia = dr["HISTORIA"].ToString(),
                                Mision = dr["MISION"].ToString(),
                                Vision = dr["VISION"].ToString(),
                                Imagen = Convert.ToString("data:image/jpeg;base64," + dr["IMAGEN"]),
                                Direccion = dr["DIRECCION"].ToString(),
                                Usuario_FK = dr["USUARIO"].ToString()
                            }).ToList();
            ClsEscuelaModel.ListaEscuela = listaEscuela;
            return ClsEscuelaModel;
        }


        public ActionResult DetallesEscuela()
        {
            return View();
        }

        public ActionResult CargarImagenSesion(String ImagenCadena)
        {

            String[] Imagen = ImagenCadena.Split(',');
            Session["Imagen"] = Imagen[1];

            String imagen = (string)(Session["Imagen"]);


            return View();
        }
    }
}