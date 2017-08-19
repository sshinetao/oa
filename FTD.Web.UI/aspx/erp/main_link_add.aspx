<%@ Page language="c#" Codebehind="main_link_add.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.main_link_add" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table id="Table2" height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td class="headfont" width="97%"><FONT face="宋体">新增快捷方式</FONT></td>
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
										<tr bgColor="#f3f8fe">
											<td align="right" width="15%"><FONT face="宋体">模块名：</FONT></td>
											<td width="85%">
												<asp:DropDownList id="name" runat="server" Width="100%"></asp:DropDownList></td>
										</tr>
										<tr bgColor="#f3f8fe">
											<td align="right" width="15%"><FONT face="宋体">剩余字符数：</FONT></td>
											<td width="85%">
												<asp:TextBox id="Tbyte" runat="server" Width="100%" ></asp:TextBox>
											</td>
										</tr>
									</table>
									<TABLE id="Table7" height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<td background="i_blue/third_head_bg1.jpg">
												<table id="Table8" cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td width="39%">&nbsp;</td>
														<td width="9%"><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:imagebutton></td>
														<td width="52%"><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></td>
													</tr>
												</table>
											</td>
										</TR>
									</TABLE>
								</td>
							</tr>
						</table>
					</td>
					<td width="15">&nbsp;</td>
				</tr>
			</table>
			<asp:textbox id="Username" style="DISPLAY: none" runat="server" ></asp:textbox>
			<script>
			function chknull()
		   {

		    if(document.getElementById('name').value=='请选择')
			{
				alert('请选择名称');
				
				return false;
			}	
		
			 var littleproduct=document.getElementById("name");
           var cindex = littleproduct.selectedIndex;
			var ctxt = littleproduct.options[cindex].text;
           
            
			if(document.getElementById('Tbyte').value-ctxt.length<0)
			{
			
				if (!confirm("字符数已经超出控制范围，是否还继续增加？"))
			   return false;
		    }	
		    
		  
		   }

		  

			</script>
		</form>
	</body>
</HTML>
