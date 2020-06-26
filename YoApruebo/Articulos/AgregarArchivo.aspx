<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="AgregarArchivo.aspx.cs" Inherits="SuperMundoHiperMegaRed.Articulos.AgregarArchivo" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <form id="form1" runat="server" >

            <nav aria-label="breadcrumb">
                <ol class="breadcrumb" style="background-color: rgb(229,240,232)">
                    <li class="breadcrumb-item"><a href="../Home.aspx">Inicio</a></li>
                    <li class="breadcrumb-item active">Articulo</li>
                    <li class="breadcrumb-item active">Agregar Articulo</li>
                </ol>
            </nav>

            <div class="form-group row">
                <div class="col-sm-1">
                    <label class="form-label">Nombre: </label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox class="form-control" ID="text_id_articulo" runat="server" placeholder="Nombre"></asp:TextBox>
                </div>
            </div>
            
            <div class="form-group row">
                <div class="col-sm-1">
                    <label class="form-label">Tipo_Articulo: </label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox class="form-control" ID="TextBox1" runat="server" placeholder="Nombre"></asp:TextBox>
                </div>
            </div>
            
            <div class="form-group row">
                <div class="col-sm-1">
                    <label class="form-label">COD_SKU: </label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox class="form-control" ID="TextBox2" runat="server" placeholder="Nombre"></asp:TextBox>
                </div>
            </div>

            <div class="form-group row">
                <div class="col-sm-1">
                </div>

                <div class="col-sm-7">
                    <asp:Button ID="AgregarUsuario" value="AgregarUsuario" class="btn btn-success btn-block" runat="server" Text="Agregar Articulo" OnClick="AgregarArticuloClick" />
                </div>
                <div class="col-sm-1"></div>
            </div>
            <div class="form-group row">
                <div class="col-sm-4">
                    <asp:Label ID="lblAd" runat="server" ForeColor="Red"> </asp:Label>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-4">
                    <asp:Label ID="lblAd2" runat="server" ForeColor="Red"> </asp:Label>
                </div>
            </div>
        </form>
    </div>

</asp:Content>
