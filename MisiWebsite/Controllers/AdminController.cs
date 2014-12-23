using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MisiWebsite.Nortwind_model;

namespace MisiWebsite.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Add_Pr()
        //{
        //    return View();
        //}

        //public ActionResult DropDownMenu2()
        //{

        //    DataClasses2DataContext context = new DataClasses2DataContext();
        //    return View(context.Misi_Partners);
        //}

        public ActionResult CreateDoc()
        {
            NorthwindClassesDataContext context = new NorthwindClassesDataContext();
            return View(context.Products);
                        
        }
 
	}
}