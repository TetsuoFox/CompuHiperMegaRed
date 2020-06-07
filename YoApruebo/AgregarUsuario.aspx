<%@ Page Title="Report Page" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="YoApruebo._Reportes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
               
                <input type="submit" class="btn btn-success btn-block" name="agregar" value="Agregar Usuario">
            </form>
            </div>
   
        <div>
        </div>

</body>
</asp:Content>