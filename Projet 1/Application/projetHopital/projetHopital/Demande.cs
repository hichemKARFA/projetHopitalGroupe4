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
        public Demande()
        {
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
                listView1.Items.Add(itm);
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {

        }
    }
}
