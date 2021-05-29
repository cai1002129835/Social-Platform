<%@ Page Language="C#" AutoEventWireup="true" CodeFile="我的资料.aspx.cs" Inherits="我的资料" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        
        .auto-style2 {
            width: 473px;
        }

        .auto-style3 {
            width: 455px;
        }
    </style>
</head>
<body style="background-color:#FFCCFF">
    <form id="form1" runat="server">
        <div>

            <table style="width: 100%">
                <tr>
                    <td>基本信息
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" Text="编辑" OnClick="Button1_Click" Width="53px" />
                        <asp:Button ID="submit1" runat="server" OnClick="Button4_Click" Text="保存" Width="50px" />
                    </td>

                    <td></td>

                </tr>
                <tr>
                    <td style="width: 30%" class="auto-style2">登录名</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="#666666"></asp:Label>
                        <asp:Button ID="Button4" runat="server" Text="修改密码" OnClick="Button4_Click1" CausesValidation="False" />
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 30%" class="auto-style2">昵称</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" ForeColor="#666666"></asp:Label>
                        <asp:TextBox ID="nicknane" runat="server" Visible="False"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nicknane" Display="Dynamic" ErrorMessage="昵称不能为空" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%" class="auto-style2">真实姓名</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" ForeColor="#666666"></asp:Label>
                        <asp:TextBox ID="realname" runat="server" Visible="False" OnTextChanged="realname_TextChanged"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 30%" class="auto-style2">所在地</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" ForeColor="#666666"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%" class="auto-style2">性别</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label5" runat="server" ForeColor="#666666"></asp:Label>
                        <asp:RadioButton ID="male" runat="server" Text="男" ForeColor="#666666" GroupName="gender" />
                        <asp:RadioButton ID="female" runat="server" ForeColor="#666666" GroupName="gender" Text="女" Checked="True" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 30%" class="auto-style2">感情状况</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label6" runat="server" ForeColor="#666666"></asp:Label>
                        <asp:DropDownList ID="feeling" runat="server">
                            <asp:ListItem>单身中</asp:ListItem>
                            <asp:ListItem Value="0">求交往</asp:ListItem>
                            <asp:ListItem Value="3">暗恋中</asp:ListItem>
                            <asp:ListItem>暧昧中</asp:ListItem>
                            <asp:ListItem>恋爱中</asp:ListItem>
                            <asp:ListItem>订婚</asp:ListItem>
                            <asp:ListItem>已婚</asp:ListItem>
                            <asp:ListItem>分居</asp:ListItem>
                            <asp:ListItem>离异</asp:ListItem>
                            <asp:ListItem>丧偶</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 30%" class="auto-style2">生日</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label7" runat="server" ForeColor="#666666"></asp:Label>
                        <asp:DropDownList ID="year" runat="server" AutoPostBack="True" OnSelectedIndexChanged="year_SelectedIndexChanged" Visible="False">
                        </asp:DropDownList>
                        <asp:DropDownList ID="month" runat="server" AutoPostBack="True" OnSelectedIndexChanged="month_SelectedIndexChanged" Visible="False">
                        </asp:DropDownList>
                        <asp:DropDownList ID="day" runat="server" OnSelectedIndexChanged="day_SelectedIndexChanged" Visible="False">
                        </asp:DropDownList>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 30%" class="auto-style2">简介</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label8" runat="server" ForeColor="#666666"></asp:Label>
                        <asp:TextBox ID="mywords" runat="server" Visible="False" Height="60px" MaxLength="200" TextMode="MultiLine" Width="349px"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 30%" class="auto-style2">注册时间</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label9" runat="server" ForeColor="#666666"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
