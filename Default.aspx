
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GraWPanstwa.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Państwa Świata by Rafał Niedzielak</title>
</head>
<body>
    <form id="form1" runat="server">

 <div style="text-align:center"> 
  GRA W
     <br />
  PAŃSTWA ŚWIATA
 </div>
        <br />
 <div style="text-align:center">
    Czy chcesz zacząć rozgrywkę?
     <br />
     <asp:Button ID="btnTak" Width="89px" OnClick="btnTak_Click" runat="server" Text="TAK"/> &nbsp; &nbsp;
     <asp:Button ID="btnNie" Width="89px" OnClick="btnNie_Click" runat="server" Text="NIE"/>
     <br />
     <br />
     <asp:Label ID="lblLogin" Visible="false" runat="server" Text="Login:"></asp:Label>&nbsp &nbsp
     <asp:TextBox ID="txtLogin" Visible="false" runat="server"></asp:TextBox> 
     <br />
     <asp:Label ID="lblError" Visible ="false" Font-Italic="true" ForeColor="Red" runat="server" Text="Niewłaściwa nazwa"></asp:Label>
     <br />
     <asp:Button ID="btnGracz" Visible="false" OnClick="btnGracz_Click" runat="server" Text="Stwórz Gracza" />
 </div>

    </form>
</body>
</html>
