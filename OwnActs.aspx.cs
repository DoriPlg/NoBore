using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OwnACTS : System.Web.UI.Page
{
    ConnClass cc = new ConnClass();
    public string s = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = "" + Session["User"] + "";
        s=cc.ShowUserActs(id);
    }
}