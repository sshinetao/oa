<%--文件名:PasswordRecovery.aspx--%>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PasswordRecovery.aspx.cs" Inherits="System_PasswordRecovery" Title="当前位置：系统管理->查询用户密码" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 558px; height: 144px">
        <tr>
            <td style="width: 147px; height: 81px">
            </td>
            <td style="width: 98px; height: 81px">
                <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BackColor="#E3EAEB" BorderColor="#E6E2D8"
                    BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana"
                    Font-Size="0.8em" Height="87px" Width="270px">
                    <QuestionTemplate>
                        <table border="0" cellpadding="4" cellspacing="0" style="width: 259px; border-collapse: collapse;
                            height: 179px">
                            <tr>
                                <td>
                                    <table border="0" cellpadding="0" style="width: 266px; height: 53px">
                                        <tr>
                                            <td align="center" colspan="2" style="font-weight: bold; font-size: 0.9em; color: white;
                                                height: 15px; background-color: darkblue">
                                                验证用户提问答案</td>
                                        </tr>
                                        <tr>
                                            <td align="left" colspan="2" style="color: black; font-style: normal">
                                                要接收您的密码，请回答下列问题:</td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 60px">
                                                用户名称:</td>
                                            <td>
                                                <asp:Literal ID="UserName" runat="server"></asp:Literal>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 60px">
                                                提示问题:</td>
                                            <td>
                                                <asp:Literal ID="Question" runat="server"></asp:Literal>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 60px">
                                                安全<asp:Label ID="AnswerLabel" runat="server" AssociatedControlID="Answer">答案:</asp:Label></td>
                                            <td>
                                                <asp:TextBox ID="Answer" runat="server" Font-Size="0.8em" Width="115px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer"
                                                    ErrorMessage="需要答案。" ToolTip="需要答案。" ValidationGroup="PasswordRecovery1">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="2" style="color: red; height: 16px">
                                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="2">
                                                <asp:Button ID="SubmitButton" runat="server" BackColor="White" BorderColor="#CC9966"
                                                    BorderStyle="Solid" BorderWidth="1px" CommandName="Submit" Font-Names="宋体" Font-Size="Small"
                                                    ForeColor="#990000" Text="提交密码查询请求" ValidationGroup="PasswordRecovery1" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </QuestionTemplate>
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <SuccessTextStyle Font-Bold="True" ForeColor="#1C5E55" />
                    <TextBoxStyle Font-Size="0.8em" />
                    <UserNameTemplate>
                        <table border="0" cellpadding="4" cellspacing="0" style="border-collapse: collapse">
                            <tr>
                                <td>
                                    <table border="0" cellpadding="0" style="width: 258px; height: 92px">
                                        <tr>
                                            <td align="center" colspan="2" style="font-weight: bold; font-size: 0.9em; color: white;
                                                background-color: darkblue">
                                                查询用户密码</td>
                                        </tr>
                                        <tr>
                                            <td align="left" colspan="2" style="color: black; font-style: normal">
                                                &nbsp; &nbsp;&nbsp; 要接收您的密码，请输入您的用户名称，并且确认已经与互联网连接：</td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 63px">
                                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">用户名称:</asp:Label></td>
                                            <td>
                                                <asp:TextBox ID="UserName" runat="server" Font-Size="0.8em" Width="122px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                                    ErrorMessage="必须填写“用户名”。" ToolTip="必须填写“用户名”。" ValidationGroup="PasswordRecovery1">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="2" style="color: red">
                                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="2">
                                                <asp:Button ID="SubmitButton" runat="server" BackColor="White" BorderColor="#CC9966"
                                                    BorderStyle="Solid" BorderWidth="1px" CommandName="Submit" Font-Names="宋体" Font-Size="Small"
                                                    ForeColor="#990000" Text="验证用户提问答案" ValidationGroup="PasswordRecovery1" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </UserNameTemplate>
                    <TitleTextStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                    <SuccessTemplate>
                        <table border="0" cellpadding="4" cellspacing="0" style="width: 289px; border-collapse: collapse;
                            height: 117px">
                            <tr>
                                <td style="height: 97px; width: 275px;">
                                    <table id="TABLE1" border="0" cellpadding="0" style="width: 280px; height: 30px" onclick="return TABLE1_onclick()">
                                        <tr>
                                            <td align="left" style="font-weight: bold; width: 238px; color: #990000; height: 30px">
                                                &nbsp; &nbsp; &nbsp;&nbsp; 您的密码已发送到您注册时登记的邮箱，请直接从邮箱中复制该密码进行登录！<br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" style="font-weight: bold; width: 238px; color: #990000">
                                                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/SystemManage/Login.aspx">登录管理系统</asp:LinkButton></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </SuccessTemplate>
                    <SubmitButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px"
                        Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
                </asp:PasswordRecovery>
            </td>
            <td style="width: 100px; height: 81px">
            </td>
        </tr>
    </table>
</asp:Content>

