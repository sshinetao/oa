<%@ Page language="c#" Codebehind="StockPlan_BB_SP_show.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.StockPlan_BB_SP_show" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>�ɭɽ������</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<META http-equiv="Pragma" content="no-cache">
		<META http-equiv="Cache-Control" content="no-cache">
		<META http-equiv="Expires" content="0">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<base target="_self">
		<script>
	   function killErrors() {
		return true;
		}
		window.onerror = killErrors;	
		
			function chknull()
				{


	    	if(document.getElementById('GoodsName').value=='')
			{
				alert('��Ʒ���Ʋ���Ϊ��');
			
				return false;
			}	
			
	    	if(document.getElementById('CompanyName').value=='')
			{
				alert('��Ӧ�̲���Ϊ��');
			
				return false;
			}		
									
			}
   	         function  CCC()  
            {       
              

                window.close();  
            }   
            
  		function selstr()
		{
	
		document.all.Allmoney.value=document.all.SingleMoney.value*document.all.StockPoint.value;
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">����̨</A>&nbsp;&gt;&gt;&nbsp;�鿴�ɹ��ƻ���ϸ
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
												<td align="right" width="15%"><FONT face="����">��Ʒ��ţ�</FONT></td>
												<td width="35%"><asp:textbox id="GoodsNumber" runat="server" Width="100%" ></asp:textbox><A href="javascript:void(0)"></A></td>
												<td align="right" width="15%"><FONT face="����">��Ʒ���ƣ�</FONT></td>
												<td width="35%"><asp:textbox id="GoodsName" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">������λ��</FONT></td>
												<td width="35%"><asp:textbox id="CountUnit" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="����">����ͺţ�</FONT></td>
												<td width="35%"><asp:textbox id="Model" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">�ɹ�������</FONT></td>
												<td width="35%"><asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="StockPoint" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%" onmouseout="selstr()"
														>0</asp:textbox></td>
												<td align="right" width="15%"><FONT face="����">�ɹ����ۣ�</FONT></td>
												<td width="35%"><asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="SingleMoney" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%" onmouseout="selstr()"
														>0</asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">�ɹ��ܽ�</FONT></td>
												<td width="35%"><asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="Allmoney" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%" onclick="selstr(this,this);return false"
														>0</asp:textbox></td>
												<td align="right" width="15%"><FONT face="����">������ʽ��</FONT></td>
												<td width="35%">
													<asp:DropDownList id="Stocktype" runat="server" Width="100%" Enabled="False">
														<asp:ListItem Value="δѡ��">δѡ��</asp:ListItem>
														<asp:ListItem Value="��������">��������</asp:ListItem>
														<asp:ListItem Value="���ڶ���">���ڶ���</asp:ListItem>
													</asp:DropDownList></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">�ɹ�Ա������</FONT></td>
												<td width="35%"><asp:textbox id="StockPeoName" runat="server" Width="100%" ></asp:textbox><A href="javascript:void(0)"></A></td>
												<td align="right" width="15%"><FONT face="����">��Ӧ������</FONT></td>
												<td width="35%"><asp:textbox id="CompanyName" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">��Ӧ�̵�ַ��</FONT></td>
												<td width="85%" colspan="3"><asp:textbox id="CompanyAdd" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">�����������ڣ�</FONT></td>
												<td width="35%"><asp:textbox id="JyOrderTime" runat="server" Width="100%"  DataType="DateTime"></asp:textbox>
													<script>SetNeed('JyOrderTime')</script>
													</FONT><A href="javascript:void(0)"></A></td>
												<td align="right" width="15%"><FONT face="����">�����������ڣ�</FONT></td>
												<td width="35%">
													<asp:textbox id="JyToTime" runat="server" Width="100%"  DataType="DateTime"></asp:textbox>
													<script>SetNeed('JyToTime')</script>
													</FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">�������ڣ�</FONT></td>
												<td width="35%"><asp:textbox id="TxTime" runat="server" Width="100%" ></asp:textbox>
													<script>SetNeed('TxTime')</script>
													</FONT><A href="javascript:void(0)"></A></td>
												<td align="right" width="15%"><FONT face="����">¼���ˣ�</FONT></td>
												<td width="35%">
													<asp:textbox id="Realname" runat="server" Width="100%" ></asp:textbox></td>
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
											<td width="52%"><FONT face="����"></FONT><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="i_blue/back.jpg" onmouseover="selstr()"></asp:imagebutton><a href="JavaScript:void(0)"></a></td>
										</tr>
									</table>
								</td>
							</TR>
						</TABLE>
					</td>
				</tr>
			</table>
			<asp:TextBox id="CompanyNumber" runat="server" style="DISPLAY: none"></asp:TextBox>
			<asp:TextBox id="StockPeoNum" runat="server" style="DISPLAY: none"></asp:TextBox></TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE>
		</form>
	</body>
</HTML>
