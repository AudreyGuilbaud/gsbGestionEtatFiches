using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clotureFichesGSB {
    public abstract class GestionDates {
        
        //Retourne le numéro du mois obtenu après avoir soustrait le nombre de mois passé en paramètre à la date passée en paramètre.
        private static string calculMois(DateTime mois, int nbMois) 
        {
            string resultat = Conversion.dateVersStringMois(mois.AddMonths(nbMois));
            return resultat;
        }

        //Retourne le numéro du mois obtenu après soustrait le nombre de mois passé en paramètre à la date du jour.
        private static string calculMois(int mois)
        {
            return calculMois(DateTime.Today, mois);
        }

        //Retourne le numéro du mois précédent par rapport à la date passée en paramètre.
        public static string getMoisPrecedent(DateTime mois) 
        {
            return calculMois(mois, -1);
        }

        //Retourne le numéro du mois précédent par rapport à la date du jour.
        public static string getMoisPrecedent()
        {
            return calculMois(-1);
        }

        //Retourne le numéro du mois suivant par rapport à la date passée en paramètre.
        public static string getMoisSuivant(DateTime mois) 
        {
            return calculMois(mois, 1);
        }

        //Retourne le numéro du mois suivant par rapport à la date du jour.
        public static string getMoisSuivant() 
        {
            return calculMois(1);
        }

        //Retourne vrai si le numéro du jour de la date passée en paramètre est comprise entre les deux numéros passés en paramètres.
        public static bool entre(DateTime jourEntre, int jourInf, int jourSup) 
        {
            int jour = Conversion.objectVersInt(jourEntre.Day);
            return ( (jour >= jourInf) && (jour <= jourSup) ) ;
        }

        //Retourne vrai si le numéro du jour de la date du jour est comprise entre les deux numéros passés en paramètres.
        public static bool entre(int jourInf, int jourSup)
        {
            return entre(DateTime.Today, jourInf, jourSup);
        }

        //Retourne l'année du mois précédent du mois passé en paramètre(notamment pour traiter le mois de janvier)
        public static string getAnneePrecedent(DateTime mois)
        {
            string resultat = Conversion.dateVersStringAnnee(mois.AddMonths(-1));
            return resultat;
        }

        //Retourne l'année du mois précédent du jour
        public static string getAnneePrecedent() {
            return getAnneePrecedent(DateTime.Today);
        }


        //Retourne la concaténation du mois et de l'année précédent de la date passée en paramètre.
        public static string getMoisAnneePrecedent(DateTime moisAnnee) 
        {
            string mois = getMoisPrecedent(moisAnnee);
            string annee = getAnneePrecedent(moisAnnee);
            string resultat = annee + mois;
            return resultat;
        }

        //Retourne la concanténation du mois et de l'annnée précédent de la date du jour.
        public static string getMoisAnneePrecedent() {
            return getMoisAnneePrecedent(DateTime.Today);
        }

    }
}
