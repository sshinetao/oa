<%--文件名:Logout.aspx--%>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Logout.aspx.cs" Inherits="System_Logout" Title="当前位置：系统管理->退出管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="font-size: 0.8em; width: 557px; font-family: 宋体; height: 51px; position: static;">
        <tr>
            <td colspan="4" rowspan="1" style="height: 37px">
            </td>
        </tr>
        <tr>
            <td rowspan="3" style="width: 140px">
            </td>
            <td align="center" colspan="2" style="font-weight: bold; color: white; background-color: darkblue">
                退出人事工资管理信息系统</td>
            <td rowspan="3" style="width: 100px">
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="background-color: gainsboro">
                是否现在立即退出人事工资管理信息系统？</td>
        </tr>
        <tr>
            <td align="center" style="background-color: aliceblue" colspan="2">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确定" Width="90px" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="取消" Width="90px" /></td>
        </tr>
        <tr>
            <td colspan="4" rowspan="5" style="height: 39px">
            </td>
        </tr>
        <tr>
        </tr>
        <tr>
        </tr>
        <tr>
        </tr>
        <tr>
        </tr>
    </table>
 </asp:Content>

