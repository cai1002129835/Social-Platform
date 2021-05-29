<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mycarepost.aspx.cs" Inherits="mycarepost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 57px;
        }

        .auto-style2 {
            height: 25px;
        }

        .auto-style3 {
            height: 40px;
            width: 651px;
        }

        .auto-style4 {
            height: 25px;
            width: 651px;
        }

        .auto-style7 {
            height: 108px;
        }

        .auto-style14 {
            height: 50px;
        }

        .auto-style15 {
            height: 25px;
        }

        .auto-style17 {
            width: 151px;
        }

        .auto-style19 {
            width: 187px;
        }

        .auto-style22 {
            width: 55px;
        }

        .auto-style23 {
            width: 123px;
        }

        .auto-style30 {
            width: 154px;
        }

        .auto-style35 {
            height: 82px;
        }

        .auto-style36 {
            height: 38px;
        }

        .auto-style37 {
            height: 271px;
        }
        .auto-style38 {
            height: 191px;
        }
        .auto-style39 {
            text-align: left;
        }
        .auto-style40 {
            height: 57px;
            width: 85px;
        }
        .auto-style41 {
            height: 25px;
            width: 85px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center" id="showtop">
            <iframe src="pattern1.aspx" height="50px" scrolling="no" frameborder="0" style="width: 95%"></iframe>
        </div>
        <div align="center">
            <iframe src="我的封面.aspx" height="280px"  scrolling="no" frameborder="0" style="width: 80%"></iframe>
        </div>
        <div align="center">
            <table style="width: 70%; height: 586px;">
                <tr>
                    <td>
                        <table style="width: 100%; height: 602px">
                            <tr>
                                <td class="auto-style35">
                                    <table style="width: 100%; height: 100%">
                                        <tr>
                                            <td class="auto-style35">
                                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                                <br />
                                                关注</td>
                                            <td class="auto-style35">
                                                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                                <br />
                                                粉丝</td>
                                            <td class="auto-style35">
                                                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                                                <br />
                                                微博</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style38">
                                    <table style="width: 100%; height: 184px;">
                                        <tr>
                                            <td class="auto-style37" valign=top>
                                                <asp:Label ID="Label6" runat="server" Text="等级"></asp:Label>
                                                <br />
                                                <asp:Label ID="Label7" runat="server" Text="个人资料完成度"></asp:Label>
                                                <br />
                                                <asp:Button ID="Button4" runat="server" Text="编辑个人资料" />
                                                </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr >
                                <td class="auto-style39" valign=top>文章</td>

                            </tr>
                            <tr >
                                <td class="auto-style39" valign=top>相册</td>

                            </tr>
                             <tr >
                                <td class="auto-style39" valign=top>赞</td>

                            </tr>
                             <tr >
                                <td class="auto-style39" valign=top>我的微博人气</td>

                            </tr>
                        </table>
                    </td>
                    <td style="height: 100%">
                        <table style="width: 100%; height: 599px">
                            <tr>
                                <td align="left" class="auto-style36">
                                    <table style="width: 100%; height: 35px;">
                                        <tr>
                                            <td class="auto-style30">
                                                <asp:DropDownList ID="DropDownList1" runat="server" Height="23px" Width="62px">
                                                    <asp:ListItem Value="1">全部</asp:ListItem>
                                                    <asp:ListItem Value="0">原创</asp:ListItem>
                                                    <asp:ListItem Value="0">音乐</asp:ListItem>
                                                    <asp:ListItem Value="0">视频</asp:ListItem>
                                                    <asp:ListItem Value="0">图片</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td align="right">
                                                <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" ImageUrl="~/photo/btn_search_box.gif" ImageAlign="Right" />
                                                <asp:TextBox ID="TextBox1" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" Height="23px" Width="218px" Columns="1" MaxLength="10" Font-Names="华文宋体" Font-Size="Medium" ForeColor="#666666">搜索我的微博</asp:TextBox>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>


</body>
</html>
