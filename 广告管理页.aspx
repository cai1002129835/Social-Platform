<%@ Page  enableEventValidation="false" Language="C#" AutoEventWireup="true" CodeFile="广告管理页.aspx.cs" Inherits="广告管理页" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <base target="_self">
    <title>广告管理页面</title>
</head>
<body style="background-color:#a3cff1">
    <form id="form1" runat="server">
    <div align="center">
            <iframe src="pattern2.aspx" width="100%" height="60px" style="border-style: none;" scrolling="no"></iframe>         
          
        </div>
        <div align="center">
            <asp:Button ID="Button4" runat="server" Height="33px" OnClick="Button4_Click" Text="增加广告" Width="87px" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" Width="469px" GridLines="None" OnRowDataBound="GridView1_RowDataBound">
                <Columns>
                    <asp:TemplateField HeaderText="正在展示的广告">
                        <ItemTemplate>
                            <table style="width:100%;">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text="广告名"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label5" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text="展示开始时间"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label6" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Text="展示结束时间"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label7" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" Text="描述信息"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label8" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label9" runat="server" Text="图片"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Image ID="Image1" runat="server" Height="200px" Width="200px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label10" runat="server" Text="广告链接"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label11" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="修改广告" Font-Size="Medium" />
                                    </td>
                                    <td>
                                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="删除广告" Font-Size="Medium" />
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <RowStyle BorderColor="White" BorderStyle="Solid" />
            </asp:GridView>

        </div>
    </form>
</body>
</html>
