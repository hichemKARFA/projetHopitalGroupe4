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
    public partial class gestionDemandes : Form
    {
        public gestionDemandes()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous quittez le logiciel");
            Application.Exit();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            IHMAccueil accueil = new IHMAccueil();
            this.Hide();
            accueil.ShowDialog();
        }

        private void gestionDemandes_Load(object sender, EventArgs e)
        {
            ArrayList lesDemandes = new ArrayList();
            lesDemandes = Passerelle.getDemandesEnAttente();
            foreach (Demande uneDemande in lesDemandes)
            {
                string[] arr = new string[3];
                ListViewItem itm;
                arr[0] = uneDemande.getId() + "";
                arr[1] = uneDemande.getNomUtilisateur();
                arr[2] = uneDemande.getLibelleEtat();
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAccepter_Click(object sender, EventArgs e)
        {
            ArrayList lesDemandes = new ArrayList();
            lesDemandes = Passerelle.getDemandesEnAttente();
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);



            int idMedicament = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            foreach (Demande maDemande in lesDemandes)
            {
                if (maDemande.getId() == id)
                {
                    ArrayList lesMedicaments;
                    lesMedicaments = Passerelle.listeMedicamentsParDemande(id);
                    foreach (Medicament leMedicament in lesMedicaments)
                    {
                        int uneQtte = Passerelle.getQtteMedicamentDemande(leMedicament.getId(), id);
                        Passerelle.ModifierStockMedicament(leMedicament.getId(), uneQtte);
                    }

                    Passerelle.AccepterDemande(id);
                }
                
                listView1.Items.Clear();
                lesDemandes = Passerelle.getDemandesEnAttente();
                foreach (Demande uneDemande in lesDemandes)
                {
                    string[] arr = new string[3];
                    ListViewItem itm;
                    arr[0] = uneDemande.getId() + "";
                    arr[1] = uneDemande.getNomUtilisateur();
                    arr[2] = uneDemande.getLibelleEtat();
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }            

        }

        private void btnRefuser_Click(object sender, EventArgs e)
        {
            ArrayList lesDemandes = new ArrayList();
            lesDemandes = Passerelle.getDemandesEnAttente();
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            foreach (Demande maDemande in lesDemandes)
            {
                if (maDemande.getId() == id)
                {
                    Passerelle.RefuserDemande(id);
                }
            }
            listView1.Items.Clear();
            lesDemandes = Passerelle.getDemandesEnAttente();
            foreach (Demande uneDemande in lesDemandes)
            {
                string[] arr = new string[3];
                ListViewItem itm;
                arr[0] = uneDemande.getId() + "";
                arr[1] = uneDemande.getNomUtilisateur();
                arr[2] = uneDemande.getLibelleEtat();
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
                
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int idDemande = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            IHMContenuDemande contenuDemande = new IHMContenuDemande(idDemande);
            this.Hide();
            contenuDemande.ShowDialog();
        }

        private void btnHistorique_Click(object sender, EventArgs e)
        {
            IHMHistoriqueDemande historiqueDemande = new IHMHistoriqueDemande();
            this.Hide();
            historiqueDemande.ShowDialog();
        }
    }
}
