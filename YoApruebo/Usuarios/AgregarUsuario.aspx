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
   
          <asp:UpdatePanel ID="paginaUser" runat="server">
          
              <ContentTemplate>

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
                        <asp:Button ID="ModificarUser" runat="server" Text="Modificar Usuario" class="btn btn-warning btn-block" visible="false" OnClick="ModificarUser_Click" data-toggle="modal" data-target="#exampleModal"/>
                        <asp:Button ID="delUsuario" runat="server" Text="Eliminar Usuario" class="btn btn-danger btn-block" visible="false"/>
                        <asp:Button ID="delPersona" runat="server" Text="Eliminar Persona" class="btn btn-danger btn-block" visible="false"/>
                    </div>
                    <!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <asp:Label ID="Label1" runat="server" Text="prueba"></asp:Label>
      </div>
     
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
          <asp:Button ID="Button1" runat="server" Text="Probando Boton"  class="btn btn-warning btn-block" OnClick="ModificarU_Click"/>
      </div>
    </div>
  </div>
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
                     </ContentTemplate>
        </asp:UpdatePanel>

        </div>
         <asp:UpdatePanel ID="uptabla" runat="server">
      
            <ContentTemplate>

                <div class="row">
                    <div class="col-sm-8">

                        <asp:GridView ID="tblUsuario" runat="server" class="table" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowDeleting="tblUsuario_RowDeleting" OnRowEditing="tblUsuario_RowEditing" OnSelectedIndexChanging="tblUsuario_SelectedIndexChanging" OnSelectedIndexChanged="tblUsuario_SelectedIndexChanged">
                            <Columns>
                                <asp:CommandField HeaderText="Acciones" ShowDeleteButton="True" ShowCancelButton="true" ShowEditButton="true" ButtonType="Button" ShowSelectButton="True" />
                            
                            </Columns>
                            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" ForeColor="#003399" />
                            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SortedAscendingCellStyle BackColor="#EDF6F6" />
                            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                            <SortedDescendingCellStyle BackColor="#D6DFDF" />
                            <SortedDescendingHeaderStyle BackColor="#002876" />
                        </asp:GridView>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

    
</asp:Content>
