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
        /// <summary>
        /// Vérification du serveur
        /// </summary>
        [Test]
        public void getHost()
        {
            clotureFichesGSB.AccesDonnees accesDonnees = new AccesDonnees();
            Assert.AreEqual("localhost", accesDonnees.getHost());
        }

        /// <summary>
        /// Vérification de la base de données
        /// </summary>
        [Test]
        public void getDatabase()
        {
            clotureFichesGSB.AccesDonnees accesDonnees = new AccesDonnees();
            Assert.AreEqual("gsb_frais", accesDonnees.getDatabase());
        }

        /// <summary>
        /// Vérification de l'utilisateur
        /// </summary>
        [Test]
        public void getUser()
        {
            clotureFichesGSB.AccesDonnees accesDonnees = new AccesDonnees();
            Assert.AreEqual("root", accesDonnees.getUser());
        }

        /// <summary>
        /// Vérification du mot de passe
        /// </summary>
        [Test]
        public void getPassword()
        {
            clotureFichesGSB.AccesDonnees accesDonnees = new AccesDonnees();
            Assert.AreEqual("ppe", accesDonnees.getPassword());
        }

    }
}