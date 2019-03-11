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
        Dictionary<Medicament, int> contenuDemande = new Dictionary<Medicament, int>();
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
            string[] leMedicament = new string[2];


            if (txtQtte.Text == String.Empty || leMedicament[0] == String.Empty || leMedicament[1] == String.Empty)
            {
                MessageBox.Show("Vous n'avez pas saisi de médicament ou de quantité");
            }
            else
            {
                listMedocDemande.Items.Clear();    //Affichage du dictionnaire avec un nouvel élément
                Medicament unMedicament;
                int idMedicament = int.Parse(listeMedicaments.SelectedItems[0].SubItems[0].Text);
                unMedicament = Passerelle.trouverMedicament(idMedicament);  //Recherche d'un médicament dans la BDD grâce à son id
                string nomMedicament = unMedicament.getNom(); //Attribution de valeur aux variables
                int stockMedicament = unMedicament.getStock();
                int seuilMedicament = unMedicament.getSeuil();
                unMedicament = new Medicament(idMedicament, nomMedicament, stockMedicament, seuilMedicament);
                
                int QtteMedicament = int.Parse(txtQtte.Text);
                contenuDemande.Add(unMedicament, QtteMedicament);
                txtQtte.Text = "";

                foreach (KeyValuePair<Medicament, int> value in contenuDemande)
                {
                    string[] monContenu = new string[3];
                    ListViewItem itm;
                    unMedicament = value.Key;
                    string uneId = unMedicament.getId() + "";
                    monContenu[0] = uneId;
                    monContenu[1] = unMedicament.getNom();
                    monContenu[2] = contenuDemande[unMedicament] + "";
                    itm = new ListViewItem(monContenu);
                    listMedocDemande.Items.Add(itm);
                }            
            }
            
            
        }

        private void listMedocDemande_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listeMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQtte_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int idDemande = Passerelle.trouverIdMax("Demandes") + 1; // Récupère id max pour créer la demande
            int id = int.Parse(listeMedicaments.SelectedItems[0].SubItems[0].Text);
            Connexion uneConnexion = new Connexion();
            Passerelle.creerDemande(idDemande, idUtilisateur);   //Création d'une nouvelle demande avec comme etat 'En attente' par défaut
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {

            /*int idMedicament = int.Parse(listMedocDemande.SelectedItems[0].SubItems[0].Text);

                if(contenuDemande.Values.Key.getId()== idMedicament)
                {
                    contenuDemande.Remove(value.Key);
                }

            listMedocDemande.Items.Clear();*/
        }
    }
}
