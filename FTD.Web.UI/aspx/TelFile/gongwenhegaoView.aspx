<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gongwenhegaoView.aspx.cs" Inherits="FTD.Web.UI.aspx.TelFile.gongwenhegaoView" %>
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
                        <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;公文管理&nbsp;>>&nbsp;公文核稿
                    </td>
                    <td align="right" valign="middle" style="height: 30px;">
                        <asp:Button runat="server" ID="button1" CssClass="btn btn-blue" Text="审批" OnClick="button1_Click" />
                        &nbsp;
                        <button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
                </tr>
                <tr>
                    <td height="3px" colspan="2" style="background-color: #ffffff"></td>
                </tr>
            </table>
            <table style="width: 100%" bgcolor="#999999" class="gridview_m" border="0" cellpadding="2" cellspacing="1">
                <tr>
                    <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">类别：</td>
                    <td height="25" width="*" align="left">
                        <asp:Label runat="server" ID="leixing" Width="200px"> </asp:Label>
                    </td>

                    <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">公文标题：</td>
                    <td height="25" width="*" align="left">
                        <asp:Label ID="biaoti" runat="server" Width="200px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">附件：</td>
                    <td height="25" width="*" align="left">
                        <asp:HyperLink ID="fujian" runat="server" Width="200px" Text="下载" ></asp:HyperLink>
                    </td>
                    <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">简介：</td>
                    <td height="25" width="*" align="left">
                        <asp:TextBox ID="neirong" ReadOnly="true" runat="server" Width="100%" TextMode="MultiLine"></asp:TextBox>                       
                    </td>
                </tr>
                <asp:HiddenField runat="server" ID="id" />
            </table>
        </div>
    </form>
</body>
</html>



