<%--文件名:UserInfo.aspx--%>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserInfo.aspx.cs" Inherits="System_UserInfo" Title="当前位置：系统管理->修改用户信息" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="font-size: 0.8em">
        <tr>
            <td style="width: 116px">
            </td>
            <td style="width: 332px; font-weight: bold; color: white; background-color: darkblue;" align="center">
                修改用户注册信息</td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 116px; height: 140px">
            </td>
            <td style="width: 332px; height: 140px">
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White"
                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3"
                    DataSourceID="ObjectDataSource1" GridLines="Vertical" Height="1px" OnItemUpdating="DetailsView1_ItemUpdating"
                    Width="370px">
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <Fields>
                        <asp:BoundField DataField="ProviderName" HeaderText="提供程序名称：" ReadOnly="True" SortExpression="ProviderName" />
                        <asp:CheckBoxField DataField="IsOnline" HeaderText="是否在线：" ReadOnly="True" SortExpression="IsOnline" />
                        <asp:BoundField DataField="LastPasswordChangedDate" HeaderText="密码最近修改日期：" ReadOnly="True"
                            SortExpression="LastPasswordChangedDate" />
                        <asp:BoundField DataField="PasswordQuestion" HeaderText="提示问题：" ReadOnly="True" SortExpression="PasswordQuestion" />
                        <asp:CheckBoxField DataField="IsLockedOut" HeaderText="是否锁定密码：" ReadOnly="True" SortExpression="IsLockedOut" />
                        <asp:BoundField DataField="Comment" HeaderText="说明：" SortExpression="Comment" />
                        <asp:BoundField DataField="UserName" HeaderText="用户名称：" ReadOnly="True" SortExpression="UserName" />
                        <asp:BoundField DataField="Email" HeaderText="电子邮件：" SortExpression="Email" />
                        <asp:BoundField DataField="CreationDate" HeaderText="新建时间：" ReadOnly="True" SortExpression="CreationDate" />
                        <asp:CheckBoxField DataField="IsApproved" HeaderText="是否检查：" SortExpression="IsApproved" />
                        <asp:BoundField DataField="LastLockoutDate" HeaderText="最近锁定时间：" ReadOnly="True"
                            SortExpression="LastLockoutDate" />
                        <asp:BoundField DataField="LastLoginDate" HeaderText="最近登录时间：" SortExpression="LastLoginDate" />
                        <asp:BoundField DataField="LastActivityDate" HeaderText="最近使用时间：" SortExpression="LastActivityDate" />
                        <asp:CommandField ShowEditButton="True" />
                    </Fields>
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                </asp:DetailsView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="System.Web.Security.MembershipUser"
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetUser" TypeName="System.Web.Security.Membership"
                    UpdateMethod="UpdateUser"></asp:ObjectDataSource>
            </td>
            <td style="width: 100px; height: 140px">
            </td>
        </tr>
    </table>
</asp:Content>

