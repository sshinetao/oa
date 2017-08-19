<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OldCarView.aspx.cs" Inherits="FTD.Web.UI.aspx.oldcar.OldCarView" %>

<html>
<head>
    <title><%=System.Configuration.ConfigurationManager.AppSettings["SYSTitle"]%></title>
    <link href="../../css/main.css" type="text/css" rel="stylesheet" />
    <link href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
    <script language="javascript">
        function PrintTable() {
            document.getElementById("PrintHide").style.visibility = "hidden"
            print();
            document.getElementById("PrintHide").style.visibility = "visible"
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table id="PrintHide" style="width: 100%" border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td valign="middle" style="height: 30px;">&nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                        <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;二手车市场&nbsp;>>&nbsp;查看信息
                    </td>
                    <td align="right" valign="middle" style="height: 30px;">
                        <button type="button" class="btn btn-blue" onclick="javascript:PrintTable()">打印</button>

                        &nbsp;
                        <button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
                </tr>
                <tr>
                    <td height="3px" colspan="2" style="background-color: #ffffff"></td>
                </tr>
            </table>
            <table style="width: 100%" bgcolor="#999999" class="gridview_m" border="0" cellpadding="2" cellspacing="1">
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">发票编号：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lbltasknum" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">合同编号：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblhtnum" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">卖家姓名：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblseller" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">卖家身份证号：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblsell_coder" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">卖家电话：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblsell_tel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">卖家地址：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblsell_address" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">买家姓名：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblbuyer" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">买家身份证号：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblbuy_coder" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">买家电话：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblbuy_tel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">买家地址：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblbuy_address" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">车牌号：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblplat_num" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">登记证号：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lbldengji_num" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">车辆类型：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblcartype" runat="server"></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">车架号/车辆识别代码：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblchejianum" runat="server"></asp:Label>
                    </td>
                </tr> <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">厂牌型：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblchangpai" runat="server"></asp:Label>
                    </td>
                </tr> <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">转入地车辆管理所名称：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lblzhuanru" runat="server"></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">成交时间：
                    </td>
                    <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                        <asp:Label ID="lbloffer_time" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

