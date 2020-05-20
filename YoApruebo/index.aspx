<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="YoApruebo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>CompuMundoHiperMegaRed</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
</head>
<body>

    <div class="container mt-5">
        <div class="row">
            <div class="col-sm">
                
            </div>
            <div class="col-sm">
                <form id="form1" runat="server" dir="ltr">
                    <div><h3>Acceso</h3></div>
                    <div>
                        <label for="exampleInputEmail1">Email address</label>
                        </div>
                       <div class="form-group">
                        <asp:TextBox ID="textUser" runat="server"></asp:TextBox>
                    </div>

                    <div>
                        <label for="exampleInputPassword1">Password</label>
                       </div>
                        <div class="form-group">
                        <asp:TextBox ID="textPassword" runat="server"></asp:TextBox>
                    </div>

                    <asp:Button ID="btnentrar" runat="server" Text="Button" OnClick="btnentrar_Click1" />

                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

                </form>
            </div>
            <div class="col-sm">
                
            </div>
        </div>
    </div>





    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>

</body>
</html>
