<%--文件名:RegisterUser.aspx--%>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegisterUser.aspx.cs" Inherits="System_RegisterUser" Title="当前位置：系统管理->新建操作用户" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 556px; height: 29px">
        <tr>
            <td style="width: 157px; height: 109px">
            </td>
            <td style="width: 91px; height: 109px">
                <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BackColor="#E3EAEB"
                    BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="1px" ContinueDestinationPageUrl="~/SystemManage/Login.aspx"
                    CreateUserButtonText="新建操作用户" Font-Names="Verdana" Font-Size="0.8em" Height="166px"
                    Width="254px">
                    <WizardSteps>
                        <asp:CreateUserWizardStep runat="server">
                            <ContentTemplate>
                                <table border="0" style="font-size: 100%; width: 264px; font-family: Verdana; height: 184px;
                                    background-color: gainsboro">
                                    <tr>
                                        <td align="center" colspan="2" style="font-weight: bold; color: white; background-color: darkblue">
                                            新建操作用户</td>
                                    </tr>
                                    <tr>
                                        <td align="right" style="width: 75px">
                                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">用户名称:</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                                ErrorMessage="必须填写“用户名”。" ToolTip="必须填写“用户名”。" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" style="width: 75px">
                                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">用户密码:</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="148px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                                ErrorMessage="必须填写“密码”。" ToolTip="必须填写“密码”。" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" style="width: 75px">
                                            <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">确认密码:</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" Width="149px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword"
                                                ErrorMessage="必须填写“确认密码”。" ToolTip="必须填写“确认密码”。" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" style="width: 75px">
                                            <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">电子邮件:</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email"
                                                ErrorMessage="必须填写“电子邮件”。" ToolTip="必须填写“电子邮件”。" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" style="width: 75px">
                                            <asp:Label ID="QuestionLabel" runat="server" AssociatedControlID="Question">提示问题:</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Question" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="QuestionRequired" runat="server" ControlToValidate="Question"
                                                ErrorMessage="必须填写“安全提示问题”。" ToolTip="必须填写“安全提示问题”。" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" style="width: 75px">
                                            <asp:Label ID="AnswerLabel" runat="server" AssociatedControlID="Answer">安全答案:</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Answer" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer"
                                                ErrorMessage="必须填写“安全答案”。" ToolTip="必须填写“安全答案”。" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2">
                                            <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password"
                                                ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="“密码”和“确认密码”必须匹配。"
                                                ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2" style="color: red">
                                            <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:CreateUserWizardStep>
                        <asp:CompleteWizardStep runat="server">
                            <ContentTemplate>
                                <table border="0" style="font-size: 100%; width: 265px; font-family: Verdana; height: 27px;
                                    background-color: #fffbd6">
                                    <tr>
                                        <td align="center" colspan="2" style="font-weight: bold; color: white; background-color: darkblue">
                                            完成用户创建工作</td>
                                    </tr>
                                    <tr>
                                        <td align="center" style="background-color: gainsboro">
                                            已成功创建您的账户。</td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2" style="background-color: gainsboro">
                                            <asp:Button ID="ContinueButton" runat="server" BackColor="White" BorderColor="#CC9966"
                                                BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Continue"
                                                Font-Names="Verdana" ForeColor="#990000" Text="登录管理系统" ValidationGroup="CreateUserWizard1" />
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:CompleteWizardStep>
                    </WizardSteps>
                    <SideBarStyle BackColor="#1C5E55" Font-Size="0.9em" VerticalAlign="Top" />
                    <TitleTextStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <SideBarButtonStyle ForeColor="White" />
                    <NavigationButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid"
                        BorderWidth="1px" Font-Names="Verdana" ForeColor="#1C5E55" />
                    <HeaderStyle BackColor="#666666" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px"
                        Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
                    <CreateUserButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid"
                        BorderWidth="1px" Font-Names="Verdana" ForeColor="#1C5E55" />
                    <ContinueButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid"
                        BorderWidth="1px" Font-Names="Verdana" ForeColor="#1C5E55" />
                    <StepStyle BorderWidth="0px" />
                </asp:CreateUserWizard>
            </td>
            <td style="width: 100px; height: 109px">
            </td>
        </tr>
    </table>
</asp:Content>

