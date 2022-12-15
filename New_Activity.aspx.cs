using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class New_Activity : System.Web.UI.Page
{
        public double se, wd, rk, pl, st, at, gn, an, sw, rp;
        public ConnClass cc = new ConnClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] != null)
        {
            if (Page.IsPostBack)
            {
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
                string sql = "INSERT INTO tblAct (name,desr,ter,skl,equ,poster,photo,genre) VALUES ('" + Request.Form["acnm"] + "','" + Request.Form["acdes"] + "','" + ter + "','" + skl + "','" + equ + "','" + Session["User"] + "','" + Request.Form["actimg"] + "','" + Request.Form["genre"] + "')";
                cc.ChangeDB(sql);
                Response.Redirect("Home.aspx");
            }
            else
            {
                se = cc.ColAvg("ter", "se");
                wd = cc.ColAvg("ter", "wd");
                rk = cc.ColAvg("ter", "rk");
                pl = cc.ColAvg("ter", "pl");
                at = cc.ColAvg("skl", "at");
                st = cc.ColAvg("skl", "st");
                gn = cc.ColAvg("skl", "gn");
                an = cc.ColAvg("equ", "an");
                sw = cc.ColAvg("equ", "sw");
                rp = cc.ColAvg("equ", "rp");
            }
        }
        else { Response.Redirect("Home.aspx"); }
    }
}