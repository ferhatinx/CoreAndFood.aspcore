using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcSadikTuranRazor10.video.Models
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunADI { get; set; }
        public string Acıklama { get; set; }
        public double Fiyat { get; set; }
        public string Resim { get; set; }
        public bool Satistami { get; set; }


    }
}