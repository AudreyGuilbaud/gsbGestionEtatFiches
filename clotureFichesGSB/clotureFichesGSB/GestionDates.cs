using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clotureFichesGSB {
    public abstract class GestionDates {
        
        /// <summary>
        /// Retourne le numéro du mois obtenu après avoir soustrait le nombre de mois passé en paramètre à la date passée en paramètre.
        /// </summary>
        /// <param name="mois"></param>
        /// <param name="nbMois"></param>
        /// <returns></returns>
        private static string calculMois(DateTime mois, int nbMois) 
        {
            string resultat = Conversion.dateVersStringMois(mois.AddMonths(nbMois));
            return resultat;
        }

        /// <summary>
        /// Retourne le numéro du mois obtenu après soustrait le nombre de mois passé en paramètre à la date du jour.
        /// </summary>
        /// <param name="mois"></param>
        /// <returns></returns>
        private static string calculMois(int mois)
        {
            return calculMois(DateTime.Today, mois);
        }

        /// <summary>
        /// Retourne le numéro du mois précédent par rapport à la date passée en paramètre.
        /// </summary>
        /// <param name="mois"></param>
        /// <returns></returns>
        public static string getMoisPrecedent(DateTime mois) 
        {
            return calculMois(mois, -1);
        }

        /// <summary>
        /// Retourne le numéro du mois précédent par rapport à la date du jour.
        /// </summary>
        /// <returns></returns>
        public static string getMoisPrecedent()
        {
            return calculMois(-1);
        }

        /// <summary>
        /// Retourne le numéro du mois suivant par rapport à la date passée en paramètre.
        /// </summary>
        /// <param name="mois"></param>
        /// <returns></returns>
        public static string getMoisSuivant(DateTime mois) 
        {
            return calculMois(mois, 1);
        }

        /// <summary>
        /// Retourne le numéro du mois suivant par rapport à la date du jour.
        /// </summary>
        /// <returns></returns>
        public static string getMoisSuivant() 
        {
            return calculMois(1);
        }

        /// <summary>
        /// Retourne vrai si le numéro du jour de la date passée en paramètre est comprise entre les deux numéros passés en paramètres.
        /// </summary>
        /// <param name="jourEntre"></param>
        /// <param name="jourInf"></param>
        /// <param name="jourSup"></param>
        /// <returns></returns>
        public static bool entre(DateTime jourEntre, int jourInf, int jourSup) 
        {
            int jour = Conversion.objectVersInt(jourEntre.Day);
            return ( (jour >= jourInf) && (jour <= jourSup) ) ;
        }

        /// <summary>
        /// Retourne vrai si le numéro du jour de la date du jour est comprise entre les deux numéros passés en paramètres.
        /// </summary>
        /// <param name="jourInf"></param>
        /// <param name="jourSup"></param>
        /// <returns></returns>
        public static bool entre(int jourInf, int jourSup)
        {
            return entre(DateTime.Today, jourInf, jourSup);
        }

        /// <summary>
        /// Retourne l'année du mois précédent du mois passé en paramètre(notamment pour traiter le mois de janvier)
        /// </summary>
        /// <param name="mois"></param>
        /// <returns></returns>
        public static string getAnneePrecedent(DateTime mois)
        {
            string resultat = Conversion.dateVersStringAnnee(mois.AddMonths(-1));
            return resultat;
        }

        /// <summary>
        /// Retourne l'année du mois précédent du jour
        /// </summary>
        /// <returns></returns>
        public static string getAnneePrecedent() {
            return getAnneePrecedent(DateTime.Today);
        }


        /// <summary>
        /// Retourne la concaténation du mois et de l'année précédent de la date passée en paramètre.
        /// </summary>
        /// <param name="moisAnnee"></param>
        /// <returns></returns>
        public static string getMoisAnneePrecedent(DateTime moisAnnee) 
        {
            string mois = getMoisPrecedent(moisAnnee);
            string annee = getAnneePrecedent(moisAnnee);
            string resultat = annee + mois;
            return resultat;
        }

        /// <summary>
        /// Retourne la concaténation du mois et de l'annnée précédent de la date du jour.
        /// </summary>
        /// <returns></returns>
        public static string getMoisAnneePrecedent() {
            return getMoisAnneePrecedent(DateTime.Today);
        }

        /// <summary>
        /// Retourne la concaténation du mois précédent sous la forme MM/YYYY
        /// </summary>
        /// <returns></returns>
        public static string getMoisPrecedentFrancais()
        {
            string mois = getMoisPrecedent();
            string annee = getAnneePrecedent();
            string resultat = mois + "/" + annee;
            return resultat;
        }

    }
}
