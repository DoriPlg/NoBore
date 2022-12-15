<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
    </title>
    <link rel="stylesheet" type="text/css" href="Styles/Site.css"/>
    <script type="text/javascript" language="javascript" src="Scripts/MyGreatFunctions.js">
    
    </script>
</head>
<body>
<h1>NoBore</h1>
    <h2>The site to end boredom, reasonably</h2>
    <div>
    <form id="form2" runat="server" action="Registration.aspx" method="post" onsubmit="return ValidReg()">
    <div align="center">
    Already have an acount? <a href="Sign_In.aspx">sign in</a>
    <table >
    <tr><td>username</td><td> <input type='text' id='id' name='id' /></td><td><p id="usern"></p></td></tr>
    <tr><td>name</td><td> <input type='text' id='nm' name='nm' /></td><td><p id="n"></p></td></tr>
    <tr><td>surname</td><td><input type='text' id='usnm' name='usnm' /></td><td><p id="usn"></p></td> </tr>
    <tr><td>password</td><td><input type='password' id='pswr' name='pswr' /></td> <td><p id="pass"></p></td></tr>
    <tr><td>terrain</td><td><input type="checkbox" name="tr" id="tr1" value="se" /> sea<br /><input type="checkbox" name="tr" id="tr2" value="wd" /> woods<br /><input type="checkbox" name="tr" id="tr3" value="rk" /> rocky<br /><input type="checkbox" name="tr" id="tr4" value="pl" /> plain</td></tr>
    <tr><td>skills</td><td><input type="checkbox" name="sk" id="sk1" value="st" /> strength<br /><input type="checkbox" name="sk" id="sk2" value="at" /> athletism<br /><input type="checkbox" name="sk" id="sk3" value="gn" /> gentle</td></tr>
    <tr><td>equipment</td><td><input type="checkbox" name="eq" id="eq1" value="an" /> anvil<br /><input type="checkbox" name="eq" id="eq2" value="sw" /> sewing kit<br /><input type="checkbox" name="eq" id="eq3" value="rp" /> rope</td></tr>
    <tr><td colspan='2' align="center"><input type='submit' value='sign up' /></td></tr>
    </table>
    </div>
    </form>
    
    </div>
</body>
</html>
