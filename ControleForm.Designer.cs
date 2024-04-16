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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            checkedListBox1 = new CheckedListBox();
            label10 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label11 = new Label();
            btnSave = new Button();
            btnPdf = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 24);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Modèle:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 39);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Immatriculation:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 9);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 3;
            label4.Text = "Numéro de Client:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 24);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Client: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(73, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 309);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(340, 42);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 1;
            label7.Text = "Date-Heure";
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
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(121, 116);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(436, 130);
            checkedListBox1.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(131, 267);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 5;
            label10.Text = "Observation:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 267);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(390, 372);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(224, 375);
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
            // textBox3
            // 
            textBox3.Location = new Point(218, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(71, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(340, 60);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(68, 23);
            textBox4.TabIndex = 8;
            // 
            // ControleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPdf);
            Controls.Add(btnSave);
            Controls.Add(label11);
            Controls.Add(textBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ControleForm";
            Text = ":!";
            Load += ControleForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox1;
        private Label label10;
        private CheckedListBox checkedListBox1;
        private TextBox textBox2;
        private Label label11;
        private TextBox textBox3;
        private Button btnSave;
        private Button btnPdf;
        private TextBox textBox4;
    }
}