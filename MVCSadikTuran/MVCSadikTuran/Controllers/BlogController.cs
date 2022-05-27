using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSadikTuran.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        //VERİTABANINDAKİ BÜTÜN BLOG BİLGİLERİNİ AL VE VİEW ÜZERİNE GÖNDER
        //KENDİSİNE GELEN BLOG BİLGİLERİNİ DİNAMİK İÇERİK ÜRETEN VİEW YAPISI BUNU STATİK HTML E ÇEVİRİR.
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}