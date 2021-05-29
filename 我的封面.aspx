<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeFile="我的封面.aspx.cs" Inherits="我的封面" MaintainScrollPositionOnPostback="true" SmartNavigation="true" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>我的首页</title>
    <style type="text/css">
        .auto-style1 {
            height: 140px;
        }

        .auto-style2 {
            width: 692px;
        }

        .auto-style3 {
            width: 199px;
        }

        .auto-style4 {
            height: 39px;
        }

        .auto-style20 {
            width: 291px;
            background-color: #FFCCFF;
            height: 21px;
        }

        .auto-style21 {
            height: 18px;
        }

        .auto-style22 {
            height: 140px;
        }

        .auto-style23 {
            height: 18px;
            width: 90px;
        }

        .auto-style24 {
            height: 39px;
            width: 90px;
        }

        .auto-style25 {
            height: 140px;
            width: 201px;
        }

        .auto-style26 {
            height: 18px;
            width: 201px;
        }

        .auto-style27 {
            height: 39px;
            width: 201px;
        }

        .auto-style29 {
            width: 305px;
        }

        .auto-style33 {
        }

        .auto-style34 {
            font-size: small;
            height: 17px;
        }

        .auto-style37 {
            background-color: #FFCCFF;
            width: 305px;
        }

        .auto-style38 {
            width: 886px;
            height: 100%;
        }

        .auto-style47 {
            width: 103px;
            height: 20px;
        }

        .auto-style49 {
            width: 570px;
        }

        .auto-style55 {
            font-size: medium;
            height: 33px;
            color: #666666;
        }

        .auto-style56 {
            font-size: medium;
        }

        .auto-style57 {
            width: 291px;
            background-color: #FFCCFF;
            height: 36px;
        }

        .auto-style58 {
            width: 182px;
        }

        .auto-style59 {
            width: 195px;
        }

        .auto-style60 {
            width: 83px;
        }

        .auto-style61 {
            width: 83px;
            height: 25px;
        }

        .auto-style62 {
            width: 182px;
            height: 25px;
        }

        .auto-style63 {
            width: 195px;
            height: 25px;
        }

        .auto-style64 {
            height: 25px;
        }

        .backToTop {
            display: none;
            width: 18px;
            line-height: 1.2;
            padding: 5px 0;
            background-color: #000;
            color: #fff;
            font-size: 12px;
            text-align: center;
            position: fixed;
            _position: absolute;
            right: 10px;
            bottom: 100px;
            _bottom: "auto";
            cursor: pointer;
            opacity: .6;
            filter: Alpha(opacity=60);
        }
    </style>
    <script type="text/javascript" src="http://lib.sinaapp.com/js/jquery/1.8.2/jquery.min.js"></script>
</head>
<script language="javascript">
    function onMouseOver() {
        document.getElementById("Panel1").style.display = "block";
        // document.getElementById("plus").style.display = "block";
    }
    function onMouseOut(button) {
        document.getElementById("Panel1").style.display = "none";
        //  document.getElementById("plus").style.display = "none";
    }

