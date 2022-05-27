using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityCvSitesi.Model;

namespace EntityCvSitesi
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Tbl_Yetenekler y = new Tbl_Yetenekler();
            y.YETENEK = txtyetad.Text;
            db.Tbl_Yetenekler.Add(y);
            db.SaveChanges();


        }
    }
}