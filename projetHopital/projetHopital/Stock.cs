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
            Form1 accueil = new Form1();
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
            
        }

        private void btnAjtMedicament_Click(object sender, EventArgs e)
        {
            
            AjouterMedicament ajtMedoc = new AjouterMedicament();
            this.Hide();
            ajtMedoc.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            ModifierStock modif = new ModifierStock();
            this.Hide();
            modif.ShowDialog();
        }
    }
}
