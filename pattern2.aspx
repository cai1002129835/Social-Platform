<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pattern2.aspx.cs" Inherits="pattern2" %>

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
            width: 124px;
           
        }
        .auto-style17 {
            width: 71px;
           
        }
        .auto-style19 {
            width: 109px;
          
        }
        .auto-style22 {
            
            text-align: center;
            width: 159px;
        }
        .auto-style25 {
            font-family: 华文行楷;
            font-style: italic;
            font-weight: bold;
            font-size: 30px;
        }
        .auto-style26 {
            width: 70px;
        }
        .auto-style27 {
            width: 72px;
        }
        .auto-style28 {
            height: 45px;
            width: 862px;
        }
    </style> 
</head>
<body style="background-color:white">
    <form id="form1" runat="server">
        <div align="center">
    <table style="background-color: #FFFFFF;" class="auto-style28" >
            <tr>
           
                <td class="auto-style2">
                    <img alt="" src="photo/logo.jpg" style="width: 123px; margin-left: 0px" /></td>
                <td class="auto-style22">
                    
                       
                        &nbsp;<span class="auto-style25" align="right">管理页面</span></td>
                <td class="auto-style19">&nbsp;                            
                        </asp:ListBox></asp:Panel>&nbsp;当前登陆：</td>
                <td class="auto-style27" align="center">
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="False" ForeColor="Gray" OnClick="LinkButton1_Click" style="text-align: center"></asp:LinkButton>
                    </td><td class="auto-style26" >
                    &nbsp;</td>
               
                <td class="auto-style26"  align="center">
                    <asp:ImageButton ID="managerinfo" runat="server" Height="33px" ImageUrl="~/photo/friends_group.png" Width="35px" OnClick="ImageButton2_Click" ToolTip="查看管理员信息" />
                    </td>
                <td class="auto-style26" align="center">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="33px" ImageUrl="~/photo/home.png" Width="35px" OnClick="ImageButton1_Click" />
                    </td>
                <td class="auto-style26" align="center">
                    <asp:ImageButton ID="plusmanager" runat="server" Height="26px" ImageUrl="~/photo/增加管理员.png" Width="25px" OnClick="ImageButton3_Click" ToolTip="增加管理员" />
                    </td>
                <td class="auto-style26" align="center">
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="43px" ImageUrl="~/photo/管理广告.jpg" ToolTip="广告处理" Width="41px" OnClick="ImageButton5_Click1" />
                    </td>
                <td class="auto-style17" align="center">
                    <asp:ImageButton ID="logout" runat="server" ImageUrl="~/photo/logout.png" OnClick="logout_Click" />
                    </td>
            </tr>
        </table>
          </div>  
    </form>
   
</body>
</html>
