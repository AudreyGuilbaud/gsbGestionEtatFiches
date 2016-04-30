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
        /// </summary>
        [STAThread]
        static void Main()
        {           
            GestionTimer timer = new GestionTimer(10000);
            Thread nonFermeture = new Thread(timer.setTimer);
            nonFermeture.Start();
            Thread.Sleep(Timeout.Infinite);
        }
    }
}
