using LocaLux_GestActivite.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Ocsp;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Exceptions;


namespace LocaLux_GestActivite
{
    public partial class ControleForm : Form
    {
        //connexion à la BD
        LocaluxContext cnx = new LocaluxContext();
        private Utilisateur lEmployer;
        private Reservation laLocation;

        public ControleForm(Utilisateur lEmployer, Reservation laLoca)
        {
            InitializeComponent();
            this.lEmployer = lEmployer;
            this.laLocation = laLoca;
        }


        private void ControleForm_Load(object sender, EventArgs e)
        {

            Reservation? uneReservation = cnx.Reservations
                .Include(u => u.LaVoiture)
                .ThenInclude(v => v.LeModele)
                .ThenInclude(m => m.Pieces)
                .Include(i => i.LeClient)
                .Include(v => v.LeControle)
                .SingleOrDefault(e => e.Id == this.laLocation.Id);


            lbNumLoca.Text = "Num Location:  " + uneReservation.Id;
            lbImmat.Text = "Immatriculation:  " + uneReservation.LaVoiture.Immatriculation;
            lbClient.Text = "Client:  " + uneReservation.LeClient.Nom + " " + uneReservation.LeClient.Prenom;
            lbNumClient.Text = "Num Client:  " + uneReservation.LeClient.Id;
            lbModele.Text = "Modèle:  " + uneReservation.LaVoiture.LeModele.Libelle;



            if (uneReservation != null && uneReservation.LaVoiture.LeModele != null && uneReservation.LaVoiture.LeModele.Pieces != null)
            {
                string[] newCarParts = uneReservation.LaVoiture.LeModele.Pieces.Select(p => p.Libelle).ToArray();
                AddCarPartsAndCheckboxesWithStateLabels(newCarParts);
            }

            if (uneReservation.LeControle != null)
            {
                lbDateHeure.Text = uneReservation.LeControle.DateHeure.ToString("dd/MM/yyyy HH:mm:ss");
                lbControleNumEmployer.Text = "Contrôle réaliser par:  " + uneReservation.LeControle.EmployeVerif.Prenom + " " + uneReservation.LeControle.EmployeVerif.Nom;
                nudKilometrage.Value = uneReservation.LeControle.KilometrageRetour;
                nudKilometrage.ReadOnly = true;
                nudCoutReparation.Value = (decimal)uneReservation.LeControle.CoutReparation;
                nudCoutReparation.ReadOnly = true;
                tbxObservation.Text = uneReservation.LeControle.Observation;
                tbxObservation.ReadOnly = true;
            }
            else
            {
                lbDateHeure.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                lbControleNumEmployer.Text = "Contrôle réaliser par:  " + lEmployer.Prenom + " " + lEmployer.Nom;
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Reservation? uneReservation = cnx.Reservations.Include(u => u.LaVoiture).Include(i => i.LeClient).Include(v => v.LeControle).SingleOrDefault(e => e.Id == (this.laLocation.Id));

            Utilisateur unUtilisateur = lEmployer;

            if (uneReservation.LeControle == null)
            {
                Controle leControle = new Controle();
                {
                    leControle.DateHeure = DateTime.Now;
                    leControle.KilometrageRetour = (int)nudKilometrage.Value;
                    leControle.CoutReparation = (double)nudCoutReparation.Value;
                    leControle.KilometrageEffectue = ((int)nudKilometrage.Value - uneReservation.LaVoiture.Kilometrage);
                    leControle.Observation = tbxObservation.Text;
                    leControle.EmployeVerifId = this.lEmployer.Id;
                }

                uneReservation.LeControle = leControle;

                cnx.SaveChanges();

                var pieces = uneReservation.LaVoiture.LeModele.Pieces.ToList();

                for (int i = 0; i < tableLayoutPanel1.RowCount - 1; i++) // Subtract 1 to skip the state labels row
                {
                    Piece piece = pieces[i]; // Access by index directly
                    TypeDegat typeDegat = null; // Initialize to null

                    // Determine the TypeDegat based on which checkbox is checked
                    for (int j = 0; j < 3; j++)
                    {
                        CheckBox checkbox = (CheckBox)tableLayoutPanel1.GetControlFromPosition(j + 1, i + 1);
                        if (checkbox.Checked)
                        {
                            // Attempt to cast the Tag to PieceTypeDegat
                            PieceTypeDegat pieceTypeDegat = checkbox.Tag as PieceTypeDegat;
                            if (pieceTypeDegat != null)
                            {
                                // Now you can access the TypeDegat property of the PieceTypeDegat object
                                typeDegat = pieceTypeDegat.TypeDegat;
                                break;
                            }
                        }
                    }

                    if (typeDegat != null)
                    {
                        // Create a Verification instance
                        Verification verification = new Verification
                        {
                            IdPieceId = piece.Id,
                            IdDegatId = typeDegat.Id,
                            IdControleId = leControle.Id // Assuming leControle has been saved and has an ID
                        };

                        // Add the Verification to the context
                        cnx.Verifications.Add(verification);
                    }
                }

                // Save the changes to the database
                cnx.SaveChanges();

                MessageBox.Show("Contrôle enregistré avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ce contrôle a déjà été effectué", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private Dictionary<int, List<CheckBox>> rowCheckboxes = new Dictionary<int, List<CheckBox>>();

        public class PieceTypeDegat
        {
            public Piece Piece { get; set; }
            public TypeDegat TypeDegat { get; set; }
        }

        private void AddCarPartsAndCheckboxesWithStateLabels(string[] carParts)
        {
            Reservation? uneReservation = cnx.Reservations.Include(u => u.LaVoiture).Include(i => i.LeClient).Include(v => v.LeControle).SingleOrDefault(e => e.Id == (this.laLocation.Id));

            // Clear existing controls and reset the dictionary
            tableLayoutPanel1.Controls.Clear();
            rowCheckboxes.Clear();
            tableLayoutPanel1.RowCount = carParts.Length + 1; // Add 1 for the state labels
            tableLayoutPanel1.ColumnCount = 4; // 1 for part names, 3 for states

            // Add state labels
            for (int i = 0; i < 3; i++)
            {
                Label stateLabel = new Label
                {
                    Text = new[] { "RS", "RP", "EC" }[i],
                    AutoSize = true,
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel1.Controls.Add(stateLabel, i + 1, 0); // Column i+1, Row 0
            }

            // for each row
            for (int i = 0; i < carParts.Length; i++)
            {
                // Add a label for the part name
                Label partLabel = new Label
                {
                    Text = carParts[i],
                    AutoSize = true,
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel1.Controls.Add(partLabel, 0, i + 1); // Column 0, Row i+1

                // add 3 checkboxes
                for (int j = 0; j < 3; j++)
                {
                    CheckBox checkbox = new CheckBox
                    {
                        AutoSize = true,
                        Dock = DockStyle.Fill
                    };
                    // Check if the control has already been saved
                    if (uneReservation.LeControle != null)
                    {
                        // Fetch the saved verification for the current part
                        var verification = cnx.Verifications
                            .Where(v => v.IdControleId == uneReservation.LeControle.Id && v.IdPieceId == uneReservation.LaVoiture.LeModele.Pieces.ElementAt(i).Id)
                            .FirstOrDefault();

                        if (verification != null)
                        {
                            if (verification.IdDegatId == j + 1)
                            {
                                checkbox.Checked = true;
                            }
                        }
                        checkbox.Enabled = false;
                    }
                    else
                    {
                        checkbox.CheckedChanged += Checkbox_CheckedChanged; // Attach event handler

                        // Fetch TypeDegats into memory first
                        var typeDegats = cnx.TypeDegats.ToList();

                        // Assuming you have a way to determine the TypeDegat for each checkbox
                        TypeDegat typeDegat = typeDegats.ElementAt(j); // This might need adjustment based on your actual data model

                        // Set the Tag to an instance of PieceTypeDegat
                        checkbox.Tag = new PieceTypeDegat
                        {
                            Piece = uneReservation.LaVoiture.LeModele.Pieces.ElementAt(i), // Assuming the order matches the checkboxes
                            TypeDegat = typeDegat
                        };
                    }

                    tableLayoutPanel1.Controls.Add(checkbox, j + 1, i + 1); // Column j+1, Row i+1

                    // Add the checkbox to the row's list
                    if (!rowCheckboxes.ContainsKey(i))
                    {
                        rowCheckboxes[i] = new List<CheckBox>();
                    }
                    rowCheckboxes[i].Add(checkbox);
                }
            }
        }



        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            // Find the row index of the checkbox
            int rowIndex = -1;
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(j, i) == checkbox)
                    {
                        rowIndex = i - 1; // Subtract 1 to account for the state labels row
                        break;
                    }
                }
                if (rowIndex != -1) break;
            }

            if (rowIndex != -1 && rowCheckboxes.ContainsKey(rowIndex))
            {
                // Uncheck all other checkboxes in the same row
                foreach (var otherCheckbox in rowCheckboxes[rowIndex])
                {
                    if (otherCheckbox != checkbox)
                    {
                        otherCheckbox.Checked = false;
                    }
                }
            }

            // Perform other actions based on the checkbox state
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
            new LocationNonControllerForm((Utilisateur)this.lEmployer).Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

            // Step 1: Get the path of the special folder
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Step 2: Combine the path with the file name
            string filePath = Path.Combine(desktopPath, "Constat_Etat_Voiture_Location_" + this.laLocation.Id + ".pdf");

            // Step 3: Create a PdfWriter object
            PdfWriter writer = new PdfWriter(filePath);

            // Step 4: Create a PdfDocument object
            PdfDocument pdf = new PdfDocument(writer);

            // Step 5: Create a Document object
            Document document = new Document(pdf);

            // Add a header to the document
            Paragraph header = new Paragraph("Constat, Etat de la Voiture")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20);
            document.Add(header);

            // Add reservation details
            Paragraph reservationDetails = new Paragraph()
                .Add("Num Location: " + lbNumLoca.Text + "\n")
                .Add("Immatriculation: " + lbImmat.Text + "\n")
                .Add("Client: " + lbClient.Text + "\n")
                .Add("Num Client: " + lbNumClient.Text + "\n")
                .Add("Modèle: " + lbModele.Text + "\n");
            document.Add(reservationDetails);

            // Add control details if available
            if (lbDateHeure.Text != string.Empty && lbControleNumEmployer.Text != string.Empty)
            {
                Paragraph controlDetails = new Paragraph()
                    .Add("Date et Heure: " + lbDateHeure.Text + "\n")
                    .Add("Contrôle réaliser par: " + lbControleNumEmployer.Text + "\n")
                    .Add("Kilometrage Retour: " + nudKilometrage.Value.ToString() + "\n")
                    .Add("Cout Reparation: " + nudCoutReparation.Value.ToString() + "\n")
                    .Add("Observation: " + tbxObservation.Text + "\n");
                document.Add(controlDetails);
            }

            // Close the document
            document.Close();

            // Optionally, show a message to the user
            MessageBox.Show("PDF généré avec succès dans vos documents.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
