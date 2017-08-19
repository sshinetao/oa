<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bzrrstj_update.aspx.cs" Inherits="FTD.Web.UI.aspx.baozhuang.bzrrstj_update" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../css/main.css" type="text/css" rel="stylesheet" />
    <link href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
    <script src="../../Controls/My97DatePicker/WdatePicker.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <table id="PrintHide" style="width: 100%" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td valign="middle" style="height: 30px;">&nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                    <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;加工包装管理&nbsp;>>&nbsp;包装人员用时统计
                </td>
                <td align="right" valign="middle" style="height: 30px;">
                    <asp:Button ID="iButton1" runat="server" CssClass="btn btn-blue" Text="提交" OnClick="iButton1_Click" />
                    &nbsp;
                    <asp:HiddenField ID="hidVal" runat="server" />
                    <button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
            </tr>
            <tr>
                <td height="3px" colspan="2" style="background-color: #ffffff"></td>
            </tr>
        </table>
        <table cellspacing="0" cellpadding="0" width="100%" border="0" bgcolor="#999999" class="gridview_m">
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">包装人员姓名：</td>
                <td height="25" width="*" align="left">
 
                     <asp:TextBox ID="rname" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">产品名称：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="pname" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">用时：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="yongshi" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">数量：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="shuliang" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">应付工资：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="gongzi" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">状态：</td>
                <td height="25" width="*" align="left">
                     <asp:DropDownList runat="server" id="zhuangtai" Width="200px">
                         <asp:ListItem Value="结清">结清</asp:ListItem>
                         <asp:ListItem Value="待结算">待结算</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

