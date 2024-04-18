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
            lbNumLoca = new Label();
            lbModele = new Label();
            lbImmat = new Label();
            lbNumClient = new Label();
            lbClient = new Label();
            groupBox1 = new GroupBox();
            lbDateHeure = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            nudKilometrage = new NumericUpDown();
            tbxObservation = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lbControleNumEmployer = new Label();
            label11 = new Label();
            btnSave = new Button();
            btnPdf = new Button();
            nudCoutReparation = new NumericUpDown();
            btnRetour = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudKilometrage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCoutReparation).BeginInit();
            SuspendLayout();
            // 
            // lbNumLoca
            // 
            lbNumLoca.AutoSize = true;
            lbNumLoca.Location = new Point(38, 9);
            lbNumLoca.Name = "lbNumLoca";
            lbNumLoca.Size = new Size(119, 15);
            lbNumLoca.TabIndex = 0;
            lbNumLoca.Text = "Numero de Location:";
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
            groupBox1.Controls.Add(lbDateHeure);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(nudKilometrage);
            groupBox1.Controls.Add(tbxObservation);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(73, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 323);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // lbDateHeure
            // 
            lbDateHeure.AutoSize = true;
            lbDateHeure.Location = new Point(340, 30);
            lbDateHeure.Name = "lbDateHeure";
            lbDateHeure.Size = new Size(63, 15);
            lbDateHeure.TabIndex = 11;
            lbDateHeure.Text = "DateHeure";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.0129852F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.9870129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Location = new Point(69, 72);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(531, 216);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // nudKilometrage
            // 
            nudKilometrage.Location = new Point(191, 28);
            nudKilometrage.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudKilometrage.Name = "nudKilometrage";
            nudKilometrage.Size = new Size(120, 23);
            nudKilometrage.TabIndex = 9;
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
            label9.Location = new Point(222, 54);
            label9.Name = "label9";
            label9.Size = new Size(199, 15);
            label9.TabIndex = 3;
            label9.Text = "Dommages constatés sur le véhicule";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(222, 10);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 2;
            label8.Text = "Kilométrage";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(340, 10);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 1;
            label7.Text = "Date-Heure";
            // 
            // lbControleNumEmployer
            // 
            lbControleNumEmployer.AutoSize = true;
            lbControleNumEmployer.Location = new Point(360, 39);
            lbControleNumEmployer.Name = "lbControleNumEmployer";
            lbControleNumEmployer.Size = new Size(155, 15);
            lbControleNumEmployer.TabIndex = 0;
            lbControleNumEmployer.Text = "Contrôle n°          réaliser par";
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
            btnPdf.Location = new Point(388, 415);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(75, 23);
            btnPdf.TabIndex = 10;
            btnPdf.Text = "Imprimer";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
            // 
            // nudCoutReparation
            // 
            nudCoutReparation.Location = new Point(389, 387);
            nudCoutReparation.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudCoutReparation.Name = "nudCoutReparation";
            nudCoutReparation.Size = new Size(120, 23);
            nudCoutReparation.TabIndex = 12;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(13, 415);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 13;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // ControleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetour);
            Controls.Add(nudCoutReparation);
            Controls.Add(btnPdf);
            Controls.Add(btnSave);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Controls.Add(lbClient);
            Controls.Add(lbNumClient);
            Controls.Add(lbControleNumEmployer);
            Controls.Add(lbImmat);
            Controls.Add(lbModele);
            Controls.Add(lbNumLoca);
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

        private Label lbNumLoca;
        private Label lbModele;
        private Label lbImmat;
        private Label lbNumClient;
        private Label lbClient;
        private GroupBox groupBox1;
        private Label lbControleNumEmployer;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox tbxObservation;
        private Label label10;
        private Label label11;
        private Button btnSave;
        private Button btnPdf;
        private NumericUpDown nudKilometrage;
        private NumericUpDown nudCoutReparation;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRetour;
        private Label lbDateHeure;
    }
}