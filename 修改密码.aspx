<%@ Page Language="C#" AutoEventWireup="true" CodeFile="修改密码.aspx.cs" Inherits="修改密码" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <base target="_self">
    <title>修改密码</title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Width="485px">
            <table >
                <tr>
                    <td  >修改密码页面</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td  >原始密码：</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="192px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td >修改后的密码：</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="189px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>确认密码：</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="189px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="两次输入的密码不一致" Font-Size="Small" ForeColor="#CC0000"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="确认修改" OnClick="Button1_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="放弃修改" style="height: 21px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    
        <br >
        <asp:Panel ID="Panel2" runat="server" Visible="False">
            <asp:Label ID="Label1" runat="server" Text="密码修改成功"></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/photo/check-64.png" />
          
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
          
            <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick">
            </asp:Timer>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
