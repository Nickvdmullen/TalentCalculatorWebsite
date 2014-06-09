<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="EindOpdrachtS22.Forms.Start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../CSS/StartCSS.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="divStart">
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" BorderColor="Black" BorderStyle="Solid">
            <asp:Button ID="btnStartNew" runat="server" OnClick="btnStartNew_Click" Text="New" />
            <br />
            <asp:DropDownList ID="dllBuilds" runat="server">
            </asp:DropDownList>
            <asp:Button ID="btnStartLoad" runat="server" Text="Load" OnClick="btnStartLoad_Click" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
