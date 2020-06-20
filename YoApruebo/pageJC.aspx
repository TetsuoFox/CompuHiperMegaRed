<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pageJC.aspx.cs" Inherits="SuperMundoHiperMegaRed.pageJC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <div>
                    HOLA MUNDIRIJIRIJIRIJIRILLO
                    <asp:Button ID="btn2" runat="server" OnClick="btn2_Click" Text="Button" />
                    <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="Button" />
                    <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <p>
            <asp:Button ID="btn3" runat="server" Text="Button" OnClick="btn3_Click" />
            <asp:Label ID="lbl2" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
