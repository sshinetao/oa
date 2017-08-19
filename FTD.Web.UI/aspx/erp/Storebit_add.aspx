<%@ Page language="c#" Codebehind="Storebit_add.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.Storebit_add" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<script>
		   function killErrors() {
		return true;
		}
		window.onerror = killErrors;	
		
			function chknull()
			{


			if(document.getElementById('Name').value=='')
			{
				alert('名称不能为空');
				
				return false;
			}	
			
			if(document.getElementById('Storeroom').value=='')
			{
				alert('所属库房不能为空');
				
				return false;
			}		
			
								
	     	}
	     	
	     	var  wName;  
            function  fnOpen()  
            {  
				 var num=Math.random();
                 wName=window.showModalDialog("open_Storeroom.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");               
             
                 if(wName!=null && wName!= "undefined")
                 {
                   
			    	document.getElementById("Storeroom").value=wName; 
			    	return;
                 }
            
                
            }	
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="Storebit.aspx">库位设置</A>&nbsp;&gt;&gt; 
									新增库位信息</td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<table height="450" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="15">&nbsp;</td>
					<td vAlign="top" width="95%">
						<table cellSpacing="1" cellPadding="0" width="100%" bgColor="#7d9db4" border="0">
							<tr>
								<td vAlign="top" bgColor="#f3f8fe">
									<table height="26" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td background="i_blue/third_head_bg.jpg">&nbsp;</td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<tr bgColor="#f3f8fe">
											<td align="right" width="15%"><FONT face="宋体">库位编号：</FONT></td>
											<td width="85%"><asp:textbox id="Number" runat="server" Width="100%" ></asp:textbox></td>
										</tr>
										<tr bgColor="#f3f8fe">
											<td align="right"><FONT face="宋体">库房名称：</FONT></td>
											<td><asp:textbox id="Name" runat="server" Width="100%"></asp:textbox></td>
										</tr>
										<tr bgColor="#f3f8fe">
											<td align="right"><FONT face="宋体">所属库房：</FONT></td>
											<td><asp:textbox id="Storeroom" runat="server" Width="90%" ></asp:textbox><A href="javascript:void(0)"><IMG var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectDanWei.aspx?TableName=ERPBuMen&LieName=BuMenName&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('unit').value=wName;} alt="" src="image/FDJ.gif" border="0"></A></td>
										</tr>
									</table>
									<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td background="i_blue/third_head_bg1.jpg">
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
													<tr>
														<td width="39%">&nbsp;</td>
														<td width="9%"><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:imagebutton></td>
														<td width="52%">
															<asp:ImageButton id="ImageButton2" runat="server" ImageUrl="i_blue/back.jpg"></asp:ImageButton></td>
													</tr>
												</table>
											</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
					<td width="15">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
