using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EntityMvc.Models.Class;

namespace EntityMvc.Controllers
{
    public class AdminController : Controller
    {
        CONTEXT c = new CONTEXT();
        // GET: Admin
        public ActionResult Index()
        {
            
            var degerler = c.YETENEKLERS.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(Yetenekler y)
        {
            c.YETENEKLERS.Add(y);
            c.SaveChanges();

            return View();


        }
        public ActionResult YetenekSil(int id)
        {
            var sorgu = c.YETENEKLERS.Find(id);
            c.YETENEKLERS.Remove(sorgu);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGüncelle(int id)
        {
            var deger = c.YETENEKLERS.Find(id);
            return View("YetenekGetir",deger);
        }
        [HttpPost]
        public ActionResult YetenekGüncelle(Yetenekler y)
        {
            var x = c.YETENEKLERS.Find(y.ID);
            x.Acıklama = y.Acıklama;
            x.Deger = y.Deger;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}