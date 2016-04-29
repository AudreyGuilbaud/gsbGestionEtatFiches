using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
            Timer timer = new Timer(10000);
            timer.Start();
                    
        }
    }
}
