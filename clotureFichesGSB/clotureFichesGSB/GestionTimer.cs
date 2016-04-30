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
        //Constructeur
        public GestionTimer(int delaiTimer)
        {
            this.delaiTimer = delaiTimer;
        }

        //Définition des actions du timer à chaque tick.
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            GestionFiches.clotureFiches();
            GestionFiches.miseEnPaiementFiches();
        }

        //Exécution du timer.
        public void setTimer()
        {
            Timer leTimer = new System.Timers.Timer(delaiTimer);
            leTimer.Elapsed += OnTimedEvent;
            leTimer.AutoReset = true;
            leTimer.Enabled = true;
        }
    }
}
