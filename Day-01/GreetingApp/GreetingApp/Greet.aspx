<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Greet.aspx.cs" Inherits="GreetingApp.Greet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="Body" runat="server">
    <h3>Greet</h3>
    <hr />
    <form id="form1" runat="server">
    <div>
        
        <asp:TextBox runat="server" ID="TxtName"/>
        <asp:Button Text="Greet" runat="server" ID="BtnGreet" OnClick="BtnGreet_OnClick"/>
        <br />
        <asp:Label Text="" runat="server" ID="LblMessage"/>
    </div>
    </form>
</body>
</html>
