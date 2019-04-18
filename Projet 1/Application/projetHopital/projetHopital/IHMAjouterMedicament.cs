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

            if (txtNom.Text == string.Empty || txtQuantite.Text == string.Empty || txtSeuil.Text==string.Empty)
            {
                MessageBox.Show("Veuillez renseigner toutes les informations ");
            }
            else
            {
                int qtte,seuil;
                Boolean testQtte;
                Boolean testSeuil;
                testQtte = int.TryParse(txtQuantite.Text, out qtte);
                testSeuil = int.TryParse(txtSeuil.Text, out seuil);
                if (!testQtte || !testSeuil)
                {
                    MessageBox.Show("Vous n'avez pas saisi une quantité et/ou un seuil valide");
                }
                else
                {
                    bool test;
                    Medicament unMedicament = new Medicament(Passerelle.trouverId("Medicaments"), txtNom.Text, qtte, seuil);
                    test = Passerelle.ajoutMedicament(unMedicament);
                    if (test == true)
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

               
            }

           
        }

        private void AjouterMedicament_Load(object sender, EventArgs e)
        {

        }
    }
}
