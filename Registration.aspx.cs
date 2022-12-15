using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            ConnClass cc = new ConnClass();
            string ter, skl,equ;
            ter = Request.Form["tr"];
            skl = Request.Form["sk"];
            equ = Request.Form["eq"];
            if (ter == "")
                ter = "null";
            if (equ == "")
                equ = "null";
            if (skl == "")
                skl = "null";
            string sql = "INSERT INTO tblUser (id,name,srname,password,ter,skl,equ,manage) VALUES ('" + Request.Form["id"] + "','" + Request.Form["nm"] + "','" + Request.Form["srnm"] + "','" + Request.Form["pswr"] + "','" + ter + "','" + skl + "','" + equ + "','false')";
            cc.ChangeDB(sql);
            Session["User"] = Request.Form["id"];
            Session["name"] = cc.GetName(Request.Form["id"]);
            Response.Redirect("Home.aspx");
        }
    }
}