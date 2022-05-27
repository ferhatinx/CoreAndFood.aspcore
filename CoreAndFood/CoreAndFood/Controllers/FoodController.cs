using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreAndFood.Repositories;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository foodRepository = new FoodRepository();
        Context c = new Context();
        public IActionResult Index(int page=1)
        {
           
            return View(foodRepository.TList("Category").ToPagedList(page,3));
        }
        [HttpGet]
        public IActionResult FoodAdd()
        {
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()

                                           }).ToList();
            ViewBag.ctgr = values;
            return View();
        }
        [HttpPost]
        public IActionResult FoodAdd(Food f)
        {
            foodRepository.TAdd(f);
            return RedirectToAction("Index");
        }
        public IActionResult FoodDelete(int id)
        {

            foodRepository.TDelete(new Food { FoodID = id });
            return RedirectToAction("Index");
        }
        public IActionResult FoodGet(int id)
        {
            var x = foodRepository.TGetID(id);
            Food fd = new Food()
            {
                CategoryID = x.CategoryID,
                FoodNAME = x.FoodNAME,
                Price = x.Price,
                Stock = x.Stock,
                FoodDescription=x.FoodDescription,
                ImageUrl = x.ImageUrl

            };
            return View(x);
            
        }
        [HttpPost]
        public IActionResult FoodUpdate(Food f)
        {
            var x = foodRepository.TGetID(f.FoodID);
            x.FoodNAME = f.FoodNAME;
            x.Stock = f.Stock;
            x.Price = f.Price;
            x.ImageUrl = f.ImageUrl;
            x.FoodDescription = f.FoodDescription;
            x.CategoryID = f.CategoryID;
            foodRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
    
