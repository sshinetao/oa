<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HuiYuanAdd.aspx.cs" Inherits="OA.aspx.HY.HuiYuanAdd" %>

<html>
<head>
    <title>
        <%=System.Configuration.ConfigurationManager.AppSettings["SYSTitle"]%></title>
<link href="../../css/main.css" type="text/css" rel="stylesheet" />
    <link href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
    <script src="../../UEditor/editor_config.js" type="text/javascript"></script>
    <script src="../../UEditor/editor_all.js" type="text/javascript"></script>
    <link rel="stylesheet" type="text/css" href="../../UEditor/themes/default/ueditor.css" />
    <script src="../../Controls/My97DatePicker/WdatePicker.js"></script>


    <script language="javascript">
        function PrintTable() {
            document.getElementById("PrintHide").style.visibility = "hidden"
            print();
            document.getElementById("PrintHide").style.visibility = "visible"
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="PrintHide" style="width: 100%" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td valign="middle" style=" height: 30px;">
                    &nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                    <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;会员管理&nbsp;>>&nbsp;添加信息
                </td>
                <td align="right" valign="middle" style=" height: 30px;">
                    
<asp:Button ID="iButton1" runat="server" CssClass="btn btn-blue" Text="提交" OnClick="iButton1_Click" />
                    
                    &nbsp;<button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button>
                </td>
            </tr>
            <tr>
                <td height="3px" colspan="2" style="background-color: #ffffff">
                </td>
            </tr>
        </table>
        <table style="width: 100%" bgcolor="#999999" class="gridview_m" border="0" cellpadding="2" cellspacing="1">
            <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    客户名称：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:TextBox ID="txtNameStr" runat="server" Width="350px"></asp:TextBox>                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNameStr"
                        ErrorMessage="*该项不可以为空"></asp:RequiredFieldValidator>
                </td>
            </tr>
               <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    联系电话 ：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:TextBox ID="txtTel" runat="server" Width="350px"></asp:TextBox>
                   
                </td>
            </tr>

               <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    地址 ：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:TextBox ID="txtAddress" runat="server" Width="350px"></asp:TextBox>
                  
                </td>
            </tr>

               <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    选择套餐 ：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:DropDownList ID="ddlTaoCan" runat="server"  Width="350px" OnSelectedIndexChanged="ddlTaoCan_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>                    
                  
                </td>
            </tr>

            
               <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    总发货次数 ：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:TextBox ID="txtSendCount" runat="server" Width="350px"></asp:TextBox>
                  
                </td>
            </tr>
               <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    已发货次数 ：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:TextBox ID="txtRealCount" Text="0" runat="server" Width="350px"></asp:TextBox>
                  
                </td>
            </tr>
            
               <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    配送方式 ：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                     <asp:DropDownList ID="ddlSendType" runat="server"  Width="350px">
                         <asp:ListItem Text="畲乡物流" Selected="True"></asp:ListItem>
                         <asp:ListItem Text="畲乡物流(仅限公司地址)"></asp:ListItem>
                         <asp:ListItem Text="中通快递（生鲜不发中通，请选顺丰）"></asp:ListItem>
                         <asp:ListItem Text="申通快递"></asp:ListItem>
                         <asp:ListItem Text="天天快递"></asp:ListItem>
                         <asp:ListItem Text="顺丰速运"></asp:ListItem>
                         <asp:ListItem Text="景宁本地自提"></asp:ListItem>
                     </asp:DropDownList>                    
                  
                  
                </td>
            </tr>


            <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    首次配送时间：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:TextBox id="txtBeginTime" runat="server"  onClick="WdatePicker({startDate:'%y-%M-01',dateFmt:'yyyy-MM-dd',alwaysUseStartDate:true})" Width="350px" ></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    发货时间：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">

                    <asp:CheckBoxList ID="ckSendRole" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Text="周日" Value="0">
                        </asp:ListItem> <asp:ListItem Text="周一" Value="1">
                        </asp:ListItem> <asp:ListItem Text="周二" Value="2">
                        </asp:ListItem> <asp:ListItem Text="周三" Value="3">
                        </asp:ListItem> <asp:ListItem Text="周四" Value="4">
                        </asp:ListItem> <asp:ListItem Text="周五" Value="5">
                        </asp:ListItem> <asp:ListItem Text="周六" Value="6">
                        </asp:ListItem> 

                    </asp:CheckBoxList>


                </td>
            </tr>

            <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    结束时间：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:TextBox id="txtEndTime" runat="server" onClick="WdatePicker({startDate:'%y-%M-01',dateFmt:'yyyy-MM-dd',alwaysUseStartDate:true})" Width="350px" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    状态：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    
                     <asp:DropDownList ID="ddlStaus" runat="server"  Width="350px">
                       <asp:ListItem Text="正在进行" Value="0" Selected="True"></asp:ListItem>
                         <asp:ListItem Text="已经完成" Value="1"></asp:ListItem>
                         <asp:ListItem Text="冻结中" Value="-1"></asp:ListItem>
                         </asp:DropDownList>
                </td>
            </tr>

            
            
            
            <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    订单编号 ：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:TextBox ID="txtOrderNum" runat="server" Width="350px"></asp:TextBox>                   
                </td>
            </tr>
            
        </table>
    </div>
    </form>
</body>
</html>
