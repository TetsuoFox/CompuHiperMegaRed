<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="YoApruebo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - Mi aplicación ASP.NET</title>

    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    <%--External Font--%>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@500&display=swap" rel="stylesheet">

    <style type="text/css">
        h5 {
            font-family: "Roboto";
        }

        label {
            font-family: "Roboto";
        }

        .div_contenedor {
            height: 100vh; /*vh (viewport-height) */
        }

        .div_centrado {
            width: 280px;
            position: absolute;
            top: 40%;
            left: 50%;
            margin-top: -150px;
            margin-left: -140px;
        }
    </style>
</head>
<body>
    <div class="div_contenedor" >
        <div class="div_centrado">
            <form id="form1" runat="server" dir="ltr">

                <div class="mt-4">
                    <h5>Iniciar Sesión</h5>
                </div>
                <div class="mt-4">
                    <label for="exampleInputEmail1">Email Address</label>
                </div>
                <div class="form-group">
                    <%--TextMode="Email"--%>
                    <asp:TextBox class="form-control" ID="textUser" runat="server"></asp:TextBox>
                </div>
                <div>
                    <label for="exampleInputPassword1">Password</label>
                </div>
                <div class="form-group">
                    <asp:TextBox class="form-control" ID="textPassword" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="mt-2" style="text-align: right">
                    <asp:Button ID="btnentrar" runat="server" Text="Aceptar" OnClick="btnentrar_Click1" />
                </div>
                <div class="mt-4">
                    <asp:Label ID="Label1" runat="server" Text="" Style="font-size: 14px;"></asp:Label>
                </div>

            </form>
        </div>
    </div>
</body>
</html>
