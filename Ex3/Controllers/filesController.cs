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
        public ActionResult save(string input1, string input2, string input3, string input4, int port , int time, int duration,string nameFile)
        {
            string ip = input1 + "." + input2 + "." + input3 + "." + input4;
            return View();
        }
    }
}