<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeFile="管理员管理页.aspx.cs" Inherits="管理员管理页" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <base target="_self">
    <title>管理员管理页</title>
    <style type="text/css">
        .auto-style1 {
            width: 838px;
            height: 351px;
        }

        .auto-style3 {
            width: 238px;
        }

        .auto-style6 {
            width: 140px;
            height: 23px;
        }

        .auto-style7 {
            width: 178px;
        }

        .auto-style9 {
            width: 139px;
            height: 23px;
        }

        .auto-style13 {
            width: 187px;
        }

        .auto-style16 {
            height: 20px;
        }

        .auto-style17 {
            width: 78px;
        }

        .auto-style18 {
            height: 20px;
            width: 123px;
        }

        .auto-style20 {
            width: 80px;
        }

        .auto-style21 {
            height: 20px;
            width: 80px;
        }

        .auto-style22 {
            height: 25px;
            width: 80px;
        }

        .auto-style23 {
            width: 54px;
            margin-left: 71px;
        }

        .auto-style24 {
            height: 25px;
            width: 54px;
            margin-left: 71px;
        }
        .auto-style25 {
            width: 54px;
            margin-left: 71px;
            height: 36px;
        }
        .auto-style26 {
            width: 80px;
            height: 36px;
        }
    </style>
</head>

<body style="background-color: #a3cff1">
    <form id="form1" runat="server">
        <div align="center" style="background-color: white">
            <iframe src="pattern2.aspx" width="80%" height="60px" style="border-style: none;" scrolling="no"></iframe>

        </div>
        <div align="center" width="80%">
            <br>
            <table class="auto-style1" height="800px">
                <tr>
                    <td class="auto-style9">被举报的人</td>
                    <td class="auto-style9">
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem Selected="True">按被举报时间</asp:ListItem>
                            <asp:ListItem>按被举报原因</asp:ListItem>
                            <asp:ListItem>按被举报用户</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style9">被举报的微博</td>
                    <td class="auto-style9">
                        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                            <asp:ListItem Selected="True">按被举报时间</asp:ListItem>
                            <asp:ListItem>按被举报原因</asp:ListItem>
                            <asp:ListItem>按被举报微博</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">被举报的评论</td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
                            <asp:ListItem>按被举报原因</asp:ListItem>
                            <asp:ListItem Selected="True">按被举报时间</asp:ListItem>
                            <asp:ListItem>按被举报评论</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2" valign="top">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" ShowHeader="False" GridLines="None" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound">
                            <Columns>
                                <asp:TemplateField ShowHeader="False">
                                    <ItemTemplate>

                                        <table style="width: 100%; left: 0px;">
                                            <tr>
                                                <td align="left">用户:</td>
                                                <td align="left">
                                                    <asp:LinkButton ID="name" runat="server" OnClick="name_Click" ForeColor="Black" onmouseover="this.style.text-decoration='underline'" onmouseout="this.style.text-decoration='none'" ToolTip="点击进入个人主页"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">举报人:</td>
                                                <td align="left">
                                                    <asp:LinkButton ID="fromname" runat="server" OnClick="fromname_Click" ForeColor="Black" ToolTip="点击进入个人主页"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">举报原因:</td>
                                                <td align="left">
                                                    <asp:Label ID="reason" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">举报时间：</td>
                                                <td align="left">
                                                    <asp:Label ID="time" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">被举报次数：</td>
                                                <td align="left">
                                                    <asp:Label ID="count" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Button ID="deal" runat="server" Text="封号处理" OnClick="deal_Click" Style="height: 21px" />
                                                </td>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>

                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td class="auto-style13" colspan="2" valign="top">
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Width="100%" ShowHeader="False" GridLines="None" AllowPaging="True" OnPageIndexChanging="GridView2_PageIndexChanging" OnRowDataBound="GridView2_RowDataBound">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <table style="width: 100%; background-image: none; background-repeat: no-repeat;">
                                            <tr>
                                                <td align="left" class="auto-style23">用户:</td>
                                                <td align="left" class="auto-style20" colspan="2">
                                                    <asp:LinkButton ID="name" runat="server" ForeColor="Black" ToolTip="点击进入个人主页"></asp:LinkButton>
                                                    <asp:Image ID="warn" runat="server" ImageUrl="~/photo/已被封号.jpg" ToolTip="已被封号" Visible="False" Width="20px" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="auto-style23">举报人:</td>
                                                <td align="left" class="auto-style21" colspan="2">
                                                    <asp:LinkButton ID="fromname" runat="server" ForeColor="Black" ToolTip="点击进入个人主页"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="auto-style23">举报微博:</td>
                                                <td align="left" class="auto-style20" colspan="2">
                                                    <asp:Label ID="ori" runat="server" Visible="False"></asp:Label>
                                                    <asp:Label ID="content" runat="server" Width="200px" Style="word-break: break-all;"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="auto-style23">举报原因：</td>
                                                <td align="left" class="auto-style20" colspan="2">
                                                    <asp:Label ID="reason" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="auto-style25">举报时间：</td>
                                                <td align="left" class="auto-style26" colspan="2">
                                                    <asp:Label ID="time" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="auto-style23">被举报次数：</td>
                                                <td align="left" class="auto-style20" colspan="2">
                                                    <asp:Label ID="count" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style24" align="center">
                                                    <asp:Button ID="Button1" runat="server" Text="封号处理" OnClick="Button1_Click" />
                                                </td>
                                                <td class="auto-style22" align="center">
                                                    <asp:Button ID="Button2" runat="server" Text="直接删除" OnClick="Button2_Click" />
                                                </td>
                                                <td class="auto-style22" align="center">
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td class="auto-style7" colspan="2" valign="top">
                        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" Width="100%" ShowHeader="False" GridLines="None" AllowPaging="True" OnPageIndexChanging="GridView3_PageIndexChanging" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" OnRowDataBound="GridView3_RowDataBound">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <table style="width: 100%;">
                                            <tr>
                                                <td align="left" class="auto-style17">用户:</td>
                                                <td align="left">
                                                    <asp:LinkButton ID="name" runat="server" ForeColor="Black" ToolTip="点击进入个人主页"></asp:LinkButton>
                                                    <asp:Image ID="warn" runat="server" ImageUrl="~/photo/已被封号.jpg" ToolTip="已被封号" Visible="False" Width="20px" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style18" align="left">举报人:</td>
                                                <td class="auto-style16" align="left">
                                                    <asp:LinkButton ID="fromname" runat="server" ForeColor="Black" ToolTip="点击进入个人主页"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="auto-style17">举报评论:</td>
                                                <td align="left">
                                                    <asp:Label ID="content" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="auto-style17">举报原因：</td>
                                                <td align="left">
                                                    <asp:Label ID="reason" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="auto-style17">举报时间：</td>
                                                <td align="left">
                                                    <asp:Label ID="time" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="auto-style17">被举报次数：</td>
                                                <td align="left">
                                                    <asp:Label ID="count" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="auto-style17">
                                                    <asp:Button ID="Button1" runat="server" Text="封号处理" OnClick="Button1_Click1" />
                                                </td>
                                                <td align="left">
                                                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="直接删除" style="margin-bottom: 0px" />
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
