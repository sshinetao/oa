<%@ Page language="c#" Codebehind="Rk_WorkStreamName_add_update.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.Rk_WorkStreamName_add_update" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<base target="_self">
		<script>
			function chknull()
				{


		if(document.getElementById('Name_Jd').value=='')
			{
				alert('名称不能为空');
				
				return false;
			}	
			
			if(document.getElementById('realname').value=='')
			{
				alert('人员不能为空');
				
				return false;
			}	
			
									
			}
	
			var  wName;  
        function  jdOpen()  
            {  
            var num=Math.random();
                wName=window.showModalDialog("open_Rk_WorkStreamJd.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");               
              
                document.getElementById("Name_Jd").value=wName; 
             
               
                
            }			
	
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table1">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0" id="Table2">
							<tr>
								<td class="headfont" width="97%">
									修改追加工作流程</td>
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
										<tr bgColor="#f3f8fe">
											<td align="right" width="15%"><FONT face="宋体">节点名称：</FONT></td>
											<td width="85%"><asp:textbox id="Name_Jd" runat="server" Width="90%" ></asp:textbox><A href="JavaScript:void(0)"><IMG onclick="jdOpen()" alt="" src="image/FDJ.gif" border="0"></A></td>
										</tr>
										<tr bgColor="#f3f8fe">
											<td align="right"><FONT face="宋体">审批人员：</FONT></td>
											<td>
												<asp:textbox id="realname" runat="server" Width="100%" ></asp:textbox></td>
										</tr>
									</table>
									<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table7">
										<tr>
											<td background="i_blue/third_head_bg1.jpg">
												<table cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table8">
													<tr>
														<td width="39%">&nbsp;</td>
														<td width="9%"><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:imagebutton></td>
														<td width="52%"><FONT face="宋体">&nbsp;</FONT><a href="javascript:void(0)"><IMG alt="" src="i_blue/close.jpg" onclick="javascript:window.close()" border="0"></a></td>
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
			<asp:textbox id="username" style="DISPLAY: none" runat="server" ></asp:textbox>
			<script language="javascript">	
				  		var  wName_1;  
        function  usOpen()  
            {  
            var num=Math.random();
                wName_1=window.showModalDialog("username_open.aspx?tmp="+num+" ","window","dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");                
              
         
                
var arr = wName_1.split("|");
for(var i=0;i<arr.length;i++)
{ 

document.getElementById("realname").value=arr[0]; 
document.getElementById("username").value=arr[1]; 
}


}
			</script>
		</form>
	</body>
</HTML>
