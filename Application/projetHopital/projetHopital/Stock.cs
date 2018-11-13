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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void lblStock_Click(object sender, EventArgs e)
        {

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
            
            AjouterMedicament ajtMedoc = new AjouterMedicament();
            this.Hide();
            ajtMedoc.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ModifierStock modif = new ModifierStock(id);
            this.Hide();
            modif.ShowDialog();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            Passerelle.supprimerMedicament(id);
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
