<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kaoqinshenqing_add.aspx.cs" Inherits="FTD.Web.UI.aspx.HR.kaoqinshenqing_add" %>

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
                    <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;考勤管理&nbsp;>>&nbsp;新增考勤申请
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
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">开始时间：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="kaishishijian" runat="server" onClick="WdatePicker({startDate:'%y-%M-01',dateFmt:'yyyy-MM-dd',alwaysUseStartDate:true})" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">结束时间：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="jieshushijian" runat="server" onClick="WdatePicker({startDate:'%y-%M-01',dateFmt:'yyyy-MM-dd',alwaysUseStartDate:true})" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">直接负责人：</td>
                <td height="25" width="*" align="left">
                    <asp:TextBox ID="fuzeren" runat="server" Width="200px"></asp:TextBox>
                    <a href="javascript:void(0)">
                        <img onclick="selectPerson()" alt="" src="../erp/image/FDJ.gif" border="0" />
                    </a>
                </td>
            </tr>
            <tr>
                <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">类型：</td>
                <td height="25" width="*" align="left">
                    <asp:DropDownList runat="server" ID="type" Width="200px">
                        <asp:ListItem Value="请假">请假</asp:ListItem>
                        <asp:ListItem Value="出差">出差</asp:ListItem>
                        <asp:ListItem Value="休假">休假</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </form>
    <script type="text/javascript">
        function selectPerson() {
            var wName;
            var RadNum = Math.random();
            wName = window.showModalDialog('../Main/SelectUser.aspx?TableName=ERPUser&LieName=UserName&Radstr=' + RadNum, '', 'dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');
            if (wName == null) {

            } else {
                document.getElementById('fuzeren').value = wName;
            }
        }
    </script>
</body>
</html>


