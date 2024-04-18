using LocaLux_GestActivite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using OtpNet;
using QRCoder;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using MimeKit.Utils;
using MimeKit;
using MailKit.Net.Smtp;

namespace LocaLux_GestActivite
{
    public partial class AjoutUtilisateurForm : Form
    {
        //connexion à la BD
        LocaluxContext cnx = new LocaluxContext();
        public AjoutUtilisateurForm()
        {
            InitializeComponent();
        }

        private void AjoutUtilisateurForm_Load(object sender, EventArgs e)
        {
            /*
            Utilisateur? unUtilisateur = (Utilisateur?)cnx.Utilisateurs.Where(e => e.Login == "totp").SingleOrDefault();
            ///// generation secret otp

            var key = KeyGeneration.GenerateRandomKey(20);

            var base32String = Base32Encoding.ToString(key);

            unUtilisateur.CodeOtp = base32String;
            cnx.SaveChanges();

            //// generation du QR Code

            var uriString = new OtpUri(OtpType.Totp, base32String, unUtilisateur.Email, "SAVARY").ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            QRCodeData qrCodeData = qrGenerator.CreateQrCode(uriString, QRCodeGenerator.ECCLevel.Q);

            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(2);

            // affichage dur QR code

            pictureBoxQRCode.Image = qrCodeImage;
            */
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = new Utilisateur

            {

                Nom = tbxNom.Text,

                Prenom = tbxPrenom.Text,

                Email = tbxEmail.Text,

            };

            AncienMdp ancienMdp = new AncienMdp();

            SHA512 sha512 = SHA512.Create();

            //sel aleatoire

            byte[] textAsByte = Encoding.Default.GetBytes(DateTime.Now.ToString());

            byte[] hash = sha512.ComputeHash(textAsByte);

            utilisateur.Sel = Convert.ToHexString(hash).ToLower().Substring(1, 8);

            //mot de passe

            textAsByte = Encoding.Default.GetBytes(tbxMdp.Text + utilisateur.Sel);

            hash = sha512.ComputeHash(textAsByte);

            utilisateur.Mdp = Convert.ToHexString(hash).ToLower();


            ///// generation secret otp

            var key = KeyGeneration.GenerateRandomKey(20);

            var base32String = Base32Encoding.ToString(key);

            utilisateur.CodeOtp = base32String;

            ///creationde l'utilisateur

            cnx.Utilisateurs.Add(utilisateur);

            cnx.SaveChanges();


            //// generation du QR Code

            var uriString = new OtpUri(OtpType.Totp, base32String, utilisateur.Email, "SAVARY").ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            QRCodeData qrCodeData = qrGenerator.CreateQrCode(uriString, QRCodeGenerator.ECCLevel.Q);

            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(2);

            // affichage dur QR code

            pictureBoxQRCode.Image = qrCodeImage;

            //// envoi email

            var email = new MimeMessage();

            email.From.Add(MailboxAddress.Parse("test@sio-savary.fr"));

            email.To.Add(MailboxAddress.Parse(utilisateur.Email));

            email.Subject = "Votre QRCode de connexion";

            Stream memoryStream = new MemoryStream();

            qrCodeImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

            var builder = new BodyBuilder();

            memoryStream.Seek(0, SeekOrigin.Begin);

            var image = builder.LinkedResources.Add("qrcode.jpg", memoryStream);

            image.ContentId = MimeUtils.GenerateMessageId();

            builder.HtmlBody = string.Format(@"{0}<br><img src='cid:{1}'>", "Votre QRCode de connexion", image.ContentId);

            email.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();

            smtp.Connect("smtp.ac-nantes.fr", 465);

            smtp.Send(email);

            smtp.Disconnect(true);

        }
    }
}
