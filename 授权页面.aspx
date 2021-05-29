<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeFile="授权页面.aspx.cs" Inherits="授权页面" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <iframe src="pattern2.aspx" width="100%" runat="server" height="60px" style="border-style: none" scroll="no"></iframe>
        </div>
        <div align="center" valign="top" >



                        <asp:Panel ID="Panel1" runat="server" Width="41%" Wrap="False" Visible="False" Height="100px"  >
                            <asp:Label ID="Label1" runat="server" Text="删除成功" ></asp:Label>
                            <br>
                           
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/photo/check-64.png" Width="30px" />
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick">
                            </asp:Timer>
                            </br>
                        </asp:Panel>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowHeader="False" Width="80%" GridLines="None">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Panel ID="Panel2" runat="server">
                                <table style="width: 100%;">
                                    <tr>
                                        <td class="auto-style1">管理员姓名</td>
                                        <td class="auto-style1">
                                            <asp:LinkButton ID="name" runat="server" OnClick="name_Click"></asp:LinkButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style1">注册时间</td>
                                        <td class="auto-style1">
                                            <asp:Label ID="time" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Button ID="deletemanager" runat="server" OnClick="deletemanager_Click" Text="删除管理员" />
                                            </asp:Panel>
                            </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
