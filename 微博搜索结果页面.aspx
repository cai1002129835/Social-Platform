<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeFile="微博搜索结果页面.aspx.cs" Inherits="微博搜索结果页面" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style3 {
            font-family: 方正舒体;
            font-size: 35px;
        }

        .auto-style6 {
            height: 25px;
        }

        .auto-style7 {
        }

        .auto-style8 {
            height: 25px;
            width: 113px;
        }

        .auto-style4 {
            width: 77px;
            height: 20px;
        }

        .auto-style5 {
            height: 20px;
        }

        .auto-style10 {
            width: 874062592px;
            height: 30px;
        }

        .auto-style11 {
        }

        .auto-style18 {
            width: 42px;
            height: 30px;
        }

        .auto-style20 {
            height: 43px;
            font-family: 方正舒体;
            font-size: 30px;
            color: #FF0066;
            width: 150px;
        }

        .auto-style21 {
            height: 43px;
        }

        .auto-style24 {
            height: 30px;
        }

        .auto-style26 {
            height: 127px;
        }

        .auto-style28 {
            width: 510px;
        }
        .auto-style29 {
            width: 50px;
        }
        .auto-style30 {
            width: 49px;
        }
        .auto-style31 {
            height: 31px;
        }
        .auto-style32 {
            height: 17px;
        }
    </style>
