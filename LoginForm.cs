using LocaLux_GestActivite.Models;
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
using OtpNet;
using QRCoder;
using MimeKit;
using MimeKit.Utils;
using MailKit.Net.Smtp;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic.Logging;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace LocaLux_GestActivite
{
    public partial class LoginForm : Form
    {
        //connexion à la BD
        LocaluxContext cnx = new LocaluxContext();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            gbxOTP.Hide();
            gpbNewPwd.Hide();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {

            if (tbxLogin.Text == "")
            {
                MessageBox.Show("Veuillez saisir un login", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cnx.Utilisateurs.SingleOrDefault(e => e.Login == tbxLogin.Text) == null)
            {
                MessageBox.Show("Login incorect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Utilisateur? unUtilisateur = (Utilisateur?)cnx.Utilisateurs.Where(e => e.Login == tbxLogin.Text).SingleOrDefault();

                //hachage avec SHA512 du mot de passe saisi

                //conversion en tableau d'octets

                byte[] textAsByte = Encoding.Default.GetBytes(tbxPass.Text + unUtilisateur?.Sel);

                //hachage

                SHA512 sha512 = SHA512.Create();

                byte[] hash = sha512.ComputeHash(textAsByte);

                //mettre dans un format compatible avec MariaDB

                String PwdSaisi = Convert.ToHexString(hash).ToLower();

                if (PwdSaisi == unUtilisateur.Mdp)
                {
                    lbResultatMdp.Text = "Correct Password !!!!";


                    (new LocationNonControllerForm(unUtilisateur)).Show();
                    this.Hide();
                }
                else if (PwdSaisi != unUtilisateur.Mdp)
                {
                    MessageBox.Show("NEIN NEIN NEIN!; Mots de Passe INCORECTE!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            if (tbxLogin.Text == "")
            {
                MessageBox.Show("Veuillez saisir un login", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cnx.Utilisateurs.SingleOrDefault(e => e.Login == tbxLogin.Text) == null)
            {
                MessageBox.Show("Login incorect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gbxOTP.Show();
            }

        }

        private void btnSaveNewPwd_Click(object sender, EventArgs e)
        {

            Utilisateur? unUtilisateur = cnx.Utilisateurs.Include(u => u.AncienMdps).SingleOrDefault(e => e.Login == tbxLogin.Text);

            if (tbxNewPwd1.Text != tbxNewPwd2.Text)
            {
                lbDifferentPwd.Text = "Les mots de passes saisie ne sont pas identique";
            }
            else
            {
                byte[] textAsByte = Encoding.Default.GetBytes(tbxNewPwd1.Text + unUtilisateur?.Sel);

                //hachage

                SHA512 sha512 = SHA512.Create();

                byte[] hash = sha512.ComputeHash(textAsByte);

                //mettre dans un format compatible avec MariaDB²

                String PwdSaisi = Convert.ToHexString(hash).ToLower();

                ICollection<AncienMdp> lesAncienMdp = unUtilisateur.AncienMdps;

                var lesAncienMdpString = new List<string> { };

                foreach (AncienMdp unAncienMdp in lesAncienMdp)
                {
                    lesAncienMdpString.Add(unAncienMdp.AncienMdp1);
                }

                if (PwdSaisi == unUtilisateur.Mdp || lesAncienMdpString.Contains(PwdSaisi))
                {

                    MessageBox.Show("Mots de passe deja utilisée dans le passer, veuillez en choisir un nouveau.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AncienMdp ancienMdp = new AncienMdp()
                    {

                        DateModifMdp = DateTime.Now,

                        AncienMdp1 = unUtilisateur.Mdp,

                    };

                    unUtilisateur.AncienMdps.Add(ancienMdp);

                    //mot de passe

                    byte[] newTextAsByte = Encoding.Default.GetBytes(tbxNewPwd1.Text + unUtilisateur.Sel);

                    byte[] newHash = sha512.ComputeHash(newTextAsByte);

                    unUtilisateur.Mdp = Convert.ToHexString(newHash).ToLower();

                    cnx.SaveChanges();

                    gpbNewPwd.Hide();

                    MessageBox.Show("Mots de Passe modifier", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnOTP_Click(object sender, EventArgs e)
        {
            Utilisateur? unUtilisateur = (Utilisateur?)cnx.Utilisateurs.Where(e => e.Login == tbxLogin.Text).SingleOrDefault();

            var base32Bytes = Base32Encoding.ToBytes((string)unUtilisateur.CodeOtp);

            var totp = new Totp(base32Bytes);

            bool ok = totp.VerifyTotp(tbxOtp.Text, out long timeWindowUsed);

            if (ok)
            {
                gpbNewPwd.Show();
                gbxOTP.Hide();
            }
            else
            {
                lbOTPresult.Text = "Code incorect";
            }
        }


    }
}
