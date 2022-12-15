using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            Session["filter"] = Request.QueryString["fltr"];
            Session["search"] = Request.QueryString["srch"];
            Response.Redirect("View_Activity.aspx");
        }
    }
}