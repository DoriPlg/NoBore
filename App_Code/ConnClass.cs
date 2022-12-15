using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// מטפלת במסדי נתונים
/// </summary>
public class ConnClass
{
    private SqlConnection con;
    //פעולה בונה
    public ConnClass()
	{
        con = new SqlConnection();
        con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\dbNoBore.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
       
	}
    //מחזיר אמת כשהמשתמש נמצא במאגר
    public bool IsUserExists(string name, string pass)
    {
        SqlCommand cmd = new SqlCommand("SELECT id,password FROM tblUser WHERE id='" + name + "' AND password='" + pass + "'", con);
        con.Open();
        object obj = cmd.ExecuteScalar();
        con.Close();
        return (obj != null);
    }

    public bool Man(string name, string pass)
    {
        bool mng = false;
        SqlCommand cmd = new SqlCommand("SELECT manage FROM tblUser WHERE id='" + name + "' AND password='" + pass + "'", con);
        con.Open();
        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
        DataSet datset = new DataSet();
        adapt.Fill(datset);
        mng =Convert.ToBoolean(datset.Tables[0].Rows[0].ItemArray[0]);
        con.Close();
        return mng;
    }
    //מקבלת שאילתה ביצועית ומבצעת אותה על המסד
    public int ChangeDB(string sql)
    {
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        int rows = cmd.ExecuteNonQuery();
        con.Close();
        return rows;
    }

    public string GetName(string us)
    {
        DataSet ds = this.GetDataSet("SELECT name,srname FROM tblUser WHERE id='" + us + "'", con);
        return (ds.Tables[0].Rows[0]["name"] + " "+ds.Tables[0].Rows[0]["srname"]);
    }

    public DataSet GetDataSet(string sqlstring, SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = sqlstring;
        cmd.Connection = con;
        con.Open();
        SqlDataAdapter adpt = new SqlDataAdapter();
        adpt.SelectCommand = cmd;
        DataSet ds = new DataSet();
        adpt.Fill(ds);
        con.Close();
        return ds;
    }

