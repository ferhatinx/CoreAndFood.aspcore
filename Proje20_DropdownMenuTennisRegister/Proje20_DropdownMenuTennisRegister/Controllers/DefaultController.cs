using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje20_DropdownMenuTennisRegister.Models.Entity;

namespace Proje20_DropdownMenuTennisRegister.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        TennisRegisterEntities db = new TennisRegisterEntities();
        public ActionResult Index()
        {
            List<SelectListItem> sehir = (from i in db.Tbl_Sehirler.ToList()
                                          select new SelectListItem
                                          {
                                              Text=i.SEHIR,
                                              Value=i.ID.ToString()

                                          }).ToList();
            ViewBag.shr = sehir;
            return View();
        }
    }
}