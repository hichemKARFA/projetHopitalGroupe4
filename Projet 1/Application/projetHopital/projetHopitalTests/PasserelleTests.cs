using Microsoft.VisualStudio.TestTools.UnitTesting;
using projetHopital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetHopital.Tests
{
    [TestClass()]
    public class PasserelleTests
    {
        
        [TestMethod()]
        public void seConnecterTest()
        {
            bool testConnexion =Passerelle.seConnecter();
            bool expected = true;
            Assert.AreEqual(expected, testConnexion, "erreur avec l'ouverture de la connexion");
            Passerelle.seDeconnecter();
        }

       



        [TestMethod()]
        public void seDeconnecterTestAvecCo()
        {
            Passerelle.seConnecter();
            bool testDeconnexion = Passerelle.seDeconnecter();
            bool expected = true;
            Assert.AreEqual(expected, testDeconnexion, "erreur avec la fermeture de connexion");
        }

        [TestMethod()]
        public void seDeconnecterTestSansco()
        {
            
            bool testDeconnexion = Passerelle.seDeconnecter();
            bool expected = false;
            Assert.AreEqual(expected, testDeconnexion, "erreur avec la fermeture de connexion");
        }




       
      [TestMethod()]
      public void verifVraiUtilisateurTest()
      {
            String login = "testpharmacien1";
            String mdp = "mdp";
            bool testVerifUtilisateur = Passerelle.verifUtilisateur(login, mdp);
            bool expected = true;
            Assert.AreEqual(expected, testVerifUtilisateur, "erreur avec la verification d'un utilisateur existant");
        }



        [TestMethod()]
        public void verifFauxUtilisateurTest()
        {
            String login = "faux";
            String mdp = "faux";
            bool testVerifUtilisateur = Passerelle.verifUtilisateur(login, mdp);
            bool expected = false;
            Assert.AreEqual(expected, testVerifUtilisateur, "erreur avec la verification d'un utilisateur inexistant");
        }


       

     [TestMethod()]
     public void getidUtilisateurTest()
     {
            String login = "testpharmacien1";
            String login2 = "testinfirmier1";
            int testGetIdUtilisateur = Passerelle.getidUtilisateur(login);
            int expected = 8;
            Assert.AreEqual(expected, testGetIdUtilisateur, "erreur avec la verification d'un utilisateur inexistant");

            testGetIdUtilisateur = Passerelle.getidUtilisateur(login2);
            expected = 7;
            Assert.AreEqual(expected, testGetIdUtilisateur, "erreur avec la verification d'un utilisateur inexistant");
        }


    [TestMethod()]
    public void verifStatutTest()
    {
            String login = "testpharmacien1";
            String login2 = "testinfirmier1";
            int testStatutUtilisateur = Passerelle.verifStatut(login);
            int expected = 1;
            Assert.AreEqual(expected, testStatutUtilisateur, "erreur avec la verification du statut d'un utilisateur pharmarcien");

            testStatutUtilisateur = Passerelle.verifStatut(login2);
            expected = 2;
            Assert.AreEqual(expected, testStatutUtilisateur, "erreur avec la verification du statut d'un utilisateur infirmier");
     }


        /*
   [TestMethod()]
   public void listeMedicamentsTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void creerDemandeTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void AjouterContenuDemandeTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void getDemandesEnAttenteTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void getDemandesHistoriqueTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void faireCommandeTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void ajoutMedicamentTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void trouverIdTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void trouverIdMaxTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void verifTableVideDemandesTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void supprimerMedicamentTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void trouverMedicamentTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void modifierMedicamentTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void verifContenuDemandeTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void supprimerContenuDemandeTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void supprimerDemandeTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void ModifierStockMedicamentTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void verifEtatDemandeTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void AccepterDemandeTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void RefuserDemandeTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void getQtteMedicamentDemandeTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void listeMedicamentsParDemandeTest()
   {
       Assert.Fail();
   }

   [TestMethod()]
   public void getContenuDemandeTest()
   {
       Assert.Fail();
   }
   */
    }
}