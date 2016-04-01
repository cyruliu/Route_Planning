<%@ Page Title="" Language="C#" MasterPageFile="~/master/client.Master" AutoEventWireup="true" CodeBehind="formRoute.aspx.cs" Inherits="Tour_Route.formRoute" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="http://api.map.baidu.com/api?v=1.3"></script> 
    <style type="text/css">
        #map
        {
            height: 632px;
        }
        .style1
        {
            width: 108px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 104%; height: 775px;">
    <tr><td style="color:Red" class="style1">热点景区</td></tr>
        <tr>
            <td class="style1">
                <asp:Image ID="Image16" ImageUrl="" style="height: 136px; width: 113px" runat="server" />
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="景点:"></asp:Label>
                <br/>
                <asp:Label ID="Label2" runat="server" Text="简介:"></asp:Label>
            </td>
        </tr>
            <tr>
            <td class="style1">
               <asp:Image ID="Image17" ImageUrl="" style="height: 136px; width: 113px" runat="server" />
            </td>
             <td>
                <asp:Label ID="Label3" runat="server" Text="景点:"></asp:Label>
                <br/>
                <asp:Label ID="Label4" runat="server" Text="简介:"></asp:Label>
            </td>
        </tr>  <tr>
            <td class="style1">
               <asp:Image ID="Image18" ImageUrl="" style="height: 136px; width: 113px" runat="server" />
            </td>
             <td>
                <asp:Label ID="Label5" runat="server" Text="景点:"></asp:Label>
                <br/>
                <asp:Label ID="Label6" runat="server" Text="简介:"></asp:Label>
            </td>
        </tr>  <tr>
            <td class="style1">
                <asp:Image ID="Image19" ImageUrl="" style="height: 136px; width: 113px" runat="server" />
            </td>
             <td>
                <asp:Label ID="Label7" runat="server" Text="景点:"></asp:Label>
                <br/>
                <asp:Label ID="Label8" runat="server" Text="简介:"></asp:Label>
            </td>
        </tr>  <tr>
            <td class="style1">
                <asp:Image ID="Image20" ImageUrl="" style="height: 136px; width: 113px" runat="server" />
            </td>
             <td>
                <asp:Label ID="Label9" runat="server" Text="景点:"></asp:Label>
                <br/>
                <asp:Label ID="Label10" runat="server" Text="简介:"></asp:Label>
            </td>
        </tr>

       
    </table>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
     <asp:Image ID="Image21" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
        &nbsp;
     <asp:Image ID="Image22" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
           &nbsp;
     <asp:Image ID="Image23" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
           &nbsp;
     <asp:Image ID="Image24" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
           &nbsp;
     <asp:Image ID="Image25" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
           &nbsp;
         <asp:Image ID="Image26" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
          
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <input id="searchtext" type="text"  />
    &nbsp;&nbsp;
    <input id="btnSearch" type="button" value="搜索" onclick="searchlocal1()"/>
    <br/>
    <br/>
    <div id="map"></div>
    <script src="scripts/loadMap.js" type="text/javascript"></script>
</asp:Content>

