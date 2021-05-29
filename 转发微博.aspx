<%@ Page Language="C#" AutoEventWireup="true" CodeFile="转发微博.aspx.cs" Inherits="转发微博" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <base target="_self">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 100px;
        }

        .auto-style2 {
            width: 3px;
        }

        .auto-style3 {
            width: 149px;
        }

        .auto-style4 {
            height: 20px;
        }
        .auto-style5 {
            width: 63px;
        }
    </style>

</head>
<body style="background-color: #FFCCFF">
    <form id="form1" runat="server">
        <table style="width: 350px;">
            <tr>
                <td colspan="2" class="auto-style4">转发微博</td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" EnableTheming="True" Width="336px" style="word-break:break-all;"></asp:Label>
                </td>
                <td>&nbsp;                    </td>
            </tr>
            <tr>
                <td colspan="3" class="auto-style1">
                    <asp:TextBox ID="TextBox1" runat="server" Height="90px" Width="336px" TextMode="MultiLine" MaxLength="140"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="26px" ImageUrl="~/photo/face.png" Width="30px" OnClick="ImageButton1_Click" CausesValidation="False" />
                </td>
                <td align="right">
                   
                    <span class="auto-style3">
                            <asp:Label ID="Label3" runat="server" Font-Size="Small" ForeColor="#FF3300" Text="输入的字符过多" Visible="False"></asp:Label>
                            <asp:Button ID="Button1" runat="server" Text="转发" OnClick="Button1_Click1" UseSubmitBehavior="False" Width="62px" />
                        </span>
                    </td>
                <td align="right">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <div runat="server" id="exp" style="position: fixed; background-color: white; left: 0px; width: 236px; top: 193px;">
                        <asp:Panel ID="Panel1" runat="server" Visible="False">
                            <table>
                                <tr>
                                    <td class="auto-style2">
                                        <img src="../express/a1.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{人}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a2.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{哭泣}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a3.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{亲吻}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a4.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{抽烟}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td>
                                        <img src="../express/a5.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{卖萌}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a6.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{发火}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a7.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{可爱}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a8.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{说谎}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a9.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{难过}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>


                                    <td class="auto-style2">
                                        <img src="../express/a10.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{大笑} ';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <img src="../express/a11.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{委屈}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a12.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{威武}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a13.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{美元}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a14.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{正义}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a15.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{orz}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a16.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{呕吐}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a17.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{大哭}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a18.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{色}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a19.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{左哼}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a20.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{开心}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <img src="../express/a21.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{小声}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a22.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{可怜}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a23.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{困}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a24.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{围观}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a25.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{偷笑}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a26.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{害羞}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a27.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{再见}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a28.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{浮云}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a29.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{右哼}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a30.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{星星}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <img src="../express/a31.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{鄙视}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a32.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{死宅}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a33.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{神马}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a34.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{给钱}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a35.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{龇牙}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a36.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{勉强}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a37.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{闭嘴}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a38.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{太阳}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td>
                                        <img src="../express/a39.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{给力}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a40.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{恼火}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <img src="../express/a41.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{加油}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td>
                                        <img src="../express/a42.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{胜利}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td class="auto-style2">
                                        <img src="../express/a43.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{示威}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td>
                                        <img src="../express/a44.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{鼓掌}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td>
                                        <img src="../express/a45.gif" width="20" height="20" onclick="document.getElementById('TextBox1').value+='{幸福}';document.getElementById('TextBox1').focus()" style="cursor: hand">
                                    </td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td class="auto-style2"></td>
                            </table>
                        </asp:Panel>
                    </div>
                </td>
                <td>
                 
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
