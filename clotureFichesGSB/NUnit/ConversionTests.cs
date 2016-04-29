using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using clotureFichesGSB;

namespace NUnit
{
    [TestFixture]
    public class ConversionTests
    {

    //Teste la conversion d'un objet de type date en type string ne comprenant que le mois
        [Test]
        public void dateVersStringMois() 
        {
            DateTime date = new DateTime(2011,04,24);
            Assert.AreEqual("04", clotureFichesGSB.Conversion.dateVersStringMois(date));
        }

     //Teste la conversion d'un objet de type date en type string ne comprenant que l'année
        [Test]
        public void dateVersStringAnnee()
        {
            DateTime date = new DateTime(2011,04,24);
            Assert.AreEqual("2011", clotureFichesGSB.Conversion.dateVersStringAnnee(date));
        }
    }
}
