using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PICTOCAM_WEB.Controllers
{
    public class EventoController : Controller
    {
        // GET: Evento
        public ActionResult Lista()
        {
            return View();
        }
    }
}