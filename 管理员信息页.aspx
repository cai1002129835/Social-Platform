<%@ Page Language="C#" AutoEventWireup="true" CodeFile="管理员信息页.aspx.cs" Inherits="管理员信息页" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color:#a3cff1">
    <form id="form1" runat="server"> 
        <div align="center" style="background-color:white">
            <iframe id="I1" height="60px" name="I1" scrolling="no" src="pattern2.aspx" style="border-style: none;" width="80%"></iframe>
        </div>
     <div align="center">
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="317px" CellPadding="4" ForeColor="#333333" GridLines="None">
             <AlternatingRowStyle BackColor="White" />
             <Columns>
                 <asp:BoundField DataField="管理员姓名" HeaderText="管理员姓名" SortExpression="管理员姓名" />
                 <asp:BoundField DataField="注册时间" HeaderText="注册时间" SortExpression="注册时间" />
                 <asp:TemplateField HeaderText="操作">
                     <ItemTemplate>
                         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="删除" CommandArgument='<%# Eval("管理员姓名") %>' />
                     </ItemTemplate>
                 </asp:TemplateField>
             </Columns>
             <EditRowStyle BackColor="#2461BF" />
             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
             <RowStyle BackColor="#EFF3FB" />
             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
             <SortedAscendingCellStyle BackColor="#F5F7FB" />
             <SortedAscendingHeaderStyle BackColor="#6D95E1" />
             <SortedDescendingCellStyle BackColor="#E9EBEF" />
             <SortedDescendingHeaderStyle BackColor="#4870BE" />
         </asp:GridView>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\UserData\Desktop\chatweb\data.mdb" ProviderName="System.Data.OleDb" SelectCommand="SELECT [管理员姓名], [注册时间] FROM [manager]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
