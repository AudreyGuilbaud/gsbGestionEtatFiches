using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace NUnit
{
    [TestFixture]
    public class TestsBDD
    {
            [Test]
            public void testConnexion()
            {
                AccesDonnees accesDonneesTest = new AccesDonnees();
                Assert.AreEqual(true, accesDonneesTest, "Acces données refusé");
            }
    }
   
}
