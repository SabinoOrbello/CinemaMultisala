using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private const int MaxSeatsPerRoom = 120;

        // Dizionario per tracciare il numero di biglietti venduti per ogni sala
        private Dictionary<string, int> soldTicketsPerRoom = new Dictionary<string, int>
        {
            {"SALA NORD", 0},
            {"SALA EST", 0},
            {"SALA SUD", 0}
        };

        // Dizionario per tracciare il numero di biglietti venduti di tipo ridotto per ogni sala
        private Dictionary<string, int> soldReducedTicketsPerRoom = new Dictionary<string, int>
        {
            {"SALA NORD", 0},
            {"SALA EST", 0},
            {"SALA SUD", 0}
        };

        protected void btnSellTicket_Click(object sender, EventArgs e)
        {
            // Ottieni le informazioni del cliente
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            // Ottieni la sala e il tipo di biglietto
            string room = ddlRoom.SelectedValue;
            string ticketType = ddlTicketType.SelectedValue;

            // Effettua la vendita del biglietto e aggiorna il numero di biglietti venduti
            SellTicket(firstName, lastName, room, ticketType);

            txtFirstName.Text = "";
            txtLastName.Text = "";
            ddlRoom.SelectedIndex = 0; 
            ddlTicketType.SelectedIndex = 0;
        }

        private void SellTicket(string firstName, string lastName, string room, string ticketType)
        {
            if (soldTicketsPerRoom[room] < MaxSeatsPerRoom)
            {
                // Incrementa il numero di biglietti venduti per la sala
                soldTicketsPerRoom[room]++;

                // Incrementa il numero di biglietti venduti di tipo ridotto se necessario
                if (ticketType == "Ridotto")
                {
                    soldReducedTicketsPerRoom[room]++;
                }

                // Mostra il riepilogo
                ShowSummary(firstName, lastName, room, ticketType);
            }
            else
            {
                // Avvisare l'utente che la sala è piena
                lblTicketSummary.Text = $"La sala {room} è al completo. Scegli un'altra sala.";
            }
        }

        private void ShowSummary(string firstName, string lastName, string room, string ticketType)
        {
            // Mostra il riepilogo delle vendite
            lblTicketSummary.Text = $"Biglietto venduto a {firstName} {lastName} per {room}, tipo: {ticketType}.<br>";
            lblTicketSummary.Text += $"Biglietti venduti in {room}: {soldTicketsPerRoom[room]} " +
                                     $"(Intero: {soldTicketsPerRoom[room] - soldReducedTicketsPerRoom[room]}, " +
                                     $"Ridotto: {soldReducedTicketsPerRoom[room]})";
        }
    }
}