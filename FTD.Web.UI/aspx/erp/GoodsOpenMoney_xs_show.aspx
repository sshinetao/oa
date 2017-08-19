<%@ Page language="c#" Codebehind="GoodsOpenMoney_xs_show.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.GoodsOpenMoney_xs_show" %>
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
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<script>
	   function killErrors() {
		return true;
		}
		window.onerror = killErrors;	
		
			function chknull()
				{


	    	if(document.getElementById('GoodsName').value=='')
			{
				alert('货品名称不能为空');
			
				return false;
			}	
			
	    	if(document.getElementById('KhName').value=='')
			{
				alert('供应商不能为空');
			
				return false;
			}		
									
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="GoodsOpenMoney_xs.aspx">销售报价资料</A>&nbsp;&gt;&gt; 
									查看销售报价资料</td>
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
												<td align="right" width="15%"><FONT face="宋体">货品编号：</FONT></td>
												<td width="35%"><asp:textbox id="GoodsNumber" runat="server" Width="100%" ></asp:textbox><A href="javascript:void(0)"></A></td>
												<td align="right" width="15%"><FONT face="宋体">货品名称：</FONT></td>
												<td width="35%"><asp:textbox id="GoodsName" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">计量单位：</FONT></td>
												<td width="35%"><asp:textbox id="CountUnit" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">规格型号：</FONT></td>
												<td width="35%"><asp:textbox id="Model" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">供应商编号：</FONT></td>
												<td width="35%"><asp:textbox id="KhNumber" runat="server" Width="100%" ></asp:textbox><A href="javascript:void(0)"></A></td>
												<td align="right" width="15%"><FONT face="宋体">供应商名：</FONT></td>
												<td width="35%"><asp:textbox id="KhName" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">预设销售单价1：</FONT></td>
												<td width="35%"><asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="Sellmoney1" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%" >0</asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">预设销售单价2：</FONT></td>
												<td width="35%">
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="Sellmoney2" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%"
														>0</asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">预设销售单价3：</FONT></td>
												<td width="35%"><asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="Sellmoney3" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%" >0</asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">预设销售单价4：</FONT></td>
												<td width="35%">
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="Sellmoney4" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%"
														>0</asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">折扣：</FONT></td>
												<td width="35%">
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="Zhekou" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%"
														>1</asp:textbox></td>
												<TD align="right" width="15%"><FONT face="宋体">加权价：</FONT></TD>
												<td width="35%">
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="Powermoney" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%"
														>0</asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">其他：</FONT></td>
												<td width="85%" colspan="3">
													<asp:textbox id="Remark" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
							</tr>
						</table>
						<TABLE id="Table7" height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<td background="i_blue/third_head_bg1.jpg">
									<table id="Table8" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"></td>
											<td width="52%"><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></td>
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
