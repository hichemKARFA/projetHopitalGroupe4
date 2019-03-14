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
            lesDemandes = Passerelle.getDemandes();
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
    }
}
