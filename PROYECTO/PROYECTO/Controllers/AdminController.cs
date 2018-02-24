using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROYECTO.Models;
using System.IO;
using System.Net;
using System.Data.Entity;
using CrystalDecisions.CrystalReports.Engine;

namespace PROYECTO.Controllers
{
    public class AdminController : Controller
    {
        PICTOCAMEntities1 db = new PICTOCAMEntities1();
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            return Redirect("/Admin/Login");
        }
        public ActionResult Salir()
        {
            Session.Remove("UserName");
            return Redirect("/Home/Index");
        }
        public ActionResult VerMasNoticias()
        {
            return View(db.NOTICIAS.ToList());
        }

        //Empieza la sección de Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(USUARIO login)
        {
            if (ModelState.IsValid)
            {
                //PICTOCAMEntities db = new PICTOCAMEntities();
                var user = (from userlist in db.USUARIO
                            where userlist.CORREO == login.CORREO && userlist.CONTRASEÑA == login.CONTRASEÑA && userlist.CORREO
                            == "Admin"
                            select new
                            {
                                userlist.CORREO
                            }).ToList();
                if (user.FirstOrDefault() != null)
                {
                    Session["UserName"] = user.FirstOrDefault().CORREO;
                    Session["UserID"] = user.FirstOrDefault().CORREO;
                    return Redirect("/Admin/Index");
                }
                else
                {
                    ViewBag.MensajeError = "Correo y/o contraseña Incorrectos";
                    return View();
                }
            }
            return View(login);
        }

        
        //Termina la sección de Login

        //Empieza la seccion de noticias

