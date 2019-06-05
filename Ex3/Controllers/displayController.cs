using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise3.Controllers
{
    public class displayController : Controller
    {
        // GET: Products
        [HttpGet]
        public ActionResult first(string ip1, string ip2, string ip3, string ip4, int port)
        {
            string ip = ip1+"."+ip2 + "." + ip3 + "." + ip4;
            return View();
        }
        [HttpGet]
        public ActionResult secand(string input, string input2, string input3, string input4, int port,int time)
        {
            string ip = input + "." + input2 + "." + input3 + "." + input4;
            return View();
        }
    }
}