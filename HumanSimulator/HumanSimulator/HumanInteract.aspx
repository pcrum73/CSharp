<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HumanInteract.aspx.cs" Inherits="HumanSimulator.HumanInteract" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label id="lblName">Name</label><asp:TextBox ID="txtName" runat="server"></asp:TextBox><br/>
        <label id="lblAge">Age</label><asp:TextBox ID="txtAge" runat="server"></asp:TextBox><br/>
        <label id="lblHeightFeet">Feet</label><asp:DropDownList ID="ddlFeet" runat="server"></asp:DropDownList><label id="lblHeightInches">Inches</label><asp:DropDownList ID="ddlInches" runat="server" ></asp:DropDownList><br/>
        <label id="lblWeight">Weight</label><asp:TextBox ID="txtWeight" runat="server"></asp:TextBox><br/>
        <label id="lblGender">Gender</label><asp:RadioButton id="rbMale" Text="Male" runat="server" /><asp:RadioButton id="rbFemale" Text="Female" runat="server" /><br />
        <label id="lblHair">Hair?</label><asp:CheckBox ID="ckHair" runat="server" OnCheckedChanged="ckHair_CheckedChanged" AutoPostBack="true" /><br />
        <label id="lblHairColor" style="display:none" runat="server">Hair Color</label><asp:TextBox ID="txtHairColor" Visible="false" runat="server"></asp:TextBox><br />
        <label id="lblEyeColor">Eye Color</label><asp:TextBox ID="txtEyeColor" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="btnCreateHuman" runat="server" OnClick="btnCreateHuman_Click" Text="Create Human" /><br />
        <asp:TextBox ID="txtNewHairColor" runat="server">Choose a new hair color?</asp:TextBox><asp:Button ID="btnDyeHair" runat="server" Text="Dye Your Hair" OnClick="btnDyeHair_Click" />
    </div>

    <div id="dvResults">
        <ul id="ulResults">
            <li id="liName" runat="server"></li>
            <li id="liAge" runat="server"></li>
            <li id="liHeight" runat="server"></li>
            <li id="liWeight" runat="server"></li>
            <li id="liGender" runat="server"></li>
            <li id="liHairColor" runat="server"></li>
            <li id="liEyeColor" runat="server"></li>
        </ul>
    </div>
    </form>
</body>
</html>
