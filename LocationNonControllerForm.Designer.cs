namespace LocaLux_GestActivite
{
    partial class LocationNonControllerForm
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
            listBox1 = new ListBox();
            btnControle = new Button();
            listBox2 = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 32);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 0;
            label1.Text = "Les Réservations non Controller";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(131, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(528, 154);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnControle
            // 
            btnControle.Location = new Point(335, 399);
            btnControle.Name = "btnControle";
            btnControle.Size = new Size(75, 23);
            btnControle.TabIndex = 3;
            btnControle.Text = "Controler";
            btnControle.UseVisualStyleBackColor = true;
            btnControle.Click += btnControle_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(131, 248);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(528, 139);
            listBox2.TabIndex = 4;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 228);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 5;
            label2.Text = "Les locations controllé";
            // 
            // LocationNonControllerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(btnControle);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "LocationNonControllerForm";
            Text = "LocationNonControllerForm";
            Load += LocationNonControllerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button btnControle;
        private ListBox listBox2;
        private Label label2;
    }
}