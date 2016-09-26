using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSecurityDemo.Controllers
{
    [ValidateInput(false)]
    public class XSS2Controller : Controller
    {
        // GET: XSS
        public ActionResult Index(string id)
        {
            var myComp = new MyComp(id);
            return Json(myComp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index2(string id)
        {
            var myComp = new MyComp(id);
           
            var settings = new JsonSerializerSettings();
            settings.StringEscapeHandling = StringEscapeHandling.EscapeHtml;
            var output = JsonConvert.SerializeObject(myComp, settings);
            return this.Content(output, "application/json");
        }

        public ActionResult Index3(string id)
        {
            var myComp = new MyComp(id);
            return Json(myComp, JsonRequestBehavior.AllowGet);
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult PostTest(string compId)
        {
            var myComp = new MyComp(compId);
            //return Json(myComp, JsonRequestBehavior.AllowGet);

            //http://stackoverflow.com/questions/10756232/json-net-serializeobject-escape-values-to-prevent-xss
            var settings = new JsonSerializerSettings();
            settings.StringEscapeHandling = StringEscapeHandling.EscapeHtml;
            var output = JsonConvert.SerializeObject(myComp, settings);
            return Json(myComp, JsonRequestBehavior.AllowGet);
        }
    }

    public class MyComp
    {
        public string CompanyId { get; set; }
        public MyComp(string compId)
        {
            //CompanyId = $"<script>compId:{compId}";
            CompanyId = compId;
        }
    }
}