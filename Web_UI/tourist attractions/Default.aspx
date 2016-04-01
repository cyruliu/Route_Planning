<%@ Page Title="" Language="C#" MasterPageFile="~/Common.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tourist_attractions.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <style type="text/css">
        #map
        {
            height: 742px;
        }
        #btnSearch
        {
            height: 33px;
            width: 62px;
        }
        #searchtext
        {
            height: 24px;
            width: 150px;
        }
    </style>
   
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <input id="searchtext" type="text"  />
    &nbsp;&nbsp;
    <input id="btnSearch" type="button" value="搜索" onclick="searchlocal1()"/>
    <br/>
    <br/>
    <div id="map"></div>
    <script src="Script/loadMap.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
