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
        //Constructeur
        public GestionTimer(int delaiTimer)
        {
            this.delaiTimer = delaiTimer;
            this.leTimer = new Timer();
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
            leTimer.AutoReset = true;
            leTimer.Enabled = true;
            leTimer.Elapsed += OnTimedEvent;
            leTimer.Start();          
        }
    }
}
