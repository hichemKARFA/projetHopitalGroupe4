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
    public partial class IHMHistoriqueDemande : Form
    {
        public IHMHistoriqueDemande()
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
            gestionDemandes demande = new gestionDemandes();
            this.Hide();
            demande.ShowDialog();
        }

        private void IHMHistoriqueDemande_Load(object sender, EventArgs e)
        {
            ArrayList lesDemandes = new ArrayList();
            lesDemandes = Passerelle.getDemandesHistorique();
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
}
