﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace labMonitoring
{
    public partial class Output_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Check the session
             */
            if (Session["sessID"] == null)
            {
                Response.Redirect("Main.aspx");
            }
        }
    }
}