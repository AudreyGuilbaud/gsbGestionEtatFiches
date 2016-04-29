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
        [Test]
        public void getMoisPrecedentTest2()
        {

        }

        //Test mois précédent avec date particulière : janvier (donc mois = 01 moins un mois = 12)
        [Test]
        public void getMoisPrecedentTest3()
        {

        }

        //Test mois suivant avec la date du jour
        [Test]
        public void getMoisSuivantTest1()
        {
            Assert.AreEqual("05", clotureFichesGSB.GestionDates.getMoisSuivant());
        }

        //Test mois suivant avec une date quelconque
        [Test]
        public void getMoisSuivantTest2()
        {

        }

        //Test mois suivant avec date particulière : décembre (donc mois = 12 moins un mois = 01)
        [Test]
        public void getMoisSuivantTest3()
        {

        }

        //Test : le jour de la date du jour doit être compris entre les deux paramètres.
        [Test]
        public void entreTest1()
        {

        }


        //Test : le jour de la date du jour ne doit pas être compris entre les deux paramètres.
        [Test]
        public void entreTest2()
        {

        }

        //Test : le jour de la date passée en paramètre doit être compris entre les deux paramètres.
        [Test]
        public void entreTest3()
        {

        }

        //Test : le jour de la date passée en paramètre ne doit pas être compris entre les deux paramètres.
        [Test]
        public void entreTest4()
        {

        }
    }
}
