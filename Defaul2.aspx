<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeFile="Defaul2.aspx.cs" Inherits="Defaul2" MaintainScrollPositionOnPostback=true %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>我的首页，随时随地发现新鲜事</title>
    <style type="text/css">
        #Text1 {
            width: 268px;
            height: 20px;
            margin-left: 31px;
        }

        #Select1 {
            width: 100px;
            height: 24px;
        }
    </style>
    <!--搜索框样式CSS-->
    <style type="text/css">
        body {
            font: normal 100% 'Arial','Helvetica','Verdana',sans-serif;
            color: #333;
            height: 1163px;
            background-color: #FFCCFF;
        }

        p {
            padding: 12px 0;
            margin: 0;
            font-size: .8em;
            line-height: 1.5;
        }

        form {
            margin: 0;
            height: 1168px;
        }

        #search_box {
            width: 548px;
            height: 31px;
            background: url("/photo/searchbg.jpg");
        }

            #search_box #s {
                border-style: none;
                border-color: inherit;
                border-width: 0;
                float: left;
                padding: 0;
                margin: 3px 0 0 33px;
                width: 448px;
                height: 24px;
                background: none;
                font-size: .8em;
            }

            #search_box #go {
                float: right;
                margin: 3px 4px 0 0;
            }

        #TextArea1 {
            width: 602px;
            height: 111px;
            margin-top: 0px;
        }

        .auto-style16 {
        }

        .auto-style21 {
            width: 601px;
        }

        .auto-style22 {
            width: 623px;
            height: 92px;
            background-color: #FFCCFF;
        }

        .auto-style26 {
            width: 93px;
            background-color: #FFCCFF;
        }

        .auto-style27 {
            width: 233px;
            height: 4px;
        }

        .auto-style33 {
            background-color: #FFCCFF;
        }

        .auto-style34 {
            font-family: 方正舒体;
            font-size: x-large;
            color: #FF0066;
        }

        .auto-style42 {
            width: 48px;
            font-family: Arial;
            font-size: medium;
        }

        #newweibo {
            width: 539px;
            height: 122px;
        }

        .auto-style47 {
            width: 233px;
        }

        .auto-style48 {
            width: 286px;
        }

        .auto-style49 {
            font-family: Arial;
            font-size: medium;
            color: #808080;
        }

        .新建样式1 {
            top: auto;
        }

        a:link {
            text-decoration: none;
        }

        a:visited {
            text-decoration: none;
        }

        a:hover {
            text-decoration: none;
            color: #FF66FF;
        }

        a:active {
            text-decoration: none;
        }

        .STYLE1 {
            color: #999999;
        }

        #showtop {
            background-color: #FFFFFF;
        }

        .auto-style52 {
            width: 93px;
            background-color: #FFCCFF;
            height: 92px;
        }

        .auto-style53 {
            background-color: #FFCCFF;
            height: 92px;
        }
        .auto-style54 {
            width: 23px;
        }
    </style>
    <!--搜索框代码结束-->


    <!--JS代码-->


    <!--JS代码结束-->
</head>

