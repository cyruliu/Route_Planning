<%@ Page Title="" Language="C#" MasterPageFile="~/master/ser.Master" AutoEventWireup="true" CodeBehind="provinceManager.aspx.cs" Inherits="Tour_Route.admin.provinceManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/admin.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<br/><br/>
<ul id="userUL">
<li><a href="sceneManager.aspx">景点管理</a></li>
<li><a href="cityManager.aspx">城市管理</a></li>
<li><a id="temp">省份管理</a></li>
</ul>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Label ID="Label1" runat="server" Text="注：陕西省图片路径(shanxi2)"></asp:Label>
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="ID" 
        DataSourceID="ObjectDataSourceProvince" InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <tr style="background-color:#FFF8DC;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                </td>
                <td>
                    <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                </td>
                <td>
                    <asp:Label ID="PIDLabel" runat="server" Text='<%# Eval("PID") %>' />
                </td>
                <td>
                    <asp:Label ID="P_NameLabel" runat="server" Text='<%# Eval("P_Name") %>' />
                </td>
                <td>
                    <asp:Label ID="P_HotDegreeLabel" runat="server" 
                        Text='<%# Eval("P_HotDegree") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="background-color:#008A8C;color: #FFFFFF;">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="取消" />
                </td>
                <td>
                    <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PIDTextBox" runat="server" Text='<%# Bind("PID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="P_NameTextBox" runat="server" Text='<%# Bind("P_Name") %>' />
                </td>
                <td>
                    <asp:TextBox ID="P_HotDegreeTextBox" runat="server" 
                        Text='<%# Bind("P_HotDegree") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" 
                style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>
                        未返回数据。</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="插入" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="清除" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="PIDTextBox" runat="server" Text='<%# Bind("PID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="P_NameTextBox" runat="server" Text='<%# Bind("P_Name") %>' />
                </td>
                <td>
                    <asp:TextBox ID="P_HotDegreeTextBox" runat="server" 
                        Text='<%# Bind("P_HotDegree") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="background-color:#DCDCDC;color: #000000;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                </td>
                <td>
                    <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                </td>
                <td>
                    <asp:Label ID="PIDLabel" runat="server" Text='<%# Eval("PID") %>' />
                </td>
                <td>
                    <asp:Label ID="P_NameLabel" runat="server" Text='<%# Eval("P_Name") %>' />
                </td>
                <td>
                    <asp:Label ID="P_HotDegreeLabel" runat="server" 
                        Text='<%# Eval("P_HotDegree") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table ID="itemPlaceholderContainer" runat="server" border="1" 
                            style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                <th runat="server">
                                </th>
                                <th runat="server">
                                    ID</th>
                                <th runat="server">
                                    PID</th>
                                <th runat="server">
                                    省名</th>
                                <th runat="server">
                                    搜索点击率</th>
                            </tr>
                            <tr ID="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" 
                        style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                </td>
                <td>
                    <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                </td>
                <td>
                    <asp:Label ID="PIDLabel" runat="server" Text='<%# Eval("PID") %>' />
                </td>
                <td>
                    <asp:Label ID="P_NameLabel" runat="server" Text='<%# Eval("P_Name") %>' />
                </td>
                <td>
                    <asp:Label ID="P_HotDegreeLabel" runat="server" 
                        Text='<%# Eval("P_HotDegree") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" 
        PageSize="15">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                ShowNextPageButton="False" ShowPreviousPageButton="False" />
            <asp:NumericPagerField />
            <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" 
                ShowNextPageButton="False" ShowPreviousPageButton="False" />
        </Fields>
    </asp:DataPager>
    <asp:ObjectDataSource ID="ObjectDataSourceProvince" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="Tour_Route.DAL.D_DataSet.DataSetProvinceTableAdapters.tb_provinceTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="PID" Type="Int32" />
            <asp:Parameter Name="P_Name" Type="String" />
            <asp:Parameter Name="P_HotDegree" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="PID" Type="Int32" />
            <asp:Parameter Name="P_Name" Type="String" />
            <asp:Parameter Name="P_HotDegree" Type="Int32" />
            <asp:Parameter Name="Original_ID" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>
