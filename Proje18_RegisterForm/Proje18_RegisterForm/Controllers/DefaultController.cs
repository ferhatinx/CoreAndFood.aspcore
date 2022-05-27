using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje18_RegisterForm.Models.Entity;

namespace Proje18_RegisterForm.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        RegisterEntities db = new RegisterEntities();
        public ActionResult Index()
        {
          
            return View();
        }
        [HttpGet]
        public ActionResult Kayit()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult Kayit(Tbl_Register p)

        {
            db.Tbl_Register.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}