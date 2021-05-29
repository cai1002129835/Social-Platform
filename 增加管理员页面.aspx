<%@ Page Language="C#" AutoEventWireup="true" CodeFile="增加管理员页面.aspx.cs" Inherits="增加管理员页面" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <base target="_self">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>增加管理员</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
   
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">

                <table style="width: 53%;">
                    <tr>
                        <td>管理员用户名:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>管理员登陆密码：</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确定" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
        <div valign="center">
        <asp:Panel ID="Panel2" runat="server" Height="106px" Width="53%" Visible="False">
            <div class="auto-style1">
                增加管理员成功<br /> 
                <asp:Image ID="Image1" runat="server" ImageUrl="~/photo/check-64.png" />
                <asp:Timer ID="Timer1" runat="server" Interval="3000" OnTick="Timer1_Tick">
                </asp:Timer>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <br />
            </div>
            </asp:Panel></div>
    </form>
</body>
</html>
