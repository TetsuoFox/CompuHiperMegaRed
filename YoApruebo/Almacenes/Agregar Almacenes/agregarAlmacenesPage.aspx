<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="agregarAlmacenesPage.aspx.cs" Inherits="SuperMundoHiperMegaRed.Almacenes.Agregar_Almacenes.agregarAlmacenesPage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestionar Almacenes</h1>
    <div class="card card-body">
        <h2>Agregar Nuevo Almacen</h2>
        <hr style="width: 50%">

        <div class="input-group lg mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="basic-addon1">Nombre</span>
            </div>
            <asp:TextBox class="form-control" ID="txtNombreAlmacen" runat="server" placeholder="Bodega Stgo" AutoPostBack="true"></asp:TextBox>
        </div>



        <div class="row">
            <div class="col-sm-3">
                <div class="form-check">
                    <asp:CheckBox Text="-  Esta Activo" ID="chkActivo" runat="server" class="form-check-input" AutoPostBack="true" value="Esta Activo" />
                </div>
            </div>
            <div class="col-sm-6"></div>
            <div class="col-sm-3">

                <asp:Button ID="agregarAlmacen" value="agregarAlmacen" class="btn btn-success btn-block" runat="server" Text="Agregar Almacen" OnClick="agregarAlmacen_Click" />

            </div>
        </div>
    </div>

    <br />
    <div class="card card-body">


        <h2>Almacenes en el sistema</h2>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <div class="row">
                    <div class="col-sm-8">

                        <asp:GridView ID="tblAlmacenes" runat="server" class="table">
                        </asp:GridView>
                    </div>
                    <div class="col-sm-2">

                        <div class="d-flex flex-column">
                            <div class="p-2">
                                <asp:Button class="btn btn-dark" ID="btnActualizaTbl" runat="server" Text="Actualizar Tabla" OnClick="btnActualizaTbl_Click" />
                            </div>
                            <div class="p-2">
                                <asp:CheckBox class="form-check-input" ID="chkTraeActivos" runat="server" Checked="true" />
                                <label class="form-check-label" for="chkTraeActivos">Incluye almacenes no activos</label>
                            </div>
                        </div>




                    </div>
            </ContentTemplate>
        </asp:UpdatePanel>


    </div>




</asp:Content>
