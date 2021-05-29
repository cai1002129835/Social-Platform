<%@ Page Language="C#" AutoEventWireup="true" CodeFile="发现.aspx.cs" Inherits="发现" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>发现新鲜事</title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            font-family: 华文新魏;
            color: #FF3399;
        }
        #main {
            width: 351px;
        }
        .auto-style2 {
            width: 479px;
        }
    </style>
</head>
<body style="background-color:#FFCCFF">
    <form id="form1" runat="server">
    <div align="center"  style="background-color:white">
    <iframe src="pattern1.aspx" height="60px" scrolling="no" frameborder="0" style="width: 80%"></iframe>
    </div>
        <div align="center" >

            <table style="width:60%"height="1000px">
                <tr>
                    <td class="auto-style1" align="center">发现</td>
                </tr>
                <tr>
                    <td align="center"><iframe id="maincontent" style="border-style: none; border-color: inherit; border-width: medium; width:100%; height: 1500px;" runat="server"></iframe></td>
                </tr>
                </table>

        </div>
    </form>
</body>
</html>
