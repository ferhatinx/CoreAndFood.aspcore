using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje3_TarimSitesi
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_BilgiTableAdapter db = new DataSet1TableAdapters.Tbl_BilgiTableAdapter();
            Repeater1.DataSource = db.BilgiGetir();
            Repeater1.DataBind();

            DataSet1TableAdapters.Tbl_UrunlerTableAdapter dt = new DataSet1TableAdapters.Tbl_UrunlerTableAdapter();
            Repeater2.DataSource = dt.UrunGetir();
            Repeater2.DataBind();
        }
    }
}