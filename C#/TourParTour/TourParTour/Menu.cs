using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourParTour
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lancerPartie_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            this.Hide();
            Jeu Jeu = new Jeu();
            Jeu.Show();
        }
    }
}
