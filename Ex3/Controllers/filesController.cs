using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise3.Controllers
{
    public class filesController : Controller
    {
        [HttpGet]
        public ActionResult display(string nameFile,int time)
        {
            return View();
        }
        // GET: save
        [HttpGet]
        public ActionResult save(string ip1, string ip2, string ip3, string ip4, int port , int time, int duration,string nameFile)
        {
            string ip = ip1 + "." + ip2 + "." + ip3 + "." + ip4;
            return View();
        }
    }
}