<%@ Page language="c#" Codebehind="OutRoom_add_update.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.OutRoom_add_update" %>
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
				alert('货品名称不能为空');
			
				return false;
			}	
			
	
									
			}
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;修改出库明细
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
												<td align="right" width="15%"><FONT face="宋体">货品编号：</FONT></td>
												<td width="35%"><asp:textbox id="GoodsNumber" runat="server" Width="90%" ></asp:textbox><A href="javascript:void(0)"><IMG onclick="cpOpen();" alt="" src="image/FDJ.gif" border="0"></A></td>
												<td align="right" width="15%"><FONT face="宋体">货品名称：</FONT></td>
												<td width="35%"><asp:textbox id="GoodsName" runat="server" Width="90%" ></asp:textbox><A href="javascript:void(0)"><IMG onclick="cpOpen();" alt="" src="image/FDJ.gif" border="0"></A></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">计量单位：</FONT></td>
												<td width="35%"><asp:textbox id="CountUnit" runat="server" Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">规格型号：</FONT></td>
												<td width="35%"><asp:textbox id="Model" runat="server" Width="100%"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">数量：</FONT></td>
												<td width="35%"><asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="StockPoint" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%" onmouseout="selstr()">0</asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">录入人：</FONT></td>
												<td width="35%"><FONT face="宋体">
														<asp:textbox id="Realname" runat="server" Width="100%"></asp:textbox></FONT></td>
											</tr>
							</tr>
						</table>
						<TABLE id="Table7" height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<td background="i_blue/third_head_bg1.jpg">
									<table id="Table8" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg" onmouseover="selstr()"></asp:imagebutton></td>
											<td width="52%"><a href="JavaScript:void(0)"><img src="i_blue/close.jpg" border="0" onclick="CCC()"></a></td>
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
			<script language="javascript">	
var  wName_1;  
function  cpOpen()  
{  
var num=Math.random();
wName_1=window.showModalDialog("open_GoodsData.aspx?tmp="+num+" ","window","dialogWidth:800px;DialogHeight=500px;status:no;scroll=yes;help:no");                
              
var arr = wName_1.split("|");
for(var i=0;i<arr.length;i++)
{ 

document.getElementById("GoodsNumber").value=arr[0]; 
document.getElementById("GoodsName").value=arr[1]; 
document.getElementById("CountUnit").value=arr[2]; 
document.getElementById("Model").value=arr[3]; 



}


}
			</script>
		</form>
	</body>
</HTML>
