<%@ Page Title="" Language="C#" MasterPageFile="~/master/client.Master" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="Tour_Route.UserInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="省份排名" style="height: 348px; width: 219px">
<center style="color:Red; font-size:large; width: 188px;">十大热点省份</center>
   <center>
    <asp:Repeater ID="RepeaterProvince" runat="server">
    <HeaderTemplate><table><tr><td>省份</td><td>搜索点击量</td></tr></HeaderTemplate>
    <ItemTemplate><tr><td><%#Eval("P_Name") %></td><td><%#Eval("P_HotDegree") %></td></tr></ItemTemplate>
    <FooterTemplate></table></FooterTemplate>
    </asp:Repeater>
    </center>
</div>
<div id="所选省份的城市排名" style="height: 406px; width: 217px;">
    <center>
    <asp:Label ID="Label2" runat="server" Text="要查询的省份："></asp:Label>
    <asp:DropDownList ID="DropDownListProvince" runat="server"  
        style="margin-left: 0px" Width="83px" AutoPostBack="True" 
        onselectedindexchanged="DropDownListProvince_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:Repeater ID="RepeaterScene" runat="server">
    <HeaderTemplate><table><tr><td>景点</td><td>城市</td><td>搜索点击量</td></tr></HeaderTemplate>
    <ItemTemplate><tr><td><%#Eval("S_Name") %></td><td> <%#Eval("S_BelongCity") %></td><td><%#Eval("S_HotDegree") %></td></tr></ItemTemplate>
    <FooterTemplate></table></FooterTemplate>
    </asp:Repeater>
    </center>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
 <asp:Image ID="ImageProTop1" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
        &nbsp;
     <asp:Image ID="ImageProTop2" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
           &nbsp;
     <asp:Image ID="ImageProTop3" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
           &nbsp;
     <asp:Image ID="ImageProTop4" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
           &nbsp;
     <asp:Image ID="ImageProTop5" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
           &nbsp;
         <asp:Image ID="ImageProTop6" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
          
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div style="height: 300px">
    <center>
    <asp:Label ID="Label1" runat="server" Text="请输入旅游城市：" Font-Bold="true" Font-Size="Large"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" 
            ontextchanged="TextBox1_TextChanged" AutoPostBack="True"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="(按回车查询)"></asp:Label>
        <hr />
    <div id="城市景点排名" style="height: 203px">
        <asp:Repeater ID="RepeaterSceneByCity" runat="server">
          <HeaderTemplate><table><tr><td>景点</td><td>城市</td><td>简介</td><td>点击量</td></tr></HeaderTemplate>
    <ItemTemplate><tr><td><%#Eval("S_Name") %></td><td><%#Eval("S_BelongCity") %></td>
    <td><%#Eval("S_Description") %></td><td><%#Eval("S_HotDegree") %></td></tr></ItemTemplate>
    <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
    </div>
    </center>

    <div id="用户信息" style="height: 282px; margin-top: 78px;">
    <hr style="height: -15px"/>
    <table>
    <tr>
    <td></td>
    </tr>
    </table>
    </div>
</div>
</asp:Content>
