using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROYECTO.Models;
using System.Net;

namespace PROYECTO.Controllers
{
    public class HomeController : Controller
    {
        PICTOCAMEntities1 db = new PICTOCAMEntities1();
        // GET: Home
        public void Sesion(string user)
        {
            Session["UserName"] = user;
        }

        public ActionResult Index(string user)
        {
            if (user != null)
            {
                Sesion(user);
            }
            
            var select =
                (from s in db.NOTICIAS
                 .Take(5)
                 .OrderByDescending(x => x.FECHA)
                 .OrderByDescending(x => x.HORA)
                 select s
                 );

            return View(select.ToList());
        }

        public ActionResult Noticias()
        {
            var select =
                (from s in db.NOTICIAS
                 .Take(5)
                 .OrderByDescending(x => x.FECHA)
                 select s
                 );

            return View(select.ToList());
        }

        public ActionResult NoticiasContent(int? id)
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

        public ActionResult Tips()
        {
            var select =
                (from s in db.TIPS
                 .Take(5)
                 .OrderByDescending(x => x.FECHA)
                 select s
                 );

            return View(select.ToList());
        }

        public ActionResult TipsContent(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPS tips = db.TIPS.Find(id);
            if (tips == null)
            {
                return HttpNotFound();
            }
            return View(tips);
        }

        public ActionResult Menu(DateTime? fecha)
        {
            if (fecha == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IEnumerable<MENU> menu;
            menu = db.MENU.Where(l => fecha >= l.FECHA_INI && fecha <= l.FECHA_FIN);
            if (menu == null)
            {
                return HttpNotFound();
            }
            return View(menu);
        }

        public ActionResult About()
        {
            return View(db.ESCUELA.ToList());
        }

        public ActionResult ubicacion()
        {
            return View();
        }
    }
}