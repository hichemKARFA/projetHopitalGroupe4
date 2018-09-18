﻿using System;
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
    public partial class AjouterMedicament : Form
    {
        public AjouterMedicament()
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
            Stock stock = new Stock();
            this.Hide();
            stock.ShowDialog();
        }

        private void lblAjouterMedicament_Click(object sender, EventArgs e)
        {

        }
    }
}
