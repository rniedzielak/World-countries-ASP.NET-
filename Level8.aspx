<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Level8.aspx.cs" Inherits="GraWPanstwa.Poziomy.Level8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Poziom 8</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center"> 
            POZIOM 8
            <br />
            <br />
            <asp:Label ID="lblStatus" runat="server" Text=" "></asp:Label>
        </div>
        <br />
         <div style="text-align:center">
             <asp:Panel ID="buttons" runat="server"></asp:Panel>
             <br />             
             <br />
            <asp:TextBox ID="txtAnswear" Enabled="false" Width="150" runat="server"></asp:TextBox>
             <br />
             <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Zatwierdź" />
             <br />
             <asp:Button ID="btnBackspace" OnClick="btnBackspace_Click" runat="server" Text="Cofnij" />
             <br />
             <asp:Label ID="lblMessage" runat="server" />           
</div>

    </form>
</body>
</html>
