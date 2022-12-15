<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Styles/Site.css"/>
</head>
<body>
    <div>
    <form id="form4" runat="server" action="Home.aspx" method="get">
    <h1>NoBore</h1>
    <h2>The site to end boredom, reasonably</h2>
    <%if (Session["name"]==null)
      { %>
        you are not signed in<br />because you didn't sign up, you can only search..
        <br />
        <a href="Registration.aspx">register</a>&nbsp&nbsp&nbsp
        <a href="Sign_In.aspx">sign in</a><br />
        <input type="text" name="srch" id="srch" value="search for a project" />
        <input type="submit" value="search" />
    <%}
      else
      { %>
        <a href="SignOut.aspx">sign out</a>
        <a href="UserEdit.aspx">Edit stats</a>
        <input type="text" name="srch" id="Text1" value="search for a project" />
        <input type="submit" value="search" />
        <input type="checkbox" id="fltr" name="fltr" value="checked" />DON'T filter<br />
        hello <%=Session["name"] %>, would you like to 
        <a href="OwnActs.aspx">look at all these activities</a>&nbsp or &nbsp
        <a href="New_Activity.aspx">create new activity <br /><br /><br /><br /></a>
        <a href="View_Activity.aspx?sbj='tch'">tech&nbsp</a>
        <a href="View_Activity.aspx?sbj='fod'">food&nbsp</a>
        <a href="View_Activity.aspx?sbj='wrk'">workshop&nbsp</a>
        <a href="View_Activity.aspx?sbj='lvn'">living&nbsp</a>
        <a href="View_Activity.aspx?sbj='ply'">play&nbsp</a>
        <a href="View_Activity.aspx?sbj='otd'">outdoors&nbsp</a>
    <%} %>
    </form>
    <br />
    <a href="chat.aspx">chat</a>
    <br /><br /><br />
      </div>
</body>
</html>