    public string showActs(string us, bool user,bool flt, string src, string sbj)
    {
        string rs = "WHERE (name LIKE '%" + src + "%') AND";
        string[] uster = new string[0];
        string[] usskl = new string[0];
        string[] usequ = new string[0];
        char[] ch = new char[2];
        ch[0] = ',';
        ch[1] = ' ';
        if(user&&flt)
        {
            SqlCommand scmd = new SqlCommand("SELECT * FROM tblUser WHERE id = '" + us + "' ", con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(scmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                uster = row["ter"].ToString().Split(ch);
                usskl = row["skl"].ToString().Split(ch);
                usequ = row["equ"].ToString().Split(ch);
            }    
            con.Close();
            rs += "((ter IS NULL) OR ((1=2)";
            foreach (string s in uster)
            {
                rs += " OR (ter = '" + s + "')";
            }
            rs += ")) AND ((skl IS NULL) OR ((1=2)";
            foreach (string s in usskl)
            {
                rs += " OR (skl = '" + s + "')";
            }
            rs += ")) AND ((equ IS NULL) OR ((1=2)";
            foreach (string s in usequ)
            {
                rs += " OR (equ = '" + s + "')";
            }
            rs += "))";
        }
        string sb = " AND (genre=" + sbj + ")";
        if (sb != " AND (genre=)"){ rs += sb; }
        if (rs == "WHERE (name LIKE '%" + src + "%') AND") { rs = "WHERE (name LIKE '%" + src + "%')"; }
        string st;
        SqlCommand cmd = new SqlCommand("SELECT * FROM tblAct  "+rs+"", con);
        con.Open();
        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
        DataSet datset = new DataSet();
        adapt.Fill(datset);
        st = "<table border=1>";
        st += "<tr>";
        st += "<td> activity </td>";
        st += "<td> little cover image </td>";
        st += "<td> posted by </td>";
        st += "</tr>";
        foreach (DataRow row in datset.Tables[0].Rows)
        {
            st += "<tr>";
            st += "<td><a href='Spec_Acts.aspx?act=" + row["name"] + "'>" + row["name"] + "<a/></td>";
            st += "<td>" + "כאן תיכנס תמונה עם הגדרות גודל" + "</td>";//work out some way to enter photo
            st += "<td>" + row["poster"] + "</td>";
            st += "</tr>";
        }
        st += "</table>";
        con.Close();
        return st;
    }

    public string Viewtivity(string name)
    {
        string st = "";
        SqlCommand cmd = new SqlCommand("SELECT * FROM tblAct WHERE name='" + name + "' ", con);
        con.Open();
        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
        DataSet datset = new DataSet();
        adapt.Fill(datset);
        st = "<table border=1>";
        foreach (DataRow row in datset.Tables[0].Rows)
        {
            st += "<tr>"+row["name"]+"</tr>";
            st += "<tr>" + "כאן תיכנס תמונה עם הגדרות גודל" + "</tr>";//work out some way to enter photo
            st += "<td>" + row["desr"] + "</td>";
        }
        con.Close();
        return st;
    }

    public string DeleteSelect(string tbl)
    {
        string st, s;
        SqlCommand scmd = new SqlCommand("SELECT * FROM tbl"+tbl, con);
        con.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(scmd);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        int i = 0;
        st = "<table border=1>";
        st += "<tr>";
        st += "<td> name </td>";
        if (tbl == "Act")
        {
            st += "<td> description </td>";
            st += "<td> genre </td>";
        }
        st += "<td> delete </td>";
        st += "</tr>";
        foreach (DataRow row in ds.Tables[0].Rows)
        {
            i++;
            st += "<tr>";
            st += "<td>" + row["name"] + "</td>";
            if (tbl == "Act")
            {
                st += "<td>" + row["desr"] + "</td>";
                st += "<td>" + row["genre"] + "</td>";
            }
            s = "checkbox" + i.ToString();
            st += "<td> <input type='checkbox' name='" + s + "' id='" + s + "' /> </td>";
            st += "</tr>";
        }
        con.Close();
        return st;
    }

    public int ListLength(string tbl)
    {
        SqlCommand scmd = new SqlCommand("SELECT * FROM tbl" + tbl, con);
        con.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(scmd);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        int i = 0;
        foreach (DataRow row in ds.Tables[0].Rows)
        {
            i++;          
        }
        con.Close();
        return i;

    }

    public void delete(bool[] d, string tbl)
    {
        SqlCommand scmd = new SqlCommand("SELECT * FROM tbl"+tbl, con);
        con.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(scmd);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        int i = 0;
        foreach (DataRow row in ds.Tables[0].Rows)
        {
            if (d[i] == true)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM tbl"+tbl+" WHERE id='" + row["id"].ToString() + "'", con);
                cmd.ExecuteNonQuery();
            }
            i++;
        }
        con.Close();
    }

    public string ShowUserActs(string usnm)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblAct  WHERE poster='" + usnm+"'" , con);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet datset = new DataSet();
            adapt.Fill(datset);
            string st = "<table border=1>";
            st += "<tr>";
            st += "<td> activity </td>";
            st += "<td> little cover image </td>";
            st += "</tr>";
            foreach (DataRow row in datset.Tables[0].Rows)
            {
                st += "<tr>";
                st += "<td><a href='Spec_Acts.aspx?act=" + row["name"] + "'>" + row["name"] + "<a/></td>";
                st += "<td>" + "כאן תיכנס תמונה עם הגדרות גודל" + "</td>";//work out some way to enter photo
                st += "</tr>";
            }
            st += "</table>";
            con.Close();
            return st;
        }
    public double ColAvg(string col, string id)
    {
        double av = 0;
        SqlCommand cmd = new SqlCommand("SELECT "+col+" FROM tblUser", con);
        con.Open();
        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
        DataSet datset = new DataSet();
        adapt.Fill(datset);
        string st = "";
        int ppl = 0;
        foreach (DataRow row in datset.Tables[0].Rows)
        {
            st+= row["col"]+",";
            ppl++;
        }
        con.Close();
        string[] ar=st.Split(',');
        int amount=0;
        for (int i = 0; i < ar.Length; i++)
        {
            if (ar[i] == id)
                amount++;
        }
        av = ((double)amount) / ((double)ppl);
        return av;
    }
}