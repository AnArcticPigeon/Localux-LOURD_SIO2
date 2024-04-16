using LocaLux_GestActivite.Models;

namespace LocaLux_GestActivite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connexion à la BD
            LocaluxContext cnx = new LocaluxContext();

            dgModele.DataSource = cnx.Modeles.ToList();
        }
    }
}