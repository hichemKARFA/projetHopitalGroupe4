using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetHopital
{
    class Médicament
    {
        private int id;
        private string nom;
        private int stock;
        private int seuil;

        public Médicament(int pId, string pNom, int pStock, int pSeuil)
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
        public int getStock()
        {
            return stock;
        }
        public int getSeuil()
        {
            return seuil;
        }
        public string getNom()
        {
            return nom;
        }

        public override string ToString()
        {
            return "Médicament n°"+id +"\nNom :"+nom+"\nStock :"+stock+"\nSeuil :"+seuil;
        }
    }
}
