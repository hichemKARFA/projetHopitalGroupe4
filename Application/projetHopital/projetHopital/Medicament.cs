using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetHopital
{
    class Medicament
    {
        private int id;
        private string nom;
        private int stock;
        private int seuil;

        public Medicament(int pId, string pNom, int pStock, int pSeuil)
        {
            id = pId;
            nom = pNom;
            stock = pStock;
            seuil = pSeuil;
        }

        public int getId()
        {
            return id;
        }

        public string getNom()
        {
            return nom;
        }

        public int getStock()
        {
            return stock;
        }

        public int getSeuil()
        {
            return seuil;
        }
    }
}
