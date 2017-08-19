<%--文件名:QueryDepartmentForm.aspx--%>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="QueryDepartmentForm.aspx.cs" Inherits="QueryManage_QueryDepartmentForm" Title="当前位置：查询管理->查询部门档案" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 556px; height: 161px">
        <tr>
            <td align="center" style="font-size: 0.8em; width: 2232px; font-family: 宋体; height: 16px;
                background-color: teal">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                    SelectCommand="SELECT * FROM [公司部门]"></asp:SqlDataSource>
                &nbsp; 请选择需要查询员工的部门:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"
                    DataSourceID="SqlDataSource1" DataTextField="部门名称" DataValueField="部门名称" Width="120px">
                </asp:DropDownList>
                <asp:Button ID="Button1" runat="server" Text="查询" Width="90px" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="打印" Width="90px" />
            </td>
        </tr>
        <tr>
            <td style="width: 2232px; height: 100px; background-color: gainsboro">
                <asp:Panel ID="Panel1" runat="server" Height="220px" ScrollBars="Auto" Width="553px">
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                        SelectCommand="SELECT [员工编号], [姓名], [性别], [出生日期], [身份证号码], [民族], [籍贯], [政治面貌], [婚姻状况], [文化程度], [职务], [毕业院校], [职称], [进入公司时间], [合同服务年限], [基本工资], [银行账号], [养老保险账号], [医疗保险账号], [住房基金账号], [联系电话], [手机号码], [电子信箱], [家庭住址], [邮政编码], [补充说明] FROM [在职员工视图] WHERE ([所属部门] = @所属部门)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList1" Name="所属部门" PropertyName="SelectedValue"
                                Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource2"
                        Font-Names="宋体" Font-Size="Small" GridLines="Vertical" Width="2400px">
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <Columns>
                            <asp:BoundField DataField="员工编号" HeaderText="员工编号" SortExpression="员工编号" />
                            <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                            <asp:BoundField DataField="性别" HeaderText="性别" SortExpression="性别" />
                            <asp:BoundField DataField="出生日期" HeaderText="出生日期" SortExpression="出生日期" />
                            <asp:BoundField DataField="身份证号码" HeaderText="身份证号码" SortExpression="身份证号码" />
                            <asp:BoundField DataField="民族" HeaderText="民族" SortExpression="民族" />
                            <asp:BoundField DataField="籍贯" HeaderText="籍贯" SortExpression="籍贯" />
                            <asp:BoundField DataField="政治面貌" HeaderText="政治面貌" SortExpression="政治面貌" />
                            <asp:BoundField DataField="婚姻状况" HeaderText="婚姻状况" SortExpression="婚姻状况" />
                            <asp:BoundField DataField="文化程度" HeaderText="文化程度" SortExpression="文化程度" />
                            <asp:BoundField DataField="职务" HeaderText="职务" SortExpression="职务" />
                            <asp:BoundField DataField="毕业院校" HeaderText="毕业院校" SortExpression="毕业院校" />
                            <asp:BoundField DataField="职称" HeaderText="职称" SortExpression="职称" />
                            <asp:BoundField DataField="进入公司时间" HeaderText="进入公司时间" SortExpression="进入公司时间" />
                            <asp:BoundField DataField="合同服务年限" HeaderText="合同服务年限" SortExpression="合同服务年限" />
                            <asp:BoundField DataField="基本工资" HeaderText="基本工资" SortExpression="基本工资" />
                            <asp:BoundField DataField="银行账号" HeaderText="银行账号" SortExpression="银行账号" />
                            <asp:BoundField DataField="养老保险账号" HeaderText="养老保险账号" SortExpression="养老保险账号" />
                            <asp:BoundField DataField="医疗保险账号" HeaderText="医疗保险账号" SortExpression="医疗保险账号" />
                            <asp:BoundField DataField="住房基金账号" HeaderText="住房基金账号" SortExpression="住房基金账号" />
                            <asp:BoundField DataField="联系电话" HeaderText="联系电话" SortExpression="联系电话" />
                            <asp:BoundField DataField="手机号码" HeaderText="手机号码" SortExpression="手机号码" />
                            <asp:BoundField DataField="电子信箱" HeaderText="电子信箱" SortExpression="电子信箱" />
                            <asp:BoundField DataField="家庭住址" HeaderText="家庭住址" SortExpression="家庭住址" />
                            <asp:BoundField DataField="邮政编码" HeaderText="邮政编码" SortExpression="邮政编码" />
                            <asp:BoundField DataField="补充说明" HeaderText="补充说明" SortExpression="补充说明" />
                        </Columns>
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

