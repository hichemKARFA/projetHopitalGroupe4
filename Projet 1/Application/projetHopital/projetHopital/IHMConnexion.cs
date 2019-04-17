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
    public partial class IHMConnexion : Form
    {        
        public IHMConnexion()
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
                MessageBox.Show("Veuillez entrer un identifiant et un mot de passe");
            }
            else if(Passerelle.seConnecter()==true)
            {
                if (Passerelle.verifUtilisateur(txtIdentifiant.Text, txtMdp.Text) == true)
                {
                    int idUtilisateur = Passerelle.getidUtilisateur(txtIdentifiant.Text);
                    MessageBox.Show("Bonjour " + txtIdentifiant.Text + "! Bienvenue sur l'application");
                    if (Passerelle.verifStatut(txtIdentifiant.Text) == 1)
                    {
                        IHMAccueil accueil = new IHMAccueil();
                        this.Hide();
                        accueil.ShowDialog();
                    }
                    else
                    {
                        IHMDemande demande = new IHMDemande(idUtilisateur);
                        this.Hide();
                        demande.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("L'identifiant et le mot de passe ne correspondent pas");
                }

            }
            else
            {
                MessageBox.Show("Merci de vérifier que votre ordinateur est bien connecté à internet");
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
