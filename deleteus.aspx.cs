using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class deleteus : System.Web.UI.Page
{
    public string s="";
    protected void Page_Load(object sender, EventArgs e)
    {
        ConnClass cc = new ConnClass();
        if (!Page.IsPostBack)
        {
            s = cc.DeleteSelect("User");
        }
        else
        {
            bool[] del = new bool[cc.ListLength("User")];
            for (int i = 1; i <= cc.ListLength("User"); i++)
            {
                del[i - 1] = (Request.Form["checkbox" + i.ToString()] != null);
            }
            cc.delete(del, "User");
            Response.Redirect("Manager.aspx");
        }
    }
}