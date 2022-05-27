using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcSadikTuranRazor10.video.Models
{
    //Sanal veritabanı
    //bilgiler bellekde saklanır.uygulama kapandığında sonlanır
    //
    public static class Veritabani
    {
        public static List<Urun> _UrunListe;
        static Veritabani()
        {
            _UrunListe = new List<Urun>()
            {
                new Urun(){UrunID=1,UrunADI="Iphone",Acıklama="Çok ucuz bir telefon",Fiyat=15000,Satistami=true,Resim="1.jpg"},
                new Urun(){UrunID=2,UrunADI="Iphone 2",Acıklama="ucuz bir telefon",Fiyat=15000,Satistami=true,Resim="2.jpg"},
                new Urun(){UrunID=3,UrunADI="Iphone 3",Acıklama="Pahalı bir telefon",Fiyat=15000,Satistami=true,Resim="1.jpg"},
                new Urun(){UrunID=4,UrunADI="Iphone 4",Acıklama="Çok Pahalı bir telefon",Fiyat=15000,Satistami=true,Resim="2.jpg"},
                 new Urun(){UrunID=4,UrunADI="Iphone 4",Acıklama="Çok Pahalı bir telefon",Fiyat=15000,Satistami=false,Resim="1.jpg"}
            };
        }

        //veritabani.liste yazarsak bura gelir
        public static List<Urun> UrunListe
        {
           get { return _UrunListe; }
            
        }
        public static void ElemanEkle(Urun entity)
        {
            _UrunListe.Add(entity);
        }
        public static Urun UrunDetay(int urunid)
        {
            Urun entity = null;
            foreach (var item in _UrunListe)
            {
                if (item.UrunID==urunid)
                {
                    entity = item;
                }
            }
            return entity;
        }
    }
}