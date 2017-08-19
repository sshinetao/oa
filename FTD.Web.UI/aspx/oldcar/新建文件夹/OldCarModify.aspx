<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OldCarModify.aspx.cs" Inherits="FTD.Web.UI.aspx.oldcar.OldCarModify" %>

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
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;二手车市场&nbsp;>>&nbsp;添加二手车销售记录
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
	<td height="25" width="30%" align="right"   style="width: 170px; height: 25px; background-color: #f9f9f7">
		发票编号：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttasknum" runat="server" Width="200px"></asp:TextBox>
	</td>

	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
		合同编号：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txthtnum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
		卖家姓名：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtseller" runat="server" Width="200px"></asp:TextBox>
	</td>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
		卖家身份证号：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsell_coder" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
		卖家电话：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsell_tel" runat="server" Width="200px"></asp:TextBox>
	</td>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
		卖家地址：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsell_address" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
	买家姓名：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbuyer" runat="server" Width="200px"></asp:TextBox>
	</td>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
	买家身份证号：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbuy_coder" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
	买家电话：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbuy_tel" runat="server" Width="200px"></asp:TextBox>
	</td>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
	买家地址：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbuy_address" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
		车牌号：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtplat_num" runat="server" Width="200px"></asp:TextBox>
	</td>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
		登记证号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdengji_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
		车辆类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcartype" runat="server" Width="200px"></asp:TextBox>
	</td>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
		车架号/车辆识别代码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtchejianum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
		厂牌型
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtchangpai" runat="server" Width="200px"></asp:TextBox>
	</td>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
		转入地车辆管理所名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtzhuanru" runat="server" Width="200px"></asp:TextBox>
	</td></tr>

       <tr>
	<td height="25" width="30%" align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
		成交时间
	：</td>
	<td height="25" width="*" align="left" colspan="3">
		<asp:TextBox id="txtoffer_time" runat="server" Width="200px" onclick="WdatePicker();" ></asp:TextBox>
	</td>

       </tr>
	
	
</table>
    </form>
</body>
</html>

