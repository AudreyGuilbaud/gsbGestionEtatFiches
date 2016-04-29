using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clotureFichesGSB {
    abstract class GestionDates {
        
        //Retourne le numéro du mois obtenu après avoir soustrait le nombre de mois passé en paramètre à la date passée en paramètre.
        public static string calculMois(DateTime mois, int nbMois) 
        { 

        }

        //Retourne le numéro du mois obtenu après soustrait le nombre de mois passé en paramètre à la date du jour.
        public static string calculMois(int Mois)
        {

        }

        //Retourne le numéro du mois précédent par rapport à la date passée en paramètre.
        public static string getMoisPrecedent(DateTime mois) 
        {
            
        }

        //Retourne le numéro du mois précédent par rapport à la date du jour.
        public static string getMoisPrecedent()
        {

        }

        //Retourne le numéro du mois suivant par rapport à la date passée en paramètre.
        public static string getMoisSuivant(DateTime mois) 
        {

        }

        //Retourne le numéro du mois suivant par rapport à la date du jour.
        public static string getMoisSuivant() 
        { 
        
        }

        //Retourne vrai si le numéro du jour de la date passée en paramètre est comprise entre les deux numéros passés en paramètres.
        public static bool entre(int jourInf, int jourSup, DateTime jourEntre) 
        {

        }

        //Retourne vrai si le numéro du jour de la date du jour est comprise entre les deux numéros passés en paramètres.
        public static bool entre(int jourInf, int jourSup)
        {

        }



    }
}
