﻿using System;
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
                //laConnection.ConnectionString = "Server= localhost; Database= slam2019projetHopitalGroupe4; Integrated Security=True;";
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
                string loginBdd = (string)unJeuResultat["login"];
                string mdpBdd = (string)unJeuResultat["mdp"];
                if (identifiant == loginBdd && mdp == mdpBdd)
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
        public static void creerDemande(int pId, int pUtilisateur)
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "INSERT INTO Demandes VALUES (" + pId +"," + pUtilisateur +",2);";
            maCommande = new SqlCommand(requete, laConnection);
            maCommande.ExecuteNonQuery();
            seDeconnecter();
        }
        public static void AjouterContenuDemande(int pId, int pMedicament, int pQtte)
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "INSERT INTO ContenuDemande VALUES("+ pId +","+ pMedicament +","+ pQtte +");";
            maCommande = new SqlCommand(requete, laConnection);
            maCommande.ExecuteNonQuery();
            seDeconnecter();
        }

        public static ArrayList getDemandesEnAttente() // donne la liste des demandes pour un pharmacien
        {
            ArrayList lesDemandes = new ArrayList();
            seConnecter();
            SqlCommand maCommande;
            String requete = "select Demandes.id as idDemande, Utilisateurs.nom, Etat.libelle from Demandes JOIN Utilisateurs on Utilisateurs.id = Demandes.utilisateur JOIN Etat ON Demandes.etat = Etat.id where etat=2";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                int id = (int)unJeuResultat["idDemande"];
                string nom = (string)unJeuResultat["nom"];
                string etat = (string)unJeuResultat["libelle"];
                Demande uneDemande = new Demande(id,nom,etat);
                lesDemandes.Add(uneDemande);
            }
            seDeconnecter();
            return lesDemandes;
        }

        public static ArrayList getDemandesHistorique() // donne la liste des demandes pour un pharmacien
        {
            ArrayList lesDemandes = new ArrayList();
            seConnecter();
            SqlCommand maCommande;
            String requete = "select Demandes.id as idDemande, Utilisateurs.nom, Etat.libelle from Demandes JOIN Utilisateurs on Utilisateurs.id = Demandes.utilisateur JOIN Etat ON Demandes.etat = Etat.id where etat=1 or etat=3";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                int id = (int)unJeuResultat["idDemande"];
                string nom = (string)unJeuResultat["nom"];
                string etat = (string)unJeuResultat["libelle"];
                Demande uneDemande = new Demande(id, nom, etat);
                lesDemandes.Add(uneDemande);
            }
            seDeconnecter();
            return lesDemandes;
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

        
         public static bool ajoutMedicament(Medicament unMedicament)
        {
            bool test = false;
            int id=trouverId("Medicaments");
            seConnecter();
            SqlCommand maCommande;
            String requete = "Insert into medicaments values ("+unMedicament.getId()+",'"+unMedicament.getNom()+"',"+unMedicament.getStock()+","+unMedicament.getSeuil()+")";
            maCommande = new SqlCommand(requete, laConnection);
            maCommande.ExecuteNonQuery();
            seDeconnecter();
            test = true;
            return test;
        }

        public static int trouverId(string pnomTable)
         {
            int test=0, id;
            int resultat=0;
            seConnecter();
            SqlCommand maCommande;
            String requete = "Select id FROM "+ pnomTable+";";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read()&&resultat==0)
            {
                id = (int)unJeuResultat["id"];
                if(id!=test+1)
                {
                    resultat = test + 1;
                }
                test++;
            }
            if(resultat==0)
            {
                resultat = test+1;
            }
            seDeconnecter();
            return resultat;
         }

        public static int trouverIdMax(string pnomTable)
        {
            int id = 1;
            if (verifTableVideDemandes()==true)
            {
                seConnecter();
                SqlCommand maCommande;
                String requete = "Select Max(id) FROM " + pnomTable + ";";
                maCommande = new SqlCommand(requete, laConnection);

                id = (int)maCommande.ExecuteScalar();
            }
            
            return id;
        }

        public static bool verifTableVideDemandes()
        {
            seConnecter();
            bool test=false;
            SqlCommand maCommande;
            String requete = "Select count(id) FROM demandes";
            maCommande = new SqlCommand(requete, laConnection);

            if ((int)maCommande.ExecuteScalar() != 0)
            {
                test = true;
            }

            return test;
        }

        public static bool supprimerMedicament(int id)
        {
            bool test = false;
            seConnecter();
            SqlCommand maCommande;
            String requete = "Delete from medicaments where id="+id;
            maCommande = new SqlCommand(requete, laConnection);
            maCommande.ExecuteNonQuery();
            seDeconnecter();
            test = true;
            return test;
        }

        public static Medicament trouverMedicament(int id)
        {
            string nom;
            int stock, seuil;
            Medicament unMedicament = null;
            seConnecter();
            SqlCommand maCommande;
            String requete = "Select nom,stock,seuil from medicaments where id=" + id;
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                nom = (string)unJeuResultat["nom"];
                stock = (int)unJeuResultat["stock"];
                seuil = (int)unJeuResultat["seuil"];
                unMedicament = new Medicament(id, nom, stock, seuil);
            }
            seDeconnecter();
            return unMedicament;
        }

        public static bool modifierMedicament(Medicament unMedicament)
        {
            bool test = false;
            int id=unMedicament.getId();
            string nom=unMedicament.getNom();
            int stock=unMedicament.getStock();
            int seuil=unMedicament.getSeuil();
            seConnecter();
            SqlCommand maCommande;
            String requete = "Update medicaments set nom ='" + nom + "',stock=" + stock + ",seuil=" + seuil+" where id="+id;
            maCommande = new SqlCommand(requete, laConnection);
            maCommande.ExecuteNonQuery();
            seDeconnecter();
            test = true;
            return test;
        }

        public static int getidUtilisateur(string pLogin)
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT id FROM Utilisateurs WHERE login='" + pLogin + "';";
            maCommande = new SqlCommand(requete, laConnection);
            int id = (int)maCommande.ExecuteScalar();
            seDeconnecter();
            return id;
        }
        

        public static bool verifContenuDemande(int medicament)
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT COUNT(demande) FROM ContenuDemande WHERE medicament=" + medicament + ";";
            maCommande = new SqlCommand(requete, laConnection);
            int nbLignes=(int)maCommande.ExecuteScalar();
            bool test = false;
            if (nbLignes != 0)
            {
                test = true;
            }
            seDeconnecter();
            return test;
        }

        public static bool supprimerContenuDemande(int medicament)
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "DELETE FROM ContenuDemande WHERE medicament=" + medicament + ";";
            maCommande = new SqlCommand(requete, laConnection);
            maCommande.ExecuteNonQuery();
            seDeconnecter();
            bool test=true;
            return test;
        }
        public static bool supprimerDemande()
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "DELETE FROM Demandes WHERE ID NOT IN (SELECT demande FROM ContenuDemande);";
            maCommande = new SqlCommand(requete, laConnection);
            maCommande.ExecuteNonQuery();
            seDeconnecter();
            bool test = true;
            return test;
        }

        public static void ModifierStockMedicament(int pId, int pQtte)
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "Update medicaments Set stock = (stock -" + pQtte + ") WHERE id="+pId+";";
            maCommande = new SqlCommand(requete, laConnection);
            maCommande.ExecuteNonQuery();
            seDeconnecter();
        }

        public static int verifEtatDemande(int pId)
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "Select etat from demandes WHERE id=" + pId + ";";
            maCommande = new SqlCommand(requete, laConnection);
            int etat = (int)maCommande.ExecuteScalar();
            seDeconnecter();
            return etat;
        }

        public static void AccepterDemande(int pId)
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "Update Demandes Set etat = 1 WHERE id="+pId+";";
            maCommande = new SqlCommand(requete, laConnection);
            maCommande.ExecuteNonQuery();
            seDeconnecter();
        }
        public static void RefuserDemande(int pId)
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "Update Demandes Set etat = 3 WHERE id=" + pId + ";";
            maCommande = new SqlCommand(requete, laConnection);
            maCommande.ExecuteNonQuery();
            seDeconnecter();
        }
        public static int getQtteMedicamentDemande(int pIdMedoc, int pIdDemande)
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "Select quantite FROM ContenuDemande WHERE demande =" + pIdDemande + " AND medicament =" + pIdMedoc + ";";
            maCommande = new SqlCommand(requete, laConnection);
            int Qtte = (int)maCommande.ExecuteScalar();
            seDeconnecter();
            return Qtte;
        }

        public static ArrayList listeMedicamentsParDemande(int pId) // donne la liste des medicaments 
        {
            ArrayList lesMedicaments = new ArrayList();
            seConnecter();
            SqlCommand maCommande;
            String requete = "select medicament from ContenuDemande WHERE demande="+pId+";";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                int id = (int)unJeuResultat["medicament"];
                Medicament unMedicament = new Medicament(id, null, 0, 0);
                lesMedicaments.Add(unMedicament);
            }
            seDeconnecter();
            return lesMedicaments;
        }

        public static ArrayList getContenuDemande(int pIdDemande)
        {
            ArrayList lesMedicaments = new ArrayList();
            seConnecter();
            SqlCommand maCommande;
            String requete = "select nom, quantite from ContenuDemande join Medicaments on Medicaments.id=ContenuDemande.medicament WHERE demande=" + pIdDemande + ";";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                string medicament = (string)unJeuResultat["nom"];
                int quantite = (int)unJeuResultat["quantite"];
                ContenuDemande unMedicament = new ContenuDemande(medicament, quantite);
                lesMedicaments.Add(unMedicament);
            }
            seDeconnecter();
            return lesMedicaments;
        }

    }
}