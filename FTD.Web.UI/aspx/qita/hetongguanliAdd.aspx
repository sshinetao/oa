<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hetongguanliAdd.aspx.cs" Inherits="FTD.Web.UI.aspx.qita.hetongguanliInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
                    <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;其他管理&nbsp;>>&nbsp;添加合同管理
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
                <asp:FileUpload ID="Fujian" runat="server" />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Fujian"
ErrorMessage="必须是Office文档" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))(.doc|.dot|.docx|.dotx|.docm|.dotm|.xls|.xlt|.xla|.xlsx|.xltx|.xlsm|.xltm|.xlam|.xlsb|.ppt|.pot|.pps|.ppa|.pptx|.potx|.ppsx|.ppam|.pptm|.potm|.ppsm|.DOC|.DOT|.DOCX|.DOTX|.DOCM|.DOTM|.XLS|.XLT|.XLA|.XLSX|.XLTX|.XLSM|.XLTM|.XLAM|.XLSB|.PPT|.POT|.PPS|.PPA|.PPTX|.POTX|.PPSX|.PPAM|.PPTM|.POTM|.PPSM
)$"></asp:RegularExpressionValidator>
                </td>
            </tr>

        </table>
    </form>
</body>
</html>

