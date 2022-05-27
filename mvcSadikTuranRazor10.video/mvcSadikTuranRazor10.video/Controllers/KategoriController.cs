using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcSadikTuranRazor10.video.Models;

namespace mvcSadikTuranRazor10.video.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }
        //urlden çağırmayı engeller
        [ChildActionOnly]
        public PartialViewResult KategoriMenu()
        {
            List<Kategori> kategori = new List<Kategori>()
            {
                new Kategori(){KategoriID=1,KategoriAD="Telefonlar"},
                new Kategori(){KategoriID=2,KategoriAD="Beyaz Eşyalar"}
            };
            return PartialView("KategoriMenu",kategori);

        }
    }
}