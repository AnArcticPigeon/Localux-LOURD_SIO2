using LocaLux_GestActivite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LocaLux_GestActivite
{
    public partial class LocationNonControllerForm : Form
    {
        //connexion à la BD
        LocaluxContext cnx = new LocaluxContext();

        private Utilisateur lEmployer;

        public LocationNonControllerForm(Utilisateur lEmployer)
        {
            InitializeComponent();

            this.lEmployer = lEmployer;
        }

        public class ListBoxItem
        {
            public string Text { get; set; }
            public object Tag { get; set; }

            public ListBoxItem(string text, object tag)
            {
                Text = text;
                Tag = tag;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void LocationNonControllerForm_Load(object sender, EventArgs e)
        {
            List<Reservation> reservations = cnx.Reservations.Include(u => u.LaVoiture)
                .ThenInclude(v => v.LeModele)
                .ThenInclude(m => m.Pieces)
                .Include(i => i.LeClient)
                .Include(v => v.LeControle).ToList();


            foreach (Reservation uneReservation in reservations)
            {
                if (uneReservation.LeControle == null)
                {
                    var uneRes = "Reservation n°:    " + uneReservation.Id + "   |   Immat: " + uneReservation.LaVoiture.Immatriculation + "    |    Client: " + uneReservation.LeClient.Nom + "   " + uneReservation.LeClient.Prenom;
                    listBox1.Items.Add(new ListBoxItem(uneRes, uneReservation));
                }
                else
                {
                    var uneRes = "Reservation n°:    " + uneReservation.Id + "   |   Immat: " + uneReservation.LaVoiture.Immatriculation + "    |    Client: " + uneReservation.LeClient.Nom + "   " + uneReservation.LeClient.Prenom;
                    listBox2.Items.Add(new ListBoxItem(uneRes, uneReservation));
                }


            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.ClearSelected();
        }

        private void btnControle_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem is ListBoxItem selectedItem && selectedItem.Tag is Reservation laLoca)
            {
                ControleForm controleForm = new ControleForm(this.lEmployer, laLoca);
                controleForm.Show();
                this.Close();
            }

            if (listBox2.SelectedItem is ListBoxItem selectedItem2 && selectedItem2.Tag is Reservation laLoca2)
            {
                ControleForm controleForm = new ControleForm(this.lEmployer, laLoca2);
                controleForm.Show();
                this.Close();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
        }
    }
}
