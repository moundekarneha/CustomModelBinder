using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomModelBinder.Models;

namespace CustomModelBinder.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetData([ModelBinder(typeof(CustomModel))]Emp emp)
        {
            return View();
        }
    }
}