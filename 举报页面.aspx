<%@ Page Language="C#" AutoEventWireup="true" CodeFile="举报页面.aspx.cs" Inherits="举报页面" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <base target="_self">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }

        #mention {
            width: 458px;
        }

        .auto-style3 {
            height: 122px;
        }
    </style>
</head>

<body style="background-color: #FFCCFF">
    <form id="form1" runat="server">
        <div id="report">
            <asp:Panel ID="Panel1" runat="server">
                <table style="width: 42%;">
                    <tr>
                        <td class="auto-style1" colspan="2">我要举报的是<asp:LinkButton ID="name" runat="server" ForeColor="Black"></asp:LinkButton>
                            <asp:Label ID="Label3" runat="server"></asp:Label>
                            :</td>
                    </tr>
                    <tr>
                        <td width="30px">
                            <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" Width="30px" OnClick="ImageButton1_Click" />
                        </td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Width="413px" Style="word-break: break-all;"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td width="30px" colspan="2" valign="top">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="119px">
                                <asp:ListItem Selected="True">垃圾营销</asp:ListItem>
                                <asp:ListItem Selected="false">色情</asp:ListItem>
                                <asp:ListItem Selected="false">诈骗</asp:ListItem>
                                <asp:ListItem Selected="false">骚扰我</asp:ListItem>
                                <asp:ListItem Selected="false">敏感信息</asp:ListItem>
                                <asp:ListItem Selected="false">不实信息</asp:ListItem>
                            </asp:RadioButtonList>

                            <br />

                            <asp:RadioButtonList ID="RadioButtonList2" runat="server" Width="123px">
                                <asp:ListItem Selected="True">垃圾营销</asp:ListItem>
                                <asp:ListItem Selected="false">色情</asp:ListItem>
                                <asp:ListItem Selected="false">诈骗</asp:ListItem>
                                <asp:ListItem Selected="false">骚扰我</asp:ListItem>
                                <asp:ListItem Selected="false">敏感信息</asp:ListItem>

                            </asp:RadioButtonList>

                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" valign="top" width="30px">
                            <asp:Button ID="post" runat="server" OnClick="post_Click" Text="举报" Width="47px" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
        <div runat="server" id="mention">
            <asp:Panel ID="Panel2" runat="server">
                <table>
                    <tr>
                        <td class="auto-style3">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    感谢您的反馈，我们将会及时处理窗口将会在<asp:Label ID="time" runat="server">5</asp:Label>
                                    秒后关闭<br /> &nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
                                    </asp:ScriptManager>
                                    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                                    </asp:Timer>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:Button ID="close" runat="server" Text="立即关闭" OnClick="close_Click" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>


    </form>
</body>
</html>
