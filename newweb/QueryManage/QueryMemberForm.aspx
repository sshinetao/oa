<%--文件名:QueryMemberForm.aspx--%>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="QueryMemberForm.aspx.cs" Inherits="QueryManage_QueryMemberForm" Title="当前位置：查询管理->查询个人档案" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 556px; height: 161px">
        <tr>
            <td align="center" style="font-size: 0.8em; width: 2232px; font-family: 宋体; height: 16px;
                background-color: teal">
                &nbsp;所在部门:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"
                    DataSourceID="SqlDataSource1" DataTextField="部门名称" DataValueField="部门名称" Width="80px">
                </asp:DropDownList>
                员工姓名:<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2"
                    DataTextField="姓名" DataValueField="员工编号" Width="80px">
                </asp:DropDownList>
                <asp:Button ID="Button1" runat="server" Text="查询" Width="80px" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="打印" Width="80px" />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                    SelectCommand="SELECT * FROM [公司部门]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                    SelectCommand="SELECT * FROM [基本档案] WHERE ([所属部门] = @所属部门)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="所属部门" PropertyName="SelectedValue"
                            Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td align="center" style="font-size: 0.8em; width: 2232px; font-family: 宋体; height: 60px;
                background-color: mediumturquoise">
                员工基本档案<asp:Panel ID="Panel1" runat="server" BackColor="Olive" Height="60px" ScrollBars="Auto"
                    Width="555px">
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                        SelectCommand="SELECT * FROM [基本档案] WHERE ([员工编号] = @员工编号)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList2" Name="员工编号" PropertyName="SelectedValue"
                                Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="自编号,员工编号"
                        DataSourceID="SqlDataSource3" GridLines="Vertical" Width="3000px">
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <Columns>
                            <asp:BoundField DataField="自编号" HeaderText="自编号" InsertVisible="False" ReadOnly="True"
                                SortExpression="自编号" Visible="False" />
                            <asp:BoundField DataField="员工编号" HeaderText="员工编号" ReadOnly="True" SortExpression="员工编号" />
                            <asp:BoundField DataField="所属部门" HeaderText="所属部门" SortExpression="所属部门" />
                            <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                            <asp:BoundField DataField="性别" HeaderText="性别" SortExpression="性别" />
                            <asp:BoundField DataField="民族" HeaderText="民族" SortExpression="民族" />
                            <asp:BoundField DataField="籍贯" HeaderText="籍贯" SortExpression="籍贯" />
                            <asp:BoundField DataField="出生日期" HeaderText="出生日期" SortExpression="出生日期" />
                            <asp:BoundField DataField="身份证号码" HeaderText="身份证号码" SortExpression="身份证号码" />
                            <asp:BoundField DataField="政治面貌" HeaderText="政治面貌" SortExpression="政治面貌" />
                            <asp:BoundField DataField="婚姻状况" HeaderText="婚姻状况" SortExpression="婚姻状况" />
                            <asp:BoundField DataField="文化程度" HeaderText="文化程度" SortExpression="文化程度" />
                            <asp:BoundField DataField="职称" HeaderText="职称" SortExpression="职称" />
                            <asp:BoundField DataField="职务" HeaderText="职务" SortExpression="职务" />
                            <asp:BoundField DataField="专业" HeaderText="专业" SortExpression="专业" />
                            <asp:BoundField DataField="毕业院校" HeaderText="毕业院校" SortExpression="毕业院校" />
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
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="center" style="font-size: 0.8em; width: 2232px; font-family: 宋体; height: 120px;
                background-color: mediumturquoise">
                员工家庭成员<asp:Panel ID="Panel2" runat="server" BackColor="Olive" Height="110px" ScrollBars="Auto"
                    Width="555px">
                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                        SelectCommand="SELECT * FROM [家庭成员] WHERE ([员工编号] = @员工编号)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList2" Name="员工编号" PropertyName="SelectedValue"
                                Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="自编号"
                        DataSourceID="SqlDataSource4" GridLines="Vertical" Width="800px">
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <Columns>
                            <asp:BoundField DataField="自编号" HeaderText="自编号" InsertVisible="False" ReadOnly="True"
                                SortExpression="自编号" Visible="False" />
                            <asp:BoundField DataField="员工编号" HeaderText="员工编号" SortExpression="员工编号" Visible="False" />
                            <asp:BoundField DataField="员工姓名" HeaderText="员工姓名" SortExpression="员工姓名" Visible="False" />
                            <asp:BoundField DataField="家庭成员姓名" HeaderText="家庭成员姓名" SortExpression="家庭成员姓名" />
                            <asp:BoundField DataField="与员工关系" HeaderText="与员工关系" SortExpression="与员工关系" />
                            <asp:BoundField DataField="工作单位" HeaderText="工作单位" SortExpression="工作单位" />
                            <asp:BoundField DataField="担任职务" HeaderText="担任职务" SortExpression="担任职务" />
                            <asp:BoundField DataField="政治面貌" HeaderText="政治面貌" SortExpression="政治面貌" />
                            <asp:BoundField DataField="联系电话" HeaderText="联系电话" SortExpression="联系电话" />
                            <asp:BoundField DataField="补充说明" HeaderText="补充说明" SortExpression="补充说明" />
                        </Columns>
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="center" style="font-size: 0.8em; width: 2232px; font-family: 宋体; height: 120px;
                background-color: mediumturquoise">
                员工工作简历<asp:Panel ID="Panel3" runat="server" BackColor="Olive" Height="110px" ScrollBars="Auto"
                    Width="555px">
                    <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                        SelectCommand="SELECT * FROM [工作简历] WHERE ([员工编号] = @员工编号)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList2" Name="员工编号" PropertyName="SelectedValue"
                                Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="自编号"
                        DataSourceID="SqlDataSource5" GridLines="Vertical" Width="800px">
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <Columns>
                            <asp:BoundField DataField="自编号" HeaderText="自编号" InsertVisible="False" ReadOnly="True"
                                SortExpression="自编号" Visible="False" />
                            <asp:BoundField DataField="员工编号" HeaderText="员工编号" SortExpression="员工编号" Visible="False" />
                            <asp:BoundField DataField="员工姓名" HeaderText="员工姓名" SortExpression="员工姓名" Visible="False" />
                            <asp:BoundField DataField="开始日期" HeaderText="开始日期" SortExpression="开始日期" />
                            <asp:BoundField DataField="结束日期" HeaderText="结束日期" SortExpression="结束日期" />
                            <asp:BoundField DataField="单位名称" HeaderText="单位名称" SortExpression="单位名称" />
                            <asp:BoundField DataField="所在部门" HeaderText="所在部门" SortExpression="所在部门" />
                            <asp:BoundField DataField="担任职务" HeaderText="担任职务" SortExpression="担任职务" />
                            <asp:BoundField DataField="补充说明" HeaderText="补充说明" SortExpression="补充说明" />
                        </Columns>
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="Gainsboro" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="center" style="font-size: 0.8em; width: 2232px; font-family: 宋体; height: 120px;
                background-color: mediumturquoise">
                员工培训记录<asp:Panel ID="Panel4" runat="server" BackColor="Olive" Height="110px" ScrollBars="Auto"
                    Width="555px">
                    <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                        SelectCommand="SELECT * FROM [培训记录] WHERE ([员工编号] = @员工编号)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList2" Name="员工编号" PropertyName="SelectedValue"
                                Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="自编号"
                        DataSourceID="SqlDataSource6" GridLines="Vertical" Width="1200px">
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <Columns>
                            <asp:BoundField DataField="自编号" HeaderText="自编号" InsertVisible="False" ReadOnly="True"
                                SortExpression="自编号" Visible="False" />
                            <asp:BoundField DataField="员工编号" HeaderText="员工编号" SortExpression="员工编号" Visible="False" />
                            <asp:BoundField DataField="员工姓名" HeaderText="员工姓名" SortExpression="员工姓名" Visible="False" />
                            <asp:BoundField DataField="开始日期" HeaderText="开始日期" SortExpression="开始日期" />
                            <asp:BoundField DataField="结束日期" HeaderText="结束日期" SortExpression="结束日期" />
                            <asp:BoundField DataField="培训单位" HeaderText="培训单位" SortExpression="培训单位" />
                            <asp:BoundField DataField="培训地点" HeaderText="培训地点" SortExpression="培训地点" />
                            <asp:BoundField DataField="培训内容" HeaderText="培训内容" SortExpression="培训内容" />
                            <asp:BoundField DataField="培训经费" HeaderText="培训经费" SortExpression="培训经费" />
                            <asp:BoundField DataField="证书名称" HeaderText="证书名称" SortExpression="证书名称" />
                            <asp:BoundField DataField="补充说明" HeaderText="补充说明" SortExpression="补充说明" />
                        </Columns>
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="center" style="font-size: 0.8em; width: 2232px; font-family: 宋体; height: 120px;
                background-color: mediumturquoise">
                员工奖惩记录<asp:Panel ID="Panel5" runat="server" BackColor="Olive" Height="110px" ScrollBars="Auto"
                    Width="555px">
                    <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                        SelectCommand="SELECT * FROM [奖惩记录] WHERE ([员工编号] = @员工编号)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList2" Name="员工编号" PropertyName="SelectedValue"
                                Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="自编号"
                        DataSourceID="SqlDataSource7" GridLines="Vertical" Width="800px">
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <Columns>
                            <asp:BoundField DataField="自编号" HeaderText="自编号" InsertVisible="False" ReadOnly="True"
                                SortExpression="自编号" Visible="False" />
                            <asp:BoundField DataField="员工编号" HeaderText="员工编号" SortExpression="员工编号" Visible="False" />
                            <asp:BoundField DataField="员工姓名" HeaderText="员工姓名" SortExpression="员工姓名" Visible="False" />
                            <asp:BoundField DataField="奖惩日期" HeaderText="奖惩日期" SortExpression="奖惩日期" />
                            <asp:BoundField DataField="奖惩类型" HeaderText="奖惩类型" SortExpression="奖惩类型" />
                            <asp:BoundField DataField="奖惩原因" HeaderText="奖惩原因" SortExpression="奖惩原因" />
                            <asp:BoundField DataField="奖惩批准单位" HeaderText="奖惩批准单位" SortExpression="奖惩批准单位" />
                            <asp:BoundField DataField="解除处分日期" HeaderText="解除处分日期" SortExpression="解除处分日期" />
                            <asp:BoundField DataField="补充说明" HeaderText="补充说明" SortExpression="补充说明" />
                        </Columns>
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="center" style="font-size: 0.8em; width: 2232px; font-family: 宋体; height: 120px;
                background-color: mediumturquoise">
                员工工作业绩<asp:Panel ID="Panel6" runat="server" BackColor="Olive" Height="110px" ScrollBars="Auto"
                    Width="555px">
                    <asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                        SelectCommand="SELECT * FROM [工作业绩] WHERE ([员工编号] = @员工编号)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList2" Name="员工编号" PropertyName="SelectedValue"
                                Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="自编号"
                        DataSourceID="SqlDataSource8" GridLines="Vertical" Width="600px">
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <Columns>
                            <asp:BoundField DataField="自编号" HeaderText="自编号" InsertVisible="False" ReadOnly="True"
                                SortExpression="自编号" Visible="False" />
                            <asp:BoundField DataField="员工编号" HeaderText="员工编号" SortExpression="员工编号" Visible="False" />
                            <asp:BoundField DataField="员工姓名" HeaderText="员工姓名" SortExpression="员工姓名" Visible="False" />
                            <asp:BoundField DataField="专长描述" HeaderText="专长描述" SortExpression="专长描述" />
                            <asp:BoundField DataField="工作业绩" HeaderText="工作业绩" SortExpression="工作业绩" />
                            <asp:BoundField DataField="补充说明" HeaderText="补充说明" SortExpression="补充说明" />
                        </Columns>
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

