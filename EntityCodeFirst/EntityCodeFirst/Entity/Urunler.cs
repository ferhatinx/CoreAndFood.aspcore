using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    class Urunler
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAD { get; set; }
        public string UrunMarka { get; set; }
        public string UrunKategori { get; set; }
        public int UrunStok { get; set; }
        public string Aciklama { get; set; }
        //1 e çok
        public Kategoriler Kategori { get; set; }
        
    }
}
