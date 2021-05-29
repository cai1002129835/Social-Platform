<%@ Page Language="C#" AutoEventWireup="true" CodeFile="头像设置.aspx.cs" Inherits="头像设置" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 273px;
        }

        .auto-style3 {
            height: 217px;
        }

        .auto-style4 {
            width: 273px;
            height: 217px;
        }

        .auto-style5 {
            height: 118px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            头像设置
        </div>
        <div>

            <table style="width: 100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td align="right" class="auto-style1" colspan="2">
                        <asp:RadioButton ID="Button1" runat="server" Checked="True" GroupName="ablum" Text="本地上传" AutoPostBack="True" />
                    </td>
                    <td class="auto-style1">
                        <asp:RadioButton ID="Button2" runat="server" GroupName="ablum" Text="微博相册" AutoPostBack="True" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style3" colspan="3" align="center">
                        <asp:FileUpload ID="FileUpload1" runat="server" BorderColor="#FF0066" BorderStyle="Solid" Height="25px" Style="margin-left: 0px" Width="262px"   />
                        <br />
                        <span style="color: rgb(128, 128, 128); font-family: Arial, 'Microsoft YaHei'; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 15px; orphans: auto; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(242, 242, 245); display: inline !important; float: none;">只支持JPG、PNG、GIF，大小不超过5M

                        </span>
                        </br>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td>
                        <table style="width: 100%; height: 208px">
                            <tr>
                                <td align="center">查看头像</td>
                            </tr>
                            <tr>
                                <td class="auto-style5" align="center">
                                    <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" />
                                    <br />
                                    100px X 100px</td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Image ID="Image2" runat="server" Height="50px" ImageAlign="Top" Width="50px" />
                                    <br />
                                    50px X 50px</td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Image ID="Image3" runat="server" Height="30px" Width="30px" />
                                    <br />
                                    30px X 30px</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="开始上传" />
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="Button4" runat="server" Text="完成" OnClick="Button4_Click" style="height: 21px" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
