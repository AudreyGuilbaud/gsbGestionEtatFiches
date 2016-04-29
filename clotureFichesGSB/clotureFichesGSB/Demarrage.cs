using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace clotureFichesGSB
{
    static class Demarrage
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AccesDonnees accesDonnees = new AccesDonnees();
            string req = "SELECT mois, idEtat FROM fichefrais WHERE idVisiteur = @idVisiteur AND nbJustificatifs = @nbJustificatifs";
            Console.WriteLine(req);
            Console.ReadKey();

            string[] cle = {"@idVisiteur" , "@nbJustificatifs"} ;
            for (int i = 0; i <= cle.Length - 1; i++)
            {
                Console.WriteLine(cle[i]);
                Console.ReadKey();
            }

            string[] valeur = { "a131", "8" };
            for (int i = 0; i <= valeur.Length - 1; i++)
            {                
                Console.WriteLine(valeur[i]);
                Console.ReadKey();
            }

           

                    
        }
    }
}
