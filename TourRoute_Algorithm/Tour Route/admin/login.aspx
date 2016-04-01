<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Tour_Route.admin.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/common.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="tit">
    <center><h1>THE BEST ROUTE旅游路线网站后台管理系统</h1></center>
    </div>
    <div id="main">
    <br /><br /><br /><br />
    <center>
        <asp:Label ID="Label1" runat="server" Text="用户名：" Font-Size="Larger"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
       
        </center>
        <br /><br /><br />
        <center>
        <asp:Label ID="Label2" runat="server" Text=" 密 码:" Font-Size="Larger"></asp:Label>
         &nbsp;  &nbsp;  &nbsp;
        <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
           
        </center>
        <br />
        <center> <asp:Label ID="lblUserErrorMsg" runat="server" Text="lblUserErrorMsg"></asp:Label></center>
        <br />
        <center>
        <asp:Button ID="Button1" runat="server" Text="登录" Font-Size="Large" 
                onclick="Button1_Click"/>   
         &nbsp;  &nbsp; 
        <asp:Button ID="Button2"  runat="server" Text="取消" Font-Size="Large" 
                onclick="Button2_Click" />
        </center>
    </div>
    </form>
</body>
</html>
