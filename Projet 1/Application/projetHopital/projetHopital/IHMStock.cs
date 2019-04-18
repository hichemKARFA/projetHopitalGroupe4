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
    public partial class IHMStock : Form
    {
        public IHMStock()
        {
            InitializeComponent();
        }

        private void lblStock_Click(object sender, EventArgs e)
        {

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

        private void Stock_Load(object sender, EventArgs e)
        {
            ArrayList lesMedicaments=new ArrayList();
            lesMedicaments=Passerelle.listeMedicaments();
            foreach (Medicament unMedicament in lesMedicaments)
            {
                string[] arr = new string[4];
                ListViewItem itm;
                arr[0] = unMedicament.getId()+"";
                arr[1] = unMedicament.getNom();
                arr[2] = unMedicament.getStock()+"";
                arr[3] = unMedicament.getSeuil() + "";
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
        }

        private void btnAjtMedicament_Click(object sender, EventArgs e)
        {
            
            IHMAjouterMedicament ajtMedoc = new IHMAjouterMedicament();
            this.Hide();
            ajtMedoc.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            IHMModifierStock modif = new IHMModifierStock(id);
            this.Hide();
            modif.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            bool test=false;
            int medicament = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            test = Passerelle.verifContenuDemande(medicament);
            if (test == true)
            {
                DialogResult result1 = MessageBox.Show("La supression de ce médicament entrainera la suppression des demandes dans lesquels le médicament est present.\n\nVoulez vous continuer ?","Avertissement",MessageBoxButtons.YesNo);
                if(result1==DialogResult.Yes)
                {
                    Passerelle.supprimerContenuDemande(medicament);
                    Passerelle.supprimerDemande();
                    Passerelle.supprimerMedicament(medicament);
                }  
            }
            else
            {
                Passerelle.supprimerMedicament(medicament);
            }
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
                ;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
