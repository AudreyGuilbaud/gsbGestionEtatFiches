using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clotureFichesGSB
{
    public abstract class GestionFiches
    {
        static string etatSaisie = "CR";
        static string etatCloture = "CL" ;
        static string etatMiseEnPaiement = "VA";
        static int jourMiseEnPaiement = 20;
        static string requeteUpdate = "UPDATE fichefrais SET idEtat = @idEtat WHERE idEtat = @idEtatActuel AND mois = @mois" ;
        static string[] cle = {"@idEtat", "@idEtatActuel", "@mois"} ;
        private static AccesDonnees accesDonnees = new AccesDonnees();
        

        //clôture des fiches créées le mois précédent et qui n'ont pas été clôturées
        public static void clotureFiches()
        {
            string[] valeur = { etatCloture, etatSaisie, GestionDates.getMoisAnneePrecedent() };           
            accesDonnees.exec(requeteUpdate, valeur, cle);
        }

       //mise en paiement des fiches créées le mois précédent à partir du 20 du mois
        public static void miseEnPaiementFiches()
        {
            if(GestionDates.entre(jourMiseEnPaiement,31)) {
                string[] valeur = {etatMiseEnPaiement, etatCloture, GestionDates.getMoisAnneePrecedent() };
                accesDonnees.exec(requeteUpdate, valeur, cle);
            }
        }
         
    }
}
