using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading;


namespace clotureFichesGSB
{
    static class Demarrage
    {
        
        /// <summary>
        /// Point d'entrée principal de l'application. 
        /// Déclaration du timer.
        /// Ligne de commande.
        /// Déclaration du thread avec la fonction setTimer réalisant les opérations sur la base de données.
        /// Démarrage du thread.
        /// Durée infinie du thread.
        /// </summary>
        [STAThread]
        static void Main()
        {           
            GestionTimer timer = new GestionTimer(10000);
            Console.WriteLine("Actualisation de l'état des fiches du mois : " + GestionDates.getMoisPrecedentFrancais());
            Thread nonFermeture = new Thread(timer.setTimer);
            nonFermeture.Start();
            Thread.Sleep(Timeout.Infinite);
        }
    }
}
