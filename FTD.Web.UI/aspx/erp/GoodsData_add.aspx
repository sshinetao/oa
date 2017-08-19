<%@ Page language="c#" Codebehind="GoodsData_add.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.GoodsData_add" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>真达进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<META HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<META HTTP-EQUIV="Cache-Control" CONTENT="no-cache">
		<META HTTP-EQUIV="Expires" CONTENT="0">
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
				alert('名称不能为空');
				Form1.GoodsName.focus();
				return false;
			}	
			
	
									
			}
			
			

	     	var  wName;  
            function  fnOpen()  
            {  
				 var num=Math.random();
                 wName=window.showModalDialog("open_CountUnit.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");               
             
                 if(wName!=null && wName!= "undefined")
                 {
                   
			    	document.getElementById("CountUnit").value=wName; 
			    	return;
                 }
            
                
            }
            
            
            var  wName1;  
            function  lbOpen()  
            {  
				 var num=Math.random();
                 wName1=window.showModalDialog("open_GoodsType.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");               
             
                 if(wName1!=null && wName1!= "undefined")
                 {
                   
			    	document.getElementById("Type").value=wName1; 
			    	return;
                 }
            
                
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="GoodsData.aspx">货品资料</A>&nbsp;&gt;&gt; 
									新增货品资料</td>
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
												
												
												<td align="right" width="15%"><FONT face="宋体">货品名称：</FONT></td>
												<td width="35%"><asp:textbox id="GoodsName" runat="server" Width="100%"></asp:textbox>
                                                    <div style="display:none;"><asp:textbox id="Number" runat="server" Width="100%" ></asp:textbox></div>

												</td>

											</tr>
											<tr bgColor="#f3f8fe">
                                                <td align="right" width="15%"><FONT face="宋体">类别：</FONT></td>
												<td width="35%">
                                                      <asp:DropDownList ID="ddlType" runat="server" Width="100%"></asp:DropDownList>
                                                  </td>
											</tr>
											<tr bgColor="#f3f8fe">
                                           
												<td align="right" width="15%"><FONT face="宋体">计量单位：</FONT></td>
												<td width="35%">
                                                    <asp:DropDownList ID="ddlCountUnit" runat="server" Width="100%"></asp:DropDownList>
                                                 </td>
												
											</tr>
										
											
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">备注：</FONT></td>
												<td width="35%"><asp:textbox id="Remark" runat="server" Width="100%"></asp:textbox></td>
											</tr>
							</tr>
						</table>
						<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table7">
							<tr>
								<td background="i_blue/third_head_bg1.jpg">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table8">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:imagebutton></td>
											<td width="52%"><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></td>
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
