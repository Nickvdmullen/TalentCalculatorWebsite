<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormCreate.aspx.cs" Inherits="EindOpdrachtS22.Forms.FormCreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../StyleSheet1.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/CreateCSS.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 988px">
    <form id="form1" runat="server">
    <div id="pnlName">
    
        <asp:Panel ID="PanelName" runat="server" BackColor="#FFFFCC">
            <br />
            <asp:Label ID="lblBuildName" runat="server" Text="BuildName:"></asp:Label>
            <asp:TextBox ID="txtBuildName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator id="validatorName" runat="server" ControlToValidate="txtBuildName" ErrorMessage="Please enter a buildname."></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="lblBuildAuthor" runat="server" Text="Build Author:"></asp:Label>
            <asp:TextBox ID="txtBuildAuthor" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator id="ValidatorAuthor" runat="server" ControlToValidate="txtBuildAuthor" ErrorMessage="Please enter a author."></asp:RequiredFieldValidator>
           
            <br />
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
            <br />
        </asp:Panel>
        </div>
        <asp:Panel ID="Panel2" runat="server">
        </asp:Panel>
        <div id="pnlBuild">
        <asp:Panel ID="PanelBuild" runat="server" BackColor="#FFFFCC">
            <br />
            <asp:ImageButton ID="ibtnDeathKnight" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/DK.PNG" OnClick="ibtnDeathKnight_Click" />
            <asp:ImageButton ID="ibtnDruid" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Druid.PNG" OnClick="ibtnDruid_Click" />
            <asp:ImageButton ID="ibtnHunter" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Hunter.PNG" OnClick="ibtnHunter_Click" />
            <asp:ImageButton ID="ibtnMage" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Mage.PNG" OnClick="ibtnMage_Click" />
            <asp:ImageButton ID="ibtnMonk" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Monk.PNG" OnClick="ibtnMonk_Click" />
            <asp:ImageButton ID="ibtnPaladin" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Paladin.PNG" OnClick="ibtnPaladin_Click" />
            <asp:ImageButton ID="ibtnPriest" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Priest.PNG" OnClick="ibtnPriest_Click" />
            <asp:ImageButton ID="ibtnRogue" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Rogue.PNG" OnClick="ibtnRogue_Click" />
            <asp:ImageButton ID="ibtnShaman" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Shaman.PNG" OnClick="ibtnShaman_Click" />
            <asp:ImageButton ID="ibtnWarlock" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Warlock.PNG" OnClick="ibtnWarlock_Click" />
            <asp:ImageButton ID="ibtnWarrior" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Warrior.PNG" OnClick="ibtnWarrior_Click" />
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ibtnSpec1" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/spec1.png" OnClick="ibtnSpec1_Click" />
            <asp:ImageButton ID="ibtnSpec2" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/spec2.png" OnClick="ibtnSpec2_Click" />
            <asp:ImageButton ID="ibtnSpec3" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/spec3.png" OnClick="ibtnSpec3_Click" />
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ibtnSpell1" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell1_Click" />
            <asp:ImageButton ID="ibtnSpell2" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell2_Click" />
            <asp:ImageButton ID="ibtnSpell3" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell3_Click" />
            <asp:Image ID="img15" runat="server" ImageUrl="~/Resources/15.PNG" />
            <br />
            <br />
            <asp:ImageButton ID="ibtnSpell4" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell4_Click" />
            <asp:ImageButton ID="ibtnSpell5" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell5_Click" />
            <asp:ImageButton ID="ibtnSpell6" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell6_Click" />
            <asp:Image ID="img30" runat="server" ImageUrl="~/Resources/30.PNG" />
            <br />
            <br />
            <asp:ImageButton ID="ibtnSpell7" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell7_Click" />
            <asp:ImageButton ID="ibtnSpell8" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell8_Click" />
            <asp:ImageButton ID="ibtnSpell9" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell9_Click" />
            <asp:Image ID="img45" runat="server" ImageUrl="~/Resources/45.PNG" />
            <br />
            <br />
            <asp:ImageButton ID="ibtnSpell10" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell10_Click" />
            <asp:ImageButton ID="ibtnSpell11" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell11_Click" />
            <asp:ImageButton ID="ibtnSpell12" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell12_Click" />
            <asp:Image ID="img60" runat="server" ImageUrl="~/Resources/60.PNG" />
            <br />
            <br />
            <asp:ImageButton ID="ibtnSpell13" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell13_Click" />
            <asp:ImageButton ID="ibtnSpell14" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell14_Click" />
            <asp:ImageButton ID="ibtnSpell15" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell15_Click" />
            <asp:Image ID="img75" runat="server" ImageUrl="~/Resources/75.PNG" />
            <br />
            <br />
            <asp:ImageButton ID="ibtnSpell16" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell16_Click" />
            <asp:ImageButton ID="ibtnSpell17" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell17_Click" />
            <asp:ImageButton ID="ibtnSpell18" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" OnClick="ibtnSpell18_Click" />
            <asp:Image ID="img90" runat="server" ImageUrl="~/Resources/90.PNG" />
            <br />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
