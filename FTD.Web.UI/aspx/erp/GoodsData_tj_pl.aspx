<%@ Page language="c#" Codebehind="GoodsData_tj_pl.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.GoodsData_tj_pl" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<META http-equiv="Pragma" content="no-cache">
		<META http-equiv="Cache-Control" content="no-cache">
		<META http-equiv="Expires" content="0">
		<base target="_self">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<script>
	   function killErrors() {
		return true;
		}
		window.onerror = killErrors;	
		

         	         function  CCC()  
            {       
              
                window.close();  
            }  
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<script language="javascript" src="DateSelect.js"></script>
			<table id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table id="Table2" height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td class="headfont" width="97%">商品调价
								</td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<table id="Table3" height="450" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="15">&nbsp;</td>
					<td vAlign="top" width="95%">
						<table id="Table4" cellSpacing="1" cellPadding="0" width="100%" bgColor="#7d9db4" border="0">
							<tr>
								<td vAlign="top" bgColor="#f3f8fe">
									<table id="Table5" height="26" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td background="i_blue/third_head_bg.jpg">&nbsp;</td>
										</tr>
									</table>
									<table id="Table6" cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">类别：</FONT></td>
												<td width="85%" colspan="3">
													<asp:DropDownList id="Type" runat="server" Width="100%"></asp:DropDownList></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">基价：</FONT></td>
												<td width="35%">
													<asp:DropDownList id="DropDownList2" runat="server" Width="100%">
														<asp:ListItem Value="Sellmoney1">预设销售单价1</asp:ListItem>
														<asp:ListItem Value="Sellmoney2">预设销售单价2</asp:ListItem>
														<asp:ListItem Value="Sellmoney3">预设销售单价3</asp:ListItem>
														<asp:ListItem Value="Sellmoney4">预设销售单价4</asp:ListItem>
													</asp:DropDownList></td>
												<td align="right" width="15%"><FONT face="宋体">调整系数：</FONT></td>
												<td width="35%">
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="Sellmoney" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%">1</asp:textbox><FONT face="宋体"></FONT></td>
											</tr>
							</tr>
						</table>
						<TABLE id="Table7" height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<td background="i_blue/third_head_bg1.jpg">
									<table id="Table8" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/ok.jpg"></asp:imagebutton></td>
											<td width="52%"><A href="JavaScript:void(0)"><IMG onclick="CCC()" src="i_blue/close.jpg" border="0"></A></td>
										</tr>
									</table>
								</td>
							</TR>
						</TABLE>
					</td>
				</tr>
			</table>
			</TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE>
		</form>
	</body>
</HTML>
