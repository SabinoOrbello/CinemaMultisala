<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketBooking.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cinema Multisala</title>
</head>
<body>
     <form id="form1" runat="server">
        <div class="display-flex">
            <h2>Vendita Biglietti</h2>
            <div>
                <label for="txtFirstName">Nome:</label>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtLastName">Cognome:</label>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="ddlRoom">Sala:</label>
                <asp:DropDownList ID="ddlRoom" runat="server">
                    <asp:ListItem Text="SALA NORD" Value="SALA NORD" />
                    <asp:ListItem Text="SALA EST" Value="SALA EST" />
                    <asp:ListItem Text="SALA SUD" Value="SALA SUD" />
                </asp:DropDownList>
            </div>
            <div>
                <label for="ddlTicketType">Tipo di Biglietto:</label>
                <asp:DropDownList ID="ddlTicketType" runat="server">
                    <asp:ListItem Text="Intero" Value="Intero" />
                    <asp:ListItem Text="Ridotto" Value="Ridotto" />
                </asp:DropDownList>
            </div>
            <div>
                <asp:Button ID="btnSellTicket" runat="server" Text="Vendi Biglietto" OnClick="btnSellTicket_Click"/>
            </div>
            <div>
                <asp:Label ID="lblTicketSummary" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
