<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Record.aspx.cs" Inherits="Web.Record" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
        用户：<asp:TextBox ID="txt_user" runat="server"></asp:TextBox>
        <br />
        密码：<asp:TextBox ID="txt_secret" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btn_OK" runat="server" onclick="btn_OK_Click" Text="Button" />
   
    </div>
    </form>
</body>
</html>
