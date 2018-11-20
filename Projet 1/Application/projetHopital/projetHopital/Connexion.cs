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
            else if (Passerelle.verifUtilisateur(txtIdentifiant.Text, txtMdp.Text))
            {
                MessageBox.Show("Bonjour " + txtIdentifiant.Text + "! Bienvenue sur l'application.");
                if (Passerelle.getPharmacien(txtIdentifiant.Text, txtMdp.Text))
                {
                    Accueil accueil = new Accueil();
                    this.Hide();
                    accueil.ShowDialog();
                }
                else
                {
                    Demande demande = new Demande();
                    this.Hide();
                    demande.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Le login et le mot de passe ne correspondent pas");
            }

        }

        private void txtMdp_TextChanged(object sender, EventArgs e)
        {
            txtMdp.PasswordChar = '*';
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void txtIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
