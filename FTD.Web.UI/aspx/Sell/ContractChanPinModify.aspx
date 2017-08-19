﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContractChanPinModify.aspx.cs" Inherits="OA.aspx.Sell.ContractChanPinModify" %>
<html>
	<head>
		<title><%=System.Configuration.ConfigurationManager.AppSettings["SYSTitle"]%></title>
<link href="../../css/main.css" type="text/css" rel="stylesheet" />
  <LINK href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
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
                <td valign="middle" style=" height: 30px;">&nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;销售订单&nbsp;>>&nbsp;修改订单产品信息
                </td>
                <td align="right" valign="middle" style=" height: 30px;">
                    
<asp:Button ID="iButton1" runat="server" CssClass="btn btn-blue" Text="提交" OnClick="iButton1_Click" />
                    
                    <button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button>&nbsp;</td>
            </tr>
            <tr>
            <td height="3px" colspan="2" style="background-color: #ffffff"></td>
        </tr>
        </table>
<table style="width: 100%" bgcolor="#999999" class="gridview_m" border="0" cellpadding="2" cellspacing="1">
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		合同名称：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtHeTongName" runat="server" Width="350px"></asp:TextBox>
		<img class="HerCss" onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectCondition.aspx?TableName=ERPContract&LieName=HeTongName&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('txtHeTongName').value=wName;}"  src="../../images/Button/search.gif" />
		<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtHeTongName" ErrorMessage="*该项不可以为空"></asp:RequiredFieldValidator>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		产品名称：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtChanPinName" runat="server" Width="350px" 
            AutoPostBack="True" ontextchanged="txtChanPinName_TextChanged"></asp:TextBox>
		<img class="HerCss" onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectCondition.aspx?TableName=ERPProduct&LieName=ProductName&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('txtChanPinName').value=wName;__doPostBack('', '');}"  src="../../images/Button/search.gif" />
	</td></tr>
    <tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		规格尺寸：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtProductSize" runat="server" Width="350px"></asp:TextBox>
		<img class="HerCss" onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectCondition.aspx?TableName=ERPProduct&LieName=ProductSize&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('txtProductSize').value=wName;}"  src="../../images/Button/search.gif" />
	</td></tr>
    <tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		性能：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtPerformance" runat="server" Width="350px"></asp:TextBox>
		<img class="HerCss" onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectCondition.aspx?TableName=ERPProduct&LieName=Performance&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('txtPerformance').value=wName;}"  src="../../images/Button/search.gif" />
	</td></tr>
    <tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		镀层：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtCoating" runat="server" Width="350px"></asp:TextBox>
		<img class="HerCss" onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectCondition.aspx?TableName=ERPProduct&LieName=Coating&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('txtCoating').value=wName;}"  src="../../images/Button/search.gif" />
	</td></tr>
    <tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		表面处理：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtSurfaceTreatment" runat="server" Width="350px"></asp:TextBox>
		<img class="HerCss" onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectCondition.aspx?TableName=ERPProduct&LieName=SurfaceTreatment&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('txtSurfaceTreatment').value=wName;}"  src="../../images/Button/search.gif" />
	</td></tr>
    <tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		充磁方向：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtMagnetizingDirection" runat="server" Width="350px"></asp:TextBox>
		<img class="HerCss" onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectCondition.aspx?TableName=ERPProduct&LieName=MagnetizingDirection&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('txtMagnetizingDirection').value=wName;}"  src="../../images/Button/search.gif" />
	</td></tr>
    <tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		公差：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtTolerance" runat="server" Width="350px"></asp:TextBox>
		<img class="HerCss" onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectCondition.aspx?TableName=ERPProduct&LieName=Tolerance&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('txtTolerance').value=wName;}"  src="../../images/Button/search.gif" />
	</td></tr>
    <tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		是否含税：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:RadioButtonList ID="rdoIsContainingTax" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Value="1">是</asp:ListItem>
            <asp:ListItem Selected="True" Value="0">否</asp:ListItem>
        </asp:RadioButtonList>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		单价：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtDanJia" runat="server" Width="350px" AutoPostBack="True" 
            ontextchanged="txtDanJia_TextChanged"></asp:TextBox>
        元</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		数量：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtShuLiang" runat="server" Width="350px" AutoPostBack="True" 
            ontextchanged="txtShuLiang_TextChanged"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtShuLiang"
            Display="Dynamic" ErrorMessage="*该项不可以为空"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtShuLiang"
            ErrorMessage="*该项必须填写为数字" MaximumValue="100000000" MinimumValue="-100000000"
            Type="Double"></asp:RangeValidator></td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		总价：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtZongJia" runat="server" Width="350px"></asp:TextBox>
        元</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		已付款数：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtYiFuKuan" runat="server" Width="350px"></asp:TextBox>
        元</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		欠款数：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtQianKuanShu" runat="server" Width="350px"></asp:TextBox>
        元</td></tr>
    <tr>
        <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
            是否交付：</td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>已交付</asp:ListItem>
                <asp:ListItem Selected="True">未交付</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="Label1" runat="server" Text="0" Visible="False" Width="0px"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="未交付" Visible="False" Width="0px"></asp:Label></td>
    </tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		备注说明：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtBackInfo" runat="server" Width="350px" Height="60px" TextMode="MultiLine"></asp:TextBox></td></tr>
    <tr>
        <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
            录入人：</td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
            <asp:Label ID="Label2" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
            录入时间：</td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
            <asp:Label ID="Label3" runat="server"></asp:Label></td>
    </tr>
</table>
		</div>
	</form>
</body>
</html>