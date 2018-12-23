<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="GraWPanstwa.Baza.Summary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Summary</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <p style="text-align:center">Podsumowanie zdobytych punktów:</p>
                <asp:Table ID="tblPodsumowanie" HorizontalAlign="Center" BorderStyle="Solid" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>Login</asp:TableCell>
                        <asp:TableCell>Level</asp:TableCell>
                        <asp:TableCell>Zdobyte Punkty</asp:TableCell>
                        <asp:TableCell>Możliwe do zdobycia</asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            <br />
            <asp:Button ID="btnDalej" style="position:absolute; float:left; margin-left:720px;" OnClick="btnDalej_Click" runat="server" Text="Dalej" />
        </div>
    </form>
</body>
</html>
