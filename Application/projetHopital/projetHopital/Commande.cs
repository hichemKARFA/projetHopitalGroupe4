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
    public partial class Commande : Form
    {
        public Commande()
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
            Accueil accueil = new Accueil();
            this.Hide();
            accueil.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Commande_Load(object sender, EventArgs e)
        {
            ArrayList lesMedicaments = new ArrayList();
            lesMedicaments = Passerelle.listeMedicaments();
            foreach (Medicament unMedicament in lesMedicaments) //Affiche la liste
            {
                string[] arr = new string[4];
                ListViewItem itm;
                arr[0] = unMedicament.getId() + "";
                arr[1] = unMedicament.getNom();
                arr[2] = unMedicament.getStock() + "";
                arr[3] = unMedicament.getSeuil() + "";
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int quantite = int.Parse(txtQuantite.Text);
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            Passerelle.faireCommande(id,quantite);
            txtQuantite.Text = "";
            listView1.Items.Clear();
            ArrayList lesMedicaments = new ArrayList();
            lesMedicaments = Passerelle.listeMedicaments();
            foreach (Medicament unMedicament in lesMedicaments) // reaffiche la liste (pour mettre a jour)
            {
                string[] arr = new string[4];
                ListViewItem itm;
                arr[0] = unMedicament.getId() + "";
                arr[1] = unMedicament.getNom();
                arr[2] = unMedicament.getStock() + "";
                arr[3] = unMedicament.getSeuil() + "";
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            
            
        }
    }
}
