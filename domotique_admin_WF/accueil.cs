﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domotique_admin_WF
{
    public partial class accueil : Form
    {
        
        public accueil()
        {
            InitializeComponent();
        }
        /**/
       
        /*private static h List<Form> _instance = null;

        public void ShowUnique(String NomFenetre)
        {
            

            if (_instance == null)
            {
                _instance = new NomFenetre();
                _instance.MdiParent = parent;
            }

            else
                _instance.Focus();

            try
            {
                _instance.Show();
            }
            catch (ObjectDisposedException)
            {
                _instance = new NomFenetre();
                _instance.MdiParent = parent;
                _instance.Show();

            }
        }*/
        /**/


        private void modesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logs fenetre = new logs();
            fenetre.MdiParent = this;
            //parti pour mettre en fullscreen
            Form[] charr = this.MdiChildren;
            foreach (Form chform in charr)
                chform.WindowState = FormWindowState.Maximized;
            /**/
            fenetre.Show();
            
        }

        private void definirLesModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            module_def fenetre = new module_def();
            fenetre.MdiParent = this;
            fenetre.Show();

        }

        private void rapportJournaliéToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /*  rapport_journali fenetre = new rapport_journali();
           
            fenetre.Show();*/
            //fenetre.MdiParent = this;
            rapport_journali.ShowUnique(this); 
            //ShowUnique(this,"rapport_journali"); 
        }
    }
}
