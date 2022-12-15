<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chat.aspx.cs" Inherits="chat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Styles/Site.css"/>
</head>
<body><h1>NoBore</h1>
<h2>The site to end boredom, reasonably</h2>

    <div>
     <%=Application["chat"] %><br />
        <%if (Session["name"] != null)
          { %>
          <a href="SignOut.aspx">sign out</a>
        <form id="chatform" runat="server" action="chat.aspx" method="post">
        <input type="text" id="message" name="message" /><input type="submit" value="send" />
        </form>
        <%} %><br />
        <a href="chat.aspx">refresh</a> maybe go <a href="Home.aspx">Home</a>
    </div>
</body>
</html>
