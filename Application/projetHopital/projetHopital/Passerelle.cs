using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace projetHopital
{
    class Passerelle
    {
        public void donnerConnection()
        {
            string chaineConnection = "Data Source=WIN-921C8FKTGAE;Initial Catalog=slam2019projetHopitalGroupe4;User ID=jablonski;Password=jablonski";
            SqlConnection maConnexion = new SqlConnection(chaineConnection);
            maConnexion.Open();
        }
        
        public void fermerConnection()
        {
            maConnexion.Close();
            Console.ReadLine();
        }
    }
}
