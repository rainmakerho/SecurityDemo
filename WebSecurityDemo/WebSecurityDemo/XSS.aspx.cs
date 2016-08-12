using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSecurityDemo.Models;

namespace WebSecurityDemo
{
    public partial class XSS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request["id"] ?? "";
            var p1 = new Product1(id);
            var settings = new JsonSerializerSettings();
            settings.StringEscapeHandling = StringEscapeHandling.EscapeHtml;
            var encodeJsonString = JsonConvert.SerializeObject(p1);
            Response.Write($"P1:{encodeJsonString}");
        }
    }
}