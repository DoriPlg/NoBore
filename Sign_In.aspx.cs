using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sign_In : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ConnClass cc=new ConnClass ();
        if (Page.IsPostBack)
        {
            if (cc.IsUserExists(Request.Form["usnm"], Request.Form["pswr"]))
            {
                Session["User"] = Request.Form["usnm"];
                Session["name"] = cc.GetName(Request.Form["usnm"]);
                if (cc.Man(Request.Form["usnm"], Request.Form["pswr"]))
                    Response.Redirect("Manager.aspx");
                else
                    Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("Wrong username/password<br/>Do you have an acount? <a href='Registration.aspx'> register</a>");
            }
        }

    }
}