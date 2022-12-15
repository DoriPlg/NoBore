<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manager.aspx.cs" Inherits="Manager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="stylesheet" type="text/css" href="Styles/Site.css"/>
</head>
<body><h1>NoBore</h1>
<h2>The site to end boredom, reasonably</h2>

    <form id="form1" runat="server">
    <div>
    <a href="SignOut.aspx">sign out</a>
        <h1>YOU ARE THE MANAGER.</h1><a href="Home.aspx">return to home</a> What do want to do?<br />
        <a href='deleteus.aspx'>delete users?</a> Or maybe <a href='deleteact.aspx'>delete activities?</a>
    </div>
    </form>
</body>
</html>
