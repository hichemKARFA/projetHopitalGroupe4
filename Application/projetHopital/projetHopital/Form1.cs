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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblHopital_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous quittez le logiciel");
            Application.Exit();
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            Commande commande = new Commande();
            this.Hide();
            commande.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            this.Hide();
            stock.ShowDialog();
            
        }
    }
}
