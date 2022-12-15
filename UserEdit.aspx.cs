using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            ConnClass cc = new ConnClass();
            string ter, skl, equ;
            ter = Request.Form["tr"];
            skl = Request.Form["sk"];
            equ = Request.Form["eq"];
            if (ter == "")
                ter = "null";
            if (equ == "")
                equ = "null";
            if (skl == "")
                skl = "null";
            string sql = "Update tblUser SET ter='" + ter + "',skl='" + skl + "',equ='" + equ + "' WHERE ID='" + Session["User"].ToString() + "'";
            cc.ChangeDB(sql);
            Response.Redirect("Home.aspx");
        }
    }
}