using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Proje2_MuzikSitesi;

namespace Proje2_MuzikSitesi
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        MuzikSitesiEntities db = new MuzikSitesiEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Kisiler t = new Tbl_Kisiler();
            t.ADSOYAD = txtad.Text;
            t.MAIL = txtmail.Text;
            t.GUN = txtdate.Text;
            t.TELEFON = txttel.Text;
            t.ENSTRUMAN = DropDownList1.SelectedItem.ToString();
          
            db.Tbl_Kisiler.Add(t);
            db.SaveChanges();
            

        }
    }
}