using GPTB1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GPTB1.Controllers
{
    public class GiaiPTB1 : Controller
    {
       GPTB1.gpt = new GPTB1();
        // GET: gpt1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GPTB1( double soa, double sob)
        {
            double a = double.Parse(soa);
            double b = double.Parse(sob);
            double x = GiaiPTB1(a, b);
            ViewBag.NghiemPT = x;
            
            return View();
        }
    }
}