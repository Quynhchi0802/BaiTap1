using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GPTB1.Controllers
{
    public class GiaiptrinhController : Controller
    {
        // GET: gpt
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GPTB1( double soa, double sob)
        {
            double x = 0;
            x = -sob/sob ;
            
            return View();
        }
    }
}