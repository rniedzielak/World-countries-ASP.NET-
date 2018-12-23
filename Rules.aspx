<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rules.aspx.cs" Inherits="GraWPanstwa.Baza.Rules" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rules</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tb>
                    <tr>
                        <b>Gra w państwa świata:</b>
                    </tr>
                    <tr>
                        <p>1. Jest 10 poziomów, każdy z ułożonymi losowo literami;</p>
                    </tr>
                    <tr>
                        <p>2. Odpowiedź jest uznana jeżeli wpisane z liter słowo jest istniejącym państwem;</p>
                    </tr>
                    <tr>
                        <p>3. Za państwo z wykorzystaniem wszystkich liter jest maksymalna ilość punktów -5,</p>
                    </tr>
                    <tr>
                        <p>   a każda kolejna litera mniej to o jeden punkt mniej. Jeżeli nie wykorzysta się 5 </p>                            
                    </tr>
                    <tr>
                        <p>   liter bądź więcej, a państwo znajduje się w bazie to przechodzi się do następnego </p>
                    </tr>
                    <tr>
                        <p>   poziomu jednak bez zdobycia punktów.</p>                           
                    </tr>

                </tb>
            </table>
            <br />
            <asp:Button ID="btnDalej" OnClick="btnDalej_Click" runat="server" Text="Dalej" />
        </div>
    </form>
</body>
</html>
