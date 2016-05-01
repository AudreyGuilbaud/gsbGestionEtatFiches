using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clotureFichesGSB
{
    public abstract class Conversion
    {

        /// <summary>
        /// Convertit un objet de type object vers une variable de type int
        /// </summary>
        /// <param name="valeur"></param>
        /// <returns></returns>
        public static int objectVersInt(object valeur)
        {
            int resultat = Convert.ToInt32(valeur);
            return resultat;
        }

        /// <summary>
        /// Convertit un objet de type object vers un objet de type String
        /// </summary>
        /// <param name="valeur"></param>
        /// <returns></returns>
        public static string objectVersString(object valeur)
        {
            string resultat = valeur.ToString();
            return resultat;
        }

        /// <summary>
        /// Convertit un objet de type Date vers un objet de type String en ne récupérant que le mois 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string dateVersStringMois(DateTime date)
        {
            string mois = date.ToString("MM");
            return mois;
        }

        /// <summary>
        /// Convertit un objet de type Date vers un objet de type String en ne récupérant que l'année
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string dateVersStringAnnee(DateTime date)
        {
            string annee = date.ToString("yyyy");
            return annee;
        }
    }
}
