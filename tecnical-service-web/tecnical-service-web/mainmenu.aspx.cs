﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tecnical_service_web.Entity;
namespace tecnical_service_web
{
    public partial class mainmenu : System.Web.UI.Page
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Repeater2.DataSource = db.TBLHAKKIMIZDA.ToList();
        }
    }
}