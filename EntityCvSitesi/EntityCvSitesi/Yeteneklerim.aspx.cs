using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityCvSitesi.Model;

namespace EntityCvSitesi
{
    public partial class Yeteneklerim : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.Tbl_Yetenekler.ToList();
            Repeater1.DataBind();
        }
      

    }
}