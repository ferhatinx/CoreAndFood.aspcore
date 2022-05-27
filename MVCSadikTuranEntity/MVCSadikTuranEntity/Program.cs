using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSadikTuranEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            Kategoriler k = new Kategoriler();
            k.KategoriID = 5;
            k.KategoriAD = "Laptop";



            UrunlerContext db = new UrunlerContext();
            db.Tbl_Kategori.Add(k);
            db.SaveChanges();
            Console.WriteLine("Veri kayı edildi");
        }
    }
}
