<%@ Page language="c#" Codebehind="Systemnbdxx_add.aspx.cs" AutoEventWireup="false" Inherits="bjoa.Systemnbdxx_add" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Эͬ�칫ƽ̨</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<script>
			
		function killErrors() {
		return true;
		}
		window.onerror = killErrors;
		</script>
		<SCRIPT language="javascript" type="text/javascript">

function checkForm()
{
with(document.Form1)
{

//--------------1
var strUploadFile=uploadFile.value;
var picOK=false;

if (strUploadFile=="")
	{
	alert("��ʾ:\r����û��ѡ���ϴ����ļ���"); 
	return(false); 
	uploadFile.focus;
	} 
	var nameLen=strUploadFile.length;
	var rightName=strUploadFile.substr(nameLen-4,4).toLowerCase();


	if (nameLen>0)
	{
		if ( rightName==".rar" ||  rightName==".zip" ||  rightName==".doc"  ||  rightName==".xls"  ||  rightName==".ppt" || rightName==".RAR" ||  rightName==".ZIP" ||  rightName==".DOC"  ||  rightName==".XLS"  ||  rightName==".PPT"   )
		{ picOK=true; }

		if (picOK==false)
		{ alert("��ʾ:\rֻ���ϴ�.rar|.zip |.doc|.xls|.ppt��ʽ���ļ���");
		return(false);
		uploadFile.focus;
		}
	}

//--------------1

}
}
		</SCRIPT>
		<script>

			
	
            
 

	function  down()  
	{
	 if(document.getElementById('fjlb').value=='')
			{
			
				alert('δѡ���ļ�');
				
				return false;
			}
			else
			{
				var num=Math.random();
				var littleproduct=document.getElementById("fjlb");
				var cindex = littleproduct.selectedIndex;
				var cText  = littleproduct.options[cindex].text;
				var cValue = littleproduct.options[cindex].value;
				
				 // window.showModalDialog("MeetingHouse_down.aspx?tmp="+num+"&number="+cValue+" ","window","dialogWidth:1000px;DialogHeight=600px;status:no;scroll=yes;help:no");                
				  
				  
				window.open ("Systemnbdxx_add_down.aspx?tmp="+num+"&number="+cValue+"", "newwindow", "height=1, width=1,toolbar=no, menubar=no, scrollbars=no,resizable=yes,location=no, status=no")
			}
	 
	
	}
	
	function  delfj()  
	{
	 if(document.getElementById('fjlb').value=='')
			{
			
				alert('δѡ���ļ�');
				
				return false;
			}
			else
			{
				var num=Math.random();
				var littleproduct=document.getElementById("fjlb");
				var cindex = littleproduct.selectedIndex;
				var cText  = littleproduct.options[cindex].text;
				var cValue = littleproduct.options[cindex].value;
				
				  window.showModalDialog("Systemnbdxx_add_del.aspx?tmp="+num+"&number="+cValue+" ","window","dialogWidth:1000px;DialogHeight=600px;status:no;scroll=yes;help:no");                
				//window.open ("MeetingHouse_fj_del.aspx?tmp="+num+"&number="+cValue+"", "newwindow", "height=1, width=1,toolbar=no, menubar=no, scrollbars=no,resizable=no,location=no, status=no")
			}
	 
	
	}			
				
			            
                   
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form method="post" runat="server" ID="Form1">
			<script language='javascript' src='DateSelect.js'></script>
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><img src="i_blue/m_head_1.jpg" width="20" height="34"></td>
					<td width="748" background="i_blue/m_head_3.jpg"><table width="92%" height="25" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td width="97%" class="headfont"><a href="main_1.aspx" class="line_b">����̨</a>&nbsp;&gt;&gt;&nbsp;<a href="Systemnbdxx.aspx" class="line_b">��Ϣ����</a>&nbsp;&gt;&gt; 
									������Ϣ</td>
							</tr>
						</table>
					</td>
					<td width="23"><img src="i_blue/m_head_2.jpg" width="21" height="34"></td>
				</tr>
			</table>
			<table width="100%" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td width="15">&nbsp;</td>
					<td width="95%" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#7d9db4">
							<TBODY>
								<tr>
									<td valign="top" bgcolor="#f3f8fe"><table width="100%" height="26" border="0" cellpadding="0" cellspacing="0">
											<tr>
												<td background="i_blue/third_head_bg.jpg">&nbsp;</td>
											</tr>
										</table>
										<table width="100%" border="0" cellpadding="4" cellspacing="1" bgcolor="#d8e1e8">
											<TBODY>
												<tr bgcolor="#f3f8fe">
													<td align="right" width="15%"><FONT face="����">��Ϣ���⣺</FONT></td>
													<td width="85%">
														<asp:TextBox id="title" runat="server" Width="100%"></asp:TextBox><a href="javascript:void(0)"></a></td>
												</tr>
												<tr bgcolor="#f3f8fe">
													<td align="right" width="15%"><FONT face="����">��Ϣ���ݣ�</FONT></td>
													<td width="85%">
														<asp:TextBox id="content" runat="server" Width="100%" Height="118px" TextMode="MultiLine"></asp:TextBox><a href="javascript:void(0)"></a></td>
												</tr>
												<tr bgColor="#f3f8fe">
													<td align="right"><FONT face="����"><FONT face="����"><FONT face="����">�����б�</FONT></FONT>��</FONT></td>
													<td><asp:dropdownlist id="fjlb" runat="server" Width="472px"></asp:dropdownlist><INPUT onclick="javascript:return down();" type="button" value="��  ��"><FONT face="����">&nbsp;</FONT>
														<asp:button id="Button1" runat="server" Text="ɾ  ��"></asp:button></td>
												</tr>
												<tr bgColor="#f3f8fe">
													<td align="right"><FONT face="����"><FONT face="����"><FONT face="����">�ϴ�����</FONT></FONT>��</FONT></td>
													<td><INPUT id="uploadFile" style="WIDTH: 464px; HEIGHT: 20px" type="file" size="58" name="uploadFile"
															runat="server"><FONT face="����">&nbsp;</FONT>
														<asp:button id="Button3" runat="server" Width="56px" Text="��  ��"></asp:button><asp:label id="newname" runat="server" Width="96px" Visible="False">nothing.jpg</asp:label><asp:label id="Label1" runat="server"></asp:label></td>
												</tr>
								</tr>
							</TBODY>
						</table>
						<TABLE WIDTH="100%" BORDER="0" CELLSPACING="0" CELLPADDING="4">
							<TR>
								<TD align="center"><FONT face="����">
										<TABLE id="Table9" style="WIDTH: 507px; HEIGHT: 152px" cellSpacing="0" cellPadding="0"
											width="507" border="0">
											<TR>
												<TD colspan="4" align="center"><FONT face="����" color="#ff0000"><STRONG>��ѡ���Ͷ���</STRONG></FONT></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 52px"></TD>
												<TD style="WIDTH: 156px">
													<asp:ListBox id="SourceListBox" runat="server" Width="144px" Height="120px" SelectionMode="Multiple"
														Rows="10"></asp:ListBox></TD>
												<TD style="WIDTH: 66px"><FONT face="����">
														<P>
															<asp:button id="btnAdd" runat="server" Width="56px" CssClass="button" Text=">"></asp:button></P>
														<P>&nbsp;</P>
														<P>
															<asp:button id="btnAddAll" runat="server" Width="56px" CssClass="button" Text=">>"></asp:button></P>
														<P>&nbsp;</P>
														<P>
															<asp:button id="btnRemove" runat="server" Width="56px" CssClass="button" Text="<"></asp:button></P>
														<P>&nbsp;</P>
														<P>
															<asp:button id="btnRemoveAll" runat="server" Width="56px" CssClass="button" Text="<<"></asp:button></P>
													</FONT>
												</TD>
												<TD>
													<asp:ListBox id="TargetListBox" runat="server" Width="144px" Height="120px" SelectionMode="Multiple"
														Rows="10"></asp:ListBox></TD>
											</TR>
										</TABLE>
									</FONT>
								</TD>
							</TR>
						</TABLE>
						<table width="100%" height="25" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td background="i_blue/third_head_bg1.jpg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%">
												<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:ImageButton></td>
											<td width="52%">&nbsp;
												<asp:ImageButton id="ImageButton2" runat="server" ImageUrl="i_blue/back.jpg"></asp:ImageButton></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			<asp:TextBox id="Number" runat="server" Visible="False"></asp:TextBox></TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE>
		</form>
	</body>
</HTML>
