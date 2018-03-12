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
    public class MenuController : Controller
    {
        cls_MenuBO bo = new cls_MenuBO();
        cls_MenuDAO dao = new cls_MenuDAO();
        CtrlMenu ctrl = new CtrlMenu();
        
        
      


        // GET: Menu
        public ActionResult Lista()
        {
            if (Session["UserName"] != null)
            {
                clsMenuModel clsMenuModels = new clsMenuModel();
                ctrl = new CtrlMenu();
                bo = new cls_MenuBO();
                bo.Id = 0;
                DataSet dsMenu = new DataSet();
                dsMenu = ctrl.consultarMenu(bo);
                DataTable tableMenu = dsMenu.Tables[0];
                List<cls_MenuBO> listamenu = new List<cls_MenuBO>();
                listamenu = (from DataRow dr in tableMenu.Rows
                             select new cls_MenuBO()
                             {
                                 Id = Convert.ToInt32(dr["ID"]),
                                 Lunes = dr["LUNES"].ToString(),
                                 Martes = dr["MARTES"].ToString(),
                                 Miercoles = dr["MIERCOLES"].ToString(),
                                 Jueves = dr["JUEVES"].ToString(),
                                 Viernes = dr["VIERNES"].ToString(),
                                 Usu_FK = dr["USUARIO"].ToString()
                             }).ToList();
                //TERMINAR ESTO .....................
                //clsMenuModel. = listamenu;
                //return View(clsMenuModel);

            }
            return RedirectToAction("Inicio", "Home");
        }
    }
}