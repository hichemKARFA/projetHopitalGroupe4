using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace projetHopital
{
    class Passerelle
    {
        private static SqlConnection laConnection = null; // Acceder a la BBD
        private static bool seConnecter()
        {
            if (laConnection == null)
            {
                laConnection = new SqlConnection();
                laConnection.ConnectionString = "Data Source=WIN-921C8FKTGAE;Initial Catalog=slam2019projetHopitalGroupe4;User Id=jablonski;Password=jablonski";
                laConnection.Open();
                System.Diagnostics.Debug.WriteLine("instanciation connexion");

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("connexion existe");

            }
            return true;

        }


        public static bool seDeconnecter() // coupe la connection a la bdd
        {
            if (laConnection != null)
            {
                laConnection.Close();
                System.Diagnostics.Debug.WriteLine("déconnexion");
                laConnection = null;

            }
            return true;
        }
        public static bool verifUtilisateur(string identifiant, string mdp) // Verifie si l'utilisateur existe et si le login et mdp corresponde
        {
            bool test = false;
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT login,mdp FROM Utilisateurs WHERE login='"+identifiant+"' AND mdp ='"+mdp+"'";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                string idBdd = (string)unJeuResultat["login"];
                string mdpBdd = (string)unJeuResultat["mdp"];
                if (identifiant == idBdd && mdp == mdpBdd)
                {
                    test = true;
                }
            }
            seDeconnecter();
            return test;
        }

        public static ArrayList listeMedicaments() // donne la liste des medicaments 
        {
            ArrayList lesMedicaments = new ArrayList();
            seConnecter();
            SqlCommand maCommande;
            String requete = "select id, nom, stock, seuil from medicaments";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                int id=(int)unJeuResultat["id"];
                string nom=(string)unJeuResultat["nom"];
                int stock=(int)unJeuResultat["stock"];
                int seuil=(int)unJeuResultat["seuil"];
                Medicament unMedicament = new Medicament(id, nom, stock, seuil);
                lesMedicaments.Add(unMedicament);
            }
            seDeconnecter();
            return lesMedicaments;
        }

        public static bool getPharmacien(string identifiant, string mdp) //Savoir si la personne est un pharmacien ou un infirmier
        {
            bool test = false;
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT statut FROM Utilisateurs WHERE login='" + identifiant + "' AND mdp ='" + mdp + "'";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                int statutBdd = (int)unJeuResultat["statut"];
                if (statutBdd == 1)
                {
                    test = true;
                }
            }
            seDeconnecter();
            return test;
        }

        public static void faireCommande(int id,int quantite)
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "Update medicaments Set stock =(select stock from medicaments where id="+id+")+"+quantite+" where id="+id;
            maCommande = new SqlCommand(requete, laConnection);
            maCommande.ExecuteNonQuery();
            seDeconnecter();
        }
        /*  Hichem debut ajout
         public static bool ajoutMedicamet(Medicament unMedoc)
        {
            bool test = false;
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT statut FROM Utilisateurs WHERE login='" + identifiant + "' AND mdp ='" + mdp + "'";

        } */
    }
}
