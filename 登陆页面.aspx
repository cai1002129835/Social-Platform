<%@ Page Language="C#" AutoEventWireup="true" CodeFile="登陆页面.aspx.cs" Inherits="登陆页面" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style6 {
            font-family: 方正舒体;
            font-size: 60px;
            color: #FF66CC;
        }

        .auto-style7 {
            width: 1047px;
        }

        .auto-style10 {
        }

        .auto-style11 {
            font-size: 20px;
            /*font-family: 方正舒体;*/
            color: #FF33CC;
        }

        .auto-style13 {
        }

        .auto-style18 {
            width: 200px;
        }

        .auto-style19 {
            width: 400px;
        }

        .auto-style20 {
            width: 300px;
        }

        .auto-style21 {
            width: 415px;
        }

        fieldset {
            padding: 10px;
            margin-top: 5px;
            border: 1px solid #FF66CC;
        }

            fieldset legend {
                color: #FF66CC;
                font-weight: bold;
                padding: 3px 20px 3px 20px;
                border: 1px solid #FF66CC;
            }
    </style>
</head>
<body style="background-color: #ffccff">
    <form id="form1" runat="server">
        <div align="center">
            <br class="auto-style6"></br>
            <table class="auto-style7">
                <tr>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style11" colspan="2">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19" rowspan="3">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:ScriptManager runat="server"></asp:ScriptManager>
                                <asp:Timer runat="server" Interval="1000" OnTick="Unnamed2_Tick"></asp:Timer>



                                <img src="/image/a1f3b501beb0e51f270a893edd78b46.jpg"  width="350px" height="280px"/>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                    <td class="auto-style10" colspan="3" align="left">
                        <span class="auto-style6">欢迎光临微博</span></td>
                </tr>
                <tr>
                    <td class="auto-style13" colspan="2" align="left">
                        <fieldset>
                            <legend>用户登录</legend>
                            <div valign="bottom">
                                <table style="width: 100%;">
                                    <tr>
                                        <td colspan="2">
                                            <asp:TextBox ID="TextBox1" runat="server" placeholder="请输入用户名或邮箱" Width="200px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="请输入用户名" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                                            <asp:Label ID="Label1" runat="server" Text="1" Visible="False" Font-Size="Small" ForeColor="Red"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" placeholder="密码" Width="200px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="请输入密码" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                                            <asp:Label ID="Label2" runat="server" Text="1" Visible="False" Font-Size="Small" ForeColor="Red"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox3" runat="server" Width="100px" placeholder="输入验证码"></asp:TextBox>
                                        </td>
                                        <td>
                                            <iframe src="验证码生成.aspx" style="border-style: none; border-color: inherit; height: 38px; width: 85px;" scrolling="no" scrollbar="no" id="I1" name="I1"></iframe>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="ChangeCode" runat="server" Text="看不清楚？换一个验证码" OnClick="ChangeCode_Click" ForeColor="Black" CausesValidation="False" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登陆" ForeColor="#FF66FF" />
                                        </td>
                                        <td>
                                            <asp:Button ID="Button2" runat="server" Text="取消" ForeColor="#FF66FF" />
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td align="right">&nbsp;</td>
                                        <td>
                                            <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Maroon" OnClick="LinkButton1_Click" CausesValidation="False">快速注册</asp:LinkButton>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </div>
                        </fieldset>



                    </td>
                    <td align="left" class="auto-style20"></td>
                </tr>
                <tr>
                    <td align="center" class="auto-style18">&nbsp;</td>
                    <td align="center" class="auto-style21">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                </tr>
            </table>

        </div>
        <div align="center">
        </div>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/ad.xml"></asp:XmlDataSource>
    </form>
</body>
</html>
