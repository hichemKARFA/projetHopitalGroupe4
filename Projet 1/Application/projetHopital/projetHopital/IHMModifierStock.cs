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
    public partial class IHMModifierStock : Form
    {
        private int id;
        public IHMModifierStock(int pId)
        {
            InitializeComponent();
            id = pId;
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

        private void ModifierStock_Load(object sender, EventArgs e)
        {
            Medicament unMedicament;
            unMedicament = Passerelle.trouverMedicament(id);
            txtNom.Text = unMedicament.getNom();
            txtQtte.Text = unMedicament.getStock()+"";
            txtSeuil.Text = unMedicament.getSeuil() + "";
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            if (txtNom.Text == string.Empty || txtQtte.Text == string.Empty || txtSeuil.Text == string.Empty)
            {
                MessageBox.Show("Veuillez renseigner toutes les informations ");
            }
            else
            {
                int stock, seuil;
                Boolean testQtte;
                Boolean testSeuil;
                testQtte = int.TryParse(txtQtte.Text, out stock);
                testSeuil = int.TryParse(txtSeuil.Text, out seuil);
                if (!testQtte || !testSeuil)
                {
                    MessageBox.Show("Vous n'avez pas saisi une quantité et/ou un seuil valide");
                }
                else
                {
                    string nom = txtNom.Text;
                    Medicament unMedicament = new Medicament(id, nom, stock, seuil);
                    bool test = Passerelle.modifierMedicament(unMedicament);
                    if (test == true)
                    {
                        MessageBox.Show("Le médicament à bien été modifié");
                        IHMStock stock2 = new IHMStock();
                        this.Hide();
                        stock2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue");
                    }
                }
            }

           
                

           

        }
    }
}
