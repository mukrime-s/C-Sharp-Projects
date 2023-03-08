using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using technical_services_web.Entity;
namespace technical_services_web
{
    public partial class MainMenu : System.Web.UI.Page
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBLHAKKIMIZDA.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.TBLURUN.ToList();
            Repeater2.DataBind();
        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            TBLILETISIM ti = new TBLILETISIM();
            ti.ADSOYAD = TextBox1.Text;
            ti.MAIL = TextBox2.Text;
            ti.KONU = TextBox3.Text;
            ti.MESAJ = TextBox4.Text;
            db.TBLILETISIM.Add(ti);
            db.SaveChanges();
        }
    }
}