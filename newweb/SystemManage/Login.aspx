<%--文件名:Login.aspx--%>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="System_Login" Title="当前位置：系统管理->登录管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 561px; height: 237px">
        <tr>
            <td style="width: 180px; height: 145px">
            </td>
            <td style="width: 202px; height: 45px">
                <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8"
                    BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" 
                    Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" Height="90px"
                    Width="196px">
                    <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <TextBoxStyle Font-Size="0.8em" />
                    <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                        Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                    <LayoutTemplate>
                        <table border="0" cellpadding="4" cellspacing="0" style="width: 247px; border-collapse: collapse;
                            height: 219px">
                            <tr>
                                <td align="center" style="width: 221px">
                                    <table border="0" cellpadding="0" style="width: 205px; height: 112px">
                                        <tr>
                                            <td align="center" style="font-weight: bold; font-size: 0.9em; width: 209px; color: honeydew;
                                                background-color: darkblue; height: 15px;">
                                                登录管理系统</td>
                                        </tr>
                                        <tr>
                                            <td style="width: 209px">
                                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">用户名称:</asp:Label><asp:TextBox
                                                    ID="UserName" runat="server" Font-Size="0.8em" Width="119px"></asp:TextBox><asp:RequiredFieldValidator
                                                        ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="必须填写“用户名”。"
                                                        ToolTip="必须填写“用户名”。" ValidationGroup="Login1">*</asp:RequiredFieldValidator></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 209px">
                                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">用户密码:</asp:Label><asp:TextBox
                                                    ID="Password" runat="server" Font-Size="0.8em" TextMode="Password" Width="119px"></asp:TextBox><asp:RequiredFieldValidator
                                                        ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="必须填写“密码”。"
                                                        ToolTip="必须填写“密码”。" ValidationGroup="Login1">*</asp:RequiredFieldValidator></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 209px">
                                                <asp:CheckBox ID="RememberMe" runat="server" Text="下次记住我。" />
                                                <asp:Button ID="LoginButton" runat="server" BackColor="White" BorderColor="#CC9966"
                                                    BorderStyle="Solid" BorderWidth="1px" CommandName="Login" Font-Names="宋体" Font-Size="Small"
                                                    ForeColor="#990000" Text="登录管理系统" ValidationGroup="Login1" Width="82px" OnClick="LoginButton_Click" />
                                                <br />
                                                <br />
                                                <br />
                                                <br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" style="width: 209px; color: red">
                                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                            </td>
                                        </tr>
                                    </table>
                                    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/SystemManage/RegisterUser.aspx">新建操作用户</asp:LinkButton>
                                    <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/SystemManage/PasswordRecovery.aspx">查询用户密码</asp:LinkButton></td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                </asp:Login>
            </td>
            <td style="width: 136px; height: 145px">
            </td>
        </tr>
    </table>
</asp:Content>

