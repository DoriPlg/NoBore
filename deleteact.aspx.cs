﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class deleteact : System.Web.UI.Page
{
    public string s = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        ConnClass cc = new ConnClass();
        if (!Page.IsPostBack)
        {
            s= cc.DeleteSelect("Act");
        }
        else
        {
            bool[] del = new bool[cc.ListLength("Act")];
            for (int i = 1; i <= cc.ListLength("Act"); i++)
            {
                del[i-1]=(Request.Form["checkbox" + i.ToString()]!=null);
            }
            cc.delete(del, "Act");
            Response.Redirect("Manager.aspx");
        }
    }
}