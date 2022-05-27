using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje1_OkulKayit;


namespace Proje1_OkulKayit
{
    public partial class KayıtOl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DbProje1_OkulKayitEntities db = new DbProje1_OkulKayitEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Ogrenci t = new Tbl_Ogrenci();
            t.KULLANICIAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.SEHIR = TextBox3.Text;
            t.SIFRE = TextBox4.Text;
            db.Tbl_Ogrenci.Add(t);
            db.SaveChanges();
       
            

        }
    }
}