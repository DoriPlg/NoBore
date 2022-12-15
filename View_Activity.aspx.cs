using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Activity : System.Web.UI.Page
{
    public string s = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        ConnClass cc = new ConnClass();
        if (!Page.IsPostBack)
        {
            string user = "" + Session["User"] + "";
            bool exist = Session["User"] != null;
            bool filter = Session["filter"] == null;
            string search = "" + Session["search"] + "";
            string sbj = "" + Request.QueryString["sbj"] + "";
            s = cc.showActs(user, exist, filter, search, sbj);
        }
    }
}