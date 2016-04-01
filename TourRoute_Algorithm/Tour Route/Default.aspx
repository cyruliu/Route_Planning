<%@ Page Title="" Language="C#" MasterPageFile="~/master/client.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tour_Route.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 106px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 102%; height: 776px;">
    <tr><td style="color:Red">TOP5热点城市</td></tr>
        <tr>
            <td class="style1">
                <asp:Image ID="ImageCity1" ImageUrl="" style="height: 136px; width: 113px" runat="server" />
            </td>
            <td>
                <asp:Label ID="LabelCity1" runat="server" Text="城市:"></asp:Label>
                <br/>
                <asp:Label ID="LabelJianjie1" runat="server" Text="简介:"></asp:Label>
            </td>
        </tr>
            <tr>
            <td class="style1">
               <asp:Image ID="ImageCity2" ImageUrl="" style="height: 136px; width: 113px" runat="server" />
            </td>
             <td>
                <asp:Label ID="LabelCity2" runat="server" Text="城市:"></asp:Label>
                <br/>
                <asp:Label ID="LabelJianjie2" runat="server" Text="简介:"></asp:Label>
            </td>
        </tr>  <tr>
            <td class="style1">
               <asp:Image ID="ImageCity3" ImageUrl="" style="height: 136px; width: 113px" runat="server" />
            </td>
             <td>
                <asp:Label ID="LabelCity3" runat="server" Text="城市:"></asp:Label>
                <br/>
                <asp:Label ID="LabelJianjie3" runat="server" Text="简介:"></asp:Label>
            </td>
        </tr>  <tr>
            <td class="style1">
                <asp:Image ID="ImageCity4" ImageUrl="" style="height: 136px; width: 113px" runat="server" />
            </td>
             <td>
                <asp:Label ID="LabelCity4" runat="server" Text="城市:"></asp:Label>
                <br/>
                <asp:Label ID="LabelJianjie4" runat="server" Text="简介:"></asp:Label>
            </td>
        </tr>  <tr>
            <td class="style1">
                <asp:Image ID="ImageCity5" ImageUrl="" style="height: 136px; width: 113px" runat="server" />
            </td>
             <td>
                <asp:Label ID="LabelCity5" runat="server" Text="城市:"></asp:Label>
                <br/>
                <asp:Label ID="LabelJianjie5" runat="server" Text="简介:"></asp:Label>
            </td>
        </tr>

       
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <asp:Image ID="Imagefloat1" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
        &nbsp;
     <asp:Image ID="Imagefloat2" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
           &nbsp;
     <asp:Image ID="Imagefloat3" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
           &nbsp;
     <asp:Image ID="Imagefloat4" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
           &nbsp;
     <asp:Image ID="Imagefloat5" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />
           &nbsp;
         <asp:Image ID="Imagefloat6" ImageUrl="" runat="server" Height="129px" 
        Width="100px" />      
         </asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style="width: 100%; height: 651px;">
        <tr>
            <td>
                 <asp:Image ID="ImageMain1" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
            <td>
                <asp:Image ID="ImageMain2" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
            <td>
              <asp:Image ID="ImageMain3" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
             <td>
                 <asp:Image ID="ImageMain4" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
            <td>
               <asp:Image ID="ImageMain5" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
        </tr>
          <tr>
            <td>
               <asp:Image ID="ImageMain6" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
            <td>
             <asp:Image ID="ImageMain7" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
            <td>
              <asp:Image ID="ImageMain8" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
             <td>
               <asp:Image ID="ImageMain9" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
            <td>
                <asp:Image ID="ImageMain10" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
        </tr>
          <tr>
            <td>
              <asp:Image ID="ImageMain11" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
            <td>
             <asp:Image ID="ImageMain12" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
            <td>
               <asp:Image ID="ImageMain13" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
             <td>
                <asp:Image ID="ImageMain14" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
            <td>
              <asp:Image ID="ImageMain15" ImageUrl="" style="height: 181px; width: 148px" runat="server" />
            </td>
        </tr>
      
    </table>
</asp:Content>
