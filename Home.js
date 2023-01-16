var http = require('http');
var url = require('url');

http.createServer(function (req, res) {
    res.write('<html xmlns="http://www.w3.org/1999/xhtml">');
    res.write('<head runat="server">');
    res.write('<title></title>');
    res.write('<link rel="stylesheet" type="text/css" href="Styles/Site.css"/>');
    res.write('</head>');
    res.write('<body>');
    res.write('<div>');
    res.write('<form id="form4" runat="server" action="Home.aspx" method="get">');
    res.write('<h1>NoBore</h1>');
    res.write('<h2>The site to end boredom, reasonably</h2>');
    res.write("you are not signed in<br />because you didn't sign up, you can only search..");
    res.write('<br />');
    res.write('<a href="Registration.aspx">register</a>&nbsp&nbsp&nbsp');
    res.write('<a href="Sign_In.aspx">sign in</a><br />');
    res.write('<input type="text" name="srch" id="srch" value="search for a project" />');
    res.write('<input type="submit" value="search" />');
    res.write('</form>');
    res.write('<br />');
    res.write('<a href="chat.aspx">chat</a>');
    res.write('<br /><br /><br />');
    res.write('</div>');
    res.write('</body>');
    res.write('</html>');
    return res.end();
}).listen(8080);
