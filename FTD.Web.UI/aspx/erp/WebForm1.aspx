<%@ Page language="c#" Codebehind="WebForm1.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<script>	
			function chknull()
			{
				val=parseInt(document.getElementById('TextBox1').value);
				if(val>1)
				{
					alert('�ۿ۲���С��0����1');
			
					return false;
				}	
				
			}
		
		
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="TextBox1" style="Z-INDEX: 101; LEFT: 272px; POSITION: absolute; TOP: 80px" runat="server"
				Width="232px"></asp:TextBox><INPUT style="Z-INDEX: 102; LEFT: 360px; POSITION: absolute; TOP: 120px" type="button"
				value="Button" onclick="chknull();">
		</form>
	</body>
</HTML>
