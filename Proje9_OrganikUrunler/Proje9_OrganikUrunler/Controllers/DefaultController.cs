using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje9_OrganikUrunler.Models.Entity;


namespace Proje9_OrganikUrunler.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        TarimSitesiEntities db = new TarimSitesiEntities();
        public ActionResult Index()
        {
            var degerler = db.Tbl_Urunler.ToList();
            return View(degerler);
        }
    }
}