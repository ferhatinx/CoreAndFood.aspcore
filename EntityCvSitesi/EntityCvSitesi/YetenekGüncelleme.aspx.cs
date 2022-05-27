using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityCvSitesi.Model;

namespace EntityCvSitesi
{
    public partial class YetenekGüncelleme : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            if (Page.IsPostBack==false)
            {
                var y = db.Tbl_Yetenekler.Find(x);
                txtyetad.Text = y.YETENEK;
            }
           
           
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var y = db.Tbl_Yetenekler.Find(x);
            y.YETENEK =txtyetad.Text;
            db.SaveChanges();
        }
    }
}