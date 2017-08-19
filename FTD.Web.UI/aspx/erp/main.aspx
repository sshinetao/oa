<%@ Page language="c#" Codebehind="main.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.main" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>好帮手进销存</title>
		<LINK href="i_blue/css.css" type="text/css" rel="stylesheet">
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<SCRIPT language="javascript">
	function killErrors() {
		return true;
		}
		window.onerror = killErrors;


		  function visible_click_f()
           {
         
               td1.className="tddisp";
               document.getElementById('middle_picture_f').style.display='none'; 
               document.getElementById('middle_picture').style.display=''; 
               
               
 
           }
            function visible_click()
           {
             td1.className="";
             document.getElementById('middle_picture_f').style.display=''; 
             document.getElementById('middle_picture').style.display='none'; 
           }
        
            function zx()
			{
			
			    if (!confirm("是否确定要注销？"))
			    return false;
		     
			
			}
			 function showhelp()
			 {
			 	var num=Math.random();
		     window.open ("help.aspx?tmp="+num+"", "newwindow", "height=640, width=800,toolbar=no, menubar=no, scrollbars=no,resizable=no,location=no, status=no")
			 }
			   
		</SCRIPT>
		<SCRIPT>


var flyingwin
var popupwidth=400
var popupheight=280
var marginright
var windowcenter
var i_top=50
var i_left=-popupwidth-10
var step=40
var timer
var waitingtime=60000
var pause=20

function showWindow() {
	flyingwin = window.open("", "flyingwin", "toolbar=no,width="+popupwidth+",height="+popupheight+",top=100, scrollbars=no,menubar=no, resizable=no,location=no, status=no,left="+(-popupwidth)+"");
	flyingwin.document.open();
	//flyingwin.document.write("<html><title>漂浮的窗口</title><body><p style='font-size:9pt;color:red' align=center>请不要关闭，我马上就自动滚蛋。</body></html>");
	
	flyingwin.document.write("<html><title>畲森山进销存提醒窗口---->请注意查看</title><body><IFRAME border=0 scrolling=yes marginWidth=0 marginHeight=0 src=main_tx.aspx frameBorder=0  width=100% height=100% BORDERCOLOR=#ffffFF></IFRAME></body></html>");
	
	
	
	flyingwin.document.close();
	
	if (document.all) {
		marginright = screen.width+50
	}
	if (document.layers) {
		marginright = screen.width+50
	}
	windowcenter=Math.floor(marginright/2)-Math.floor(popupwidth/2)
	movewindow()
		
}

function movewindow() {
		if (i_left<=windowcenter) {
			flyingwin.moveTo(i_left,i_top)
			i_left+=step
			timer= setTimeout("movewindow()",pause)
		}
		else {
			clearTimeout(timer)
			timer= setTimeout("movewindow2()",waitingtime)
		}
}

