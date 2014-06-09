<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartTest.aspx.cs" Inherits="EindOpdrachtS22.Tests.StartTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="new" />
    
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server" style="margin-bottom: 6px">
        </asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="load" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
