<%@ Page Title="" Language="C#" MasterPageFile="~/master/ser.Master" AutoEventWireup="true" CodeBehind="cityManager.aspx.cs" Inherits="Tour_Route.admin.cityManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/admin.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<br/><br/>
<ul id="userUL">
<li><a href="sceneManager.aspx">景点管理</a></li>
<li><a id="temp">城市管理</a></li>
<li><a href="provinceManager.aspx">省份管理</a></li>
</ul>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="ID" 
        DataSourceID="ObjectDataSourceCity" 
        InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <li style="background-color: #FFF8DC;">ID:
                <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                <br />
                CID:
                <asp:Label ID="CIDLabel" runat="server" Text='<%# Eval("CID") %>' />
                <br />
                城市名:
                <asp:Label ID="C_NameLabel" runat="server" Text='<%# Eval("C_Name") %>' />
                <br />
                所属省份:
                <asp:Label ID="C_BelongProvinceLabel" runat="server" 
                    Text='<%# Eval("C_BelongProvince") %>' />
                <br />
                简介:
                <asp:Label ID="C_DescriptionLabel" runat="server" 
                    Text='<%# Eval("C_Description") %>' />
                <br />
                图片路径:
                <asp:Label ID="C_ImageLabel" runat="server" Text='<%# Eval("C_Image") %>' />
                <br />
                搜索点击率:
                <asp:Label ID="C_HotDegreeLabel" runat="server" 
                    Text='<%# Eval("C_HotDegree") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
            </li>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <li style="background-color: #008A8C;color: #FFFFFF;">ID:
                <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                <br />
                CID:
                <asp:TextBox ID="CIDTextBox" runat="server" Text='<%# Bind("CID") %>' />
                <br />
                城市名:
                <asp:TextBox ID="C_NameTextBox" runat="server" Text='<%# Bind("C_Name") %>' />
                <br />
                所属省份:
                <asp:TextBox ID="C_BelongProvinceTextBox" runat="server" 
                    Text='<%# Bind("C_BelongProvince") %>' />
                <br />
                简介:
                <asp:TextBox ID="C_DescriptionTextBox" runat="server" 
                    Text='<%# Bind("C_Description") %>' />
                <br />
                图片路径:
                <asp:TextBox ID="C_ImageTextBox" runat="server" Text='<%# Bind("C_Image") %>' />
                <br />
                搜索点击率:
                <asp:TextBox ID="C_HotDegreeTextBox" runat="server" 
                    Text='<%# Bind("C_HotDegree") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="取消" />
            </li>
        </EditItemTemplate>
        <EmptyDataTemplate>
            未返回数据。
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <li style="">CID:
                <asp:TextBox ID="CIDTextBox" runat="server" Text='<%# Bind("CID") %>' />
                <br />
                城市名:
                <asp:TextBox ID="C_NameTextBox" runat="server" Text='<%# Bind("C_Name") %>' />
                <br />
                所属省份:
                <asp:TextBox ID="C_BelongProvinceTextBox" runat="server" 
                    Text='<%# Bind("C_BelongProvince") %>' />
                <br />
                简介:
                <asp:TextBox ID="C_DescriptionTextBox" runat="server" 
                    Text='<%# Bind("C_Description") %>' />
                <br />
                图片路径:
                <asp:TextBox ID="C_ImageTextBox" runat="server" Text='<%# Bind("C_Image") %>' />
                <br />
                搜索点击率:
                <asp:TextBox ID="C_HotDegreeTextBox" runat="server" 
                    Text='<%# Bind("C_HotDegree") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="插入" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="清除" />
            </li>
        </InsertItemTemplate>
        <ItemSeparatorTemplate>
            <br />
        </ItemSeparatorTemplate>
        <ItemTemplate>
            <li style="background-color: #DCDCDC;color: #000000;">ID:
                <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                <br />
                CID:
                <asp:Label ID="CIDLabel" runat="server" Text='<%# Eval("CID") %>' />
                <br />
                城市名:
                <asp:Label ID="C_NameLabel" runat="server" Text='<%# Eval("C_Name") %>' />
                <br />
                所属省份:
                <asp:Label ID="C_BelongProvinceLabel" runat="server" 
                    Text='<%# Eval("C_BelongProvince") %>' />
                <br />
                简介:
                <asp:Label ID="C_DescriptionLabel" runat="server" 
                    Text='<%# Eval("C_Description") %>' />
                <br />
                图片路径:
                <asp:Label ID="C_ImageLabel" runat="server" Text='<%# Eval("C_Image") %>' />
                <br />
                搜索点击率:
                <asp:Label ID="C_HotDegreeLabel" runat="server" 
                    Text='<%# Eval("C_HotDegree") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
            </li>
        </ItemTemplate>
        <LayoutTemplate>
            <ul ID="itemPlaceholderContainer" runat="server" 
                style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                <li runat="server" id="itemPlaceholder" />
            </ul>
            <div style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <li style="background-color: #008A8C;font-weight: bold;color: #FFFFFF;">ID:
                <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                <br />
                CID:
                <asp:Label ID="CIDLabel" runat="server" Text='<%# Eval("CID") %>' />
                <br />
                城市名:
                <asp:Label ID="C_NameLabel" runat="server" Text='<%# Eval("C_Name") %>' />
                <br />
                所属省份:
                <asp:Label ID="C_BelongProvinceLabel" runat="server" 
                    Text='<%# Eval("C_BelongProvince") %>' />
                <br />
                简介:
                <asp:Label ID="C_DescriptionLabel" runat="server" 
                    Text='<%# Eval("C_Description") %>' />
                <br />
                图片路径:
                <asp:Label ID="C_ImageLabel" runat="server" Text='<%# Eval("C_Image") %>' />
                <br />
                搜索点击率:
                <asp:Label ID="C_HotDegreeLabel" runat="server" 
                    Text='<%# Eval("C_HotDegree") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
            </li>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" 
        PageSize="2">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                ShowNextPageButton="False" ShowPreviousPageButton="False" />
            <asp:NumericPagerField />
            <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" 
                ShowNextPageButton="False" ShowPreviousPageButton="False" />
        </Fields>
    </asp:DataPager>
    <asp:ObjectDataSource ID="ObjectDataSourceCity" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="Tour_Route.DAL.D_DataSet.DataSetCityTableAdapters.tb_cityTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_ID" Type="Int64" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="CID" Type="Int64" />
            <asp:Parameter Name="C_Name" Type="String" />
            <asp:Parameter Name="C_BelongProvince" Type="String" />
            <asp:Parameter Name="C_Description" Type="String" />
            <asp:Parameter Name="C_Image" Type="String" />
            <asp:Parameter Name="C_HotDegree" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="CID" Type="Int64" />
            <asp:Parameter Name="C_Name" Type="String" />
            <asp:Parameter Name="C_BelongProvince" Type="String" />
            <asp:Parameter Name="C_Description" Type="String" />
            <asp:Parameter Name="C_Image" Type="String" />
            <asp:Parameter Name="C_HotDegree" Type="Int32" />
            <asp:Parameter Name="Original_ID" Type="Int64" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>
