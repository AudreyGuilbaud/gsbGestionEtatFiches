using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using clotureFichesGSB;
using MySql.Data.MySqlClient;

namespace NUnit
{
    [TestFixture]
    public class AccesDonneesTests
    {
        //Vérification du serveur
        [Test]
        public void getHost()
        {
            clotureFichesGSB.AccesDonnees accesDonnees = new AccesDonnees();
            Assert.AreEqual("localhost", accesDonnees.getHost());
        }

        //Vérification de la base de données
        [Test]
        public void getDatabase()
        {
            clotureFichesGSB.AccesDonnees accesDonnees = new AccesDonnees();
            Assert.AreEqual("gsb_frais", accesDonnees.getDatabase());
        }

        //Vérification de l'utilisateur
        [Test]
        public void getUser()
        {
            clotureFichesGSB.AccesDonnees accesDonnees = new AccesDonnees();
            Assert.AreEqual("root", accesDonnees.getUser());
        }

        //Vérification du mot de passe
        [Test]
        public void getPassword()
        {
            clotureFichesGSB.AccesDonnees accesDonnees = new AccesDonnees();
            Assert.AreEqual("ppe", accesDonnees.getPassword());
        }

    }
}