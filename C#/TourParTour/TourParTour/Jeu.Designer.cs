﻿namespace TourParTour
{
    partial class Jeu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jeu));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PVdisplay2 = new System.Windows.Forms.Label();
            this.PVdisplay1 = new System.Windows.Forms.Label();
            this.MenuAction1 = new System.Windows.Forms.GroupBox();
            this.SpecialAtk = new System.Windows.Forms.Button();
            this.GuardJ1 = new System.Windows.Forms.Button();
            this.atkButtonJ1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.soinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dégatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.energieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkillPointDisplay = new System.Windows.Forms.Label();
            this.SkillPointBar = new System.Windows.Forms.ProgressBar();
            this.damageFlashTimer1 = new System.Windows.Forms.Timer(this.components);
            this.damageFlashTimer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuAction1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TourParTour.Properties.Resources.crackhead2;
            this.pictureBox2.Location = new System.Drawing.Point(749, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TourParTour.Properties.Resources.crackhead1;
            this.pictureBox1.Location = new System.Drawing.Point(344, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PVdisplay2
            // 
            this.PVdisplay2.AutoSize = true;
            this.PVdisplay2.Location = new System.Drawing.Point(874, 195);
            this.PVdisplay2.Name = "PVdisplay2";
            this.PVdisplay2.Size = new System.Drawing.Size(27, 13);
            this.PVdisplay2.TabIndex = 3;
            this.PVdisplay2.Text = "PV :";
            // 
            // PVdisplay1
            // 
            this.PVdisplay1.AutoSize = true;
            this.PVdisplay1.Location = new System.Drawing.Point(477, 295);
            this.PVdisplay1.Name = "PVdisplay1";
            this.PVdisplay1.Size = new System.Drawing.Size(27, 13);
            this.PVdisplay1.TabIndex = 4;
            this.PVdisplay1.Text = "PV :";
            // 
            // MenuAction1
            // 
            this.MenuAction1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MenuAction1.Controls.Add(this.SpecialAtk);
            this.MenuAction1.Controls.Add(this.GuardJ1);
            this.MenuAction1.Controls.Add(this.atkButtonJ1);
            this.MenuAction1.Controls.Add(this.menuStrip1);
            this.MenuAction1.Location = new System.Drawing.Point(453, 346);
            this.MenuAction1.Name = "MenuAction1";
            this.MenuAction1.Size = new System.Drawing.Size(185, 133);
            this.MenuAction1.TabIndex = 5;
            this.MenuAction1.TabStop = false;
            this.MenuAction1.Text = "Menu d\'action";
            // 
            // SpecialAtk
            // 
            this.SpecialAtk.Location = new System.Drawing.Point(6, 77);
            this.SpecialAtk.Name = "SpecialAtk";
            this.SpecialAtk.Size = new System.Drawing.Size(108, 23);
            this.SpecialAtk.TabIndex = 9;
            this.SpecialAtk.Text = "Attaque spéciale";
            this.SpecialAtk.UseVisualStyleBackColor = true;
            this.SpecialAtk.Click += new System.EventHandler(this.SpecialAtk_Click);
            // 
            // GuardJ1
            // 
            this.GuardJ1.Location = new System.Drawing.Point(6, 48);
            this.GuardJ1.Name = "GuardJ1";
            this.GuardJ1.Size = new System.Drawing.Size(75, 23);
            this.GuardJ1.TabIndex = 7;
            this.GuardJ1.Text = "Bloquer";
            this.GuardJ1.UseVisualStyleBackColor = true;
            this.GuardJ1.Click += new System.EventHandler(this.GuardJ1_Click);
            // 
            // atkButtonJ1
            // 
            this.atkButtonJ1.Location = new System.Drawing.Point(6, 19);
            this.atkButtonJ1.Name = "atkButtonJ1";
            this.atkButtonJ1.Size = new System.Drawing.Size(75, 23);
            this.atkButtonJ1.TabIndex = 6;
            this.atkButtonJ1.Text = "Attaquer";
            this.atkButtonJ1.UseVisualStyleBackColor = true;
            this.atkButtonJ1.Click += new System.EventHandler(this.atkButtonJ1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenu});
            this.menuStrip1.Location = new System.Drawing.Point(2, 106);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(57, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ItemMenu
            // 
            this.ItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soinToolStripMenuItem,
            this.dégatsToolStripMenuItem,
            this.réductionToolStripMenuItem,
            this.energieToolStripMenuItem});
            this.ItemMenu.Name = "ItemMenu";
            this.ItemMenu.Size = new System.Drawing.Size(48, 20);
            this.ItemMenu.Text = "Objet";
            // 
            // soinToolStripMenuItem
            // 
            this.soinToolStripMenuItem.Name = "soinToolStripMenuItem";
            this.soinToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.soinToolStripMenuItem.Text = "Soin";
            this.soinToolStripMenuItem.Click += new System.EventHandler(this.soinToolStripMenuItemJ1_Click);
            // 
            // dégatsToolStripMenuItem
            // 
            this.dégatsToolStripMenuItem.Name = "dégatsToolStripMenuItem";
            this.dégatsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.dégatsToolStripMenuItem.Text = "Dégats";
            this.dégatsToolStripMenuItem.Click += new System.EventHandler(this.dégatsToolStripMenuItemJ1_Click);
            // 
            // réductionToolStripMenuItem
            // 
            this.réductionToolStripMenuItem.Name = "réductionToolStripMenuItem";
            this.réductionToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.réductionToolStripMenuItem.Text = "Réduction";
            this.réductionToolStripMenuItem.Click += new System.EventHandler(this.réductionToolStripMenuItemJ1_Click);
            // 
            // energieToolStripMenuItem
            // 
            this.energieToolStripMenuItem.Name = "energieToolStripMenuItem";
            this.energieToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.energieToolStripMenuItem.Text = "Energie";
            this.energieToolStripMenuItem.Click += new System.EventHandler(this.energieToolStripMenuItemJ1_Click);
            // 
            // SkillPointDisplay
            // 
            this.SkillPointDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SkillPointDisplay.AutoSize = true;
            this.SkillPointDisplay.Location = new System.Drawing.Point(644, 407);
            this.SkillPointDisplay.Name = "SkillPointDisplay";
            this.SkillPointDisplay.Size = new System.Drawing.Size(24, 13);
            this.SkillPointDisplay.TabIndex = 8;
            this.SkillPointDisplay.Text = "2/2";
            // 
            // SkillPointBar
            // 
            this.SkillPointBar.BackColor = System.Drawing.SystemColors.Control;
            this.SkillPointBar.Location = new System.Drawing.Point(573, 423);
            this.SkillPointBar.Maximum = 2;
            this.SkillPointBar.Name = "SkillPointBar";
            this.SkillPointBar.Size = new System.Drawing.Size(181, 30);
            this.SkillPointBar.TabIndex = 6;
            this.SkillPointBar.Value = 2;
            // 
            // damageFlashTimer1
            // 
            this.damageFlashTimer1.Tick += new System.EventHandler(this.damageFlashTimer1_Tick);
            // 
            // damageFlashTimer2
            // 
            this.damageFlashTimer2.Tick += new System.EventHandler(this.damageFlashTimer2_Tick);
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 573);
            this.Controls.Add(this.SkillPointBar);
            this.Controls.Add(this.SkillPointDisplay);
            this.Controls.Add(this.MenuAction1);
            this.Controls.Add(this.PVdisplay1);
            this.Controls.Add(this.PVdisplay2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.Load += new System.EventHandler(this.Jeu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuAction1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label PVdisplay2;
        private System.Windows.Forms.Label PVdisplay1;
        private System.Windows.Forms.GroupBox MenuAction1;
        private System.Windows.Forms.Button atkButtonJ1;
        private System.Windows.Forms.Button GuardJ1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ItemMenu;
        private System.Windows.Forms.ToolStripMenuItem soinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dégatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem energieToolStripMenuItem;
        private System.Windows.Forms.ProgressBar SkillPointBar;
        private System.Windows.Forms.Label SkillPointDisplay;
        private System.Windows.Forms.Button SpecialAtk;
        private System.Windows.Forms.Timer damageFlashTimer1;
        private System.Windows.Forms.Timer damageFlashTimer2;
    }
}