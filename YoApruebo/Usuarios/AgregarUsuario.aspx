<%@ Page Title="User Page" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="YoApruebo._Usuario" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <nav aria-label="breadcrumb">
            <ol class="breadcrumb" style="background-color: rgb(229,240,232)">
                <li class="breadcrumb-item"><a href="../Home.aspx">Inicio</a></li>
                <li class="breadcrumb-item active">Usuarios</li>
                <li class="breadcrumb-item active">Agregar Usuarios</li>
            </ol>
        </nav>
        <div class="card card-body">

                <div class="form-group row">
                    <div class="col-sm-1">
                        <label class="form-label">Rut: </label>
                    </div>
                    <div class="col-sm-5">
                        <asp:TextBox class="form-control" ID="textRut" runat="server" placeholder="12345678" OnTextChanged="textRut_TextChanged" autopostback="true"></asp:TextBox>
                    </div>
                    <div class="col-sm-1">
                        <label class="form-label">-</label>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox class="form-control" ID="textDV" runat="server" placeholder="0"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-1">
                        <label class="form-label">Nombre: </label>
                    </div>
                    <div class="col-sm-8">
                        <asp:TextBox class="form-control" ID="textNombre" runat="server" placeholder="Nombre"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-1">
                        <label class="form-label">Apellido: </label>
                    </div>
                    <div class="col-sm-8">
                        <asp:TextBox class="form-control" ID="textApellido" runat="server" placeholder="Apellido"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group row">
                    <div class="col-sm-1">
                        <label class="form-label">Usuario: </label>
                    </div>
                    <div class="col-sm-8">
                        <asp:TextBox class="form-control" ID="textUsuario" runat="server" placeholder="Usuario"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-1">
                        <label class="form-label">Password: </label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="password" class="form-control" ID="textPass1" runat="server" placeholder="Contraseña"></asp:TextBox>
                    </div>
                    <div class="col-sm-2">
                        <label class="form-label">Repetir Password: </label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="password" class="form-control" ID="textPass2" runat="server" placeholder="Contraseña"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group row">
                    <div class="col-sm-1">
                        <label class="form-label">Cargo: </label>
                    </div>
                    <div class="col-sm-8">
                        <asp:TextBox class="form-control" ID="textCargo" runat="server" placeholder="Cargo"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-1">
                        <label class="form-label">Perfil: </label>
                    </div>
                    <div class="col-sm-8">
                        <asp:DropDownList ID="listPerfil" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-1">
                        <label class="form-label">Correo: </label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="email" class="form-control" ID="textCorreo" runat="server" placeholder="mimail@compumundo.cl"></asp:TextBox>
                    </div>
                    <div class="col-sm-2">
                        <label class="form-label">Telefono: (+56)</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox class="form-control" ID="textTelefono" runat="server" placeholder="999999999"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-1">
                        <label class="form-label">Dirección: </label>
                    </div>
                    <div class="col-sm-8">
                        <asp:TextBox class="form-control" ID="textDireccion" runat="server" placeholder="Calle Falsa 123"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group row">
                    <div class="col-sm-1">
                    </div>

                    <div class="col-sm-7">
                        <asp:Button ID="AgregarUsuario" value="AgregarUsuario" class="btn btn-success btn-block" runat="server" Text="Agregar Usuario" OnClick="AgregarUsuario_Click" />
                    </div>
                    <div class="col-sm-1"></div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-4">
                        <asp:Label ID="lblAd" runat="server" ForeColor="Red"></asp:Label>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-4">
                        <asp:Label ID="lblAd2" runat="server" ForeColor="Red"></asp:Label>
                    </div>
                </div>


        </div>
    </div>
</asp:Content>
