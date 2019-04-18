using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetHopital
{
    public partial class IHMAccueil : Form
    {
        public IHMAccueil()
        {
            InitializeComponent();
        }

        private void lblHopital_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Vous quittez le logiciel");
            Application.Exit();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            IHMStock stock = new IHMStock();
            this.Hide();
            stock.ShowDialog();
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            IHMCommande commande = new IHMCommande();
            this.Hide();
            commande.ShowDialog();
        }

        private void btnDemande_Click(object sender, EventArgs e)
        {
            gestionDemandes demande = new gestionDemandes();
            this.Hide();
            demande.ShowDialog();
        }
    }
}
