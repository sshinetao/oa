<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nongchanpinpeisong_add.aspx.cs" Inherits="FTD.Web.UI.aspx.chanpinpeisong.nongchanpinpeisong_add" %>
<html>
<head id="Head2" runat="server">
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
                    <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;产品配送管理&nbsp;>>&nbsp;新增配送管理
                </td>
                <td align="right" valign="middle" style="height: 30px;">
                    <asp:Button ID="iButton1" runat="server" CssClass="btn btn-blue" Text="提交" OnClick="iButton1_Click" />
                    &nbsp;
                    <button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
            </tr>
            <tr>
                <td height="3px" colspan="2" style="background-color: #ffffff"></td>
            </tr>
        </table>
        <table cellspacing="0" cellpadding="0" width="100%" border="0" bgcolor="#999999" class="gridview_m">
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">记录时间：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="recordtime" runat="server" onClick="WdatePicker({startDate:'%y-%M-01',dateFmt:'yyyy-MM-dd',alwaysUseStartDate:true})"  Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">配送单位：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="peisongdanwei" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">配送地址：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="peisongdizhi" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">货物订单号：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="dingdanhao" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">交接人：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="jiaojieren" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">配送车辆：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="peisongcheliang" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">配送里程：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="peisonglicheng" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">配送人：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="peisongren" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>


