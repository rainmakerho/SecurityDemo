using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSecurityDemo.Models;

namespace WebSecurityDemo.Controllers
{
    public class XSSController : Controller
    {
        // GET: XSS
        public ActionResult T1P1(string id)
        {
            var myProduct = new Product1(id);
            return Json(myProduct, JsonRequestBehavior.AllowGet);
        }

        public ActionResult T2P1(string id)
        {
            var myProduct = new Product1(id);
            var settings = new JsonSerializerSettings();
            settings.StringEscapeHandling = StringEscapeHandling.EscapeHtml;
            var encodeJsonString = JsonConvert.SerializeObject(myProduct, settings);
            return this.Content(encodeJsonString, "application/json");
        }

        public ActionResult T3P2(string id)
        {
            var myProduct = new Product2(id);
            return Json(myProduct, JsonRequestBehavior.AllowGet);
        }
    }
}