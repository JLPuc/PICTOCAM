using Newtonsoft.Json;
using PICTOCAM_SERVICE.BO;
using PICTOCAM_SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace PICTOCAM_SERVICE.UI
{
    /// <summary>
    /// Summary description for PictocamServicioWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PictocamServicioWeb : System.Web.Services.WebService
    {
        CtrlPictograma ctrlPictograma;

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void ver_Pictograma()
        {
            ctrlPictograma = new CtrlPictograma();


            cls_Pictograma pictogramaBO = new cls_Pictograma();
            DataSet dsPictograma = new DataSet();
            dsPictograma = ctrlPictograma.ver_Pictograma(pictogramaBO);
            DataTable dtPictograma = dsPictograma.Tables[0];

            FormatoJson(dtPictograma);
        }


        public void FormatoJson(DataTable dt)
        {
            //Salida a formato js
            string SalidaJson = string.Empty;
            SalidaJson = JsonConvert.SerializeObject(dt);

            HttpContext contexto = HttpContext.Current;
            contexto.Response.ContentType = "application/json";
            contexto.Response.Write(SalidaJson);
            contexto.Response.End();
        }
    }
}
