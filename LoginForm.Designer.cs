namespace LocaLux_GestActivite
{
    partial class LoginForm
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
            groupBox1 = new GroupBox();
            gbxOTP = new GroupBox();
            lbOTPresult = new Label();
            btnOTP = new Button();
            label5 = new Label();
            tbxOtp = new TextBox();
            gpbNewPwd = new GroupBox();
            lbDifferentPwd = new Label();
            label4 = new Label();
            tbxNewPwd2 = new TextBox();
            btnSaveNewPwd = new Button();
            label3 = new Label();
            tbxNewPwd1 = new TextBox();
            btnChangePwd = new Button();
            lbResultatMdp = new Label();
            btnConnection = new Button();
            tbxPass = new TextBox();
            tbxLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            gbxOTP.SuspendLayout();
            gpbNewPwd.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChangePwd);
            groupBox1.Controls.Add(lbResultatMdp);
            groupBox1.Controls.Add(btnConnection);
            groupBox1.Controls.Add(tbxPass);
            groupBox1.Controls.Add(tbxLogin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(139, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Se Connecter";
            // 
            // gbxOTP
            // 
            gbxOTP.Controls.Add(lbOTPresult);
            gbxOTP.Controls.Add(btnOTP);
            gbxOTP.Controls.Add(label5);
            gbxOTP.Controls.Add(tbxOtp);
            gbxOTP.Location = new Point(139, 203);
            gbxOTP.Name = "gbxOTP";
            gbxOTP.Size = new Size(200, 125);
            gbxOTP.TabIndex = 10;
            gbxOTP.TabStop = false;
            gbxOTP.Text = "OTP";
            // 
            // lbOTPresult
            // 
            lbOTPresult.AutoSize = true;
            lbOTPresult.Location = new Point(70, 48);
            lbOTPresult.Name = "lbOTPresult";
            lbOTPresult.Size = new Size(0, 15);
            lbOTPresult.TabIndex = 11;
            // 
            // btnOTP
            // 
            btnOTP.Location = new Point(61, 66);
            btnOTP.Name = "btnOTP";
            btnOTP.Size = new Size(75, 23);
            btnOTP.TabIndex = 10;
            btnOTP.Text = "Valider Code";
            btnOTP.UseVisualStyleBackColor = true;
            btnOTP.Click += btnOTP_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 23);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 9;
            label5.Text = "Code OTP";
            // 
            // tbxOtp
            // 
            tbxOtp.Location = new Point(76, 20);
            tbxOtp.Name = "tbxOtp";
            tbxOtp.Size = new Size(100, 23);
            tbxOtp.TabIndex = 8;
            // 
            // gpbNewPwd
            // 
            gpbNewPwd.Controls.Add(lbDifferentPwd);
            gpbNewPwd.Controls.Add(label4);
            gpbNewPwd.Controls.Add(tbxNewPwd2);
            gpbNewPwd.Controls.Add(btnSaveNewPwd);
            gpbNewPwd.Controls.Add(label3);
            gpbNewPwd.Controls.Add(tbxNewPwd1);
            gpbNewPwd.Location = new Point(351, 203);
            gpbNewPwd.Name = "gpbNewPwd";
            gpbNewPwd.Size = new Size(275, 125);
            gpbNewPwd.TabIndex = 7;
            gpbNewPwd.TabStop = false;
            gpbNewPwd.Text = "Nouveau Mots de Passe";
            // 
            // lbDifferentPwd
            // 
            lbDifferentPwd.AutoSize = true;
            lbDifferentPwd.Location = new Point(38, 83);
            lbDifferentPwd.Name = "lbDifferentPwd";
            lbDifferentPwd.Size = new Size(0, 15);
            lbDifferentPwd.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 54);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 6;
            label4.Text = "Confirmer MDP";
            // 
            // tbxNewPwd2
            // 
            tbxNewPwd2.Location = new Point(128, 51);
            tbxNewPwd2.Name = "tbxNewPwd2";
            tbxNewPwd2.Size = new Size(100, 23);
            tbxNewPwd2.TabIndex = 5;
            // 
            // btnSaveNewPwd
            // 
            btnSaveNewPwd.Location = new Point(142, 96);
            btnSaveNewPwd.Name = "btnSaveNewPwd";
            btnSaveNewPwd.Size = new Size(75, 23);
            btnSaveNewPwd.TabIndex = 4;
            btnSaveNewPwd.Text = "Enregistrer";
            btnSaveNewPwd.UseVisualStyleBackColor = true;
            btnSaveNewPwd.Click += btnSaveNewPwd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 25);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 3;
            label3.Text = "Nouveau MDP";
            // 
            // tbxNewPwd1
            // 
            tbxNewPwd1.Location = new Point(128, 22);
            tbxNewPwd1.Name = "tbxNewPwd1";
            tbxNewPwd1.Size = new Size(100, 23);
            tbxNewPwd1.TabIndex = 1;
            // 
            // btnChangePwd
            // 
            btnChangePwd.Location = new Point(201, 127);
            btnChangePwd.Name = "btnChangePwd";
            btnChangePwd.Size = new Size(110, 23);
            btnChangePwd.TabIndex = 6;
            btnChangePwd.Text = "Changer Mdp";
            btnChangePwd.UseVisualStyleBackColor = true;
            btnChangePwd.Click += btnChangePwd_Click;
            // 
            // lbResultatMdp
            // 
            lbResultatMdp.AutoSize = true;
            lbResultatMdp.Location = new Point(256, 110);
            lbResultatMdp.Name = "lbResultatMdp";
            lbResultatMdp.Size = new Size(0, 15);
            lbResultatMdp.TabIndex = 5;
            // 
            // btnConnection
            // 
            btnConnection.Location = new Point(180, 98);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(142, 23);
            btnConnection.TabIndex = 4;
            btnConnection.Text = "Se Connecter";
            btnConnection.UseVisualStyleBackColor = true;
            btnConnection.Click += btnConnection_Click;
            // 
            // tbxPass
            // 
            tbxPass.Location = new Point(256, 69);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(100, 23);
            tbxPass.TabIndex = 3;
            // 
            // tbxLogin
            // 
            tbxLogin.Location = new Point(256, 39);
            tbxLogin.Name = "tbxLogin";
            tbxLogin.Size = new Size(100, 23);
            tbxLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 72);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Mots de passe:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 42);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Identifiant:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpbNewPwd);
            Controls.Add(gbxOTP);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxOTP.ResumeLayout(false);
            gbxOTP.PerformLayout();
            gpbNewPwd.ResumeLayout(false);
            gpbNewPwd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button btnConnection;
        private TextBox tbxPass;
        private TextBox tbxLogin;
        private Label lbResultatMdp;
        private Button btnChangePwd;
        private GroupBox gpbNewPwd;
        private Label label3;
        private TextBox tbxNewPwd1;
        private Button btnSaveNewPwd;
        private Label lbDifferentPwd;
        private Label label4;
        private TextBox tbxNewPwd2;
        private TextBox tbxOtp;
        private GroupBox gbxOTP;
        private Label lbOTPresult;
        private Button btnOTP;
        private Label label5;
    }
}