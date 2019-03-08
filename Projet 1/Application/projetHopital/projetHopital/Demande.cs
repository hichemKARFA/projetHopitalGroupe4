using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace projetHopital
{
    public partial class Demande : Form
    {
        private int idUtilisateur;
        public Demande(int pIdUtilisateur)
        {
            idUtilisateur = pIdUtilisateur;
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            this.Hide();
            accueil.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous quittez le logiciel");
            Application.Exit();
        }

        private void lbldemandes_Click(object sender, EventArgs e)
        {

        }

        private void Demande_Load(object sender, EventArgs e)
        {
            ArrayList lesMedicaments = new ArrayList();
            lesMedicaments = Passerelle.listeMedicaments();
            foreach (Medicament unMedicament in lesMedicaments)
            {
                string[] arr = new string[2];
                ListViewItem itm;
                arr[0] = unMedicament.getId() + "";
                arr[1] = unMedicament.getNom();
                itm = new ListViewItem(arr);
                listeMedicaments.Items.Add(itm);
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int quantite = int.Parse(txtQtte.Text);  
            int idDemande = Passerelle.trouverIdMax("Demandes")+1; // Récupère id max pour créer la demande
            string[] leMedicament = new string[2];


            if (txtQtte.Text == String.Empty || leMedicament[0] == String.Empty || leMedicament[1] == String.Empty)
            {
                MessageBox.Show("Vous n'avez pas saisi de médicament ou de quantité");
            }
            else
            {
                int id = int.Parse(listeMedicaments.SelectedItems[0].SubItems[0].Text);
                Connexion uneConnexion = new Connexion();
                Passerelle.creerDemande(idDemande, idUtilisateur);
                txtQtte.Text = "";
                
               
            }
            
            
        }

        private void listMedocDemande_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listeMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
