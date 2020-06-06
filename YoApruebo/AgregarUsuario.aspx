<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="SuperMundoHiperMegaRed.AgregarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Agregar Usuario</title>
    	<!--Bootsrap 4 CDN-->
	<!--<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <!--Fontawesome CDN-->
	<!--<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">

	Custom styles
	<link rel="stylesheet" type="text/css" href="styles.css">-->
</head>
<body>
     <div class="card card-body">
            <form id="form1" runat="server">
            
                <div class="form-group row">
                    <label class="form-label">Nombre: </label>
                    <div class="col-sm-10">
                        <asp:TextBox class="form-control" ID="textNombre" runat="server" placeholder="Nombre"></asp:TextBox>
               </div>
                        </div>
                 <div class="form-group row">
            <label class="form-label">Apellido: </label>   
            
                     <div class="col-sm-10">
                    <asp:TextBox class="form-control" ID="textApellido" runat="server" placeholder="Apellido"></asp:TextBox>
               </div>  </div> 
                <div class="form-group row">
                <label class="form-label">RUT: </label>    
                  <div class="col-sm-8">  <asp:TextBox class="form-control" ID="textRut" runat="server" placeholder="12345678"></asp:TextBox>
                   </div><div class="col-sm-3"> <asp:TextBox class="form-control" ID="textDV" runat="server" placeholder="0"></asp:TextBox>
                    </div></div>   
               
                <input type="submit" class="btn btn-success btn-block" name="agregar" value="Agregar Producto">
            </form>
            </div>
   
        <div>
        </div>

</body>
</html>
