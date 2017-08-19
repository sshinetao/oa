<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cpjgtj_add.aspx.cs" Inherits="FTD.Web.UI.aspx.baozhuang.cpjgtj" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1"  runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../css/main.css" type="text/css" rel="stylesheet" />
    <link href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
    <script src="../../Controls/My97DatePicker/WdatePicker.js"></script>
</head>
<body>
    <form id="Form1"   runat="server">
        <table id="PrintHide" style="width: 100%" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td valign="middle" style="height: 30px;">&nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                    <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;加工包装管理&nbsp;>>&nbsp;包装统计
                </td>
                <td align="right" valign="middle" style="height: 30px;">
                    <asp:Button ID="iButton3" runat="server" CssClass="btn btn-blue" Text="提交" OnClick="iButton1_Click" />
                    &nbsp;
                    <button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
            </tr>
            <tr>
                <td height="3px" colspan="2" style="background-color: #ffffff"></td>
            </tr>
        </table>
        <table cellspacing="0" cellpadding="0" width="100%" border="0" bgcolor="#999999" class="gridview_m">
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">品名：</td>
                <td height="25" width="*" align="left">
                     
                     <asp:TextBox ID="pname4" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">数量：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="shuliang4" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">质量：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="zhiliang4" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
          
        </table>
    </form>
</body>
</html>
