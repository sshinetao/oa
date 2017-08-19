<%--文件名:OperatorForm.aspx--%>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OperatorForm.aspx.cs" Inherits="System_OperatorForm" Title="当前位置：系统管理->分配用户权限" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 558px; height: 1px">
        <tr>
            <td align="left" style="font-size: 0.8em; width: 584px; font-family: 宋体; height: 21px;
                background-color: teal">
                用户名称：<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1"
                    DataTextField="UserName" DataValueField="UserName" Width="80px">
                </asp:DropDownList>
                用户姓名：<asp:TextBox ID="TextBox1" runat="server" Width="39px"></asp:TextBox>
                所在部门：<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource3"
                    DataTextField="部门名称" DataValueField="部门名称" Width="70px">
                </asp:DropDownList>&nbsp;
                联系电话：<asp:TextBox ID="TextBox3" runat="server" Width="64px"></asp:TextBox>
                职责说明：<asp:TextBox ID="TextBox4" runat="server" Width="329px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="新增" Width="70px" />&nbsp;<asp:Button
                    ID="Button2" runat="server" OnClick="Button2_Click" Text="修改" Width="70px" /></td>
        </tr>
        <tr>
            <td align="left" style="font-size: 0.8em; width: 584px; font-family: 宋体; height: 15px;
                background-color: darkturquoise">
                &nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="人事管理之员工基本档案" Width="164px" />
                &nbsp;
                <asp:CheckBox ID="CheckBox2" runat="server" Text="人事管理之员工家庭成员" Width="164px" />
                &nbsp;
                <asp:CheckBox ID="CheckBox3" runat="server" Text="人事管理之员工工作简历" Width="164px" />&nbsp;<asp:CheckBox
                    ID="CheckBox4" runat="server" Text="人事管理之员工奖惩记录" Width="164px" />
                &nbsp;
                <asp:CheckBox ID="CheckBox5" runat="server" Text="人事管理之员工培训记录" Width="164px" />
                &nbsp;
                <asp:CheckBox ID="CheckBox6" runat="server" Text="人事管理之员工工作业绩" Width="164px" />&nbsp;<asp:CheckBox
                    ID="CheckBox7" runat="server" Text="人事管理之员工离职管理" Width="164px" />
                &nbsp;
                <asp:CheckBox ID="CheckBox8" runat="server" Text="考勤管理之月度部门考勤" Width="164px" />&nbsp;
                &nbsp;<asp:CheckBox ID="CheckBox9" runat="server" Text="考勤管理之年度个人考勤" Width="164px" />&nbsp;<asp:CheckBox
                    ID="CheckBox10" runat="server" Text="工资管理之月度工资核算" Width="164px" />
                &nbsp;
                <asp:CheckBox ID="CheckBox11" runat="server" Text="工资管理之月度工资发放" Width="164px" />&nbsp;
                &nbsp;<asp:CheckBox ID="CheckBox12" runat="server" Text="查询管理之查询个人档案" Width="164px" />&nbsp;<asp:CheckBox
                    ID="CheckBox13" runat="server" Text="查询管理之查询部门档案" Width="164px" />
                &nbsp;
                <asp:CheckBox ID="CheckBox14" runat="server" Text="查询管理之查询考勤信息" Width="164px" />
                &nbsp;
                <asp:CheckBox ID="CheckBox15" runat="server" Text="查询管理之查询工资信息" Width="164px" />&nbsp;<asp:CheckBox
                    ID="CheckBox16" runat="server" Text="系统管理之分配用户权限" Width="164px" />
                &nbsp;
                <asp:CheckBox ID="CheckBox17" runat="server" Text="系统管理之公司信息设置" Width="164px" />
                &nbsp;
                <asp:CheckBox ID="CheckBox18" runat="server" Text="系统管理之公司部门设置" Width="164px" />&nbsp;&nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp;
            </td>
        </tr>
        <tr>
            <td style="overflow: auto; width: 580px; height: 103px; background-color: gainsboro">
                <asp:Panel ID="Panel1" runat="server" Height="150px" ScrollBars="Auto" Width="555px">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyASPNETDBConnectionString %>"
                        SelectCommand="SELECT DISTINCT * FROM [vw_aspnet_Users]">
                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                        SelectCommand="SELECT * FROM [操作用户]" DeleteCommand="DELETE FROM [操作用户] WHERE [用户名称] = @用户名称" InsertCommand="INSERT INTO [操作用户] ([用户名称], [用户姓名], [所在部门], [联系电话], [职责说明], [人事管理之员工基本档案], [人事管理之员工家庭成员], [人事管理之员工工作简历], [人事管理之员工奖惩记录], [人事管理之员工培训记录], [人事管理之员工工作业绩], [人事管理之员工离职管理], [考勤管理之月度部门考勤], [考勤管理之年度个人考勤], [工资管理之月度工资核算], [工资管理之月度工资发放], [查询管理之查询个人档案], [查询管理之查询部门档案], [查询管理之查询考勤信息], [查询管理之查询工资信息], [系统管理之分配用户权限], [系统管理之公司信息设置], [系统管理之公司部门设置]) VALUES (@用户名称, @用户姓名, @所在部门, @联系电话, @职责说明, @人事管理之员工基本档案, @人事管理之员工家庭成员, @人事管理之员工工作简历, @人事管理之员工奖惩记录, @人事管理之员工培训记录, @人事管理之员工工作业绩, @人事管理之员工离职管理, @考勤管理之月度部门考勤, @考勤管理之年度个人考勤, @工资管理之月度工资核算, @工资管理之月度工资发放, @查询管理之查询个人档案, @查询管理之查询部门档案, @查询管理之查询考勤信息, @查询管理之查询工资信息, @系统管理之分配用户权限, @系统管理之公司信息设置, @系统管理之公司部门设置)" UpdateCommand="UPDATE [操作用户] SET [用户姓名] = @用户姓名, [所在部门] = @所在部门, [联系电话] = @联系电话, [职责说明] = @职责说明, [人事管理之员工基本档案] = @人事管理之员工基本档案, [人事管理之员工家庭成员] = @人事管理之员工家庭成员, [人事管理之员工工作简历] = @人事管理之员工工作简历, [人事管理之员工奖惩记录] = @人事管理之员工奖惩记录, [人事管理之员工培训记录] = @人事管理之员工培训记录, [人事管理之员工工作业绩] = @人事管理之员工工作业绩, [人事管理之员工离职管理] = @人事管理之员工离职管理, [考勤管理之月度部门考勤] = @考勤管理之月度部门考勤, [考勤管理之年度个人考勤] = @考勤管理之年度个人考勤, [工资管理之月度工资核算] = @工资管理之月度工资核算, [工资管理之月度工资发放] = @工资管理之月度工资发放, [查询管理之查询个人档案] = @查询管理之查询个人档案, [查询管理之查询部门档案] = @查询管理之查询部门档案, [查询管理之查询考勤信息] = @查询管理之查询考勤信息, [查询管理之查询工资信息] = @查询管理之查询工资信息, [系统管理之分配用户权限] = @系统管理之分配用户权限, [系统管理之公司信息设置] = @系统管理之公司信息设置, [系统管理之公司部门设置] = @系统管理之公司部门设置 WHERE [用户名称] = @用户名称">
                        <DeleteParameters>
                            <asp:Parameter Name="用户名称" Type="String" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:ControlParameter ControlID="TextBox1" Name="用户姓名" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="DropDownList2" Name="所在部门" PropertyName="SelectedValue"
                                Type="String" />
                            <asp:ControlParameter ControlID="TextBox3" Name="联系电话" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox4" Name="职责说明" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="CheckBox1" Name="人事管理之员工基本档案" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox2" Name="人事管理之员工家庭成员" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox3" Name="人事管理之员工工作简历" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox4" Name="人事管理之员工奖惩记录" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox5" Name="人事管理之员工培训记录" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox6" Name="人事管理之员工工作业绩" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox7" Name="人事管理之员工离职管理" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox8" Name="考勤管理之月度部门考勤" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox9" Name="考勤管理之年度个人考勤" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox10" Name="工资管理之月度工资核算" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox11" Name="工资管理之月度工资发放" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox12" Name="查询管理之查询个人档案" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox13" Name="查询管理之查询部门档案" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox14" Name="查询管理之查询考勤信息" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox15" Name="查询管理之查询工资信息" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox16" Name="系统管理之分配用户权限" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox17" Name="系统管理之公司信息设置" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox18" Name="系统管理之公司部门设置" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="DropDownList1" Name="用户名称" PropertyName="SelectedValue"
                                Type="String" />
                        </UpdateParameters>
                        <InsertParameters>
                            <asp:ControlParameter ControlID="DropDownList1" Name="用户名称" PropertyName="SelectedValue"
                                Type="String" />
                            <asp:ControlParameter ControlID="TextBox1" Name="用户姓名" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="DropDownList2" Name="所在部门" PropertyName="SelectedValue"
                                Type="String" />
                            <asp:ControlParameter ControlID="TextBox3" Name="联系电话" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox4" Name="职责说明" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="CheckBox1" Name="人事管理之员工基本档案" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox2" Name="人事管理之员工家庭成员" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox3" Name="人事管理之员工工作简历" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox4" Name="人事管理之员工奖惩记录" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox5" Name="人事管理之员工培训记录" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox6" Name="人事管理之员工工作业绩" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox7" Name="人事管理之员工离职管理" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox8" Name="考勤管理之月度部门考勤" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox9" Name="考勤管理之年度个人考勤" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox10" Name="工资管理之月度工资核算" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox11" Name="工资管理之月度工资发放" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox12" Name="查询管理之查询个人档案" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox13" Name="查询管理之查询部门档案" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox14" Name="查询管理之查询考勤信息" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox15" Name="查询管理之查询工资信息" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox16" Name="系统管理之分配用户权限" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox17" Name="系统管理之公司信息设置" PropertyName="Checked"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="CheckBox18" Name="系统管理之公司部门设置" PropertyName="Checked"
                                Type="Int32" />
                        </InsertParameters>
                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                        SelectCommand="SELECT * FROM [公司部门]"></asp:SqlDataSource>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="用户名称"
                        DataSourceID="SqlDataSource2" Font-Names="宋体" Font-Size="Small" GridLines="Vertical"
                        Width="3500px" OnRowCreated="GridView1_RowCreated" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <Columns>
                            <asp:CommandField ButtonType="Button" HeaderText="选择" ShowSelectButton="True" />
                            <asp:TemplateField HeaderText="删除" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandName="Delete"
                                        Text="删除" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="用户名称" HeaderText="用户名称" ReadOnly="True" SortExpression="用户名称" />
                            <asp:BoundField DataField="用户姓名" HeaderText="用户姓名" SortExpression="用户姓名" />
                            <asp:BoundField DataField="所在部门" HeaderText="所在部门" SortExpression="所在部门" />
                            <asp:BoundField DataField="联系电话" HeaderText="联系电话" SortExpression="联系电话" />
                            <asp:BoundField DataField="职责说明" HeaderText="职责说明" SortExpression="职责说明" />
                            <asp:BoundField DataField="人事管理之员工基本档案" HeaderText="人事管理之员工基本档案" SortExpression="人事管理之员工基本档案" />
                            <asp:BoundField DataField="人事管理之员工家庭成员" HeaderText="人事管理之员工家庭成员" SortExpression="人事管理之员工家庭成员" />
                            <asp:BoundField DataField="人事管理之员工工作简历" HeaderText="人事管理之员工工作简历" SortExpression="人事管理之员工工作简历" />
                            <asp:BoundField DataField="人事管理之员工奖惩记录" HeaderText="人事管理之员工奖惩记录" SortExpression="人事管理之员工奖惩记录" />
                            <asp:BoundField DataField="人事管理之员工培训记录" HeaderText="人事管理之员工培训记录" SortExpression="人事管理之员工培训记录" />
                            <asp:BoundField DataField="人事管理之员工工作业绩" HeaderText="人事管理之员工工作业绩" SortExpression="人事管理之员工工作业绩" />
                            <asp:BoundField DataField="人事管理之员工离职管理" HeaderText="人事管理之员工离职管理" SortExpression="人事管理之员工离职管理" />
                            <asp:BoundField DataField="考勤管理之月度部门考勤" HeaderText="考勤管理之月度部门考勤" SortExpression="考勤管理之月度部门考勤" />
                            <asp:BoundField DataField="考勤管理之年度个人考勤" HeaderText="考勤管理之年度个人考勤" SortExpression="考勤管理之年度个人考勤" />
                            <asp:BoundField DataField="工资管理之月度工资核算" HeaderText="工资管理之月度工资核算" SortExpression="工资管理之月度工资核算" />
                            <asp:BoundField DataField="工资管理之月度工资发放" HeaderText="工资管理之月度工资发放" SortExpression="工资管理之月度工资发放" />
                            <asp:BoundField DataField="查询管理之查询个人档案" HeaderText="查询管理之查询个人档案" SortExpression="查询管理之查询个人档案" />
                            <asp:BoundField DataField="查询管理之查询部门档案" HeaderText="查询管理之查询部门档案" SortExpression="查询管理之查询部门档案" />
                            <asp:BoundField DataField="查询管理之查询考勤信息" HeaderText="查询管理之查询考勤信息" SortExpression="查询管理之查询考勤信息" />
                            <asp:BoundField DataField="查询管理之查询工资信息" HeaderText="查询管理之查询工资信息" SortExpression="查询管理之查询工资信息" />
                            <asp:BoundField DataField="系统管理之分配用户权限" HeaderText="系统管理之分配用户权限" SortExpression="系统管理之分配用户权限" />
                            <asp:BoundField DataField="系统管理之公司信息设置" HeaderText="系统管理之公司信息设置" SortExpression="系统管理之公司信息设置" />
                            <asp:BoundField DataField="系统管理之公司部门设置" HeaderText="系统管理之公司部门设置" SortExpression="系统管理之公司部门设置" />
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