<body>
    <form id="form1" runat="server">
        <div align="center" id="showtop">
            <iframe src="pattern1.aspx" height="60px" scrolling="no" frameborder="0" style="width: 80%"></iframe>
        </div>
        <table style="width: 80%;" align="center">
            <tr>
                <td class="auto-style52">
                    <table>
                        <tr>
                            <td class="auto-style27">
                                <asp:Button ID="Button1" runat="server" BackColor="#FFCCFF" BorderStyle="None" Font-Size="Medium" Height="22px" Text="首页" Width="80px" Style="margin-left: 1px" BorderColor="#FF99CC" ForeColor="#CC0066" OnClick="Button1_Click" onmouseover="{this.style.background='white'}" onmouseout="this.style.backgroundColor='#FFCCFF';" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style27">
                                <asp:Button ID="Button2" runat="server" BackColor="#FFCCFF" BorderStyle="None" Font-Size="Medium" Height="22px" Text="收藏" Width="80px" Style="margin-left: 1px" BorderColor="#FF99CC" ForeColor="#CC0066" OnClick="Button2_Click" onmouseover="{this.style.background='white'}" onmouseout="this.style.backgroundColor='#FFCCFF';" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style27">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style47"></td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style22">
                    <table>
                        <tr>
                            <td>
                                <table style="width: 100%">
                                    <tr>
                                        <td class="auto-style48">
                                            <span class="auto-style34">有什么新鲜事想告诉大家?</span></td>
                                        <td align="right">
                                            <br />

                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="100%" Height="130px" Style="margin-top: 0px" TextMode="MultiLine"
                                MaxLength="140" BorderColor="White" ></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">
                                <table style="width: 100%; height: 100%">
                                    <tr>
                                        <td class="auto-style54">
                                            <asp:ImageButton ID="ImageButton7" runat="server" Height="26px" ImageUrl="~/photo/face.png" Width="30px" onserverclick="" OnClick="ImageButton7_Click" />
                                        </td>
                                        <td class="auto-style42">表情</td>
                                        <td class="auto-style16" align="right">
                                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                <ContentTemplate>
                                                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                                                    </asp:ScriptManager>
                                                    <asp:Timer ID="Timer1" runat="server" Interval="100" OnTick="Timer1_Tick">
                                                    </asp:Timer>
                                                    <asp:Label ID="Label3" runat="server" ></asp:Label>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        <td align="right">
                                            
                                            <asp:ImageButton ID="ImageButton6" runat="server" Height="33px" ImageUrl="~/photo/post.jpg" Width="87px" OnClick="ImageButton6_Click" ToolTip="发布微博" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style53">
                    <table style="width: 100%; height: 231px">
                        <tr>
                            <td colspan="3" align="center">
                                <asp:ImageButton ID="look" runat="server" Height="100px" OnClick="look_Click" Width="100px" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="3">
                                <asp:Label ID="Label1" runat="server" Font-Size="Small" ForeColor="#666666"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#FFCCFF">
                                <span class="STYLE1">
                                    <asp:LinkButton ID="Button8" runat="server" ForeColor="#333333" Style="text-decoration: none" OnClick="Button8_Click" onmouseover="{this.style.background='white'}" onmouseout="this.style.backgroundColor='#FFCCFF';"></asp:LinkButton>
                                </span></br>
                                <span class="auto-style49">关注</span>                          </td>
                            <td align="center">
                                <asp:LinkButton ID="Button9" runat="server" ForeColor="#333333" Style="text-decoration: none" OnClick="Button9_Click" onmouseover="{this.style.background='white'}" onmouseout="this.style.backgroundColor='#FFCCFF';"></asp:LinkButton>
                                </br>
                           <span class="auto-style49">粉丝</span>
                            </td>
                            <td align="center">
                                <asp:LinkButton ID="Button10" runat="server" ForeColor="#333333" Style="text-decoration: none" OnClick="Button10_Click" onmouseover="{this.style.background='white'}" onmouseout="this.style.backgroundColor='#FFCCFF';"></asp:LinkButton>
                                </br>
                            <span class="auto-style49">微博</span>
                            </td>
                        </tr>
                    </table>
                </td>

            </tr>
            <tr>
                <td class="auto-style26">&nbsp;</td>
                <td  align="left">
                    <div runat="server" id="exp" style="position: fixed; background-color: white; left: 200px; width: 236px;">
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

                   <iframe style="border-style: none; border-color: inherit; border-width: medium; width: 100%; height: 1500px;" id="myweibocontent" src="微博页面.aspx" runat="server" scrollbar="no" ></iframe>
             </td>
                <td class="auto-style33">&nbsp;</td>

            </tr>
        </table>

       
        </div>

    </form>
</body>
</html>
