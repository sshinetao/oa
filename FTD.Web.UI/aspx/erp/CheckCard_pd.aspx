<%@ Page language="c#" Codebehind="CheckCard_pd.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.CheckCard_pd" %>
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
  
function hyjz()
{
  	if (!confirm("货物名："+document.getElementById('GoodsName').value+"\n\n库房："+document.getElementById('Storeroom').value+"\n\n账面数："+document.getElementById('AccountPoint').value+"\n\n实盘数："+document.getElementById('FactPoint').value+"\n\n差异数量："+document.getElementById('Difference').value+"\n\n是否确认保存"))
	return false;
}

        function selstr()
		{
	
			document.all.Difference.value=document.all.FactPoint.value-document.all.AccountPoint.value;
			
		}


  
         
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout" onmouseover="selstr()">
		<form id="Form1" method="post" runat="server">
			<script language="javascript" src="DateSelect.js"></script>
			<table cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table1">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0" id="Table2">
							<tr>
								<td class="headfont" width="97%">盘点</td>
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
												<td align="right" width="15%"><FONT face="宋体">货物名：</FONT></td>
												<td width="85%" colspan="3"><FONT face="宋体">
														<asp:TextBox id="GoodsName" runat="server" Width="100%"></asp:TextBox></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">库房：</FONT></td>
												<td width="85%" colspan="3">
													<asp:TextBox id="Storeroom" runat="server" Width="100%"></asp:TextBox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">账面数：</FONT></td>
												<td width="85%" colspan="3">
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="AccountPoint" ondragenter="return false" style="IME-MODE: disabled" runat="server" 
														Width="100%">0</asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">实盘数：</FONT></td>
												<td width="85%" colspan="3">
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="FactPoint" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%">0</asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">差异数量：</FONT></td>
												<td width="85%" colspan="3">
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="Difference" ondragenter="return false" style="IME-MODE: disabled" runat="server" 
														Width="100%">0</asp:textbox></td>
											</tr>
							</tr>
						</table>
						<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table7">
							<tr>
								<td background="i_blue/third_head_bg1.jpg">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table8">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%">
												<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:ImageButton><FONT face="宋体">&nbsp;</FONT></td>
											<td width="52%"><a href="JavaScript:void(0)"><IMG onclick="CCC()" src="i_blue/close.jpg" border="0"></a></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			<asp:TextBox id="GoodsNumber" runat="server" Visible="False"></asp:TextBox>
			<asp:TextBox id="CountUnit" runat="server" Visible="False"></asp:TextBox>
			<asp:TextBox id="Model" runat="server" Visible="False"></asp:TextBox></TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE></form>
	</body>
</HTML>
