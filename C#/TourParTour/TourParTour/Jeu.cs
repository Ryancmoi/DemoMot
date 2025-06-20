using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourParTour
{
    public partial class Jeu : Form
    {

        Personnage joueur1; //class J1
        Personnage joueur2; //class J2
        bool Player1Turn; //Tour du J1
        bool IsDead = false; //Pour vérifier la mort
        const int soin = 300; //valeur de l'objet de soin
        private int flashCounter1 = 0; //Compter le nombre de tick du J1
        private int flashCounter2 = 0; //Compter le nombre de tick du J2
        private Color defaultColor1; //Couleur de base des PV
        private Color defaultColor2; //Couleur de base des PV
        int LeftHealing = 1; //nombre d'objet de soin restant
        int LeftDmgBoost = 2; //nombre d'objet de boost des dgt restant
        int LeftReduction = 2; //nombre d'objet de réduction restant
        int LeftSkillPointRefill = 1; //nombre de recharge de skill point restant
        bool IsBoosted = false; //pour vérifier si un boost de dgt est actif


        public Jeu()
        {
            InitializeComponent();
        }

        private void Jeu_Load(object sender, EventArgs e) //à l'ouverture du form Jeu
        {
            

            //prend la couleur de base du texte des PV
            defaultColor1 = PVdisplay1.BackColor;
            defaultColor2 = PVdisplay2.BackColor;

            //affiche le nombre d'objet restant
            soinToolStripMenuItem.Text = "Soin x" + LeftHealing.ToString();
            dégatsToolStripMenuItem.Text = "Dégats x" + LeftDmgBoost.ToString();
            energieToolStripMenuItem.Text = "Energie x" + LeftSkillPointRefill.ToString();
            réductionToolStripMenuItem.Text = "Réduction x" + LeftReduction.ToString();

            //caractéristique du J1
            joueur1 = new Personnage()
            {
                Nom = "Jhonbi",
                PV = 1500,
                PVMax = 1500,
                Attack = 200,
                AttackMax = 400,
                IsGuarding = false,
                SkillPoint = 2,
            };

            //caractéristique du J2
            joueur2 = new Personnage()
            {
                Nom = "Jhondalton",
                PV = 1500,
                PVMax = 1500,
                Attack = 200,
                AttackMax = 400,
                IsGuarding = false,
                SkillPoint = 2,
            };

            //affiche les PV du J1 et J2
            PVdisplay1.Text = "PV : " + joueur1.PV.ToString();
            PVdisplay2.Text = "PV : " + joueur2.PV.ToString();

            Player1Turn = true;


            SkillPointBar.Value = 2;

        }

        private async void atkButtonJ1_Click(object sender, EventArgs e) //évènement du boutton atk
        {
            //vérifie si l'ennemi est en garde, inflige les dgt vérifie la mort
            if (Player1Turn)
            {
                double damageJ1 = joueur1.Attack;

                if (joueur2.IsGuarding)
                {
                    damageJ1 *= 0.7; //réduit les dgt du J1 à 70%
                    joueur2.IsGuarding = false; //enlève l'état de garde du J2
                }

                joueur2.PV -= damageJ1; //inflige les dgt au J2

                if (joueur2.PV < 0) joueur2.PV = 0; //vérifie si les PV du J2 sont en dessous de 0 et si c'est le cas, les met à 0 car c'est mieux visuellement

                //met à jour les PV des 2 joueurs à l'écran
                PVdisplay1.Text = "PV : " + joueur1.PV.ToString();
                PVdisplay2.Text = "PV : " + joueur2.PV.ToString();

                joueur1.Attack = 200; //remet l'attaque de base du J1, car les boost ne durent qu'1 seul tour

                FlashLabel(PVdisplay2, damageFlashTimer2, ref flashCounter2); //fais clignoter en rouge les PV du J2

                if (joueur2.PV == 0) //vérifie si le J2 est mort
                {
                    MessageBox.Show("Le joueur 2 est mort, vous avez gagné !");
                    Application.Exit(); //quite l'application
                }
                else //si le J1 n'est pas mort
                {
                    Player1Turn = false; //plus le tour du J1
                    await Task.Delay(500); //met 500 milisecondes de délai
                    await Bot(); //fais jouer le Bot (J2)
                }
            }
        }


        private void SpecialAtk_Click(object sender, EventArgs e) //évènement du boutton atk spéciale
        {
            if (joueur1.SkillPoint > 0) //vérifie si le J1 a des skill point
            {
                joueur1.SkillPoint = joueur1.SkillPoint - 1; //retire 1 skill point
                SkillPointBar.Value = SkillPointBar.Value - 1; //retire 1 à la veleu de la barre
            }
            else //si le J1 n'a plus de skill point
            {
                MessageBox.Show("Vous n'avez plus d'énergie pour une attaque spéciale");
                return; //sors de l'évènement pour que le J1 puisse faire une autre action
                
            }


            if (Player1Turn == true) //vérifie si c'est le tour du J1
            {
                //définit les dgt spécial du J1
                double SpecialAtkDmgJ1 = joueur1.Attack + 100;


                if (joueur2.IsGuarding) //vérifie si le J2 est en garde
                {
                    SpecialAtkDmgJ1 *= 0.7; //réduit les dgt du J1 à 70%
                    joueur2.IsGuarding = false; //enlève l'état de garde du J2
                }

                joueur2.PV -= SpecialAtkDmgJ1; //inflige les dgt au J2

                //vérifie si le joueur1 ou le joueur2 est mort
                if (joueur1.PV <= 0 | joueur2.PV <= 0)
                {
                    IsDead = true;
                }

                if (joueur2.PV < 0) joueur2.PV = 0; //vérifie si les PV du J2 sont en dessous de 0 et si c'est le cas, les met à 0 car c'est mieux visuellement

                //met à jour les PV des 2 joueurs
                PVdisplay1.Text = "PV : " + joueur1.PV.ToString();
                PVdisplay2.Text = "PV : " + joueur2.PV.ToString();

                SkillPointDisplay.Text = SkillPointBar.Value.ToString() + "/" + SkillPointBar.Maximum; //affiche le nombre de skill point disponibles

                FlashLabel(PVdisplay2, damageFlashTimer2, ref flashCounter2); //fais clignoter en rouge les PV du J2

                //remet la valeur d'attaque de base au joueur 1
                joueur1.Attack = 200;

                if (IsDead == true) //vérifie si le J2 est mort
                {
                    MessageBox.Show("Le joueur 2 est mort vous avez gagné");
                    System.Windows.Forms.Application.Exit(); //quitte l'application
                }
                else
                {
                    Player1Turn = false; //plus le tour du J1
                    Bot(); //tour du Bot
                }
            }
        }

        private void GuardJ1_Click(object sender, EventArgs e) //évènement du boutton bloquer
        {
            joueur1.IsGuarding = true; //met l'état de garde au J1
            Player1Turn = false;
            Bot(); //fait jouer le Bot (J2)

            //met à jour les PV des 2 joueurs
            PVdisplay1.Text = "PV : " + joueur1.PV.ToString();
            PVdisplay2.Text = "PV : " + joueur2.PV.ToString();
        }

        private void soinToolStripMenuItemJ1_Click(object sender, EventArgs e) //évènement du boutton soin
        {
            if (LeftHealing > 0) //vérifie si il reste un objet de soin
            {
                joueur1.PV += soin; //soigne le J1

                if (joueur1.PV > joueur1.PVMax) joueur1.PV = joueur1.PVMax; //empêche d'avoir un trop grand nombre PV

                LeftHealing--; //enlève une utilisation d'objet de soin

                soinToolStripMenuItem.Text = "Soin x" + LeftHealing.ToString(); //met à jour à l'écran sur le nombre d'usage restant

                if (LeftHealing == 0)
                {
                    soinToolStripMenuItem.Enabled = false; //désactive le soin si 0 utilisation restante
                }

                PVdisplay1.Text = "PV : " + joueur1.PV.ToString(); //met à jour les PV du J1
                Player1Turn = false;
                Bot(); //fait jouer le bot
            }
        }

        private void dégatsToolStripMenuItemJ1_Click(object sender, EventArgs e) //évènement du boutton de bonus de dégâts
        {
            //
            if (LeftDmgBoost > 0) //vérifie si il rest un objet de boost de dgt
            {
                joueur1.Attack = joueur1.Attack + 200; //augmente l'attaque du J1

                LeftDmgBoost--; //retire une utilisation

                dégatsToolStripMenuItem.Text = "Dégats x" + LeftDmgBoost.ToString(); //met à jour à l'écran sur le nombre d'usage restant

                if (LeftDmgBoost == 0) //vérifie si le nombre de boost de dgt restant = 0
                {
                    dégatsToolStripMenuItem.Enabled = false;
                }

                if (joueur1.Attack > joueur1.AttackMax) //vérifie si l'attaque du J2
                {
                    joueur1.Attack -= 200;
                    MessageBox.Show("Vous avez déjà un bonus de dégâts actif");
                }
            }
            

            Player1Turn = false;
            Bot();

        }
        private void réductionToolStripMenuItemJ1_Click(object sender, EventArgs e) //évènement du boutton d'objet de réduction de dgt
        {
            if (LeftReduction > 0)
            {
                joueur2.Attack = joueur2.Attack / 2;

                LeftReduction--;

                réductionToolStripMenuItem.Text = "Réduction x" + LeftReduction.ToString();

                if (LeftReduction == 0)
                {
                    réductionToolStripMenuItem.Enabled = false;
                }
            }
           
            Player1Turn = false;
            Bot();
        }
        private void energieToolStripMenuItemJ1_Click(object sender, EventArgs e) //évènement du boutton d'objet de récupération d'énergie
        {
            if (LeftSkillPointRefill > 0)
            {
                SkillPointBar.Value = SkillPointBar.Value + 1;
                joueur1.SkillPoint += 1;
                SkillPointDisplay.Text = SkillPointBar.Value.ToString() + "/" + SkillPointBar.Maximum;

                LeftSkillPointRefill--;

                energieToolStripMenuItem.Text = "Energie x" + LeftSkillPointRefill.ToString();

                if(LeftSkillPointRefill == 0)
                {
                    energieToolStripMenuItem.Enabled=false;
                }
            }


            Player1Turn = false;
            Bot();
        }

        private async Task Bot() //actin du Bot
        {
            int[] actions = new int[]
                {
                    1, 1, 1, 1, //attaque normale
                    2, //blocage
                    3, 3, //attaque spéciale
                    4,4, //soin
                    5,5, //bonus dégâts
                    6, //réductions dégâts
                    7 //récupération skill point
                };

            int actionValue = actions[new Random().Next(actions.Length)];

            switch (actionValue)
            {
                case 1: //attaque
                    double damageJ2 = joueur2.Attack;
                    if (joueur1.IsGuarding)
                    {
                        damageJ2 *= 0.7;
                        joueur1.IsGuarding = false;
                    }
                    await Task.Delay(300);
                    MessageBox.Show("Jhondalton attaque");
                    if (IsBoosted == false)
                    {
                        damageJ2 = 200;
                        joueur1.PV -= damageJ2;
                    }
                    else
                    {
                        joueur1.PV -= damageJ2;
                        IsBoosted = false;
                    }

                    if (joueur1.PV < 0) joueur1.PV = 0;
                    PVdisplay1.Text = "PV : " + joueur1.PV.ToString();
                    FlashLabel(PVdisplay1, damageFlashTimer1, ref flashCounter1);
                    break;


                case 2: //bloquer
                    joueur2.IsGuarding = true;
                    if (joueur2.IsGuarding == true)
                    {

                    }
                    await Task.Delay(800);
                    MessageBox.Show("Jhondalton se met en garde");
                    break;

                case 3: //attaque spéciale 
                    if (joueur2.SkillPoint >= 1)
                    {
                        joueur2.SkillPoint -= 1;
                        double damageSpJ2 = joueur2.Attack + 100;
                        if (joueur1.IsGuarding)
                        {
                            damageSpJ2 *= 0.7;
                            joueur1.IsGuarding = false;
                        }
                        await Task.Delay(300);
                        MessageBox.Show("Jhondalton utilise une attaque spéciale");
                        if (IsBoosted == false)
                        {
                            damageSpJ2 = 300;
                            joueur1.PV -= damageSpJ2;
                        }
                        else
                        {
                            joueur1.PV -= damageSpJ2;
                            IsBoosted = false;
                        }
                        
                        FlashLabel(PVdisplay1, damageFlashTimer1, ref flashCounter1);
                    }
                    else
                    {
                        goto case 1;
                    }
                    break;

                case 4: //soin
                    joueur2.PV += soin;
                    if (joueur2.PV > joueur2.PVMax)
                        joueur2.PV = joueur2.PVMax;
                    await Task.Delay(800);
                    MessageBox.Show("Jhondalton se soigne");
                    break;

                case 5: //bonus dégâts
                    if (joueur2.Attack + 200 <= joueur2.AttackMax)
                    {
                        IsBoosted = true;
                        joueur2.Attack += 200;
                        await Task.Delay(800);
                        MessageBox.Show("Jhondalton utilise un bonus de dégâts");

                    }
                    else
                    {
                        goto case 1;
                    }
                    break;

                case 6: //réduction dégâts J1
                    joueur1.Attack /= 2;
                    await Task.Delay(800);
                    MessageBox.Show("Jhondalton obtient une réduction de 50% de dégâts");
                    break;

                case 7: //récupération skill point
                    if (joueur2.SkillPoint < 7)
                    {
                        joueur2.SkillPoint += 1;
                        await Task.Delay(800);
                        MessageBox.Show("Jhondalton récupère 1pt de compétence");
                    }
                    else
                    {
                        goto case 1;
                    }
                    break;
            }

            if (joueur1.PV <= 0)
            {
                joueur1.PV = 0;
                PVdisplay1.Text = "PV : " + joueur1.PV.ToString();
                MessageBox.Show("Jhondalton a gagné");
                Application.Exit();
            }

            PVdisplay1.Text = "PV : " + joueur1.PV.ToString();
            PVdisplay2.Text = "PV : " + joueur2.PV.ToString();
            Player1Turn = true;
        }
        private void FlashLabel(Label label, Timer timer, ref int counter) //changement de couleur des PV
        {
            label.BackColor = Color.Red;
            counter = 0;
            timer.Start();
        }

        private void damageFlashTimer1_Tick(object sender, EventArgs e) //timer de changement de couleur des PV du J1
        {
            flashCounter1++;
            if (flashCounter1 >= 5)
            {
                PVdisplay1.BackColor = defaultColor1;
                damageFlashTimer1.Stop();
            }
        }

        private void damageFlashTimer2_Tick(object sender, EventArgs e) //timer de changement de couleur des PV du J2
        {
            flashCounter2++;
            if (flashCounter2 >= 5)
            {
                PVdisplay2.BackColor = defaultColor2;
                damageFlashTimer2.Stop();
            }
        }

    }
    public class Personnage //variables personnages
    {
        public string Nom;
        public double PV;
        public double PVMax;
        public double Attack;
        public double AttackMax;
        public bool IsGuarding;
        public double SkillPoint;
    }
}

