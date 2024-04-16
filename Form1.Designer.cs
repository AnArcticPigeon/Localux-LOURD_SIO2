namespace LocaLux_GestActivite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgModele = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgModele).BeginInit();
            SuspendLayout();
            // 
            // dgModele
            // 
            dgModele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgModele.Location = new Point(294, 120);
            dgModele.Name = "dgModele";
            dgModele.RowTemplate.Height = 25;
            dgModele.Size = new Size(240, 150);
            dgModele.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgModele);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgModele).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgModele;
    }
}