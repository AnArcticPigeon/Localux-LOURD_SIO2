using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocaLux_GestActivite.Models;

namespace LocaLux_GestActivite
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            //connexion à la BD
            LocaluxContext cnx = new LocaluxContext();

            Utilisateur? unUtilisateur = (Utilisateur?)cnx.Utilisateurs.Where(e => e.Login == tbxLogin.Text).SingleOrDefault();

            //hachage avec SHA512 du mot de passe saisi

            //conversion en tableau d'octets

            byte[] textAsByte = Encoding.Default.GetBytes(tbxPass.Text + unUtilisateur?.sel);

            //hachage

            SHA512 sha512 = SHA512.Create();

            byte[] hash = sha512.ComputeHash(textAsByte);

            //mettre dans un format compatible avec MariaDB

            String PwdSaisi = Convert.ToHexString(hash).ToLower();

            if (PwdSaisi == unUtilisateur.Mdp)
            {
                lbResultatMdp.Text = "Correct Password !!!!";
            }
            else if (PwdSaisi != unUtilisateur.Mdp)
            {
                lbResultatMdp.Text = "NEIN NEIN NEIN";
            }
        }


    }
}
