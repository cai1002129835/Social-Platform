<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeFile="微博搜索.aspx.cs" Inherits="微博搜索" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 92px;
            width: 281px;
        }
        .auto-style3 {
            width: 281px;
        }
        .auto-style4 {
            font-family: 方正舒体;
            font-size: 50px;
            color: #FF00FF;
        }
        .auto-style7 {
            width: 74px;
        }
        .auto-style8 {
            width: 1047px;
        }
        .auto-style9 {
            height: 92px;
            width: 284px;
        }
        .auto-style13 {
            width: 40px;
        }
        .auto-style14 {
            width: 58px;
        }
        .auto-style15 {
            height: 92px;
            width: 283px;
        }
        .auto-style17 {
            width: 283px;
        }
        .auto-style18 {
            width: 284px;
        }
    </style>
</head>
<body style="background-color: #FFCCFF">
    <form id="form1" runat="server">
     <div  align="center" style="background-color:white">
    <iframe runat="server" src="pattern1.aspx" width="80%" style="border-style: none; border-color: inherit; border-width: medium; height: 71px;" scrolling="no" scrollbar="no"></iframe>

    </div>
        <table class="auto-style8">
            <tr>
                <td class="auto-style15"></td>
                <td class="auto-style2" colspan="3" align="center">
                  
                    <asp:Panel ID="Panel1" runat="server">
                        <span class="auto-style4">微博搜索</span></asp:Panel>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr >
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style7" >
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" ForeColor="#FF0066" style="text-decoration:none">综合</asp:LinkButton>
                </td>
                <td class="auto-style13">
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" ForeColor="Black" style="text-decoration:none">找人</asp:LinkButton>
                </td>
                <td class="auto-style14">
                    <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="#333333" OnClick="LinkButton3_Click" style="text-decoration:none">内容</asp:LinkButton>
                </td>
                <td class="auto-style18">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3" colspan="3">
                    <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="466px"></asp:TextBox>
                </td>
                <td class="auto-style18">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="搜索" Height="28px" Width="54px" />
                </td>
            </tr>
        </table>
        <center><asp:Label ID="Label1" runat="server" Font-Size="Small" ForeColor="Red" Text="请输入关键字" Visible="False"></asp:Label></center>
    </form>
</body>
</html>
