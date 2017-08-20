<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XiangmucaiwubiaoModify.aspx.cs" Inherits="FTD.Web.UI.aspx.Project.XiangmucaiwubiaoModify" %>
 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link href="../../css/main.css" type="text/css" rel="stylesheet" />
    <link href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
    <script src="../../Controls/My97DatePicker/WdatePicker.js"></script>

</head>
<body>
    
    <form id="form1" runat="server">
  <table id="PrintHide" style="width: 100%" border="0" cellpadding="0" cellspacing="0">            
            <tr>
                <td valign="middle" style=" height: 30px;">&nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;项目管理&nbsp;>>&nbsp;项目财务表
                </td>
                <td align="right" valign="middle" style=" height: 30px;">
                    
<asp:Button ID="iButton1" runat="server" CssClass="btn btn-blue" Text="提交" OnClick="iButton1_Click" />
                    <asp:HiddenField ID="hidVal" runat="server" />
                    &nbsp;<button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
            </tr>
            <tr>
            <td height="3px" colspan="2" style="background-color: #ffffff"></td>
        </tr>
        </table>
   <table cellSpacing="0" cellPadding="0" width="100%" border="0"  bgcolor="#999999" class="gridview_m">
       <tr>
           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">项目科目：</td>
           <td height="25" width="*" align="left">
               <asp:TextBox ID="Kemu" runat="server" Width="200px"></asp:TextBox>
           </td>

           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">金额：</td>
           <td height="25" width="*" align="left">
               <asp:TextBox ID="Jine" runat="server" Width="200px"></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">记录日期：</td>
           <td height="25" width="*" align="left">
               <asp:TextBox ID="Riqi" runat="server" Width="200px" onclick="WdatePicker();"></asp:TextBox>
           </td>
           <td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">状态：</td>
           <td height="25" width="*" align="left">
                <asp:DropDownList ID="Zhuangtai" runat="server" Width="200px">
                        <asp:ListItem Value="已结">已结</asp:ListItem>
                        <asp:ListItem Value="未结">未结</asp:ListItem>
                    </asp:DropDownList>
           </td>
       </tr>
       
    <asp:HiddenField runat="server" ID="Fujian_hidden" />
	
</table>
    </form>
</body>
</html>