function movewindow2() {
		if (i_left<=marginright) {
			flyingwin.moveTo(i_left,i_top)
			i_left+=step
			timer= setTimeout("movewindow2()",pause)
		}
		else {
			clearTimeout(timer)
			flyingwin.close()
		}
}


		</SCRIPT>
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
					
					if(http_request.responseText=='1')
					{
				if(document.getElementById('iftx').value=='需要')
		            	{
				showWindow()
			           }		
					
					
					
					}
					}
					else
					{
					
						//window.parent.location = 'default.aspx' 
						
					//window.parent.location = 'default.aspx'
					//content.innerHTML="您所请求的页面有异常。请重新登陆再试";
					}
				}
			}
			
		
			window.setInterval("send_request('main_tx_ajax.aspx?tmp='+Math.random())",<%=txtime%>);
			
		</script>
		<script language="javascript">
		
		function MM_jumpMenu(targ,selObj,restore){ 
          eval(targ+".location='"+selObj.options[selObj.selectedIndex].value+"'");
          if (restore) selObj.selectedIndex=0;
                   }
                   
		</script>
		<script>
		function xt()
		{
		var num=Math.random();
		  window.showModalDialog("xt.aspx?tmp="+num+"","window","dialogWidth:457px;DialogHeight=300px;status:no;scroll=no;help:no");  
		}
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout" >
		<form id="Form1" method="post" runat="server">
			<table height="660" border="0" cellpadding="0" cellspacing="0">
				<div id="content">
				</div>
				<SCRIPT>
	send_request('main_tx_ajax.aspx?tmp='+Math.random());
				</SCRIPT>
				<tr>
					<td width="1054" valign="top"><table width="1004" height="69" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td background="i_blue/head.jpg"><table width="100%" height="54" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td width="32%" height="35">&nbsp;</td>
											<td width="68%">
												<asp:TextBox id="iftx" runat="server" style="DISPLAY: none"></asp:TextBox></td>
										</tr>
										<tr>
											<td>&nbsp;</td>
											<td>欢迎进入：好帮手进销存
												<%=riqi%>
											</td>
										</tr>
									</table>
									<asp:TextBox id="type" runat="server" style="DISPLAY: none"></asp:TextBox>
								</td>
							</tr>
						</table>
						<table width="1004" height="29" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td background="i_blue/head_l.jpg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td width="2%">&nbsp;</td>
											<td width="21%"><strong><a target="rform" href="main_1.aspx"><font color="#ffffff">工作台 </font>
													</a></strong>|<strong>
													<asp:LinkButton id="LinkButton1" runat="server" ForeColor="White">注销</asp:LinkButton></strong></td>
											<td width="72%">
												<asp:Label id="link" runat="server"></asp:Label></td>
											<td width="5%">&nbsp;</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
						<table width="1004" height="538" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td valign="top"><table width="1004" height="538" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td width="192" valign="top" class="" id="td1">
												<table width="192" height="538" border="0" cellpadding="0" cellspacing="0">
													<tr>
														<td valign="top"><table width="192" height="72" border="0" cellpadding="0" cellspacing="0">
																<tr>
																	<td width="192" height="72" background="i_blue/left_head.jpg">
																		<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
																			<TR>
																				<TD width="59"><FONT face="宋体"></FONT></TD>
																				<TD><FONT face="宋体">&nbsp;</FONT>
																				</TD>
																				<TD></TD>
																			</TR>
																			<TR>
																				<TD height="26"><FONT face="宋体"></FONT></TD>
																				<TD height="26"><FONT face="宋体"></FONT></TD>
																				<TD height="26"></TD>
																			</TR>
																		</TABLE>
																	</td>
																</tr>
															</table>
															<table width="192" height="416" border="0" cellpadding="0" cellspacing="0">
																<tr>
																	<td><table width="192" height="416" border="0" cellpadding="0" cellspacing="0">
																			<tr>
																				<td width="19" valign="top"><img src="i_blue/left_middle_1.jpg" width="19" height="416"></td>
																				<td valign="top">
																					<IFRAME border="0" name="lform" marginWidth="1" marginHeight="1" src="left.aspx" frameBorder="0"
																						width="100%" height="100%" BORDERCOLOR="#ffffFF"></IFRAME>
																				</td>
																				<td width="6" valign="top"><img src="i_blue/left_middle_3.jpg" width="6" height="416"></td>
																			</tr>
																		</table>
																	</td>
																</tr>
															</table>
															<table width="192" height="50" border="0" cellpadding="0" cellspacing="0">
																<tr>
																	<td valign="top"><table width="192" border="0" cellspacing="0" cellpadding="0">
																			<tr>
																				<td height="11"><img src="i_blue/tail_1.jpg" width="192" height="11"></td>
																			</tr>
																			<tr>
																				<td height="35"><a href="SystemPassword.aspx" target="rform"><img src="i_blue/d_zxry.jpg" width="72" height="35" border="0"></a><a href="user_all.aspx" target="rform"><img src="i_blue/d_qbry.jpg" width="61" height="35" border="0"></a><a target="rform" href="Systemnbdxx.aspx"><img src="i_blue/d_dxx.jpg" width="59" height="35" border="0"></a></td>
																			</tr>
																			<tr>
																				<td height="4"><img src="i_blue/tail_3.jpg" width="192" height="4"></td>
																			</tr>
																		</table>
																	</td>
																</tr>
															</table>
														</td>
													</tr>
												</table>
											</td>
											<td width="25" valign="top">
												<a href="javascript:void(0)"><img src="i_blue/left_2_f.jpg" width="25" height="538" border="0" id="middle_picture_f"
														onclick="visible_click_f()"></a> <a href="javascript:void(0)"><img src="i_blue/left_2.jpg" width="25" height="538" border="0" id="middle_picture" style="DISPLAY: none"
														onclick="visible_click()"></a>
											</td>
											<td valign="top" bgcolor="#fcfafb">
												<IFRAME border="0" name="rform" marginWidth="1" marginHeight="1" src="main_1.aspx" frameBorder="0"
													width="100%" height="100%" BORDERCOLOR="#ffffFF"></IFRAME>
											</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
						<table width="100%" border="0" cellspacing="0" cellpadding="0">
							<tr>
								<td>
									<IFRAME border="0" marginWidth="0" marginHeight="0" src="main_tail.aspx" frameBorder="0"
										width="100%" height="28"></IFRAME><IFRAME border="0" marginWidth="0" marginHeight="0" src="user_online.aspx" frameBorder="0"
										width="0" height="0"></IFRAME>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
