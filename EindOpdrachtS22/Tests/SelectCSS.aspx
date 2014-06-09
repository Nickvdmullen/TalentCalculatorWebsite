<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectCSS.aspx.cs" Inherits="EindOpdrachtS22.Tests.Test2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Resources/selectedspec1.png" OnClick="ImageButton1_Click" />
&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Resources/selectedspec1.png" OnClick="ImageButton2_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
