using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Food
    {
        [Key]
        public int FoodID { get; set; }
        public string FoodNAME { get; set; }
        public string FoodDescription { get; set; }

        public double Price { get; set; }
        public string ImageUrl { get; set; }
   
        public int Stock { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
