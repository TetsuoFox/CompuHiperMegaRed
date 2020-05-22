<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qrcode.aspx.cs" Inherits="SuperMundoHiperMegaRed.qrcode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:TextBox ID="textCode" runat="server"></asp:TextBox>
                <asp:Button ID="btnGeneraQR" runat="server" Text="Generar" OnClick="btnGeneraQR_Click" />
                <hr />
            </div>
            <div>
                <img runat="server" id="imgCtrl" />
            </div>
        </div>
    </form>
</body>
</html>
