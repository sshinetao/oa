<%@ Page language="c#" Codebehind="main_tail.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.main_tail" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>main_tail</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="i_blue/css.css" type="text/css" rel="stylesheet">
		<script>
	
			function send_request(url)
			{
				http_request=false;
				if(window.XMLHttpRequest)//Mozilla �����
				{
					http_request=new XMLHttpRequest();
					if(http_request.overrideMimeType)//����MiME���
					{
						http_request.overrideMimeType("text/xml");
					}
				}
				else if(window.ActiveXObject)// IE�����
				{
					try
					{
						http_request=new ActiveXObject("Msxml2.XMLHTTP");
					}
					catch(e)
					{
						try
						{
							http_request=new ActivexObject("Microsoft.XMLHTTP");
						}
						catch(e)
						{}
					}
				}
				if(!http_request)// �쳣����������ʵ��ʧ��
				{
				    content.innerHTML="���ܴ���XMLHttpRequest����ʵ��";
					//window.alert("���ܴ���XMLHttpRequest����ʵ��");
					return false;
				}
				//ָ��������������Ϣʱ�������
				http_request.onreadystatechange=processRequest;
				// ȷ����������ķ�ʽ��URL�Լ��Ƿ�ͬ��ִ���¶δ���
				http_request.open("GET",url,true);
				http_request.send(null);
			}
			
			
			
			function processRequest()
			{
				if(http_request.readyState==4)
				{					
					if(http_request.status==200)
					{						
				
					//content.innerHTML=http_request.responseText;
					
					if(http_request.responseText=='notuser')
					{
					alert('��½��ʱ');window.parent.location = 'default.aspx' }
					}
					else
					{
						//window.parent.location = 'default.aspx' 
						
					window.parent.location = 'default.aspx'
					content.innerHTML="���������ҳ�����쳣�������µ�½����";
					}
				}
			}
			
		
			window.setInterval("send_request('user_online_update.aspx?tmp='+Math.random())",300000);
			
		</script>
		<script>
		function card()
		{
		var num=Math.random();
		  window.showModalDialog("card.aspx?tmp="+num+"","window","dialogWidth:457px;DialogHeight=300px;status:no;scroll=no;help:no");  
		}
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<div id="content">
			</div>
			<SCRIPT>
	send_request('user_online_update.aspx?tmp='+Math.random());
			</SCRIPT>
			<FONT face="����"></FONT><FONT face="����"></FONT><FONT face="����"></FONT><FONT face="����">
			</FONT><FONT face="����"></FONT><FONT face="����"></FONT><FONT face="����"></FONT><FONT face="����">
			</FONT><FONT face="����"></FONT><FONT face="����"></FONT><FONT face="����"></FONT><FONT face="����">
			</FONT><FONT face="����"></FONT>
			<TABLE WIDTH="1004" BORDER="0" CELLSPACING="0" CELLPADDING="0">
				<TR>
					<TD height="26" background="i_blue/tail.jpg" width="1004" vAlign="middle" align="center">
						<FONT face="����">��Ȩ���У�<FONT face="����" color="#ffffff">�ð������</FONT>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<a href="javascript:void(0)" onclick="card()"><FONT face="����" color="#ffffff">��ϵ����</FONT></a></FONT></TD>
				</TR>
			</TABLE>
			</TD></TR></TABLE>
		</form>
	</body>
</HTML>
