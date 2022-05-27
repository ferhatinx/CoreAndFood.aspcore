using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityCvSitesi;
using EntityCvSitesi.Model;

namespace EntityCvSitesi
{
    public partial class Default : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.Tbl_Hakkımda.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.Tbl_Hakkımda.ToList();
            Repeater2.DataBind();

            Repeater3.DataSource = db.Tbl_Hakkımda.ToList();
            Repeater3.DataBind();

            Repeater4.DataSource = db.Tbl_Yetenekler.ToList();
            Repeater4.DataBind();
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Iletisim iletisim = new Tbl_Iletisim();

            iletisim.ADSOYAD = txtad.Text;
            iletisim.MAIL = txtmail.Text;
            iletisim.KONU = txtkonu.Text;
            iletisim.MESAJ = txtmesaj.Text;
            db.Tbl_Iletisim.Add(iletisim);
            db.SaveChanges();
            
        }
    }
}