</script>
<body style="background-color: #FFCCFF">
    <form id="form1" runat="server">

        <div align="center" style="background-color: white">
            <iframe runat="server" src="pattern1.aspx" width="80%" style="border-style: none; border-color: inherit; border-width: medium; height: 71px;" scrolling="no" scrollbar="no"></iframe>
        </div>
        <div>
            <br />
        </div>
        <div runat="server" id="bg" width="100%" align="center" style="display: none">

            <table style="width: 80%;">
                <tr>
                    <td class="auto-style60" align="right">
                        <asp:Button ID="pre" runat="server" Text="上一页" OnClick="Button16_Click1" Style="height: 21px" />
                    </td>
                    <td class="auto-style58">
                        <asp:ImageButton ID="one" runat="server" Height="200px" Width="200px" OnClick="one_Click" BorderColor="White" BorderStyle="Solid" />
                    </td>
                    <td class="auto-style59">
                        <asp:ImageButton ID="two" runat="server" Height="200px" Width="200px" OnClick="two_Click" BorderColor="White" BorderStyle="Solid" />
                    </td>
                    <td class="auto-style59">
                        <asp:ImageButton ID="three" runat="server" Height="200px" Width="200px" OnClick="three_Click" BorderColor="White" BorderStyle="Solid" />
                    </td>
                    <td>
                        <asp:ImageButton ID="four" runat="server" Height="200px" Width="200px" OnClick="four_Click" BorderColor="White" BorderStyle="Solid" />
                    </td>
                    <td align="left">
                        <asp:Button ID="next" runat="server" Text="下一页" OnClick="next_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style61" align="right"></td>
                    <td class="auto-style62"></td>
                    <td class="auto-style63" align="right">
                        <asp:Button ID="Button18" runat="server" Text="确定" OnClick="Button18_Click" />
                    </td>
                    <td class="auto-style63" align="left">
                        <asp:Button ID="Button19" runat="server" Text="取消" OnClick="Button19_Click" />
                    </td>
                    <td class="auto-style64"></td>
                    <td align="left" class="auto-style64"></td>
                </tr>
            </table>
            </br>
        </div>
        <div height="428px" width="100%" align="center">
            <asp:Panel ID="Panel2" runat="server" Width="70%">
                <table style="height: 281px;" align="center" id="showbg">

                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>
                            <asp:Button ID="Button5" runat="server" Text="上传封面图" OnClick="Button5_Click" Style="height: 21px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">
                            <table style="width: 100%; height: 345px;">
                                <tr>
                                    <td class="auto-style25"></td>
                                    <td class="auto-style22" align="center">
                                        <asp:ImageButton ID="Image1" runat="server" Height="100px" OnClick="Image1_Click" Width="100px" />
                                      
                                        <asp:Label ID="name" runat="server" Font-Size="Large" Font-Bold="True"></asp:Label>
                                        <asp:Label ID="word" runat="server" align="center"></asp:Label>
                                    </td>
                                    <td class="auto-style1"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style26"></td>

                                    <td class="auto-style23" align="center">
                                        
                                    <br />
                                    </td>
                                    <td class="auto-style21"></td>
                                </tr>
                                <tr>
                                    <td class="auto-style27"></td>
                                    <td class="auto-style24" height="70px" align="center">
                                        <asp:Button ID="plus" runat="server" onmouseover="onMouseOver()" onmouseout="onMouseOut()" Visible="False" OnClick="plus_Click" BackColor="#CCFFFF" BorderColor="#FF99FF" BorderStyle="Solid" Height="26px" />
                                        <br />
                                        <asp:Panel ID="Panel1" runat="server" Visible="False" onmouseout="onMouseOut()" onmouseover="onMouseOver()">

                                            <asp:Button ID="Button11" runat="server" BackColor="#FF3399" BorderStyle="None" OnClick="Button11_Click" Text="取消关注" Width="60px" Style="height: 17px" />
                                            <br />
                                            <asp:Button ID="Button15" runat="server" BackColor="#FF3399" BorderStyle="None" OnClick="Button12_Click" Text=" 举报" Width="60px" />
                                        </asp:Panel>
                                    </td>
                                    <td class="auto-style4"></td>
                                </tr>
                            </table>
                        </td>
                        <td class="auto-style3">&nbsp;</td>
                    </tr>

                </table>
            </asp:Panel>
            <table class="auto-style38" align="center">
                <tr>
                    <td style="background-color: white" class="auto-style47" align="center">
                        <asp:LinkButton ID="Button8" runat="server" ForeColor="#333333" Style="text-decoration: none" OnClick="Button8_Click" Font-Bold="True"></asp:LinkButton>
                        </br>
                                <span>关注</span>
                    </td>
                    <td style="background-color: white" class="auto-style47" align="center">
                        <asp:LinkButton ID="Button9" runat="server" ForeColor="#333333" Style="text-decoration: none" OnClick="Button9_Click" Font-Bold="True"></asp:LinkButton>
                        <br />
                        <span>粉丝</span>
                    </td>
                    <td style="background-color: white" class="auto-style47" align="center">
                        <asp:LinkButton ID="Button10" runat="server" ForeColor="#333333" Style="text-decoration: none" Font-Bold="True"></asp:LinkButton>
                        <br />
                        <span>微博</span>
                    </td>
                    <td rowspan="5" class="auto-style49" valign="top">
                        <iframe id="mainshow" style="border: 0px none #FFFFFF; margin: 0px; padding: 0px; width: 600px; height: 1500px; background-color: #FFFFFF;" runat="server" src="iframe.aspx"></iframe>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20" colspan="3">
                        <asp:Image ID="Image3" runat="server" ImageUrl="~/photo/占位图.jpg" Height="16px" Width="168px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style57" style="background-color: white" colspan="3" align="center">
                        <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#666666" OnClick="LinkButton1_Click" Style="text-decoration: none" Font-Size="medium" CssClass="auto-style56">编辑个人资料</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" Font-Size="Small" ForeColor="#333333" OnClick="LinkButton2_Click" Style="color: #808080" CssClass="auto-style56">查看资料</asp:LinkButton>
                    </td>

                </tr>
                <tr>
                    <td colspan="3" valign="top" align="center">
                        <asp:Panel ID="showchart" runat="server" BorderStyle="None" CssClass="auto-style37">
                            <table border="0" class="auto-style29" style="height: 321px;">
                                <tr>
                                    <td class="auto-style55" align="center" style="background-color: #FFCCFF" valign="bottom">本周我的主页被访问次数</td>
                                </tr>
                                <tr>
                                    <td align="left" class="auto-style34" style="background-color: white">
                                        <asp:Image ID="Image2" runat="server" ImageUrl="~/photo/home64.png" Width="50px" />
                                        <asp:Label ID="visitcount" runat="server"></asp:Label>
                                        <asp:Image ID="tend" runat="server" Height="16px" Width="10px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="auto-style33">

                                        <asp:Chart ID="visit" runat="server" OnLoad="visit_Load" Palette="None">
                                            <Series>
                                                <asp:Series ChartType="Line" IsValueShownAsLabel="True" Name="Series1" YValuesPerPoint="2">
                                                </asp:Series>
                                            </Series>
                                            <ChartAreas>
                                                <asp:ChartArea Name="ChartArea1">
                                                    <AxisY IntervalAutoMode="VariableCount" LineColor="LightCoral" Title="访问数">
                                                        <MajorGrid LineColor="LightCoral" />
                                                        <MinorGrid LineColor="LightCoral" />
                                                        <MajorTickMark LineColor="LightCoral" />
                                                    </AxisY>
                                                    <AxisX InterlacedColor="LightCoral" LineColor="LightCoral" Title="时间">
                                                        <MajorGrid LineColor="LightCoral" />
                                                        <MajorTickMark LineColor="LightCoral" />
                                                    </AxisX>
                                                </asp:ChartArea>
                                            </ChartAreas>
                                        </asp:Chart>

                                    </td>
                                </tr>
                            </table>

                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td valign="top" colspan="3">
                        <asp:Image ID="Image4" runat="server" ImageUrl="~/photo/占位图.jpg" Height="931px" Width="168px" />
                    </td>
                </tr>
            </table>
            <script type="text/javascript">
                (function () {
                    var $backToTopTxt = "返回顶部", $backToTopEle = $('<div class="backToTop"></div>').appendTo($("body"))
                        .text($backToTopTxt).attr("title", $backToTopTxt).click(function () {
                            $("html, body").animate({ scrollTop: 0 }, 120);
                        }), $backToTopFun = function () {
                            var st = $(document).scrollTop(), winh = $(window).height();
                            (st > 0) ? $backToTopEle.show() : $backToTopEle.hide();
                            //IE6下的定位
                            if (!window.XMLHttpRequest) {
                                $backToTopEle.css("top", st + winh - 166);
                            }
                        };
                    $(window).bind("scroll", $backToTopFun);
                    $(function () { $backToTopFun(); });
                })();
</script>
        </div>
    </form>
</body>
</html>
