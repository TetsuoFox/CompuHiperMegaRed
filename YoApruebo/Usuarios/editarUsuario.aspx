<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="editarUsuario.aspx.cs" Inherits="SuperMundoHiperMegaRed.Usuarios.editarUsuario" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div><h2>Editar Usuarios</h2>
    <br />
    <h4>Presione la fila que desea editar</h4></div>
      
    <div class="card card-body">      
    <div class="form-group row">
                    <div class="col-sm-4">
                      <div class="form-check">
                        <asp:CheckBox Text="-  Usuario Activo" ID="checkUser" runat="server" class="form-check-input" AutoPostBack="true" value="Esta Activo" OnCheckedChanged="Page_Load" />
                        </div>
                    </div>
                    <div class="col-sm-4">
                       <div class="form-check">
                        <asp:CheckBox Text="-  Persona Activa" ID="checkPer" runat="server" class="form-check-input" AutoPostBack="true" value="Esta Activo" />
                    </div>
                </div>

                        </div></div>
    <div class="card card-body">
     
          <asp:GridView ID="GridView1" class="table"  
    runat="server" AutoGenerateColumns="false" OnRowDataBound = "OnRowDataBound" OnSelectedIndexChanged = "OnSelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="Usuario" HeaderText="Usuario"  />
        <asp:BoundField DataField="Perfil" HeaderText="Perfil"  />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="Apellido" HeaderText="Apellido"  />
        <asp:BoundField DataField="Rut" HeaderText="Rut" />
        <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
        <asp:BoundField DataField="Correo" HeaderText="Correo"  />
        <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
        <asp:BoundField DataField="Direccion" HeaderText="Dirección"  />
        <asp:BoundField DataField="EstadoUser" HeaderText="Estado Usuario" />
        <asp:BoundField DataField="EstadoPer" HeaderText="Estado Persona" />
      

    </Columns>
</asp:GridView>
<asp:LinkButton ID="lnkDummy" runat="server"></asp:LinkButton>

    

    </div>
 
            

    <!-- Bootstrap Modal Dialog -->
<div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
       <div class="modal-dialog">
           <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
               <ContentTemplate>
                   <div class="modal-content">
                       <div class="modal-header">
                         <h4 class="modal-title"><asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label></h4>
                        </div>
                       <div class="modal-body">
                       
                           
                        <div class="input-group lg mb-4">
                            <div class="input-group-prepend">
                            <span class="input-group-text" id="basic-addon1">Rut     </span>
                        </div>
                            <asp:Label ID="Label3" runat="server" Text="" Hidden="true" ></asp:Label>
                        <asp:TextBox class="form-control" ID="txtRutC" runat="server" placeholder="Rut - DV" AutoPostBack="true" Enabled="false"></asp:TextBox>
                        </div> 
                       <%--------------------------------------------------%>
                           <div class="input-group lg mb-4">
                        <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon2">Usuario </span>
                        </div>
                            <asp:Label ID="lblId" runat="server" Text="" Hidden="true" ></asp:Label>
                        <asp:TextBox class="form-control" ID="txtUsuario" runat="server" placeholder="Usuario" AutoPostBack="true"></asp:TextBox>
                        </div>
                           <%--------------------------------------------------%>
                                  <div class="input-group lg mb-4">
                        <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon3">Perfil</span>
                        </div>
                            <asp:Label ID="Label5" runat="server" Text="" Hidden="true" ></asp:Label>
                            <asp:DropDownList ID="listPerfil" runat="server"></asp:DropDownList>
                        </div>
                           <%--------------------------------------------------%>
                              <div class="input-group lg mb-4">
                        <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon4">Nombre  </span>
                        </div>
                            <asp:Label ID="Label1" runat="server" Text="" Hidden="true" ></asp:Label>
                        <asp:TextBox class="form-control" ID="txtNombre" runat="server" placeholder="Nombre" AutoPostBack="true"></asp:TextBox>
                        </div>
                           <%--------------------------------------------------%>
                            <div class="input-group lg mb-4">
                        <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon5">Apellido</span>
                        </div>
                            <asp:Label ID="Label2" runat="server" Text="" Hidden="true" ></asp:Label>
                        <asp:TextBox class="form-control" ID="txtApellido" runat="server" placeholder="Apellido" AutoPostBack="true"></asp:TextBox>
                        </div>
                           <%--------------------------------------------------%>
                                  <div class="input-group lg mb-4">
                        <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon6">Cargo</span>
                        </div>
                            <asp:Label ID="Label4" runat="server" Text="" Hidden="true" ></asp:Label>
                        <asp:TextBox class="form-control" ID="txtCargo" runat="server" placeholder="Cargo" AutoPostBack="true"></asp:TextBox>
                        </div>
                           <%--------------------------------------------------%>
                        <div class="input-group lg mb-4">
                        <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon7">Correo</span>
                        </div>
                            <asp:Label ID="Label6" runat="server" Text="" Hidden="true" ></asp:Label>
                        <asp:TextBox class="form-control" ID="txtCorreo" runat="server" placeholder="Correo" AutoPostBack="true"></asp:TextBox>
                        </div>
                           <%--------------------------------------------------%>
                            <div class="input-group lg mb-4">
                        <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon8">Telefono</span>
                        </div>
                            <asp:Label ID="Label7" runat="server" Text="" Hidden="true" ></asp:Label>
                        <asp:TextBox class="form-control" ID="txtTelefono" runat="server" placeholder="Telefono" AutoPostBack="true"></asp:TextBox>
                        </div>
                           <%--------------------------------------------------%>
                            <div class="input-group lg mb-4">
                        <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon9">Dirección</span>
                        </div>
                            <asp:Label ID="Label8" runat="server" Text="" Hidden="true" ></asp:Label>
                        <asp:TextBox class="form-control" ID="txtDireccion" runat="server" placeholder="Dirección" AutoPostBack="true"></asp:TextBox>
                        </div>
                           <%--------------------------------------------------%>
                 
                        
                <div class="form-group row">
                    <div class="col-sm-4">
                      <div class="form-check">
                        <asp:CheckBox Text="-  Usuario Activo" ID="chkActivoUser" runat="server" class="form-check-input" AutoPostBack="true" value="Esta Activo" />
                        </div>
                    </div>
                    <div class="col-sm-4">
                       <div class="form-check">
                        <asp:CheckBox Text="-  Persona Activa" ID="chkActivoPer" runat="server" class="form-check-input" AutoPostBack="true" value="Esta Activo" />
                    </div>
                </div>

                        
                        <div class="col-sm-4">

                        <asp:Button ID="btnGuardar" value="guardarAlmacen" class="btn btn-success btn-block" runat="server" Text="Guardar" OnClick="btnGuardar_Click"  />

                        </div>
                        </div>
                           
                           
                            
                       <div class="modal-footer">
                             
                        
                       </div>

                           <div class="trans text-center"> 
                                 <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">Cerrar</button>
                    
                               </div>

                   </div>
               </ContentTemplate>
           </asp:UpdatePanel>
       </div>
</div>      
 



  

</asp:Content>
