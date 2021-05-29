<%@ Page enableEventValidation="false" Language="C#" AutoEventWireup="true" CodeFile="我的粉丝.aspx.cs" Inherits="我的粉丝" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
  
    <style type="text/css">
        .auto-style1 {
            font-size: 30px;
            font-family: 方正舒体;
        }
        .auto-style2 {
            width: 67px;
        }
    </style>
  
    </head>
<body style="background-color:#FFCCFF">
    <form id="form1" runat="server">
        <div align="center">
<iframe runat="server" src="pattern1.aspx" width="80%" style="border-style: none; border-color: inherit; border-width: medium; height: 71px;" scrolling="no" scrollbar="no"></iframe>
           </div>
        <div align="center">
            <strong><span class="auto-style1">我的粉丝</span></strong><asp:Label ID="amount" runat="server" Font-Size="Small" ForeColor="#666666" ></asp:Label>
            &nbsp;
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowHeader="False" PageIndex="1" PageSize="1" BackColor="White" Width="162px" >
                <Columns>
                    <asp:TemplateField >
                         <ItemTemplate>                            
                             <table style="width:100%;">
                                 <tr>
                                     <td rowspan="2" class="auto-style2">
                                         <asp:ImageButton ID="i1" runat="server" Height="100px" OnClick="i1_Click" Width="100px" />
                                     </td>
                                     <td valign="bottom">
                                         <asp:Label ID="Label9" runat="server" Font-Bold="True"></asp:Label>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td valign="top">
                                         <asp:Label ID="Label10" runat="server"></asp:Label>
                                     </td>
                                 </tr>
                             </table>
                             
                             </ItemTemplate>
                        
                    </asp:TemplateField>
                </Columns>
                <PagerSettings PreviousPageText="上一页" FirstPageText="1" Mode="NextPreviousFirstLast" NextPageText="下一页" />
            </asp:GridView>
            <br />
        </div>
    </form>

</body>
</html>
