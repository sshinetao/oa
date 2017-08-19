<%@ Page language="c#" Codebehind="GoodsOpenMoney_cp_show.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.GoodsOpenMoney_cp_show" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<META HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<META HTTP-EQUIV="Cache-Control" CONTENT="no-cache">
		<META HTTP-EQUIV="Expires" CONTENT="0">
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
			<table cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table1">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0" id="Table2">
							<tr>
								<td width="97%"><FONT color="#ffffff">查看往来单位</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<table height="450" cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table3">
				<tr>
					<td width="15">&nbsp;</td>
					<td vAlign="top" width="95%">
						<table cellSpacing="1" cellPadding="0" width="100%" bgColor="#7d9db4" border="0" id="Table4">
							<tr>
								<td vAlign="top" bgColor="#f3f8fe">
									<table height="26" cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table5">
										<tr>
											<td background="i_blue/third_head_bg.jpg">&nbsp;</td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0" id="Table6">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">客户编号：</FONT></td>
												<td width="35%"><asp:textbox id="Number" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">客户名称：</FONT></td>
												<td width="35%"><asp:textbox id="Name" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">客户分类：</FONT></td>
												<td width="35%"><FONT face="宋体"></FONT>
													<asp:textbox id="Type" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">联系人：</FONT></td>
												<td width="35%"><asp:textbox id="Linkman" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">手机：</FONT></td>
												<td width="35%"><FONT face="宋体">
														<asp:textbox id="MoveTel" runat="server" Width="100%" ></asp:textbox></FONT></td>
												<td align="right" width="15%"><FONT face="宋体">开户行：</FONT></td>
												<td width="35%"><asp:textbox id="Bank" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">银行帐号：</FONT></td>
												<td width="35%"><asp:textbox id="BankNumber" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">纳税号：</FONT></td>
												<td width="35%"><asp:textbox id="TaxNumber" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">法人代表：</FONT></td>
												<td width="35%"><asp:textbox id="Deputy" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">电话：</FONT></td>
												<td width="35%"><asp:textbox id="Tel" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">传真：</FONT></td>
												<td width="35%"><asp:textbox id="Fax" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">邮政编码：</FONT></td>
												<td width="35%"><asp:textbox id="Mail" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">通讯地址：</FONT></td>
												<td width="85%" colspan="3"><asp:textbox id="Address" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">Email：</FONT></td>
												<td width="35%"><asp:textbox id="Email" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">QQ：</FONT></td>
												<td width="35%"><asp:textbox id="QQ" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">期初应收款：</FONT></td>
												<td width="35%"><FONT face="宋体">
														<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
															id="Receivable" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%"
															>0</asp:textbox></FONT></td>
												<td align="right" width="15%"><FONT face="宋体">期初应付款：</FONT></td>
												<td width="35%">
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="Payable" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%"
														>0</asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">其他信息：</FONT></td>
												<td width="85%" colspan="3"><asp:textbox id="Other" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">备注：</FONT></td>
												<td width="85%" colspan="3"><asp:textbox id="Remark" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
							</tr>
						</table>
						<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table7">
							<tr>
								<td background="i_blue/third_head_bg1.jpg">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table8">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"></td>
											<td width="52%"><a href="JavaScript:void(0)"><IMG onclick="CCC()" src="i_blue/close.jpg" border="0"></a></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			</TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE></form>
	</body>
</HTML>
