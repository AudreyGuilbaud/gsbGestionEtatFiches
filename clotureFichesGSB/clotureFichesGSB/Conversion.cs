using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clotureFichesGSB
{
    abstract class Conversion
    {

        //Convertit un objet de type object vers une variable de type int
        public static int objectVersInt(object valeur)
        {
            int resultat = Convert.ToInt32(valeur);
            return resultat;
        }

        //Convertit un objet de type object vers un objet de type String
        public static string objectVersString(object valeur)
        {
            string resultat = valeur.ToString();
            return resultat;
        }

        //Convertit un objet de type Date vers un objet de type String en ne récupérant que le mois
        public static string dateVersStringMois(DateTime date)
        {
            string mois = date.ToString("MM");
            return mois;
        }
    }
}
