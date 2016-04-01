<%@ Page Title="" Language="C#" MasterPageFile="~/master/ser.Master" AutoEventWireup="true" CodeBehind="evaluateManager.aspx.cs" Inherits="Tour_Route.admin.evaluateManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/admin.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<br/><br/>
<ul id="userUL">
<li><a href="routeAndevaluateManager.aspx">路线管理</a></li>
<li><a id="temp">评价管理</a></li>
</ul>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="ID" 
        DataSourceID="ObjectDataSourceEvaluate" InsertItemPosition="LastItem">
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
                    <asp:Label ID="UIDLabel" runat="server" Text='<%# Eval("UID") %>' />
                </td>
                <td>
                    <asp:Label ID="E_EvaluateLabel" runat="server" 
                        Text='<%# Eval("E_Evaluate") %>' />
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
                    <asp:TextBox ID="UIDTextBox" runat="server" Text='<%# Bind("UID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="E_EvaluateTextBox" runat="server" 
                        Text='<%# Bind("E_Evaluate") %>' />
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
                    <asp:TextBox ID="UIDTextBox" runat="server" Text='<%# Bind("UID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="E_EvaluateTextBox" runat="server" 
                        Text='<%# Bind("E_Evaluate") %>' />
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
                    <asp:Label ID="UIDLabel" runat="server" Text='<%# Eval("UID") %>' />
                </td>
                <td>
                    <asp:Label ID="E_EvaluateLabel" runat="server" 
                        Text='<%# Eval("E_Evaluate") %>' />
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
                                    用户ID</th>
                                <th runat="server">
                                    评价</th>
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
                    <asp:Label ID="UIDLabel" runat="server" Text='<%# Eval("UID") %>' />
                </td>
                <td>
                    <asp:Label ID="E_EvaluateLabel" runat="server" 
                        Text='<%# Eval("E_Evaluate") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" 
        PageSize="18">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                ShowNextPageButton="False" ShowPreviousPageButton="False" />
            <asp:NumericPagerField />
            <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" 
                ShowNextPageButton="False" ShowPreviousPageButton="False" />
        </Fields>
    </asp:DataPager>
    <asp:ObjectDataSource ID="ObjectDataSourceEvaluate" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="Tour_Route.DAL.D_DataSet.DataSetEvaluateTableAdapters.tb_evaluateTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="UID" Type="Int32" />
            <asp:Parameter Name="E_Evaluate" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="UID" Type="Int32" />
            <asp:Parameter Name="E_Evaluate" Type="String" />
            <asp:Parameter Name="Original_ID" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>
