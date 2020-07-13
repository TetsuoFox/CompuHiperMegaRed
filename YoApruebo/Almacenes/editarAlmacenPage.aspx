<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="editarAlmacenPage.aspx.cs" Inherits="SuperMundoHiperMegaRed.Almacenes.editarAlmacenPage" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Editar Almacenes</h2>
    <br />
    <h4>Presione la fila que desea editar</h4>
    <div class="card card-body">

          <asp:GridView ID="GridView1" class="table"  
    runat="server" AutoGenerateColumns="false" OnRowDataBound = "OnRowDataBound" OnSelectedIndexChanged = "OnSelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="Almacen" HeaderText="Nombre Almacen"  />
        <asp:BoundField DataField="Estado" HeaderText="Esta Activo" />
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
                        <span class="input-group-text" id="basic-addon1">Nombre</span>
                        </div>
                            <asp:Label ID="lblId" runat="server" Text="" Hidden="true" ></asp:Label>
                        <asp:TextBox class="form-control" ID="txtNombreAlmacen" runat="server" placeholder="Bodega Stgo" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="row">
                        <div class="col-sm-4">
                        <div class="form-check">
                        <asp:CheckBox Text="-  Esta Activo" ID="chkActivo" runat="server" class="form-check-input" AutoPostBack="true" value="Esta Activo" />
                        </div>
                        </div>
                        <div class="col-sm-2"></div>
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
