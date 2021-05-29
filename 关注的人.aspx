<%@ Page enableEventValidation="false" Language="C#" AutoEventWireup="true" CodeFile="关注的人.aspx.cs" Inherits="关注的人" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: 30px;
            font-family: 方正舒体;
        }
        .auto-style2 {
            height: 40px;
        }
        .auto-style3 {
            width: 60px;
        }
    </style>
</head>
<body style="background-color:#FFCCFF">
    <form id="form1" runat="server">
        <div align="center">
<iframe runat="server" src="pattern1.aspx" width="80%" style="border-style: none; border-color: inherit; border-width: medium; height: 71px;" scrolling="no" scrollbar="no"></iframe>
           </div>
            <div>
             <table style="width:100%;">
                <tr>
                    <td align="center" class="auto-style2">
            <strong><span class="auto-style1">我的关注</span></strong><asp:Label ID="amount" runat="server" Font-Size="Small" ForeColor="#666666"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowHeader="False" PageIndex="1" PageSize="1" Width="326px" GridLines="None" BackColor="White">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>                          
                            <table style="width:100%;">
                                <tr>
                                    <td rowspan="2" class="auto-style3">
                                        <asp:ImageButton ID="i1" runat="server" Height="100px" OnClick="i1_Click" Width="100px" />
                                    </td>
                                    <td valign="bottom">
                                        <asp:Label ID="Label9" runat="server" Font-Bold="True"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top">
                                        <asp:Label ID="Label10" runat="server" ForeColor="#666666"></asp:Label>
                                    </td>
                                </tr>
                            </table>

                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
                <PagerSettings PreviousPageText="上一页" FirstPageText="1" NextPageText="下一页" />
                <PagerStyle HorizontalAlign="Center" />
            </asp:GridView>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>

</body>
</html>
