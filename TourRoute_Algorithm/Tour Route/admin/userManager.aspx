<%@ Page Title="" Language="C#" MasterPageFile="~/master/ser.Master" AutoEventWireup="true" CodeBehind="userManager.aspx.cs" Inherits="Tour_Route.admin.userManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/admin.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
<br/><br/>
<ul id="userUL">
<li><a id="temp">用户权限</a></li>
<li><a href="userInfoManager.aspx">用户信息</a></li>
</ul>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="ID" 
        DataSourceID="ObjectDataSourceUser" InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <tr style="background-color: #FFF8DC;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                </td>
                <td>
                    <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                </td>
                <td>
                    <asp:Label ID="UIDLabel" runat="server" Text='<%# Eval("UID") %>' />
                </td>
                <td>
                    <asp:Label ID="U_NameLabel" runat="server" Text='<%# Eval("U_Name") %>' />
                </td>
                <td>
                    <asp:Label ID="U_PwdLabel" runat="server" Text='<%# Eval("U_Pwd") %>' />
                </td>
                <td>
                    <asp:Label ID="U_LevelLabel" runat="server" Text='<%# Eval("U_Level") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="background-color: #008A8C; color: #FFFFFF;">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="取消" />
                </td>
                <td>
                    <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UIDTextBox" runat="server" Text='<%# Bind("UID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="U_NameTextBox" runat="server" Text='<%# Bind("U_Name") %>' />
                </td>
                <td>
                    <asp:TextBox ID="U_PwdTextBox" runat="server" Text='<%# Bind("U_Pwd") %>' />
                </td>
                <td>
                    <asp:TextBox ID="U_LevelTextBox" runat="server" Text='<%# Bind("U_Level") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" 
                style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
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
                    <asp:TextBox ID="UIDTextBox" runat="server" Text='<%# Bind("UID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="U_NameTextBox" runat="server" Text='<%# Bind("U_Name") %>' />
                </td>
                <td>
                    <asp:TextBox ID="U_PwdTextBox" runat="server" Text='<%# Bind("U_Pwd") %>' />
                </td>
                <td>
                    <asp:TextBox ID="U_LevelTextBox" runat="server" Text='<%# Bind("U_Level") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="background-color: #DCDCDC; color: #000000;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                </td>
                <td>
                    <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                </td>
                <td>
                    <asp:Label ID="UIDLabel" runat="server" Text='<%# Eval("UID") %>' />
                </td>
                <td>
                    <asp:Label ID="U_NameLabel" runat="server" Text='<%# Eval("U_Name") %>' />
                </td>
                <td>
                    <asp:Label ID="U_PwdLabel" runat="server" Text='<%# Eval("U_Pwd") %>' />
                </td>
                <td>
                    <asp:Label ID="U_LevelLabel" runat="server" Text='<%# Eval("U_Level") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table ID="itemPlaceholderContainer" runat="server" border="1" 
                            style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr runat="server" style="background-color: #DCDCDC; color: #000000;">
                                <th runat="server">
                                </th>
                                <th runat="server">
                                    ID</th>
                                <th runat="server">
                                    用户ID(必填)</th>
                                <th runat="server">
                                    用户名</th>
                                <th runat="server">
                                    密码</th>
                                <th runat="server">
                                    用户权限</th>
                            </tr>
                            <tr ID="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" 
                        style="text-align: center; background-color: #CCCCCC; font-family: Verdana, Arial, Helvetica, sans-serif; color: #000000;">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="background-color: #008A8C; font-weight: bold; color: #FFFFFF;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                </td>
                <td>
                    <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                </td>
                <td>
                    <asp:Label ID="UIDLabel" runat="server" Text='<%# Eval("UID") %>' />
                </td>
                <td>
                    <asp:Label ID="U_NameLabel" runat="server" Text='<%# Eval("U_Name") %>' />
                </td>
                <td>
                    <asp:Label ID="U_PwdLabel" runat="server" Text='<%# Eval("U_Pwd") %>' />
                </td>
                <td>
                    <asp:Label ID="U_LevelLabel" runat="server" Text='<%# Eval("U_Level") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" 
        PageSize="15">
    </asp:DataPager>
    <asp:ObjectDataSource ID="ObjectDataSourceUser" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="Tour_Route.DAL.D_DataSet.DataSetUserTableAdapters.tb_userTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="UID" Type="Int32" />
            <asp:Parameter Name="U_Name" Type="String" />
            <asp:Parameter Name="U_Pwd" Type="String" />
            <asp:Parameter Name="U_Level" Type="Int32" />
            <asp:Parameter Name="U_ErrorTimes" Type="Int32" />
            <asp:Parameter Name="U_LastErrorTime" Type="DateTime" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="UID" Type="Int32" />
            <asp:Parameter Name="U_Name" Type="String" />
            <asp:Parameter Name="U_Pwd" Type="String" />
            <asp:Parameter Name="U_Level" Type="Int32" />
            <asp:Parameter Name="U_ErrorTimes" Type="Int32" />
            <asp:Parameter Name="U_LastErrorTime" Type="DateTime" />
            <asp:Parameter Name="Original_ID" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>
