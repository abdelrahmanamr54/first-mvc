using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            AdventureWorks2017Entities dc= new AdventureWorks2017Entities();
            var items=dc.Addresses.ToList();
            return View(items);
        }
    }
}