<%@ Page Language="C#" AutoEventWireup="true" CodeFile="举报处理查看.aspx.cs" Inherits="举报处理查看" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color:#a3cff1">
    <form id="form1" runat="server">
         <div align="center">
            <iframe src="pattern2.aspx" width="80%" height="60px" style="border-style: none;" scrolling="no"></iframe>
           
        </div>
    <div align="center" width="100%">
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" width="54%" OnPageIndexChanging="GridView1_PageIndexChanging" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="微博举报处理信息">
                    <ItemTemplate>
                        <table style="width:100%;" ali>
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="举报原因"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label2" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="处理人"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label4" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="违规信息"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label6" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="处理"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label8" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label9" runat="server" Text="被举报用户"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label10" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <EmptyDataTemplate>
               
            </EmptyDataTemplate>
            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
