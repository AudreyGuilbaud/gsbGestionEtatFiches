using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clotureFichesGSB
{
    class Conversion
    {

        //Convertit un objet de type object vers une variable de type int
        public static int ObjectVersInt(object valeur)
        {
            int resultat = Convert.ToInt32(valeur);
            return resultat;
        }

        //Convertit un objet de type object vers une variable de type string
        public static string ObjectVersString(object valeur)
        {
            string resultat = valeur.ToString();
            return resultat;
        }
    }
}
