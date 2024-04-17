namespace LocaLux_GestActivite
{
    partial class AjoutUtilisateurForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxNom = new TextBox();
            tbxPrenom = new TextBox();
            tbxEmail = new TextBox();
            tbxMdp = new TextBox();
            btnCreer = new Button();
            pictureBoxQRCode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 81);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 114);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Prenom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 140);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 171);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Mdp";
            // 
            // tbxNom
            // 
            tbxNom.Location = new Point(230, 78);
            tbxNom.Name = "tbxNom";
            tbxNom.Size = new Size(100, 23);
            tbxNom.TabIndex = 4;
            // 
            // tbxPrenom
            // 
            tbxPrenom.Location = new Point(230, 111);
            tbxPrenom.Name = "tbxPrenom";
            tbxPrenom.Size = new Size(100, 23);
            tbxPrenom.TabIndex = 5;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(230, 140);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(100, 23);
            tbxEmail.TabIndex = 6;
            // 
            // tbxMdp
            // 
            tbxMdp.Location = new Point(230, 171);
            tbxMdp.Name = "tbxMdp";
            tbxMdp.Size = new Size(100, 23);
            tbxMdp.TabIndex = 7;
            // 
            // btnCreer
            // 
            btnCreer.Location = new Point(242, 238);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(75, 23);
            btnCreer.TabIndex = 8;
            btnCreer.Text = "Creer";
            btnCreer.UseVisualStyleBackColor = true;
            btnCreer.Click += btnCreer_Click;
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.Location = new Point(474, 114);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(223, 175);
            pictureBoxQRCode.TabIndex = 9;
            pictureBoxQRCode.TabStop = false;
            // 
            // AjoutUtilisateurForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxQRCode);
            Controls.Add(btnCreer);
            Controls.Add(tbxMdp);
            Controls.Add(tbxEmail);
            Controls.Add(tbxPrenom);
            Controls.Add(tbxNom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AjoutUtilisateurForm";
            Text = "AjoutUtilisateurForm";
            Load += AjoutUtilisateurForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbxNom;
        private TextBox tbxPrenom;
        private TextBox tbxEmail;
        private TextBox tbxMdp;
        private Button btnCreer;
        private PictureBox pictureBoxQRCode;
    }
}