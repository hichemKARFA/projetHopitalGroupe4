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
    public partial class IHMContenuDemande : Form
    {
        private int idDemande;
        public IHMContenuDemande(int pIdDemande)
        {
            InitializeComponent();
            idDemande = pIdDemande;
        }

        private void IHMContenuDemande_Load(object sender, EventArgs e)
        {
            ArrayList contenuDemande = new ArrayList();
            contenuDemande = Passerelle.getContenuDemande(idDemande);
            foreach (ContenuDemande unMedicament in contenuDemande)
            {
                string[] arr = new string[2];
                ListViewItem itm;
                arr[0] = unMedicament.getMedicament();
                arr[1] = unMedicament.getQuantite() + "";
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
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
    }
}
