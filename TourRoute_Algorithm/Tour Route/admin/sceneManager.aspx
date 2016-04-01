<%@ Page Title="" Language="C#" MasterPageFile="~/master/ser.Master" AutoEventWireup="true" CodeBehind="sceneManager.aspx.cs" Inherits="Tour_Route.admin.sceneManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/admin.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<br/><br/>
<ul id="userUL">
<li><a id="temp">景点管理</a></li>
<li><a href="cityManager.aspx">城市管理</a></li>
<li><a href="provinceManager.aspx">省份管理</a></li>
</ul>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="ID" 
        DataSourceID="ObjectDataSourceScene" 
        InsertItemPosition="LastItem" style="margin-left: 101px">
        <AlternatingItemTemplate>
            <li style="background-color: #FFF8DC;">ID:
                <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                <br />
                SID:
                <asp:Label ID="SIDLabel" runat="server" Text='<%# Eval("SID") %>' />
                <br />
                景点名:
                <asp:Label ID="S_NameLabel" runat="server" Text='<%# Eval("S_Name") %>' />
                <br />
                所属城市:
                <asp:Label ID="S_BelongCityLabel" runat="server" 
                    Text='<%# Eval("S_BelongCity") %>' />
                <br />
                简介:
                <asp:Label ID="S_DescriptionLabel" runat="server" 
                    Text='<%# Eval("S_Description") %>' />
                <br />
                图片路径:
                <asp:Label ID="S_ImageLabel" runat="server" Text='<%# Eval("S_Image") %>' />
                <br />
                景点位置:
                <asp:Label ID="S_PositionLabel" runat="server" 
                    Text='<%# Eval("S_Position") %>' />
                <br />
                搜索点击率:
                <asp:Label ID="S_HotDegreeLabel" runat="server" 
                    Text='<%# Eval("S_HotDegree") %>' />
                <br />
                所属省份:
                <asp:Label ID="S_BelongProvinceLabel" runat="server" 
                    Text='<%# Eval("S_BelongProvince") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
            </li>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <li style="background-color: #008A8C;color: #FFFFFF;">ID:
                <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                <br />
                SID:
                <asp:TextBox ID="SIDTextBox" runat="server" Text='<%# Bind("SID") %>' />
                <br />
                景点名:
                <asp:TextBox ID="S_NameTextBox" runat="server" Text='<%# Bind("S_Name") %>' />
                <br />
                所属城市:
                <asp:TextBox ID="S_BelongCityTextBox" runat="server" 
                    Text='<%# Bind("S_BelongCity") %>' />
                <br />
                简介:
                <asp:TextBox ID="S_DescriptionTextBox" runat="server" 
                    Text='<%# Bind("S_Description") %>' />
                <br />
                图片路径:
                <asp:TextBox ID="S_ImageTextBox" runat="server" Text='<%# Bind("S_Image") %>' />
                <br />
                景点位置:
                <asp:TextBox ID="S_PositionTextBox" runat="server" 
                    Text='<%# Bind("S_Position") %>' />
                <br />
                搜索点击率:
                <asp:TextBox ID="S_HotDegreeTextBox" runat="server" 
                    Text='<%# Bind("S_HotDegree") %>' />
                <br />
                所属城市:
                <asp:TextBox ID="S_BelongProvinceTextBox" runat="server" 
                    Text='<%# Bind("S_BelongProvince") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="取消" />
            </li>
        </EditItemTemplate>
        <EmptyDataTemplate>
            未返回数据。
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <li style="">SID:
                <asp:TextBox ID="SIDTextBox" runat="server" Text='<%# Bind("SID") %>' />
                <br />
                景点名:
                <asp:TextBox ID="S_NameTextBox" runat="server" Text='<%# Bind("S_Name") %>' />
                <br />
                所属城市:
                <asp:TextBox ID="S_BelongCityTextBox" runat="server" 
                    Text='<%# Bind("S_BelongCity") %>' />
                <br />
                简介:
                <asp:TextBox ID="S_DescriptionTextBox" runat="server" 
                    Text='<%# Bind("S_Description") %>' />
                <br />
                图片路径:
                <asp:TextBox ID="S_ImageTextBox" runat="server" Text='<%# Bind("S_Image") %>' />
                <br />
                景点位置:
                <asp:TextBox ID="S_PositionTextBox" runat="server" 
                    Text='<%# Bind("S_Position") %>' />
                <br />
                搜索点击率:
                <asp:TextBox ID="S_HotDegreeTextBox" runat="server" 
                    Text='<%# Bind("S_HotDegree") %>' />
                <br />
                所属省份:
                <asp:TextBox ID="S_BelongProvinceTextBox" runat="server" 
                    Text='<%# Bind("S_BelongProvince") %>' />
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
                SID:
                <asp:Label ID="SIDLabel" runat="server" Text='<%# Eval("SID") %>' />
                <br />
                景点名:
                <asp:Label ID="S_NameLabel" runat="server" Text='<%# Eval("S_Name") %>' />
                <br />
                所属城市:
                <asp:Label ID="S_BelongCityLabel" runat="server" 
                    Text='<%# Eval("S_BelongCity") %>' />
                <br />
                简介:
                <asp:Label ID="S_DescriptionLabel" runat="server" 
                    Text='<%# Eval("S_Description") %>' />
                <br />
                图片路径:
                <asp:Label ID="S_ImageLabel" runat="server" Text='<%# Eval("S_Image") %>' />
                <br />
                景点位置:
                <asp:Label ID="S_PositionLabel" runat="server" 
                    Text='<%# Eval("S_Position") %>' />
                <br />
                搜索点击量:
                <asp:Label ID="S_HotDegreeLabel" runat="server" 
                    Text='<%# Eval("S_HotDegree") %>' />
                <br />
                所属省份:
                <asp:Label ID="S_BelongProvinceLabel" runat="server" 
                    Text='<%# Eval("S_BelongProvince") %>' />
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
                SID:
                <asp:Label ID="SIDLabel" runat="server" Text='<%# Eval("SID") %>' />
                <br />
                景点名:
                <asp:Label ID="S_NameLabel" runat="server" Text='<%# Eval("S_Name") %>' />
                <br />
                所属城市:
                <asp:Label ID="S_BelongCityLabel" runat="server" 
                    Text='<%# Eval("S_BelongCity") %>' />
                <br />
                简介:
                <asp:Label ID="S_DescriptionLabel" runat="server" 
                    Text='<%# Eval("S_Description") %>' />
                <br />
                图片路径:
                <asp:Label ID="S_ImageLabel" runat="server" Text='<%# Eval("S_Image") %>' />
                <br />
                景点位置:
                <asp:Label ID="S_PositionLabel" runat="server" 
                    Text='<%# Eval("S_Position") %>' />
                <br />
                搜索点击率:
                <asp:Label ID="S_HotDegreeLabel" runat="server" 
                    Text='<%# Eval("S_HotDegree") %>' />
                <br />
                所属省份:
                <asp:Label ID="S_BelongProvinceLabel" runat="server" 
                    Text='<%# Eval("S_BelongProvince") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
            </li>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:ObjectDataSource ID="ObjectDataSourceScene" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="Tour_Route.DAL.D_DataSet.DataSetSceneTableAdapters.tb_sceneTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="SID" Type="Int32" />
            <asp:Parameter Name="S_Name" Type="String" />
            <asp:Parameter Name="S_BelongCity" Type="String" />
            <asp:Parameter Name="S_Description" Type="String" />
            <asp:Parameter Name="S_Image" Type="String" />
            <asp:Parameter Name="S_Position" Type="String" />
            <asp:Parameter Name="S_HotDegree" Type="Int32" />
            <asp:Parameter Name="S_BelongProvince" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="SID" Type="Int32" />
            <asp:Parameter Name="S_Name" Type="String" />
            <asp:Parameter Name="S_BelongCity" Type="String" />
            <asp:Parameter Name="S_Description" Type="String" />
            <asp:Parameter Name="S_Image" Type="String" />
            <asp:Parameter Name="S_Position" Type="String" />
            <asp:Parameter Name="S_HotDegree" Type="Int32" />
            <asp:Parameter Name="S_BelongProvince" Type="String" />
            <asp:Parameter Name="Original_ID" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" 
        PageSize="1">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                ShowNextPageButton="False" ShowPreviousPageButton="False" />
            <asp:NumericPagerField />
            <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" 
                ShowNextPageButton="False" ShowPreviousPageButton="False" />
        </Fields>
    </asp:DataPager>
</asp:Content>
