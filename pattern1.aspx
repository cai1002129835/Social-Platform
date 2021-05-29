<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pattern1.aspx.cs" Inherits="pattern1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css"> 
body{ 
font: normal 100% 'Arial','Helvetica','Verdana',sans-serif; 
color: #333; 
} 
p { 
padding: 12px 0; 
margin: 0; 
font-size: .8em; 
line-height: 1.5; 
} 
form { 
margin: 0; 
} 
#search_box { 
width: 467px; 
height: 31px; 
 background: url("/photo/searchbg.jpg");
} 
#search_box #s { 
    border-style: none;
        border-color: inherit;
        border-width: 0;
        float: left; 
        padding: 0; 
        margin: 3px 0 0 3px; 
width: 427px; 
        height:24px;
        background: none; 
        font-size: .8em; 
} 
#search_box #go { 
float: right; 
margin: 3px 4px 0 0; 
} 
        .auto-style2 {
            width: 132px;
           
        }
        .auto-style12 {
            width: 42px;
          
        }
        .auto-style16 {
            width: 735px;
          
        }
        .auto-style17 {
            width: 134px;
           
        }
        .auto-style21 {
            width: 197px;
        }
        .auto-style22 {
            width: 105px;
        }
        .auto-style23 {
            width: 594px;
        }
        </style> 
</head>
<body style="background-color:white">
    <form id="form1" runat="server">
        <div style="width:100%" align="center" >
    <table style="height: 40px;width:80%" border="0">
            <tr>           
                <td class="auto-style2">
                    <img alt="" src="photo/logo.jpg" style="width: 123px; margin-left: 0px" /></td>
                <td class="auto-style21">
                    
                       
                        <asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="277px" BorderColor="Silver" BorderStyle="Solid"  placeholder="搜索相关用户和微博"></asp:TextBox>
                       
                   
                </td>
                <td class="auto-style22">
                    
                       
                        <asp:ImageButton ID="ImageButton6" runat="server" Height="28px" ImageUrl="~/photo/btn_search_box.gif" OnClick="ImageButton6_Click" Width="29px" ToolTip="点击搜索" />
                       
                   
                </td>
                <td class="auto-style12" align="center">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="33px" ImageUrl="~/photo/home.png" Width="35px" OnClick="ImageButton1_Click" />
                    </td><td class="auto-style23">首页                            
                      </td>
                <td class="auto-style12" align="center">
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="33px" ImageUrl="~/photo/fire.png" Width="35px" OnClick="ImageButton2_Click" />
                    </td><td class="auto-style23">发现</td>
               
                <td class="auto-style16"  align="center">
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="False" ForeColor="Gray" OnClick="LinkButton1_Click"></asp:LinkButton>
                    </td>
                <td class="auto-style17" align="center">
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="33px" ImageUrl="~/photo/new.png" OnClick="ImageButton5_Click" ToolTip="发布微博" />
                    </td>
                <td class="auto-style17" align="center">
                    <asp:ImageButton ID="ImageButton3" runat="server" Height="33px" ImageUrl="~/photo/logout.png" Width="35px" OnClick="ImageButton3_Click" ToolTip="退出登录" />
                    </td>
            </tr>
        </table>
       </div>     
    </form>
</body>
</html>