        //Index Noticias
        public ActionResult Noticias()
        {
            if (Session["UserName"] != null)
            {
                return View(db.NOTICIAS.ToList());
            }
            return Redirect("/Admin/Login");
        }
        //Agregar Noticia
        public ActionResult NoticiasAdd()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            return Redirect("/Admin/Login");
        }
        [HttpPost]
        public ActionResult NoticiasAdd([Bind(Include = "TITULO, DESCRIPCION, CONTENIDO") ]NOTICIAS noti, HttpPostedFileBase file)
        {
            if (file != null)
            {
                if (file.ContentType == "image/jpg" || file.ContentType == "image/png" || file.ContentType == "image/jpeg")
                {
                    var filename = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Pictures/"), filename);
                    file.SaveAs(path);

                    noti.IMAGEN = "/Pictures/" + filename;
                }
                else
                {
                    return View();
                }
                
                noti.FECHA = DateTime.Now.Date;
                noti.USER1 = Session["UserName"].ToString();
                noti.HORA = DateTime.Now.TimeOfDay;
                db.NOTICIAS.Add(noti);
                db.SaveChanges();
                ViewBag.Mensaje = "Noticia Guardada con éxito";
                return RedirectToAction("Noticias","Admin");
                
            }
            else
            {
                ViewBag.Mensaje = "La Noticia no ha podido guardarse";
                return View();
            } 
        }
        public ActionResult EliminarNoticia(int? id)
        {
            using (var entidad = new PICTOCAMEntities1())
            {
                var objTips = (from t in entidad.NOTICIAS
                               where t.ID_N == id
                               select t).FirstOrDefault();
                entidad.NOTICIAS.Remove(objTips);
                entidad.SaveChanges();
                return RedirectToAction("Noticias", "Admin");
            }
        }
        //Editar Noticia
        public ActionResult NoticiasUpdate(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NOTICIAS noti = db.NOTICIAS.Find(id);
            if (noti == null)
            {
                return HttpNotFound();
            }
            return View(noti);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NoticiasUpdate([Bind(Include = "ID_N,TITULO,DESCRIPCION,CONTENIDO,IMAGEN")] NOTICIAS noti)
        {
            if (ModelState.IsValid)
            {
                noti.USER1 = Session["UserName"].ToString();
                noti.HORA = DateTime.Now.TimeOfDay;
                noti.FECHA = DateTime.Now.Date;
                db.Entry(noti).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Noticias", "Admin");
            }
            return View(noti);
        }


        //Termina la seccion de noticias

        //Inicia sección maestros

        public ActionResult Maestros()
        {
            if (Session["UserName"] != null)
            {
                return View(db.USUARIO.ToList());
            }
            return Redirect("/Admin/Login");
        }

        public ActionResult MaestrosAdd()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            return Redirect("/Admin/Login");
        }

        [HttpPost]
        public ActionResult MaestrosAdd([Bind(Include = "CORREO, CONTRASEÑA, NOMBRES, APATERNO, AMATERNO, TELEFONO, IMAGEN, TIPO_USUARIO")]USUARIO USUARIO, HttpPostedFileBase file)
        {
            if (file != null)
            {
                if (file.ContentType == "image/jpg" || file.ContentType == "image/png" || file.ContentType == "image/jpeg")
                {
                    var filename = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Pictures/"), filename);
                    file.SaveAs(path);

                    USUARIO.IMAGEN = "/Pictures/" + filename;
                }
                else
                {
                    return View();
                }
                USUARIO.TIPO_USUARIO = "Maestro";
                db.USUARIO.Add(USUARIO);
                db.SaveChanges();
                ViewBag.Mensaje = "Maestro agregado con éxito";
                return RedirectToAction("Maestros", "Admin");

            }
            else
            {
                ViewBag.Mensaje = "Los datos del maestro no han podido guardarse";
                return View();
            }
        }

        //Termina sección maestros

        //Inicia Sección de Tips
        public ActionResult Tips()
        {
            if (Session["UserName"] != null)
            {
                return View(db.TIPS.ToList());
            }
            return Redirect("/Admin/Login");

            
        }
        public ActionResult TipsAdd()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            return Redirect("/Admin/Login");
        }
        [HttpPost]
        public ActionResult TipsAdd([Bind(Include = "TITULO, DESCRIPCION, CONTENIDO")]TIPS tips, HttpPostedFileBase file)
        {
            if (file != null)
            {
                var filename = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Pictures/"), filename);
                file.SaveAs(path);

                tips.IMAGEN = "/Pictures/" + filename;
                tips.FECHA = DateTime.Now.Date;
                tips.USER1 = Session["UserName"].ToString();
                tips.HORA = DateTime.Now.TimeOfDay;
                db.TIPS.Add(tips);
                db.SaveChanges();
                return RedirectToAction("Tips", "Admin");
            }
            else
            {
                ViewBag.Mensaje = "No se ha podido guardar";
                return View();
            }
        }
        public ActionResult Eliminar(int? id)
        {
            using (var entidad = new PICTOCAMEntities1())
            {
                var objTips = (from t in entidad.TIPS
                               where t.ID_T == id
                               select t).FirstOrDefault();
                entidad.TIPS.Remove(objTips);
                entidad.SaveChanges();
                return RedirectToAction("Tips", "Admin");
            }
        }

        public ActionResult TipsEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPS tip = db.TIPS.Find(id);
            if (tip == null)
            {
                return HttpNotFound();
            }
            return View(tip);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TipsEdit([Bind(Include = "ID_T,TITULO,DESCRIPCION,CONTENIDO,IMAGEN")] TIPS tip)
        {
            if (ModelState.IsValid)
            {
                tip.USER1 = Session["UserName"].ToString();
                tip.HORA = DateTime.Now.TimeOfDay;
                tip.FECHA = DateTime.Now.Date;
                db.Entry(tip).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Tips", "Admin");
            }
            return View(tip);
        }

        //Termina Sección Tips

        //Inicia Sección Menú

        public ActionResult Menu()
        {
            if (Session["UserName"] != null)
            {
                return View(db.MENU.ToList());
            }
            return Redirect("/Admin/Login");
        }

        //Agregar Menu

        public ActionResult MenuAdd()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            return Redirect("/Admin/Login");
        }
        [HttpPost]
        public ActionResult MenuAdd([Bind(Include = "LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, FECHA_INI, FECHA_FIN")]MENU menuu, HttpPostedFileBase file)
        {   
                menuu.USER1 = Session["UserName"].ToString();
                db.MENU.Add(menuu);
                db.SaveChanges();
                ViewBag.Mensaje = "Menu Guardado con éxito";
                return RedirectToAction("Menu", "Admin"); 
        }

        //Editar Menu
        public ActionResult MenuUpdate(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MENU menu = db.MENU.Find(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            return View(menu);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MenuUpdate([Bind(Include = "LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, FECHA_INI, FECHA_FIN")] MENU menu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Menu", "Admin");
            }
            return View(menu);
        }

        //Eliminar menú

        public ActionResult EliminarMenu(int? id)
        {
            using (var entidad = new PICTOCAMEntities1())
            {
                var objTips = (from t in entidad.MENU
                               where t.ID_M == id
                               select t).FirstOrDefault();
                entidad.MENU.Remove(objTips);
                entidad.SaveChanges();
                return RedirectToAction("Menu", "Admin");
            }
        }

        //Termina la sección de menú

        //Empieza la sección de la escuela

        public ActionResult Escuela()
        {
            if (Session["UserName"] != null)
            {
                return View(db.ESCUELA.ToList());
            }
            return Redirect("/Admin/Login");
            
        }

        public ActionResult EscuelaUpdate(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESCUELA esc = db.ESCUELA.Find(id);
            if (esc == null)
            {
                return HttpNotFound();
            }
            return View(esc);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EscuelaUpdate([Bind(Include = "IMAGEN, DIRECCION, VISION, MISION, HISTORIA, ID_E")] ESCUELA esc)
        {
            if (ModelState.IsValid)
            {
                esc.USER1 = Session["UserName"].ToString();
                db.Entry(esc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Escuela", "Admin");
            }
            return View(esc);
        }

        public ActionResult ExportReporte(int id ,MENU menus)
        {

            var menu = db.MENU.Where(x => x.ID_M == id).ToList();
            //List<MENU> allCustomer = new List<MENU>();
            //allCustomer = db.MENU.ToList();
            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/CrystalReports"), "Reporte.rpt"));
            rd.Database.Tables[0].SetDataSource(menu);    
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);
            return File(stream, "application/pdf", (/*Convert.ToString(string.Format("{0:dd MMM yy}", menus.FECHA_INI + */"MenuDeLaSemana.pdf"))/*)))*/;
        }

    }
}