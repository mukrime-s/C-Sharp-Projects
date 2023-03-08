using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using technical_services_web.Entity;
namespace technical_services_web
{
    public partial class WebMasterPage : System.Web.UI.Page
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var value = db.TBLURUNTAKIP.ToList();
            //Repeater1.DataSource = value;
            //Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var value = db.TBLURUNTAKIP.Where(x => x.SERINO == TextBox1.Text);
            Repeater1.DataSource = value.ToList();  
            Repeater1.DataBind();
        }
    }
}