<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SellOrderList.aspx.cs" Inherits="FTD.Web.UI.aspx.HY.SellOrderList" %>

<%@ Register TagPrefix="uc1" TagName="fenye" Src="../erp/fenye.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	
        <link href="../../css/main.css" type="text/css" rel="stylesheet" />
  <LINK href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
		<SCRIPT language="javascript">
		    function del() {
		        if (!confirm("是否确定删除？"))
		            return false;
		    }

		    function wb() {
		        if (!confirm("是否确定把状态更改为[执行完毕]？"))
		            return false;
		    }

		    function zf() {
		        if (!confirm("是否确定把状态更改为[作废]？"))
		            return false;
		    }

		</SCRIPT>
        <SCRIPT LANGUAGE="JavaScript">
            var a;
            function CheckValuePiece() {
                if (window.document.form1.GoPage.value == "") {
                    alert("请输入跳转的页码！");
                    window.document.form1.GoPage.focus();
                    return false;
                }
                return true;
            }
            function CheckAll() {
                if (a == 1) {
                    for (var i = 0; i < window.document.forms['form1'].elements.length; i++) {
                        var e = form1.elements[i];
                        e.checked = false;
                    }
                    a = 0;
                }
                else {
                    for (var i = 0; i < window.document.forms['form1'].elements.length; i++) {
                        var e = form1.elements[i];
                        e.checked = true;
                    }
                    a = 1;
                }
            }
            function CheckDel() {
                var number = 0;
                for (var i = 0; i < window.document.forms['form1'].elements.length; i++) {
                    var e = form1.elements[i];
                    if (e.Name != "CheckBoxAll") {
                        if (e.checked == true) {
                            number = number + 1;
                        }
                    }
                }
                if (number == 0) {
                    alert("请选择需要删除的项！");
                    return false;
                }
                if (window.confirm("你确认删除吗？")) {
                    return true;
                }
                else {
                    return false;
                }
            }

            function CheckModify() {
                var Modifynumber = 0;
                for (var i = 0; i < window.document.forms['form1'].elements.length; i++) {
                    var e = form1.elements[i];
                    if (e.Name != "CheckBoxAll") {
                        if (e.checked == true) {
                            Modifynumber = Modifynumber + 1;
                        }
                    }
                }
                if (Modifynumber == 0) {
                    alert("请至少选择一项！");
                    return false;
                }
                if (Modifynumber > 1) {
                    alert("只允许选择一项！");
                    return false;
                }

                return true;
            }



		</SCRIPT>  

	</HEAD>
	<body >
		<form id="Form1" runat="server">
            <div>
                  <table style="width: 100%" border="0" cellpadding="0" cellspacing="0">            
            <tr>
                <td valign="middle" style=" height: 30px; ">&nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;工作台&nbsp;>>&nbsp;销售订单
                </td>
                <TD style="WIDTH: 143px"><FONT face="宋体">标题关键字：</FONT></TD>
						<TD style="WIDTH: 130px"><asp:textbox id="tilte" runat="server" Width="120px"></asp:textbox></TD>
						
                <td align="right" valign="middle" style=" height: 30px;">
			
                    <asp:imagebutton id="ImageButton2" runat="server" ImageUrl="../erp/i_blue/search.jpg"></asp:imagebutton><FONT face="宋体">&nbsp;</FONT>
							<asp:imagebutton id="Imagebutton1" runat="server" ImageUrl="../erp/i_blue/insert.jpg" OnClick="Imagebutton1_Click1"></asp:imagebutton><FONT face="宋体">&nbsp;
								<asp:imagebutton id="Imagebutton9" runat="server" ImageUrl="../erp/i_blue/chakan.jpg" OnClick="Imagebutton9_Click1"></asp:imagebutton>&nbsp;</FONT>
							<asp:imagebutton id="Imagebutton4" runat="server" ImageUrl="../erp/i_blue/xiugai.jpg" OnClick="Imagebutton4_Click1"></asp:imagebutton><FONT face="宋体">&nbsp;</FONT>
							<asp:imagebutton id="Imagebutton5" runat="server" ImageUrl="../erp/i_blue/shanchu.jpg" OnClick="Imagebutton5_Click1"></asp:imagebutton><FONT face="宋体">&nbsp;
								&nbsp;
								&nbsp;</FONT>
                    <asp:imagebutton id="ImageButton3" runat="server" ImageUrl="../erp/i_blue/back.jpg"></asp:imagebutton>

                </td>
            </tr>
        </table>
            </div>
			
			<table height="135" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td vAlign="top">
									<asp:datagrid id="Datagrid2" CssClass="gridview_m"  runat="server" Width="100%" BorderStyle="Groove" GridLines="Vertical"
											BackColor="White" AutoGenerateColumns="False"  PageSize="12" OnPageIndexChanged="MyDataGrid_Page_1"
											BorderWidth="1px" AllowPaging="True">
											<FooterStyle ForeColor="Black"></FooterStyle>
											<SelectedItemStyle Font-Bold="True" ForeColor="White"></SelectedItemStyle>
											<AlternatingItemStyle></AlternatingItemStyle>
											<ItemStyle ForeColor="Black"></ItemStyle>
											<HeaderStyle BackColor="#F3F3F3" Font-Size="12px" ForeColor="Black" Height="30px" ></HeaderStyle>
											<Columns>
												<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
												
												<asp:BoundColumn DataField="CompanyName" SortExpression="CompanyName" HeaderText="客户名称">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="Tel" SortExpression="YjMoney" HeaderText="联系电话">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="CompanyAdd" SortExpression="YjMoney" HeaderText="客户地址">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="StockPeoName" SortExpression="StockPeoName" HeaderText="业务员姓名">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="Discount" SortExpression="Discount" HeaderText="享受折扣">
													<HeaderStyle Wrap="False"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="AllMoney" SortExpression="AllMoney" HeaderText="总金额">
													<HeaderStyle Wrap="False"></HeaderStyle>
												</asp:BoundColumn>
												
												<asp:BoundColumn Visible="False" DataField="MyTimes"></asp:BoundColumn>
											</Columns>
											<PagerStyle Visible="False" NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
												BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
										</asp:datagrid>
									<uc1:fenye id="Fenye1" runat="server"></uc1:fenye></td>
							</tr>
              
						</table>
					
		</form>
	</body>
</HTML>
