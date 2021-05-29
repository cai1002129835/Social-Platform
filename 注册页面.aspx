<%@ Page Language="C#" AutoEventWireup="true" CodeFile="注册页面.aspx.cs" Inherits="注册页面" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 615px;
        }

        .auto-style2 {
            width: 50%;
            height: 25px;
        }

        .auto-style3 {
            width: 615px;
            height: 25px;
        }
        body {
  
    text-align:center;

}

        fieldset {
            padding: 10px;
            margin-top: 5px;
            border: 1px solid #1E7ACE;
          width:50%;
          align-content:center;
        }

            fieldset legend {
                color: #1E7ACE;
                font-weight: bold;
                padding: 3px 20px 3px 20px;
                border: 1px solid #1E7ACE;
             
            }
    </style>
</head>
<body style="background-color: #a3cff1">
    <form id="form1" runat="server">
        <div align="center">
        <fieldset >
            <legend>用户注册</legend>
         
                <table style="height: 36px">
                    <tr>
                        <td align="right" class="auto-style2">
                            <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
                        </td>
                        <td class="auto-style3" align="left" >
                            <asp:TextBox ID="TextBox1" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="请输入用户名" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage=" 含有非法字符" Font-Size="Small" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[a-zA-Z_][a-zA-Z0-9_]*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 50%" align="right">
                            <asp:Label ID="Label2" runat="server" Text="注册邮箱"></asp:Label></td>
                        <td class="auto-style1" align="left" >
                            <asp:TextBox ID="TextBox2" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="请输入邮箱" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" Display="Dynamic" ErrorMessage="请输入正确的邮箱地址" Font-Size="Small" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TextBox2"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 50%" align="right">
                            <asp:Label ID="Label3" runat="server" Text="密码"></asp:Label>
                        </td>
                        <td class="auto-style1" align="left" >
                            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Wrap="False" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="请输入密码" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 50%" align="right">
                            <asp:Label ID="Label4" runat="server" Text="确认密码" Style="text-align: right"></asp:Label>
                        </td>
                        <td class="auto-style1" align="left" >
                            <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" Wrap="False" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="请再次输入密码" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage=" 两次输入的密码不一致" Font-Size="Small" ForeColor="Red"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
                        </td>
                        <td align="left" >
                            <asp:Button ID="Button2" runat="server" Text="取消" CausesValidation="False" OnClick="Button2_Click" />
                        </td>
                    </tr>
                </table>
          
        </fieldset>
        </div>
    </form>
</body>
</html>
