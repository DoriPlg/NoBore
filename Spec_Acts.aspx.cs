using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Spec_Acts : System.Web.UI.Page
{
    ConnClass cc = new ConnClass();
    public string s = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string actname = "" + Request.QueryString["act"] + "";
        s=cc.Viewtivity(actname);
    }
}