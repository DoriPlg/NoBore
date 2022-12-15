<%@ Page Language="C#" AutoEventWireup="true" CodeFile="New_Activity.aspx.cs" Inherits="New_Activity" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="stylesheet" type="text/css" href="Styles/Site.css"/>
</head>
<body> <h1>NoBore</h1>
<h2>The site to end boredom, reasonably</h2>

<a href="Home.aspx">Home</a>
<%  if ((!Page.IsPostBack)&&(Session["name"]!=null))
  { %>
  <a href="SignOut.aspx">sign out</a>
    <form id="form1" runat="server" method="post" action='New_Activity.aspx'>
    <table>
    <tr><td>Name your activity</td><td> <input type='text' id='acnm' name='acnm' required/></td></tr>
    <tr><td colspan='2'>Describe your activity<br /><textarea rows="10" cols="100" id="acdes" name="acdes" required></textarea></td></tr>
     <tr><td colspan='2'>Add an image<br /><input id="actimg" type="file" name="actimg" /></td></tr><%//work out some way to enter photo %>
    <tr><td>What terrain is needed?</td><td><input type="radio" name="tr" id="tr1" value="se" /> sea  <%=se %><br /><input type="radio" name="tr" id="tr2" value="wd" /> woods  <%=wd %><br /><input type="radio" name="tr" id="tr3" value="rk" /> rocky  <%=rk %><br /><input type="radio" name="tr" id="tr4" value="pl" /> plain  <%=pl %></td></tr>
    <tr><td>Which skills are needed?</td><td><input type="radio" name="sk" id="sk1" value="st" /> strength  <%=st %><br /><input type="radio" name="sk" id="sk2" value="at" /> athletism  <%=at %><br /><input type="radio" name="sk" id="sk3" value="gn" /> gentle  <%=gn %></td></tr>
    <tr><td>What equipment is needed?</td><td><input type="radio" name="eq" id="eq1" value="an" /> anvil  <%=an %><br /><input type="radio" name="eq" id="eq2" value="sw" /> sewing kit  <%=sw %><br /><input type="radio" name="eq" id="eq3" value="rp" /> rope  <%=rp %></td></tr>
    <tr><td>what genre is it?</td>
    <td>
    <select name="genre" id="genre">
        <option value="tch">tech</option>
        <option value="fod">food</option>
        <option value="wrk">workshop</option>
        <option value="lvn">living</option>
        <option value="ply">play</option>
        <option value="otd">outdoors</option>
    </select>
    </td>
    </tr>
    <tr><td colspan='2' align="center"><input type='submit' value='Add activity' /></td></tr>
    </table>
    </form>
    <%}%>
</body>
</html>
