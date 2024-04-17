using LocaLux_GestActivite.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocaLux_GestActivite
{
    public partial class ControleForm : Form
    {
        //connexion à la BD
        LocaluxContext cnx = new LocaluxContext();
        public ControleForm()
        {
            InitializeComponent();
        }

        private void ControleForm_Load(object sender, EventArgs e)
        {
            cbbIdLocation.DataSource = cnx.Reservations.ToList();

            cbbIdLocation.DisplayMember = "Id";

            cbbIdLocation.ValueMember = "Id";
            string[] initialCarParts = { "Engine", "Brakes", "Tires" };
            AddCarPartButtons(initialCarParts);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbbIdLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbIdLocation.SelectedIndex >= 0)

            {
                //On récupère la location choisi dans la liste

                // Adjust the query to include LeModele and its Pieces
                Reservation? uneReservation = cnx.Reservations
                    .Include(u => u.LaVoiture)
                    .ThenInclude(v => v.LeModele) // Include LeModele
                    .ThenInclude(m => m.Pieces) // Include Pieces of LeModele
                    .Include(i => i.LeClient)
                    .Include(v => v.LeControle)
                    .SingleOrDefault(e => e.Id == ((Reservation)cbbIdLocation.SelectedItem).Id);

                lbImmat.Text = "Immatriculation:  " + uneReservation.LaVoiture.Immatriculation;
                lbClient.Text = "Client:  " + uneReservation.LeClient.Nom + " " + uneReservation.LeClient.Prenom;
                lbNumClient.Text = "Num Client:  " + uneReservation.LeClient.Id;
                //lbModele.Text = "Modèle:  " + uneReservation.LaVoiture.LeModele.Id;

                if (uneReservation != null && uneReservation.LaVoiture.LeModele.Pieces != null)
                {
                    string[] newCarParts = uneReservation.LaVoiture.LeModele.Pieces.Select(p => p.Libelle).ToArray();
                    AddCarPartButtons(newCarParts);
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Reservation? uneReservation = cnx.Reservations.Include(u => u.LaVoiture).Include(i => i.LeClient).Include(v => v.LeControle).SingleOrDefault(e => e.Id == ((Reservation)cbbIdLocation.SelectedItem).Id);

            Controle leControle = new Controle();
            {
                leControle.DateHeure = DateTime.Now;
                leControle.KilometrageRetour = (int)nudKilometrage.Value;
                leControle.CoutReparation = (double)nudCoutReparation.Value;
                leControle.KilometrageEffectue = ((int)nudKilometrage.Value - uneReservation.LaVoiture.Kilometrage);
                leControle.Observation = tbxObservation.Text;

            }

            uneReservation.LeControle = leControle;

            cnx.SaveChanges();
        }

        private void AddCarPartButtons(string[] carParts)
        {
            // Assuming you're using a FlowLayoutPanel named flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear(); // Clear existing buttons

            foreach (var part in carParts)
            {
                // Create a container for the part's buttons
                Panel partPanel = new Panel
                {
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink
                };

                // Add buttons for each state
                foreach (var state in new[] { "Damaged", "Scratched", "Undamaged" })
                {
                    Button button = new Button
                    {
                        Text = $"{part} - {state}",
                        AutoSize = true,
                        Tag = new { Part = part, State = state } // Store part and state information in the Tag for later use
                    };
                    button.Click += CarPartButton_Click; // Handle the button click event
                    partPanel.Controls.Add(button);
                }

                flowLayoutPanel1.Controls.Add(partPanel);
            }
        }

        private void CarPartButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var tag = (dynamic)button.Tag;
            string part = tag.Part;
            string state = tag.State;

            // Perform action based on the selected part and state
            MessageBox.Show($"You selected: {part} - {state}");
        }

    }
}
