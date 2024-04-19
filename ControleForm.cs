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

                    for (int j = 0; j < 3; j++)
                    {
                        CheckBox checkbox = (CheckBox)tableLayoutPanel1.GetControlFromPosition(j + 1, i + 1);
                        if (checkbox.Checked)
                        {
                            PieceTypeDegat pieceTypeDegat = checkbox.Tag as PieceTypeDegat;
                            if (pieceTypeDegat != null)
                            {
                                typeDegat = pieceTypeDegat.TypeDegat;
                                break;
                            }
                        }
                    }

                    if (typeDegat != null)
                    {
                        Verification verification = new Verification
                        {
                            IdPieceId = piece.Id,
                            IdDegatId = typeDegat.Id,
                            IdControleId = leControle.Id
                        };
                        cnx.Verifications.Add(verification);
                    }
                }

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

            tableLayoutPanel1.Controls.Clear();
            rowCheckboxes.Clear();
            tableLayoutPanel1.RowCount = carParts.Length + 1;
            tableLayoutPanel1.ColumnCount = 4;

            // add label degat
            for (int i = 0; i < 3; i++)
            {
                Label stateLabel = new Label
                {
                    Text = new[] { "RS", "RP", "EC" }[i],
                    AutoSize = true,
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel1.Controls.Add(stateLabel, i + 1, 0);
            }

            // for each row in the table
            for (int i = 0; i < carParts.Length; i++)
            {
                // Add label nom piece
                Label partLabel = new Label
                {
                    Text = carParts[i],
                    AutoSize = true,
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel1.Controls.Add(partLabel, 0, i + 1);

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
                        checkbox.CheckedChanged += Checkbox_CheckedChanged;

                        var typeDegats = cnx.TypeDegats.ToList();

                        TypeDegat typeDegat = typeDegats.ElementAt(j);

                        checkbox.Tag = new PieceTypeDegat
                        {
                            Piece = uneReservation.LaVoiture.LeModele.Pieces.ElementAt(i),
                            TypeDegat = typeDegat
                        };
                    }

                    tableLayoutPanel1.Controls.Add(checkbox, j + 1, i + 1); 

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
                        rowIndex = i - 1;
                        break;
                    }
                }
                if (rowIndex != -1) break;
            }

            if (rowIndex != -1 && rowCheckboxes.ContainsKey(rowIndex))
            {
                // Uncheck all other checkboxes on the same row
                foreach (var otherCheckbox in rowCheckboxes[rowIndex])
                {
                    if (otherCheckbox != checkbox)
                    {
                        otherCheckbox.Checked = false;
                    }
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
            new LocationNonControllerForm((Utilisateur)this.lEmployer).Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string filePath = Path.Combine(desktopPath, "Constat_Etat_Voiture_Location_" + this.laLocation.Id + ".pdf");

            PdfWriter writer = new PdfWriter(filePath);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // header
            Paragraph header = new Paragraph("Constat, Etat de la Voiture")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20);
            document.Add(header);

            // detail reservation
            Paragraph reservationDetails = new Paragraph()
                .Add("Num Location: " + lbNumLoca.Text + "\n")
                .Add("Immatriculation: " + lbImmat.Text + "\n")
                .Add("Client: " + lbClient.Text + "\n")
                .Add("Num Client: " + lbNumClient.Text + "\n")
                .Add("Modèle: " + lbModele.Text + "\n");
            document.Add(reservationDetails);

            // detail controle
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

            document.Close();

            MessageBox.Show("PDF généré avec succès dans vos documents.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
