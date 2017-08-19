<%--文件名:DepartmentForm.aspx--%>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DepartmentForm.aspx.cs" Inherits="SystemManage_DepartmentForm" Title="当前位置：系统管理->公司部门设置" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 556px; height: 161px">
        <tr>
            <td align="left" style="font-size: 0.8em; width: 1232px; font-family: 宋体; height: 16px;
                background-color: gainsboro">
                部门名称:<asp:TextBox ID="TextBox1" runat="server" Width="38px"></asp:TextBox>
                部门负责人:<asp:TextBox ID="TextBox2" runat="server" Width="42px"></asp:TextBox>
                人事文员:<asp:TextBox ID="TextBox3" runat="server" Width="44px">0</asp:TextBox>
                联系电话:<asp:TextBox ID="TextBox4" runat="server" Width="45px">1</asp:TextBox>
                额定人数:<asp:TextBox ID="TextBox5" runat="server" Width="14px">1</asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" style="font-size: 0.8em; width: 1232px; font-family: 宋体; height: 27px;
                background-color: gainsboro">
                补充说明:<asp:TextBox ID="TextBox6" runat="server" Width="351px">暂无</asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="新增" Width="59px" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="修改" Width="59px" /></td>
        </tr>
        <tr>
            <td style="width: 1232px; height: 100px; background-color: gainsboro">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None"
                    BorderWidth="1px" CellPadding="3" DataKeyNames="部门名称" DataSourceID="SqlDataSource1"
                    Font-Names="宋体" Font-Size="Small" GridLines="Vertical" OnRowCreated="GridView1_RowCreated"
                    OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="550px">
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <Columns>
                        <asp:CommandField ButtonType="Button" HeaderText="选择" ShowSelectButton="True" />
                        <asp:TemplateField HeaderText="删除" ShowHeader="False">
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandName="Delete"
                                    Text="删除" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="部门名称" HeaderText="部门名称" ReadOnly="True" SortExpression="部门名称" />
                        <asp:BoundField DataField="部门负责人" HeaderText="部门负责人" SortExpression="部门负责人" />
                        <asp:BoundField DataField="人事文员" HeaderText="人事文员" SortExpression="人事文员" />
                        <asp:BoundField DataField="联系电话" HeaderText="联系电话" SortExpression="联系电话" />
                        <asp:BoundField DataField="额定人数" HeaderText="额定人数" SortExpression="额定人数" />
                        <asp:BoundField DataField="补充说明" HeaderText="补充说明" SortExpression="补充说明" />
                    </Columns>
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                    DeleteCommand="DELETE FROM [公司部门] WHERE [部门名称] = @部门名称" InsertCommand="INSERT INTO [公司部门] ([部门名称], [部门负责人], [人事文员], [联系电话], [额定人数], [补充说明]) VALUES (@部门名称, @部门负责人, @人事文员, @联系电话, @额定人数, @补充说明)"
                    SelectCommand="SELECT [部门名称], [部门负责人], [人事文员], [联系电话], [额定人数], [补充说明] FROM [公司部门]"
                    UpdateCommand="UPDATE [公司部门] SET [部门负责人] = @部门负责人, [人事文员] = @人事文员, [联系电话] = @联系电话, [额定人数] = @额定人数, [补充说明] = @补充说明 WHERE [部门名称] = @部门名称">
                    <DeleteParameters>
                        <asp:Parameter Name="部门名称" Type="String" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:ControlParameter ControlID="TextBox2" Name="部门负责人" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox3" Name="人事文员" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox4" Name="联系电话" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox5" Name="额定人数" PropertyName="Text" Type="Int32" />
                        <asp:ControlParameter ControlID="TextBox6" Name="补充说明" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" Name="部门名称" PropertyName="Text" Type="String" />
                    </UpdateParameters>
                    <InsertParameters>
                        <asp:ControlParameter ControlID="TextBox1" Name="部门名称" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox2" Name="部门负责人" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox3" Name="人事文员" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox4" Name="联系电话" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox5" Name="额定人数" PropertyName="Text" Type="Int32" />
                        <asp:ControlParameter ControlID="TextBox6" Name="补充说明" PropertyName="Text" Type="String" />
                    </InsertParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

