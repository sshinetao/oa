<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>

<%@ Page Language="c#" CodeBehind="IncomeRoom_update.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.IncomeRoom_update" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>畲森山进销存</title>
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
            if (!confirm("是否确定删除？"))
                return false;
        }


        function chknull() {


            if (document.getElementById('title').value == '') {
                alert('标题不能为空');

                return false;
            }

            if (document.getElementById('Storeroom').value == '') {
                alert('进货仓不能为空');

                return false;
            }


        }





        var wName_ddlx;
        function jsOpen() {
            var num = Math.random();
            wName_ddlx = window.showModalDialog("open_InSource.aspx?tmp=" + num + "", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");

            if (wName_ddlx != null && wName_ddlx != "undefined") {

                document.getElementById("InSource").value = wName_ddlx;
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
            window.showModalDialog("IncomeRoom_add_add.aspx?tmp=" + num + "&number=" + number + " ", "window", "dialogWidth:700px;DialogHeight=400px;status:no;scroll=yes;help:no");




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
                            <td class="headfont" width="97%"><a class="line_b" href="main_1.aspx">工作台</a>&nbsp;&gt;&gt;&nbsp;<a class="line_b" href="IncomeRoom.aspx">入库</a>&nbsp;&gt;&gt;修改入库</td>
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
                                        <td background="i_blue/third_head_bg.jpg">&nbsp;
												<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="i_blue/zenghang.jpg"></asp:ImageButton><font face="宋体">&nbsp;</font>
                                            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="i_blue/xiugai.jpg"></asp:ImageButton><font face="宋体">&nbsp;</font>
                                            <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="i_blue/shanchu.jpg"></asp:ImageButton><font face="宋体"></font></td>
                                    </tr>
                                </table>
                                <table cellspacing="1" cellpadding="4" width="100%" bgcolor="#d8e1e8" border="0">
                                    <tbody>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right" width="15%"><font face="宋体">标题：</font></td>
                                            <td width="35%">
                                                <asp:TextBox ID="title" runat="server" Width="100%"></asp:TextBox></td>
                                            <td align="right" width="15%"><font face="宋体">入库时间：</font></td>
                                            <td width="35%">
                                                <asp:TextBox ID="ShTime" runat="server" Width="90%" DataType="DateTime"></asp:TextBox>
                                                <script>SetNeed('ShTime')</script>
                                                </FONT><a href="javascript:void(0)"><img id="ShTime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
                                                    src="image/FDJ.gif" border="0"></a>
                                            </td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right" width="15%">收料人：</td>
                                            <td width="35%">
                                                <asp:TextBox ID="StockPeoName" runat="server" Width="90%"></asp:TextBox><a href="javascript:void(0)"><img style="display: none" onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectUser.aspx?TableName=ERPUser&LieName=UserName&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('StockPeoName').value=wName;}" alt="" src="image/FDJ.gif" border="0"></a></td>
                                            <td align="right" width="15%"><font face="宋体">进货仓：</font></td>
                                            <td width="35%">
                                                <asp:TextBox ID="Storeroom" runat="server" Width="90%"></asp:TextBox><a href="javascript:void(0)"><img onclick="jhcOpen();" alt="" src="image/FDJ.gif" border="0"></a></td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right" width="15%" style="HEIGHT: 33px"><font face="宋体">入库来源：</font></td>
                                            <td width="35%" style="HEIGHT: 33px">
                                                <asp:TextBox ID="InSource" runat="server" Width="90%"></asp:TextBox><a href="javascript:void(0)"><img onclick="jsOpen();" alt="" src="image/FDJ.gif" border="0" style="display: none"></a></td>
                                            <td align="right" style="HEIGHT: 33px"><font face="宋体">状态：</font></td>
                                            <td style="HEIGHT: 33px">
                                                <asp:TextBox ID="State" runat="server" Width="100%"></asp:TextBox></td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right" width="15%" style="HEIGHT: 33px"><font face="宋体">选择审批流程：</font></td>
                                            <td width="35%" style="HEIGHT: 33px">
                                                <asp:TextBox ID="StreamName" runat="server" Width="90%"></asp:TextBox><a href="javascript:void(0)"><img onclick="splc()" src="image/FDJ.gif" border="0"></a></FONT>
                                            </td>
                                            <td align="right" width="15%" style="HEIGHT: 33px"><font face="宋体">入库类型</font></td>

                                            <td width="35%" style="HEIGHT: 33px">
                                                <asp:TextBox ID="rukuleixing" runat="server" Width="90%"></asp:TextBox><a href="javascript:void(0)"><img onclick="openCKLX()" src="image/FDJ.gif" border="0"></a></td>

                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right"><font face="宋体">摘要：</font></td>
                                            <td colspan="3">
                                                <asp:TextBox ID="Remark" runat="server" Width="100%" TextMode="MultiLine" Height="52px"></asp:TextBox><a href="javascript:void(0)"></a></FONT></td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td width="100%" colspan="4">
                                                <div class="mainDiv">
                                                    <asp:DataGrid ID="Datagrid2" runat="server" Width="100%" BorderStyle="None" GridLines="Vertical"
                                                        BackColor="White" AutoGenerateColumns="False" BorderColor="#4D77B1" CellPadding="3" PageSize="12" OnPageIndexChanged="MyDataGrid_Page_1"
                                                        BorderWidth="1px" AllowPaging="True">
                                                        <FooterStyle ForeColor="Black" BackColor="#AECADF"></FooterStyle>
                                                        <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669AC1"></SelectedItemStyle>
                                                        <AlternatingItemStyle BackColor="#FBFCFE"></AlternatingItemStyle>
                                                        <ItemStyle ForeColor="Black" BackColor="#E6EDF7"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" HorizontalAlign="Center" BackColor="#AECADF"></HeaderStyle>
                                                        <Columns>
                                                            <asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
                                                            <asp:BoundColumn DataField="GoodsName" SortExpression="GoodsName" HeaderText="商品名称">
                                                                <HeaderStyle Wrap="False"></HeaderStyle>
                                                                <ItemStyle Wrap="False"></ItemStyle>
                                                            </asp:BoundColumn>
                                                            <asp:BoundColumn DataField="CountUnit" SortExpression="CountUnit" HeaderText="计量单位">
                                                                <HeaderStyle Wrap="False"></HeaderStyle>
                                                                <ItemStyle Wrap="False"></ItemStyle>
                                                            </asp:BoundColumn>
                                                            <asp:BoundColumn DataField="Model" SortExpression="Model" HeaderText="规格型号">
                                                                <HeaderStyle Wrap="False"></HeaderStyle>
                                                                <ItemStyle Wrap="False"></ItemStyle>
                                                            </asp:BoundColumn>
                                                            <asp:BoundColumn DataField="StockPoint" SortExpression="StockPoint" HeaderText="入库数量">
                                                                <HeaderStyle Wrap="False"></HeaderStyle>
                                                                <ItemStyle Wrap="False"></ItemStyle>
                                                            </asp:BoundColumn>
                                                        </Columns>
                                                        <PagerStyle Visible="False" NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
                                                            BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
                                                    </asp:DataGrid>
                                                </div>
                                                <uc1:fenye ID="Fenye1" runat="server"></uc1:fenye>
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
                                        <td width="9%">
                                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:ImageButton></td>
                                        <td width="52%">
                                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="i_blue/back.jpg"></asp:ImageButton></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:TextBox ID="number" runat="server" Style="DISPLAY: none"></asp:TextBox></TD>
			<td width="15">&nbsp;</td>
        </TR></TBODY></TABLE><asp:TextBox ID="CompanyNumber" runat="server" Style="DISPLAY: none"></asp:TextBox><asp:TextBox ID="StockPeoNum" runat="server" Style="DISPLAY: none"></asp:TextBox><asp:TextBox ID="StreamNumber" runat="server" Style="DISPLAY: none"></asp:TextBox>
        <script language="javascript">
            var wName_2;
            function khOpen() {
                var num = Math.random();
                wName_2 = window.showModalDialog("open_Company.aspx?tmp=" + num + "&key=0 ", "window", "dialogWidth:800px;DialogHeight=500px;status:no;scroll=yes;help:no");

                var arr = wName_2.split("|");
                for (var i = 0; i < arr.length; i++) {

                    document.getElementById("CompanyNumber").value = arr[0];
                    document.getElementById("CompanyName").value = arr[1];


                }


            }
        </script>
        <script language="javascript">
            var wName_3;
            function usOpen() {
                var num = Math.random();
                wName_3 = window.showModalDialog("open_manage.aspx?tmp=" + num + " ", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");



                var arr = wName_3.split("|");
                for (var i = 0; i < arr.length; i++) {

                    document.getElementById("StockPeoName").value = arr[0];
                    document.getElementById("StockPeoNum").value = arr[2];

                }


            }
        </script>
        <script language="javascript">


            var wName_5;
            function splc() {
                var num = Math.random();
                wName_5 = window.showModalDialog("open_Rk_stream.aspx?tmp=" + num + "", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");



                var arr = wName_5.split("|");
                for (var i = 0; i < arr.length; i++) {

                    document.getElementById("StreamName").value = arr[0];
                    document.getElementById("StreamNumber").value = arr[1];
                }


            }



            var chukulx;
            function openCKLX() {
                var num = Math.random();
                chukulx = window.showModalDialog("open_rukuleixing.aspx?tmp=" + num + "", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");
                if (chukulx != null && chukulx != "undefined") {
                    document.getElementById("rukuleixing").value = chukulx;
                    return;
                }
            }

        </script>
    </form>
</body>
</html>
