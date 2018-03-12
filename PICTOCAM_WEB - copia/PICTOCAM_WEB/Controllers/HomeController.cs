using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PICTOCAM_WEB.Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using PICTOCAM_SERVICE.BO;

namespace PICTOCAM_WEB.Controllers
{
    public class HomeController : Controller
    {
        cls_UsuarioBO usu = new cls_UsuarioBO();
        cls_conexion con = new cls_conexion();
        // GET: Home
        public ActionResult Inicio()
        {
            return View();
        }
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(cls_UsuarioBO usuario)
        {
            try
            {
                
                string commandText = "SELECT NOMBRE FROM USUARIO WHERE CORREO=@Username AND CONTRASENIA = @Password";
                using (var command = new SqlCommand(commandText, con.conexionBD()))
                {
                    command.Parameters.AddWithValue("@Username", usuario.Correo);
                    command.Parameters.AddWithValue("@Password", usuario.Contrasenia);
                    con.abrirCon();

                    string userName = (string)command.ExecuteScalar();

                    if (!String.IsNullOrEmpty(userName))
                    {
                        Session["UserName"] = userName;
                        System.Web.Security.FormsAuthentication.SetAuthCookie(usuario.Correo, false);
                        return RedirectToAction("Lista", "Evento");
                    }

                    TempData["Mensaje"] = "Login failed.User name or password supplied doesn't exist.";

                    con.cerrarCon();
                }

            }
            catch (Exception ex)
            {
                TempData["Mensaje"] = "Login failed.Error - " + ex.Message;
            }
            return RedirectToAction("/Inicio");
        }
        
    }
}