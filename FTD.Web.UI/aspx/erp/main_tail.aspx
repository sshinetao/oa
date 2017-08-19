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
				if(window.XMLHttpRequest)//Mozilla 浏览器
				{
					http_request=new XMLHttpRequest();
					if(http_request.overrideMimeType)//设置MiME类别
					{
						http_request.overrideMimeType("text/xml");
					}
				}
				else if(window.ActiveXObject)// IE浏览器
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
				if(!http_request)// 异常，创建对象实例失败
				{
				    content.innerHTML="不能创建XMLHttpRequest对象实例";
					//window.alert("不能创建XMLHttpRequest对象实例");
					return false;
				}
				//指定服务器返回信息时处理程序
				http_request.onreadystatechange=processRequest;
				// 确定发送请求的方式和URL以及是否同步执行下段代码
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
					alert('登陆超时');window.parent.location = 'default.aspx' }
					}
					else
					{
						//window.parent.location = 'default.aspx' 
						
					window.parent.location = 'default.aspx'
					content.innerHTML="您所请求的页面有异常。请重新登陆再试";
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
			<FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体">
			</FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体">
			</FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体">
			</FONT><FONT face="宋体"></FONT>
			<TABLE WIDTH="1004" BORDER="0" CELLSPACING="0" CELLPADDING="0">
				<TR>
					<TD height="26" background="i_blue/tail.jpg" width="1004" vAlign="middle" align="center">
						<FONT face="宋体">版权所有：<FONT face="宋体" color="#ffffff">好帮手软件</FONT>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<a href="javascript:void(0)" onclick="card()"><FONT face="宋体" color="#ffffff">联系我们</FONT></a></FONT></TD>
				</TR>
			</TABLE>
			</TD></TR></TABLE>
		</form>
	</body>
</HTML>
