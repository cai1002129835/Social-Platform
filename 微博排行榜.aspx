<%@ Page Language="C#" AutoEventWireup="true" CodeFile="微博排行榜.aspx.cs" Inherits="微博排行榜" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style3 {
            height: 25px;
        }
        
        .auto-style12 {
            width: 580px;
        }

        .auto-style19 {
            width: 50px;
        }

        .auto-style2 {
            height: 23px;
        }

        .auto-style22 {
            height: 8px;
        }

        .auto-style25 {
            height: 17px;
        }
    
        .auto-style20 {
            height: 25px;
            width: 50px;
        }

        .auto-style14 {
            height: 25px;
            width: 138px;
        }

        .auto-style23 {
            height: 25px;
            width: 139px;
        }

        .auto-style4 {
            width: 77px;
            height: 20px;
        }

        .auto-style24 {
            height: 20px;
            width: 282px;
        }
        
        .auto-style5 {
            height: 20px;
        }

        .auto-style27 {
            height: 25px;
            width: 33px;
        }
        .auto-style28 {
            height: 25px;
      
        }
        .auto-style29 {
            height: 25px;
            width: 8px;
        }
        .auto-style30 {
            height: 25px;
            width: 289px;
        }

        </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div > 
        <table style="width:540px; vertical-align:top" valign="top"  runat="server" id="show">
            <tr style="background-color:#f8178c" >
                <td class="auto-style28" align="center" style="background-color: #FF3399">
                    <asp:Button ID="Button1" runat="server" Text="一小时" OnClick="Button1_Click" style="height: 21px" BorderColor="White" BorderStyle="Solid" Font-Bold="True" BackColor="White" />
                </td>
                <td class="auto-style28" align="center" style="background-color: #FF3399">
                    <asp:Button ID="Button2" runat="server" Text="24小时" OnClick="Button2_Click" style="height: 21px" BorderStyle="None" Font-Bold="True" BackColor="White" />
                </td>
                <td class="auto-style28" align="center" style="background-color: #FF3399">
                    <asp:Button ID="Button3" runat="server" Text=" 周榜 " OnClick="Button3_Click" BorderColor="#FF0066" BorderStyle="None" Font-Bold="True" BackColor="White" />
                </td>
                <td class="auto-style28" align="center" style="background-color: #FF3399">
                    <asp:Button ID="Button4" runat="server" Text="月榜" OnClick="Button4_Click" BorderColor="#FF0066" BorderStyle="None" Font-Bold="True" BackColor="White" Width="38px" />
                </td>
            </tr>
            <tr>
                <td colspan="4">
                   
            <asp:GridView ID="GridView1" runat="server" align="top" AllowPaging="True" AutoGenerateColumns="False" CaptionAlign="Top" HorizontalAlign="Left" PageSize="5" ShowHeader="False" UseAccessibleHeader="False" GridLines="None" Width="100%" BackColor="White" BorderStyle="None" OnPageIndexChanging="GridView1_PageIndexChanging" OnLoad="GridView1_Load">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <table class="auto-style12">
                                <tr>
                                    <td class="auto-style19" rowspan="3" valign="top">
                                        <asp:ImageButton ID="showimg" runat="server" Height="50px" ImageAlign="Top" Width="50px" OnClick="showimg_Click" />
                                    </td>
                                    <td colspan="2" class="auto-style2">
                                        <asp:LinkButton ID="name" runat="server" Font-Bold="True" ForeColor="#333333" OnClick="name_Click1"></asp:LinkButton>
                                    </td>
                                    <td class="auto-style2" colspan="2" align="right">
                                        <asp:ImageButton ID="more" runat="server" ImageUrl="~/photo/flag_mark_red.png" Height="20px" OnClick="ImageButton13_Click" Width="23px" ToolTip="举报该微博" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style22" colspan="4">
                                        <asp:Panel ID="Panel3" runat="server" BackColor="White" Width="542px">
                                            <asp:Label ID="showpost" runat="server" Width="542px" style="word-break:break-all;"></asp:Label>

                                            <asp:Panel ID="Panel1" runat="server" BackColor="#E4E4E4" Width="540px" Height="97px">
                                                <asp:LinkButton ID="originalname" runat="server" ForeColor="#333333" OnClick="originalname_Click"></asp:LinkButton>


                                                <asp:Label ID="original" runat="server" Width="500px" style="word-break:break-all;"></asp:Label>

                                            </asp:Panel>
                                        </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style25" colspan="4">
                                        <asp:Label ID="posttime" runat="server" Font-Size="Small" ForeColor="#666666"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style20" valign="top"></td>
                                    <td class="auto-style14">
                                        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="收藏" Style="height: 21px" />
                                    </td>
                                    <td class="auto-style14">
                                        <asp:Button ID="follow" runat="server" OnClick="Button12_Click" Style="height: 21px" />
                                    </td>
                                    <td class="auto-style23">
                                        <asp:Button ID="comment" runat="server" OnClick="Button13_Click" />
                                    </td>
                                    <td class="auto-style23">
                                        <asp:Button ID="del" runat="server" OnClick="Button14_Click" Visible="False" />
                                    </td>
                                </tr>

                                <asp:Panel ID="Panel2" runat="server" Visible="false" Height="50px" Width="100%"> 
                                    <tr>
                                        <td valign="top" class="auto-style7">
                                            <asp:ImageButton ID="ImageButton10" runat="server" Height="30px" Width="30px" OnClick="ImageButton10_Click" />
                                        </td>
                                        <td class="auto-style7" valign="top" colspan="4">
                                            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="100%" Height="100%" MaxLength="140"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td valign="top">&nbsp;</td>
                                        <td class="auto-style52" valign="top">
                                            <asp:ImageButton ID="ImageButton11" runat="server" />
                                        </td>
                                        <td class="auto-style52" valign="top">
                                            <asp:CheckBox ID="CheckBox1" runat="server" Font-Size="Small" ForeColor="#666666" Text="转发到我的微博" />
                                        </td>
                                        <td class="auto-style52" valign="top">
                                            <asp:Button ID="Button15" runat="server" BackColor="#FF3399" BorderStyle="None" Text="评论" Width="40px" OnClick="Button15_Click" />
                                        </td>
                                        <td></td>
                                    </tr>
                               </asp:Panel>
                                <tr>
                                    <td class="auto-style52" colspan="5" valign="top">
                                        <asp:GridView ID="allcomment" runat="server" AutoGenerateColumns="False" Visible="False" BorderStyle="None" GridLines="Horizontal" ShowHeader="False" Width="100%" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="allcomment_PageIndexChanging" PageSize="3">
                                            <Columns>
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <table style="width: 100%;">
                                                            <tr>
                                                                <td class="auto-style3">
                                                                    <asp:ImageButton ID="ImageButton8" runat="server" Height="30px" OnClick="ImageButton8_Click" Width="30px" />
                                                                </td>
                                                                <td class="auto-style3">
                                                                    <asp:LinkButton ID="name0" runat="server" OnClick="name_Click2"></asp:LinkButton>
                                                                </td>
                                                                <td colspan="2">
                                                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="auto-style4" colspan="2"></td>
                                                                <td class="auto-style24">
                                                                    <asp:Label ID="Label2" runat="server" Font-Size="Small" ForeColor="#666666"></asp:Label>
                                                                </td>
                                                                <td class="auto-style5" align="right">
                                                                    <asp:Button ID="report" runat="server" Text="举报" OnClick="Button18_Click1" Visible="False" />
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
                            <br />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <RowStyle BorderColor="#FFCCCC" BorderStyle="Solid" BorderWidth="4px" />
            </asp:GridView>
                </td>
            </tr>
            
        </table>
    
    
          <asp:Label ID="Label3" runat="server" Text="暂无新微博" Visible="False"></asp:Label>
        </div> 
    </form>
</body>
</html>
