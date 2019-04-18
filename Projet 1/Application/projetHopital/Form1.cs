using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetHopital
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void lblHopital_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous quittez le logiciel");
            Application.Exit();
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtIdentifiant.Text == String.Empty || txtMdp.Text == String.Empty)
            {
                MessageBox.Show("Veuillez vérifier que vous ayez bien tout rempli");
            }
            else
            {
                MessageBox.Show("Bonjour "+txtIdentifiant.Text+"! Bienvenue sur l'application.");
                Accueil accueil = new Accueil();
                this.Hide();
                accueil.ShowDialog();
            }
            
        }
    }
}
