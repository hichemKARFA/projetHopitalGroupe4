using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace projetHopital
{
    class Passerelle
    {
        private static SqlConnection laConnection = null;
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


        public static bool seDeconnecter()
        {
            if (laConnection != null)
            {
                laConnection.Close();
                System.Diagnostics.Debug.WriteLine("déconnexion");
                laConnection = null;

            }
            return true;
        }
        public static bool verifUtilisateur(string identifiant, string mdp)
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
    }
}
