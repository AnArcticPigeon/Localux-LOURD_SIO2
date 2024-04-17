namespace LocaLux_GestActivite
{
    partial class ControleForm
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
            lbModele = new Label();
            lbImmat = new Label();
            lbNumClient = new Label();
            lbClient = new Label();
            groupBox1 = new GroupBox();
            nudKilometrage = new NumericUpDown();
            textBox4 = new TextBox();
            tbxObservation = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label11 = new Label();
            btnSave = new Button();
            btnPdf = new Button();
            cbbIdLocation = new ComboBox();
            nudCoutReparation = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudKilometrage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCoutReparation).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero de Location:";
            // 
            // lbModele
            // 
            lbModele.AutoSize = true;
            lbModele.Location = new Point(38, 24);
            lbModele.Name = "lbModele";
            lbModele.Size = new Size(50, 15);
            lbModele.TabIndex = 1;
            lbModele.Text = "Modèle:";
            // 
            // lbImmat
            // 
            lbImmat.AutoSize = true;
            lbImmat.Location = new Point(38, 39);
            lbImmat.Name = "lbImmat";
            lbImmat.Size = new Size(95, 15);
            lbImmat.TabIndex = 2;
            lbImmat.Text = "Immatriculation:";
            // 
            // lbNumClient
            // 
            lbNumClient.AutoSize = true;
            lbNumClient.Location = new Point(360, 9);
            lbNumClient.Name = "lbNumClient";
            lbNumClient.Size = new Size(104, 15);
            lbNumClient.TabIndex = 3;
            lbNumClient.Text = "Numéro de Client:";
            // 
            // lbClient
            // 
            lbClient.AutoSize = true;
            lbClient.Location = new Point(360, 24);
            lbClient.Name = "lbClient";
            lbClient.Size = new Size(44, 15);
            lbClient.TabIndex = 4;
            lbClient.Text = "Client: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(nudKilometrage);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(tbxObservation);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(73, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 323);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // nudKilometrage
            // 
            nudKilometrage.Location = new Point(191, 61);
            nudKilometrage.Name = "nudKilometrage";
            nudKilometrage.Size = new Size(120, 23);
            nudKilometrage.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(340, 60);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(97, 23);
            textBox4.TabIndex = 8;
            // 
            // tbxObservation
            // 
            tbxObservation.Location = new Point(218, 294);
            tbxObservation.Name = "tbxObservation";
            tbxObservation.Size = new Size(279, 23);
            tbxObservation.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(132, 297);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 5;
            label10.Text = "Observation:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(218, 98);
            label9.Name = "label9";
            label9.Size = new Size(199, 15);
            label9.TabIndex = 3;
            label9.Text = "Dommages constatés sur le véhicule";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(218, 42);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 2;
            label8.Text = "Kilométrage";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(340, 42);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 1;
            label7.Text = "Date-Heure";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 19);
            label6.Name = "label6";
            label6.Size = new Size(155, 15);
            label6.TabIndex = 0;
            label6.Text = "Contrôle n°          réaliser par";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(224, 395);
            label11.Name = "label11";
            label11.Size = new Size(160, 15);
            label11.TabIndex = 7;
            label11.Text = "Cout estimé des réparations: ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(291, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Enregister";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnPdf
            // 
            btnPdf.Location = new Point(389, 415);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(75, 23);
            btnPdf.TabIndex = 10;
            btnPdf.Text = "Imprimer";
            btnPdf.UseVisualStyleBackColor = true;
            // 
            // cbbIdLocation
            // 
            cbbIdLocation.FormattingEnabled = true;
            cbbIdLocation.Location = new Point(163, 9);
            cbbIdLocation.Name = "cbbIdLocation";
            cbbIdLocation.Size = new Size(121, 23);
            cbbIdLocation.TabIndex = 11;
            cbbIdLocation.SelectedIndexChanged += cbbIdLocation_SelectedIndexChanged;
            // 
            // nudCoutReparation
            // 
            nudCoutReparation.Location = new Point(389, 387);
            nudCoutReparation.Name = "nudCoutReparation";
            nudCoutReparation.Size = new Size(120, 23);
            nudCoutReparation.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(69, 116);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(502, 172);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // ControleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudCoutReparation);
            Controls.Add(cbbIdLocation);
            Controls.Add(btnPdf);
            Controls.Add(btnSave);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Controls.Add(lbClient);
            Controls.Add(lbNumClient);
            Controls.Add(lbImmat);
            Controls.Add(lbModele);
            Controls.Add(label1);
            Name = "ControleForm";
            Text = ":!";
            Load += ControleForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudKilometrage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCoutReparation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbModele;
        private Label lbImmat;
        private Label lbNumClient;
        private Label lbClient;
        private GroupBox groupBox1;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox tbxObservation;
        private Label label10;
        private Label label11;
        private Button btnSave;
        private Button btnPdf;
        private TextBox textBox4;
        private ComboBox cbbIdLocation;
        private NumericUpDown nudKilometrage;
        private NumericUpDown nudCoutReparation;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}