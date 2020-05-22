<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qrcode.aspx.cs" Inherits="SuperMundoHiperMegaRed.qrcode" %>

<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="input-group form-group">
            <div "input-group-prepend">
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
