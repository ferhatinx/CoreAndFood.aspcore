using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSadikTuranEntity
{
    class UrunlerContext:DbContext
    {
        public DbSet<Kategoriler> Tbl_Kategori { get; set; }
        public DbSet<Urunler> Tbl_Urunler { get; set; }

    }
}
