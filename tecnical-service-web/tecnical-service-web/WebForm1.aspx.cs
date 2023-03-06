using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tecnical_service_web.Entity;
namespace tecnical_service_web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var value = db.TBLURUNTAKIP.ToList();
            Repeater1.DataSource = value;
            Repeater1.DataBind();//veriyi baglamak icin olusturuldu.
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            //var value = db.TBLURUNTAKIP.Where(x => x.SERINO == TextBox1.Text);//SERİ NUMARASINA GÖRE VERİLER CEKİLDİ
           // Repeater1.DataSource = value.ToList();
            //Repeater1.DataBind();//veriyi baglamak icin olusturuldu.
        }
    }
}