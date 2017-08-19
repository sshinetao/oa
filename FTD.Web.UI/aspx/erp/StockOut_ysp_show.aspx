<%@ Page Language="c#" CodeBehind="StockOut_ysp_show.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.StockOut_ysp_show" %>

<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>�ɭɽ������</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <link href="i_blue/ny.css" type="text/css" rel="stylesheet">
    <script>
        function killErrors() {
            return true;
        }
        window.onerror = killErrors;

        function del() {
            if (!confirm("�Ƿ�ȷ��ɾ����"))
                return false;
        }


        function chknull() {


            if (document.getElementById('tilte').value == '') {
                alert('���ⲻ��Ϊ��');
                Form1.tilte.focus();
                return false;
            }

            if (document.getElementById('unit').value == '') {
                alert('���Ų���Ϊ��');
                Form1.unit.focus();
                return false;
            }


        }


        function drjh() {


            if (document.getElementById('CompanyName').value == '') {
                alert('��Ӧ�̲���Ϊ��\n���붩�����ݽ���Ӧ�ù�Ӧ��');
                Form1.CompanyName.focus();
                return false;
            }
            else if (!confirm("�Ƿ�ȷ�����룿ϵͳ����յ�ǰ�����ϸ��"))
                return false;

            else {
                var num = Math.random();
                var number = document.getElementById('number').value;
                var CompanyNumber = document.getElementById('CompanyNumber').value;
                window.showModalDialog("open_StockOrder.aspx?tmp=" + num + "&number=" + number + "&CompanyNumber=" + CompanyNumber + "", "window", "dialogWidth:700px;DialogHeight=600px;status:no;scroll=yes;help:no");
            }





        }

        var wName;
        function fnOpen() {
            var num = Math.random();
            wName = window.showModalDialog("open_TrafficType.aspx?tmp=" + num + "", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");

            if (wName != null && wName != "undefined") {

                document.getElementById("Traffic").value = wName;
                return;
            }


        }





        var wName_ddlx;
        function jsOpen() {
            var num = Math.random();
            wName_ddlx = window.showModalDialog("open_Balance.aspx?tmp=" + num + "", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");

            if (wName_ddlx != null && wName_ddlx != "undefined") {

                document.getElementById("Balance").value = wName_ddlx;
                return;
            }


        }


        var wNamekf;
        function jhcOpen() {
            var num = Math.random();
            wNamekf = window.showModalDialog("open_Storeroom.aspx?tmp=" + num + "", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");

            if (wNamekf != null && wNamekf != "undefined") {

                document.getElementById("Storeroom").value = wNamekf;
                return;
            }


        }

        function zjOpen() {
            var num = Math.random();
            var number = document.getElementById('number').value;
            window.showModalDialog("StockOut_add_add.aspx?tmp=" + num + "&number=" + number + " ", "window", "dialogWidth:700px;DialogHeight=400px;status:no;scroll=yes;help:no");




        }
    </script>
</head>
<body ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
        <script language="javascript" src="DateSelect.js"></script>
        <table cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td width="16" background="i_blue/m_head_3.jpg">
                    <img height="34" src="i_blue/m_head_1.jpg" width="20"></td>
                <td width="748" background="i_blue/m_head_3.jpg">
                    <table height="25" cellspacing="0" cellpadding="0" width="92%" border="0">
                        <tr>
                            <td class="headfont" width="97%"><a class="line_b" href="main_1.aspx">����̨</a>&nbsp;&gt;&gt;&nbsp;<a class="line_b" href="StockOut_ysp.aspx">�������Ĳɹ��˻�</a>&nbsp;&gt;&gt; 
									�鿴�ɹ��˻�</td>
                        </tr>
                    </table>
                </td>
                <td width="23">
                    <img height="34" src="i_blue/m_head_2.jpg" width="21"></td>
            </tr>
        </table>
        <table height="450" cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td width="15">&nbsp;</td>
                <td valign="top" width="95%">
                    <table cellspacing="1" cellpadding="0" width="100%" bgcolor="#7d9db4" border="0">
                        <tr>
                            <td valign="top" bgcolor="#f3f8fe">
                                <table height="26" cellspacing="0" cellpadding="0" width="100%" border="0">
                                    <tr>
                                        <td background="i_blue/third_head_bg.jpg"><font face="����"></font></td>
                                    </tr>
                                </table>
                                <table cellspacing="1" cellpadding="4" width="100%" bgcolor="#d8e1e8" border="0">
                                    <tbody>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right" width="15%"><font face="����">���⣺</font></td>
                                            <td width="35%">
                                                <asp:textbox id="title" runat="server" width="100%"></asp:textbox>
                                            </td>
                                            <td align="right" width="15%"><font face="����">�ջ����ڣ�</font></td>
                                            <td width="35%">
                                                <asp:textbox id="ShTime" runat="server" width="100%" datatype="DateTime"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right" width="15%">�ֹ�</td>
                                            <td width="35%">
                                                <asp:textbox id="StockPeoName" runat="server" width="100%"></asp:textbox>
                                            </td>
                                            <td align="right" width="15%"><font face="����">�����֣�</font></td>
                                            <td width="35%">
                                                <asp:textbox id="Storeroom" runat="server" width="100%"></asp:textbox>
                                                <a href="javascript:void(0)"></a></td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right" width="15%"><font face="����">��Ӧ�����ƣ�</font></td>
                                            <td width="35%">
                                                <asp:textbox id="CompanyName" runat="server" width="100%"></asp:textbox>
                                            </td>
                                            <td align="right" width="15%"><font face="����">��Ӧ�̵�ַ��</font></td>
                                            <td width="35%"><font face="����">
                                                <asp:textbox id="CompanyAdd" runat="server" width="100%"></asp:textbox>
                                            </font></td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td style="HEIGHT: 33px" align="right" width="15%"><font face="����">���䵥λ��</font></td>
                                            <td style="HEIGHT: 33px" width="35%">
                                                <asp:textbox id="Traffic" runat="server" width="100%"></asp:textbox>
                                            </td>
                                            <td style="HEIGHT: 33px" align="right"><font face="����">���㷽ʽ��</font></td>
                                            <td style="HEIGHT: 33px">
                                                <asp:textbox id="Balance" runat="server" width="100%"></asp:textbox>
                                                <a href="javascript:void(0)"></a></td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td style="HEIGHT: 33px" align="right" width="15%"><font face="����">¼���ˣ�</font></td>
                                            <td style="HEIGHT: 33px" width="35%">
                                                <asp:textbox id="Realname" runat="server" width="100%"></asp:textbox>
                                            </td>
                                            <td style="HEIGHT: 33px" align="right"><font face="����">״̬��</font></td>
                                            <td style="HEIGHT: 33px">
                                                <asp:textbox id="State" runat="server" width="100%"></asp:textbox>
                                                <a href="javascript:void(0)"></a></td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right"><font face="����">ѡ���������̣�</font></td>
                                            <td colspan="3">
                                                <asp:textbox id="StreamName" runat="server" width="100%"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right"><font face="����">ժҪ��</font></td>
                                            <td colspan="3">
                                                <asp:textbox id="Remark" runat="server" width="100%" height="52px" textmode="MultiLine"></asp:textbox>
                                                <a href="javascript:void(0)"></a></FONT></td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right"><font face="����">������ע��</font></td>
                                            <td colspan="3">
                                                <asp:textbox id="Sreakmart" runat="server" width="100%" height="52px" textmode="MultiLine"></asp:textbox>
                                                <a href="javascript:void(0)"></a></FONT></td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td width="100%" colspan="4">
                                                <div class="mainDiv">
                                                    <asp:datagrid id="Datagrid2" runat="server" width="100%" allowpaging="True" borderwidth="1px"
                                                        onpageindexchanged="MyDataGrid_Page_1" pagesize="12" cellpadding="3" bordercolor="#4D77B1" autogeneratecolumns="False"
                                                        backcolor="White" gridlines="Vertical" borderstyle="None">
															<FooterStyle ForeColor="Black" BackColor="#AECADF"></FooterStyle>
															<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669AC1"></SelectedItemStyle>
															<AlternatingItemStyle BackColor="#FBFCFE"></AlternatingItemStyle>
															<ItemStyle ForeColor="Black" BackColor="#E6EDF7"></ItemStyle>
															<HeaderStyle Font-Bold="True" HorizontalAlign="Center" BackColor="#AECADF"></HeaderStyle>
															<Columns>
																<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
																<asp:BoundColumn DataField="GoodsName" SortExpression="GoodsName" HeaderText="��Ʒ����">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="CountUnit" SortExpression="CountUnit" HeaderText="������λ">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="Model" SortExpression="Model" HeaderText="����ͺ�">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="StockPoint" SortExpression="StockPoint" HeaderText="�ɹ�����">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="SingleMoney" SortExpression="SingleMoney" HeaderText="����"></asp:BoundColumn>
																<asp:BoundColumn DataField="Allmoney" SortExpression="Allmoney" HeaderText="�ɹ��ܽ��">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
															</Columns>
															<PagerStyle Visible="False" NextPageText="��һҳ" PrevPageText="��һҳ" HorizontalAlign="Right" ForeColor="White"
																BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
														</asp:datagrid>
                                                </div>
                                                <uc1:fenye id="Fenye1" runat="server"></uc1:fenye>
                                            </td>
                                        </tr>
                        </tr>
                    </table>
                    <table height="25" cellspacing="0" cellpadding="0" width="100%" border="0">
                        <tr>
                            <td background="i_blue/third_head_bg1.jpg">
                                <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                    <tr>
                                        <td width="39%">&nbsp;</td>
                                        <td width="9%"><font face="����"></font></td>
                                        <td width="52%">
                                            <asp:imagebutton id="ImageButton2" runat="server" imageurl="i_blue/back.jpg"></asp:imagebutton>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:textbox id="number" style="DISPLAY: none" runat="server"></asp:textbox>
        </TD>
			<td width="15">&nbsp;</td>
        </TR></TBODY></TABLE><asp:textbox id="CompanyNumber" style="DISPLAY: none" runat="server"></asp:textbox><asp:textbox id="StockPeoNum" style="DISPLAY: none" runat="server"></asp:textbox><asp:textbox id="StreamNumber" style="DISPLAY: none" runat="server"></asp:textbox>
    </form>
</body>
</html>
