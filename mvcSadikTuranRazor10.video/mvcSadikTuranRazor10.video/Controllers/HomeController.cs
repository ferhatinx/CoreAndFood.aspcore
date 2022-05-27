
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcSadikTuranRazor10.video.Models;

namespace mvcSadikTuranRazor10.video.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //veritabanına bağlanılır  ve bilgileri getirilir
        //getirilen bilgiler bir model içerisine yani sınıfa aktarılır
        //bu model view e gönderilir.
        public ActionResult Index()
        {

            UrunKategoriModel model = new UrunKategoriModel();
            model.UrunSayisi = Veritabani.UrunListe.Count();
            model.Urunler = Veritabani.UrunListe.Where(x => x.Satistami==false).ToList();
 
            ////çoklu model
            //UrunKategoriModel model = new UrunKategoriModel();
            //model.Urunler = urunler;
            //model.UrunSayisi = urunler.Count();

          
            //VİEWBAG
            //ViewBag.kategoriler = kategori;
            //ViewBag.urunsayisi = urunler.Count();
            return View(model);
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun entity)
        { 

            Veritabani.ElemanEkle(entity);
            

            return View("UrunListele",Veritabani.UrunListe);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            var urun = Veritabani.UrunListe.Where(x => x.UrunID == id).FirstOrDefault();
            return View(urun);
        }
            
    }
}
     
