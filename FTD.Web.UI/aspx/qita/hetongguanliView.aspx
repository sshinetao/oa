<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hetongguanliView.aspx.cs" Inherits="FTD.Web.UI.aspx.qita.hetongguanliAdd" %>

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
                        <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;其他管理&nbsp;>>&nbsp;合同管理
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
           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">合同分类：</td>
           <td height="25" width="*" align="left">
               <asp:TextBox ID="Hetongfenlei" runat="server" Width="200px"></asp:TextBox>
           </td>

           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">合同编号：</td>
           <td height="25" width="*" align="left">
               <asp:TextBox ID="Bianhao" runat="server" Width="200px"></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">甲方：</td>
           <td height="25" width="*" align="left">
               <asp:TextBox ID="Jiafang" runat="server" Width="200px"></asp:TextBox>
           </td>
           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">乙方：</td>
           <td height="25" width="*" align="left">
               <asp:TextBox ID="Yifang" runat="server" Width="200px"></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">合同金额：</td>
           <td height="25" width="*" align="left">
               <asp:TextBox ID="Hetongjine" runat="server" Width="200px"></asp:TextBox>
           </td>
           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">合同期限：</td>
           <td height="25" width="*" align="left">
               <asp:TextBox ID="Hetongqixian" runat="server" Width="200px"></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">签订日期：</td>
           <td height="25" width="*" align="left">
               <asp:TextBox ID="Qiandingriqi" runat="server" Width="200px"></asp:TextBox>
           </td>
           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">内容：</td>
           <td height="25" width="*" align="left">
               <asp:TextBox ID="Neirong" runat="server" Width="200px" TextMode="MultiLine"></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">附件：</td>
           <td height="25" width="*" align="left">
                <asp:HyperLink ID="FujianXiazai" runat="server" Width="200px">下载</asp:HyperLink>
           </td>
       </tr>
            </table>
        </div>
    </form>
</body>
</html>


