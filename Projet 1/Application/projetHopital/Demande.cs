using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetHopital
{
    class Demande
    {
        int id;
        string nomUtilisateur;
        string libelleEtat;

        public Demande(int pId, string pNom, string pLibelle)
        {
            id = pId;
            nomUtilisateur = pNom;
            libelleEtat = pLibelle;
        }

        public int getId()
        {
            return id;
        }

        public string getNomUtilisateur()
        {
            return nomUtilisateur;
        }

        public string getLibelleEtat()
        {
            return libelleEtat;
        }
    }
}
