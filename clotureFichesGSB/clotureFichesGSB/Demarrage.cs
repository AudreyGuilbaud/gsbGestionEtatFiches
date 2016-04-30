using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


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
            //MessageBox.Show("L'application de gestion des états de fiches de frais a démarré.", "Démarrage de l'application", MessageBoxButtons.OK);
            timer.setTimer();             
        }


    }
}
