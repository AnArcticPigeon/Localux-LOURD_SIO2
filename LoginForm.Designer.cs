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
            btnConnection = new Button();
            tbxPass = new TextBox();
            tbxLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lbResultatMdp = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbResultatMdp);
            groupBox1.Controls.Add(btnConnection);
            groupBox1.Controls.Add(tbxPass);
            groupBox1.Controls.Add(tbxLogin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(139, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 355);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Se Connecter";
            // 
            // btnConnection
            // 
            btnConnection.Location = new Point(192, 205);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(142, 23);
            btnConnection.TabIndex = 4;
            btnConnection.Text = "Se Connecter";
            btnConnection.UseVisualStyleBackColor = true;
            btnConnection.Click += btnConnection_Click;
            // 
            // tbxPass
            // 
            tbxPass.Location = new Point(251, 140);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(100, 23);
            tbxPass.TabIndex = 3;
            // 
            // tbxLogin
            // 
            tbxLogin.Location = new Point(251, 95);
            tbxLogin.Name = "tbxLogin";
            tbxLogin.Size = new Size(100, 23);
            tbxLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 140);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Mots de passe:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 98);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Identifiant:";
            // 
            // lbResultatMdp
            // 
            lbResultatMdp.AutoSize = true;
            lbResultatMdp.Location = new Point(251, 166);
            lbResultatMdp.Name = "lbResultatMdp";
            lbResultatMdp.Size = new Size(0, 15);
            lbResultatMdp.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}