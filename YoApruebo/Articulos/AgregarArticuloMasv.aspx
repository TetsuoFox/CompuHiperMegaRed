<%@ Page Title="Stock Page" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="AgregarArticuloMasv.aspx.cs" Inherits="YoApruebo._Articulos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div>

	<nav aria-label="breadcrumb">
		<ol class="breadcrumb" style="background-color: rgb(229,240,232)">
			<li class="breadcrumb-item"><a href="../Home.aspx">Inicio</a></li>
			<li class="breadcrumb-item active">Articulos</li>
			<li class="breadcrumb-item active">Agregar Articulos Masivos</li>
		</ol>
	</nav>
	
	<br>
	<div class="card text-center border-secondary">
		<div class="card-header bg-info">
		AGREGAR ARTICULO MASIVO
		</div>
		<div class="card-body bg-light">
			<form role="form">
				<label>PRUEBA</label>
				<input type="text" class="form-control"/>
				<label>PRUEBA</label>
				<input type="text" class="form-control"/>
				<label>PRUEBA</label>
				<input type="text" class="form-control"/>
				<div class="checkbox">
					<label>
						<input type="checkbox" /> administrador
					</label>
				</div> 
				<button type="submit" class="btn btn-primary">
				GUARDAR
				</button>
			</form>
		</div>
	</div>
</div>

</asp:Content>
