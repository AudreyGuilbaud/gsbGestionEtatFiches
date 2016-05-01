using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace clotureFichesGSB
{
    class GestionTimer
    {
        double delaiTimer;
        Timer leTimer;
        /// <summary>
        /// Constructeur de la classe GestionTimer : valorise les propriétés delaiTimer (pour le délai du timer) et instancie un objet de type Timer.
        /// </summary>
        /// <param name="delaiTimer"></param>
        public GestionTimer(int delaiTimer)
        {
            this.delaiTimer = delaiTimer;
            this.leTimer = new Timer();
        }

        /// <summary>
        /// Définition des actions du timer à chaque tick (les deux fonctions de modifications de données).
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            GestionFiches.clotureFiches();
            GestionFiches.miseEnPaiementFiches();
        }

        /// <summary>
        /// Exécution du timer (démarrage et répétition tic)
        /// </summary>
        public void setTimer()
        {
            GestionFiches.affichageConsole();
            leTimer.AutoReset = true;
            leTimer.Enabled = true;
            leTimer.Elapsed += OnTimedEvent;
            leTimer.Start();          
        }
    }
}
