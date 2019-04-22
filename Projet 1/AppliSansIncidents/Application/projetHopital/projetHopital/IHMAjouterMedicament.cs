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
    public partial class IHMAjouterMedicament : Form
    {
        public IHMAjouterMedicament()
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
            IHMStock stock = new IHMStock();
            this.Hide();
            stock.ShowDialog();
        }

        private void lblAjouterMedicament_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool test;
            Medicament unMedicament = new Medicament(Passerelle.trouverId("Medicaments"), txtNom.Text, int.Parse(txtQuantite.Text), int.Parse(txtSeuil.Text));
            test=Passerelle.ajoutMedicament(unMedicament);
            if (test==true)
            {
                MessageBox.Show("Le médicament à bien été ajouté");
                IHMStock stock = new IHMStock();
                this.Hide();
                stock.ShowDialog();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue");
            }
        }

        private void AjouterMedicament_Load(object sender, EventArgs e)
        {

        }
    }
}
