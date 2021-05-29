<%@ Page enableEventValidation="false" Language="C#" AutoEventWireup="true" CodeFile="举报处理页.aspx.cs" Inherits="举报处理页" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <base target="_self">
    <title>举报处理</title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            width: 322px;
        }
    </style>
</head>
<body style="background-color:#a3cff1">
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="Panel1" runat="server">
        <table style="600px;">
            <tr>
                <td class="auto-style2">处理举报</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" rowspan="2">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                        <asp:ListItem>暂时封掉被举报用户账户</asp:ListItem>
                        <asp:ListItem Selected="True">永久封掉被举报用户账户</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:Panel ID="Panel3" runat="server" Visible="False">
                    <asp:Label ID="Label1" runat="server" Text="封掉该用户账号"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Selected="True">7</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                    </asp:DropDownList>
                    天</td></asp:Panel>
                </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
     </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Visible="False">
            <asp:Label ID="Label2" runat="server" Text="举报处理成功"></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/photo/处理举报成功.png" />
            <br />
            <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick">
            </asp:Timer>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </asp:Panel>
    </div>
        
       
    </form>
</body>
</html>
