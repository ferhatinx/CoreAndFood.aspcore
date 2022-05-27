using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    class Musteriler
    {
        [Key]
        public int MusteriID { get; set; }
        public string MüsteriAD { get; set; }
        public string MüsteriSOYAD { get; set; }
        public string MüsteriSEHIR { get; set; }


    }
}
