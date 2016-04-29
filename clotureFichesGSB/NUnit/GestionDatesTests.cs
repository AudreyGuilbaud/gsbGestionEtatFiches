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
            DateTime mois = new DateTime(2015,10,02);
            Assert.AreEqual("09", clotureFichesGSB.GestionDates.getMoisPrecedent(mois));
        }

        //Test mois précédent avec date particulière : janvier (donc mois = 01 moins un mois = 12)
        [Test]
        public void getMoisPrecedentTest3()
        {
            DateTime mois = new DateTime(2015, 01, 02);
            Assert.AreEqual("12", clotureFichesGSB.GestionDates.getMoisPrecedent(mois));
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
            DateTime mois = new DateTime(2015, 10, 02);
            Assert.AreEqual("11", clotureFichesGSB.GestionDates.getMoisSuivant(mois));
        }

        //Test mois suivant avec date particulière : décembre (donc mois = 12 moins un mois = 01)
        [Test]
        public void getMoisSuivantTest3()
        {
            DateTime mois = new DateTime(2015, 12, 02);
            Assert.AreEqual("01", clotureFichesGSB.GestionDates.getMoisSuivant(mois));
        }

        //Test : le jour de la date du jour doit être compris entre les deux paramètres.
        [Test]
        public void entreTest1()
        {
            Assert.IsTrue(clotureFichesGSB.GestionDates.entre(20,31)) ;
        }


        //Test : le jour de la date du jour ne doit pas être compris entre les deux paramètres.
        [Test]
        public void entreTest2()
        {
            Assert.IsFalse(clotureFichesGSB.GestionDates.entre(7, 14)) ;
        }

        //Test : le jour de la date passée en paramètre doit être compris entre les deux paramètres.
        [Test]
        public void entreTest3()
        {
            DateTime date = new DateTime(2015, 10, 15);
            Assert.IsTrue(clotureFichesGSB.GestionDates.entre(date,10, 30));
        }

        //Test : le jour de la date passée en paramètre ne doit pas être compris entre les deux paramètres.
        [Test]
        public void entreTest4()
        {
            DateTime date = new DateTime(2015, 10, 15);
            Assert.IsFalse(clotureFichesGSB.GestionDates.entre(date,7, 14));
        }

        //Test année du mois précédent avec date donnée en paramètre.
        [Test]
        public void getAnneePrecedentTest1() 
        {
            DateTime date = new DateTime(2013, 10, 15);
            Assert.AreEqual("2013", clotureFichesGSB.GestionDates.getAnneePrecedent(date));
        }

        //Test année du mois précédent avec date au mois de janvier.
        [Test]
        public void getAnneePrecedentTest2()
        {
            DateTime date = new DateTime(2012, 04, 15);
            Assert.AreEqual("2012", clotureFichesGSB.GestionDates.getAnneePrecedent(date));
        }

        //Test année du mois précédent avec date du jour.
        [Test]
        public void getAnneePrecedentTest3()
        {
            Assert.AreEqual("2016", clotureFichesGSB.GestionDates.getAnneePrecedent());
        }

        //Test année/mois précédent avec date donnée en paramètre.
        [Test]
        public void getMoisAnneePrecedentTest1()
        {
            DateTime date = new DateTime(2004, 08, 15);
            Assert.AreEqual("200407", clotureFichesGSB.GestionDates.getMoisAnneePrecedent(date));
        }

        //Test année/mois précédent avec date au mois de janvier.
        [Test]
        public void getMoisAnneePrecedentTest2()
        {
            DateTime date = new DateTime(2000, 01, 15);
            Assert.AreEqual("199912", clotureFichesGSB.GestionDates.getMoisAnneePrecedent(date));
        }

        //Test année du mois précédent avec date du jour.
        [Test]
        public void getMoisAnneePrecedentTest3()
        {
            Assert.AreEqual("201603", clotureFichesGSB.GestionDates.getMoisAnneePrecedent());
        }

    }
}
