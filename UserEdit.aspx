<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserEdit.aspx.cs" Inherits="UserEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" type="text/css" href="Styles/Site.css"/>
    <title></title>
</head>
<body>
<h1>NoBore</h1>
<h2>The site to end boredom, reasonably</h2>

    <form id="form1" runat="server" action="UserEdit.aspx">
    <div>
    <%if (Session["name"] != null)
      { %>
      <a href="Home.aspx">never mind editing</a>
      select the resources currently available <br />
       <table>
            <tr><td>terrain</td><td><input type="checkbox" name="tr" id="tr1" value="se" /> sea<br /><input type="checkbox" name="tr" id="tr2" value="wd" /> woods<br /><input type="checkbox" name="tr" id="tr3" value="rk" /> rocky<br /><input type="checkbox" name="tr" id="tr4" value="pl" /> plain</td></tr>
            <tr><td>skills</td><td><input type="checkbox" name="sk" id="sk1" value="st" /> strength<br /><input type="checkbox" name="sk" id="sk2" value="at" /> athletism<br /><input type="checkbox" name="sk" id="sk3" value="gn" /> gentle</td></tr>
            <tr><td>equipment</td><td><input type="checkbox" name="eq" id="eq1" value="an" /> anvil<br /><input type="checkbox" name="eq" id="eq2" value="sw" /> sewing kit<br /><input type="checkbox" name="eq" id="eq3" value="rp" /> rope</td></tr>
            <tr><td colspan='2' align="center"><input type='submit' value='sign up' /></td></tr>
        </table>
      <%} %>
    </div>
    </form>
</body>
</html>
