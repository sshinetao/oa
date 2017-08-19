<%@ Page language="c#" Codebehind="Cgrk_WorkStreamName.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.Cgrk_WorkStreamName" %>
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
			function chknull()
				{


		if(document.getElementById('Name').value=='')
			{
				alert('名称不能为空');
				
				return false;
			}	
			
	
			
									
			}
			
			 function  lxOpen()  
            {  
            var num=Math.random();
            var number=document.getElementById('KeyFile').value;
           window.showModalDialog("Cgrk_WorkStreamName_add_add.aspx?tmp="+num+"&number="+number+" ","window","dialogWidth:600px;DialogHeight=330px;status:no;scroll=yes;help:no");                
              
               
               
                
            }  
 
 function m_show(id)
{ 
  var num=Math.random();
window.showModalDialog('Cgrk_WorkStreamName_add_update.aspx?id='+id+'&tmp='+num+'','window','dialogWidth:505px;DialogHeight=400px;status:no;help=no;scroll=on');window.location='#'

window.location="Cgrk_WorkStreamName.aspx?id=<%=id%>";
}  


 function del(id)
{
	if (!confirm("确定删除此项吗？"))
		return false;
		window.location="Cgrk_WorkStreamName.aspx?id=<%=id%>&del="+id;
}  



 function pdzj(id)
{ 
  var num=Math.random();
window.showModalDialog('Cgrk_WorkStreamName_add_pdzj.aspx?id='+id+'&tmp='+num+'','window','dialogWidth:505px;DialogHeight=400px;status:no;help=no;scroll=on');window.location='#'

window.location="Cgrk_WorkStreamName.aspx?id=<%=id%>";
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;采购入库审批流程&nbsp; 
									&gt;&gt;&nbsp;<A class="line_b" href="Cgrk_stream.aspx">工作流</A>&nbsp;&gt;&gt; 
									设置工作流</td>
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
											<td align="right" background="i_blue/third_head_bg.jpg"><asp:imagebutton id="ImageButton3" runat="server" ImageUrl="i_blue/szlc.jpg"></asp:imagebutton>&nbsp;</td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<tr bgColor="#f3f8fe">
											<td align="right" width="15%"><FONT face="宋体"><FONT face="宋体">工作流名称</FONT>：</FONT></td>
											<td width="85%"><asp:textbox id="Name_type" runat="server"  Width="100%"></asp:textbox></td>
										</tr>
										<tr bgColor="#f3f8fe">
											<td align="center" colSpan="2"><asp:label id="Label1" runat="server">Label</asp:label></td>
										</tr>
									</table>
									<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td background="i_blue/third_head_bg1.jpg">
												<table cellSpacing="0" cellPadding="0" width="100%" border="0">
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
						<asp:textbox id="KeyFile" style="DISPLAY: none" runat="server" ></asp:textbox></td>
					<td width="15">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
