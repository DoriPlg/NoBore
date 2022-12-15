<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sign_In.aspx.cs" Inherits="Sign_In" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="stylesheet" type="text/css" href="Styles/Site.css"/>
</head>
<body><h1>NoBore</h1>
<h2>The site to end boredom, reasonably</h2>

    <form id="form1" runat="server" action="Sign_In.aspx" method="post">
    <div align="center">
    <table >
    <tr><td>username</td><td> <input type='text' id='usnm' name='usnm' /></td></tr>
    <tr><td>password</td><td><input type='password' id='pswr' name='pswr' /></td> </tr>
    <tr><td><input type='submit' value='sign in' /></td><td><a href="Home.aspx">never mind signing in</a></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
