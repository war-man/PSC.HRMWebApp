﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace HRMChamCong
{
    public partial class MasterHBU : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        protected void Logout_Click(object sender, System.EventArgs e)
        {
            //sign out from form authentication
            FormsAuthentication.SignOut();
            //abandon session
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}