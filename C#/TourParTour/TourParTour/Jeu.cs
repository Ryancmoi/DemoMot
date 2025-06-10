using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourParTour
{
    public partial class Jeu : Form
    {

        Personnage joueur1;
        Personnage joueur2;
        bool Player1Turn;
        bool IsGameOver = false;
        bool IsDead = false;
        const int soin = 300;


        public Jeu()
        {
            InitializeComponent();
        }

        private void Jeu_Load(object sender, EventArgs e)
        {

                joueur1 = new Personnage()
                {
                    Nom = "Jhonbi",
                    PV = 1000,
                    PVMax = 1000,
                    Attack = 200,
                    IsGuarding = false,
                };

                joueur2 = new Personnage()
                {
                    Nom = "Jhondalton",
                    PV = 1000,
                    PVMax = 1000,
                    Attack = 100,
                    IsGuarding = false,
                };

                PVdisplay1.Text = "PV : " + joueur1.PV.ToString();
                PVdisplay2.Text = "PV : " + joueur2.PV.ToString();

                Player1Turn = true;

                if (joueur1.PV == 0 | joueur2.PV == 0)
                {
                    IsGameOver = true;
                }

        }

        private void atkButtonJ1_Click(object sender, EventArgs e)
        {
            joueur2.PV = joueur2.PV - joueur1.Attack;

            if (joueur1.PV <= 0 | joueur2.PV <= 0)
            {
                IsDead = true;
            }

            PVdisplay1.Text = "PV : " + joueur1.PV.ToString();
            PVdisplay2.Text = "PV : " + joueur2.PV.ToString();

            if (IsDead == true)
            {
                MessageBox.Show("Le joueur 2 est mort vous avez gagné");
                System.Windows.Forms.Application.Exit();
            }

        }


        private void soinToolStripMenuItemJ1_Click(object sender, EventArgs e)
        {
            joueur1.PV = joueur1.PV + soin;
            PVdisplay1.Text = "PV : " + joueur1.PV.ToString();
        }
        private void dégatsToolStripMenuItemJ1_Click(object sender, EventArgs e)
        {

        }
        private void réductionToolStripMenuItemJ1_Click(object sender, EventArgs e)
        {

        }
        private void energieToolStripMenuItemJ1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Personnage
    {
        public string Nom;
        public int PV;
        public int PVMax;
        public int Attack;
        public bool IsGuarding;
    }
}
