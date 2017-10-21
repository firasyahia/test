using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ski.Web.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "this is the default </br>  message";
        }

        [Route("Welcomer/{name}/{numtimes:int}")]
        public string Welcomer(string name,int numTimes=1)
        {
            return "My name is "+name+", Num times"+ numTimes;
        }
        public string WelcomeYou(string name, int id = 1)
        {
            return "My name is " + name + ", Num times" + id;
        }
        public ActionResult Welcome(String name, int numTimes)
        {
            ViewBag.Message = "my name is "+ name;
            ViewBag.numtimes = numTimes;
            return View();
        }
    }
}