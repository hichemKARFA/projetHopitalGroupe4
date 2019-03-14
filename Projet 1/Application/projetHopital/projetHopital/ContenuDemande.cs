using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetHopital
{
    class ContenuDemande
    {
        private string medicament;
        private int quantite;

        public ContenuDemande(string pMedicament, int pQuantite)
        {
            medicament = pMedicament;
            quantite = pQuantite;
        }


        public string getMedicament()
        {
            return medicament;
        }

        public int getQuantite()
        {
            return quantite;
        }

    }
}
