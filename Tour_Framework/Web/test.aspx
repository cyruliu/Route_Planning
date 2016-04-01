<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Web.test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            Height="20px" onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
            Width="102px">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" 
            onselectedindexchanged="DropDownList2_SelectedIndexChanged" Height="16px" 
            Width="103px">
        </asp:DropDownList>
    </div>
&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;<br />
&nbsp;景点：&nbsp;&nbsp;<asp:TextBox ID="txt_scence" runat="server"></asp:TextBox>
    <br />
&nbsp;喜欢程度：<asp:TextBox ID="txt_like" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ListBox ID="lst_scence" runat="server" Height="41px" style="margin-top: 0px" 
        Width="215px"></asp:ListBox>
  <br />&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="btn_OK" runat="server" Text="添加" onclick="btn_OK_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_delete" runat="server" Text="删除" 
        onclick="btn_delete_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_Add" runat="server" Text="确定" onclick="btn_Add_Click" />
    </form>
</body>
</html>
