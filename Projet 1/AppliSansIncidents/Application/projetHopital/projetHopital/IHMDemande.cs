﻿using System;
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
    public partial class IHMDemande : Form
    {
        Dictionary<Medicament, int> contenuDemande = new Dictionary<Medicament, int>();
        private int idUtilisateur;
        public IHMDemande(int pIdUtilisateur)
        {
            idUtilisateur = pIdUtilisateur;
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            IHMAccueil accueil = new IHMAccueil();
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
            int idMedicament = int.Parse(listeMedicaments.SelectedItems[0].SubItems[0].Text);
            int quantite = int.Parse(txtQtte.Text); 
            string[] leMedicament = new string[2];

            listMedocDemande.Items.Clear();    //Affichage du dictionnaire avec un nouvel élément
            Medicament unMedicament;           // Création d'un médicament lorsque le client sélectionne un Médicament et lui odnne une quantité
            unMedicament = Passerelle.trouverMedicament(idMedicament);  //Recherche d'un médicament dans la BDD grâce à son id
            string nomMedicament = unMedicament.getNom(); //Attribution de valeur aux variables
            int stockMedicament = unMedicament.getStock();
            int seuilMedicament = unMedicament.getSeuil();
            unMedicament = new Medicament(idMedicament, nomMedicament, stockMedicament, seuilMedicament); // Création d'un médicament
            if (txtQtte.Text == String.Empty || leMedicament[0] == String.Empty || leMedicament[1] == String.Empty)  //erreur lorsque un champs est vide
            {
                MessageBox.Show("Vous n'avez pas saisi de médicament ou de quantité. Vérifiez également que la quantité est un nombre.");
            }

            else
            {
                int QtteMedicament = int.Parse(txtQtte.Text);
                
                txtQtte.Text = "";
                if(contenuDemande.Count == 0)
                {
                    contenuDemande.Add(unMedicament, QtteMedicament);
                }
                else
                {
                    bool MedicamentExiste = false;
                    foreach (Medicament MedicamentExistant in contenuDemande.Keys)
                    {
                        
                        if (MedicamentExistant.getId() == unMedicament.getId())
                        {
                            MedicamentExiste = true;
                            unMedicament = MedicamentExistant;
                        }
                        
                    }   
                    if (MedicamentExiste == false)
                    {
                        contenuDemande.Add(unMedicament, QtteMedicament);
                    }
                    else
                    {
                        contenuDemande[unMedicament] += QtteMedicament;
                    }
                }

               
                              
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
            IHMConnexion uneConnexion = new IHMConnexion();
            Passerelle.creerDemande(idDemande, idUtilisateur);   //Création d'une nouvelle demande avec comme etat 'En attente' par défaut
            foreach (KeyValuePair<Medicament, int> value in contenuDemande)
            {
                int idMedicament = value.Key.getId();
                int qtte = value.Value;
                Passerelle.AjouterContenuDemande(idDemande, idMedicament, qtte);
            }
           
            MessageBox.Show("Votre demande a bien été envoyée en pharmacie.");
            listMedocDemande.Items.Clear();
            contenuDemande.Clear();
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {
            Medicament leMedicament=null;
            int idMedicament = int.Parse(listMedocDemande.SelectedItems[0].SubItems[0].Text);
            foreach (Medicament unMedicament in contenuDemande.Keys)
            {
                if(idMedicament == unMedicament.getId())
                {
                    leMedicament = unMedicament;
                }
            }
            contenuDemande.Remove(leMedicament);
            listMedocDemande.Items.Clear();
            foreach (KeyValuePair<Medicament, int> value in contenuDemande)
            {
                string[] monContenu = new string[3];
                ListViewItem itm;
                leMedicament = value.Key;
                string uneId = leMedicament.getId() + "";
                monContenu[0] = uneId;
                monContenu[1] = leMedicament.getNom();
                monContenu[2] = contenuDemande[leMedicament] + "";
                itm = new ListViewItem(monContenu);
                listMedocDemande.Items.Add(itm);
            }            
        }
    }
}
