<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exTreeView.aspx.cs" Inherits="SuperMundoHiperMegaRed.exTreeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

       <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TreeDBConnectionString %>" SelectCommand="SELECT * FROM [treeview]">
        </asp:SqlDataSource>--%>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Server=sql5046.site4now.net;Database=DB_A62E4D_inacap2020;UID=DB_A62E4D_inacap2020_admin;Password=Lindi2020" SelectCommand="SELECT * FROM [treeview]">
        </asp:SqlDataSource>
        <asp:TreeView ID="TreeView1" runat="server"   
            DataSourceID="SqlDataSource1"
            DataTextField="Menu"
            DataIdField="ID"
            DataParentIdField="ID_PADRE"
            DataHasChildField="tiene_hijo"
            DataExpandedField="Expanded">
        </asp:TreeView>
    
    </div>
    </form>
</body>
</html>
         <%--   ConnectionString="<%$ ConnectionStrings:TreeDBConnectionString %>"--%>