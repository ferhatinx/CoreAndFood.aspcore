using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    class Kategoriler
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAD { get; set; }
        // 1 e çok
        public ICollection<Urunler> Urunlers { get; set; }
    }
}
