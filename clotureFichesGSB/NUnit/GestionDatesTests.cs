using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using clotureFichesGSB;

namespace NUnit
{
    [TestFixture]
    public class GestionDatesTests
    {
        //Test mois précédent avec la date du jour
        [Test]
        public void getMoisPrecedentTest1()
        {
            Assert.AreEqual("03", clotureFichesGSB.GestionDates.getMoisPrecedent());
        }

        //Test mois précédent avec une date quelconque
        public void getMoisPrecedentTest2()
        {

        }
    }
}
