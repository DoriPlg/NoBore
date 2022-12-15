using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class chat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Application["chat"] == null) { Application["chat"] = ""; }
        if (Page.IsPostBack)
        {
            if ((Request.Form["message"] != null) && (Request.Form["message"] != ""))
            { 
                Application["chat"] += "<br/>" + Session["name"] + ": " + Request.Form["message"];
            }
        }
    }
}