</head>
<body style="background-color: #FFCCFF">
    <form id="form1" runat="server">
        <div align="center" style="background-color: white" width="100%">
           <iframe id="I1" runat="server"  scrollbar="no" scrolling="no" src="pattern1.aspx" style="border-style: none; border-color: inherit; border-width: medium; height: 71px;" width="80%"></iframe>
        </div>
        <div align="center" width="100%">
            <table width="70%">
                <tr>
                    <td align="center" class="auto-style20" valign="bottom">
                        <asp:Label ID="Label3" runat="server" Text="微博搜索"></asp:Label>
                    </td>
                    <td class="auto-style21" align="left" valign="bottom">
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" ForeColor="Black" Style="text-decoration: none">综合</asp:LinkButton>
                    </td>
                    <td class="auto-style21" align="left" valign="bottom">
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" ForeColor="Black" Style="text-decoration: none">找人</asp:LinkButton>
                    </td>
                    <td class="auto-style21" align="left" colspan="3" valign="bottom">
                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" ForeColor="Black" Style="text-decoration: none">微博</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style24" colspan="4" align="right">
                        <asp:TextBox ID="TextBox1" runat="server" Height="28px" Width="386px" OnTextChanged="TextBox1_TextChanged" Style="margin-left: 0px"></asp:TextBox>
                    </td>
                    <td class="auto-style10" align="left">
                        <asp:Button ID="Button1" runat="server" Text="搜索" OnClick="Button1_Click" Height="25px" Width="50px" />
                    </td>
                    <td class="auto-style18"></td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="4" valign="top">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="3" Width="433px" AllowPaging="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderWidth="1px" OnPageIndexChanging="GridView1_PageIndexChanging" BorderStyle="None" CellSpacing="2">
                            <Columns>
                                <asp:TemplateField HeaderText="相关微博" FooterStyle-VerticalAlign="Top">
                                    <ItemTemplate>
                                        <table class="auto-style28">
                                            <tr>
                                                <td class="auto-style29" rowspan="3" valign="top">
                                                    <asp:ImageButton ID="showimg" runat="server" Height="50px" ImageAlign="Top" OnClick="showimg_Click" Width="50px" />
                                                </td>
                                                <td class="auto-style7">
                                                    <asp:LinkButton ID="name" runat="server" Font-Bold="True" ForeColor="#333333" OnClick="name_Click1"></asp:LinkButton>
                                                </td>
                                                <td colspan="3" align="right">
                                                    <asp:ImageButton ID="more" runat="server" Height="20px" ImageUrl="~/photo/flag_mark_red.png" OnClick="ImageButton13_Click" ToolTip="举报该微博" Width="23px" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style26" colspan="4"  align="left" valign="top">
                                                    <asp:Panel ID="Panel3" runat="server" BackColor="White" Width="450px" Height="67px">
                                                        <asp:Label ID="showpost" runat="server" ForeColor="Black" Width="450px" Style="word-break: break-all;"></asp:Label>
                                                        <asp:Panel ID="Panel1" runat="server" BackColor="#E4E4E4" Width="450px" Height="110px">
                                                            <asp:LinkButton ID="originalname" runat="server" ForeColor="#333333" OnClick="originalname_Click"></asp:LinkButton>

                                                            <asp:Label ID="original" runat="server" ForeColor="Black" Width="400px" Style="word-break: break-all;"></asp:Label>
                                                        </asp:Panel>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style32" colspan="4" align="left">
                                                    <asp:Label ID="posttime" runat="server" Font-Size="Small" ForeColor="#666666"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style29" valign="top">&nbsp;</td>
                                                <td class="auto-style8" valign="top">
                                                    <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="收藏" />
                                                </td>
                                                <td class="auto-style6">
                                                    <asp:Button ID="follow" runat="server" OnClick="Button12_Click" />
                                                </td>
                                                <td class="auto-style6">
                                                    <asp:Button ID="comment" runat="server" OnClick="Button13_Click" Style="height: 21px" />
                                                </td>
                                                <td class="auto-style6">
                                                    <asp:Button ID="del" runat="server" OnClick="Button14_Click" Visible="False" />
                                                </td>
                                            </tr>
                                            <asp:Panel ID="Panel2" runat="server" Visible="false" Height="50px" Width="100%">
                                                <tr>
                                                    <td valign="top" class="auto-style7">
                                                        <asp:ImageButton ID="ImageButton10" runat="server" Height="30px" Width="30px" OnClick="ImageButton10_Click" />
                                                    </td>
                                                    <td class="auto-style7" valign="top" colspan="4">
                                                        <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="100%" Height="100%"></asp:TextBox>
                                                    </td>
                                                </tr>


                                                <tr>
                                                    <td valign="top">&nbsp;</td>
                                                    <td class="auto-style52" valign="top">
                                                        <asp:ImageButton ID="ImageButton11" runat="server" />
                                                    </td>
                                                    <td class="auto-style52" valign="top">
                                                      
                                                    </td>
                                                    <td class="auto-style52" valign="top">
                                                        <asp:Button ID="Button15" runat="server" BackColor="#FF3399" BorderStyle="None" Text="评论" Width="40px" OnClick="Button15_Click" Style="height: 17px" />
                                                    </td>
                                                    <td></td>
                                                </tr>
                                            </asp:Panel>
                                            <tr>
                                                <td class="auto-style30" colspan="5" valign="top">
                                                    <asp:GridView ID="allcomment" runat="server" AutoGenerateColumns="False" BorderStyle="None" GridLines="Horizontal" ShowHeader="False" Visible="False" Width="100%">
                                                        <Columns>
                                                            <asp:TemplateField>
                                                                <ItemTemplate>
                                                                    <table style="width: 100%;">
                                                                        <tr>
                                                                            <td class="auto-style3">
                                                                                <asp:ImageButton ID="ImageButton8" runat="server" Height="30px" OnClick="ImageButton8_Click" Width="30px" />
                                                                            </td>
                                                                            <td>
                                                                                <asp:Label ID="Label1" runat="server"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="auto-style4"></td>
                                                                            <td class="auto-style5">
                                                                                <asp:Label ID="Label2" runat="server" Font-Size="Small" ForeColor="#666666"></asp:Label>
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
                                    </ItemTemplate>

                                    <FooterStyle VerticalAlign="Top"></FooterStyle>

                                    <HeaderStyle Height="30px" />
                                </asp:TemplateField>
                            </Columns>
                            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#FFF1D4" />
                            <SortedAscendingHeaderStyle BackColor="#B95C30" />
                            <SortedDescendingCellStyle BackColor="#F1E5CE" />
                            <SortedDescendingHeaderStyle BackColor="#93451F" />
                        </asp:GridView>
                        <asp:Label ID="tip1" runat="server" Visible="False">未查找到相关微博</asp:Label>
                    </td>
                    <td class="auto-style11" colspan="2" valign="top">

                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="183px" AllowPaging="True" Style="margin-top: 0px" OnPageIndexChanging="GridView2_PageIndexChanging">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField HeaderText="相关用户">
                                    <ItemTemplate>
                                        <table style="width: 100%;">
                                            <tr>
                                                <td>
                                                    <asp:ImageButton ID="img" runat="server" Height="50px" OnClick="ImageButton9_Click" Width="50px" />
                                                </td>
                                                <td colspan="2">
                                                    <asp:Label ID="introduction" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:LinkButton ID="relatename" runat="server" OnClick="relatename_Click" ForeColor="Black"></asp:LinkButton>
                                                </td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                    <HeaderStyle Height="20px" />
                                    <ItemStyle Height="50px" />
                                </asp:TemplateField>
                            </Columns>

                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />
                        </asp:GridView>
                        <asp:Label ID="tip" runat="server" Visible="False">未查找到相关用户</asp:Label>
                    </td>
                </tr>
            </table>

        </div>

    </form>
</body>
</html>
