using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Librairie MySQL ajoutée dans les références.
using MySql.Data.MySqlClient;


namespace clotureFichesGSB
{

    public class AccesDonnees
    {

        private string host = "localhost";
        private string database = "gsb_frais";
        private string user = "root";
        private string password = "ppe";
        private MySqlConnection connexion;

        /// <summary>
        /// Constructeur de la classe AccesDonnees : crée un objet d'accès à la base de données
        /// </summary>
        public AccesDonnees(/*string host, string database, string user, string password*/)
        {
            this.Initialize();
        }


        /// <summary>
        ///  Méthode pour initialiser la connexion.
        /// </summary>
        private void Initialize()
        {
            // Création de la chaîne de connexion
            string connect = "SERVER=" + host + "; DATABASE=" + database + "; UID=" + user + "; PASSWORD=" + password;
            this.connexion = new MySqlConnection(connect);
        }

        /// <summary>
        /// Get Serveur.
        /// </summary>
        /// <returns></returns> 
        public string getHost()
        {
            return this.host;
        }

        /// <summary>
        /// Get Mot de passe.
        /// </summary>
        /// <returns></returns>
        public string getPassword()
        {
            return this.password;
        }

        /// <summary>
        /// Get Utilisateur.
        /// </summary>
        /// <returns></returns>
        public string getUser()
        {
            return this.user;
        }

        /// <summary>
        /// Get Base de données
        /// </summary>
        /// <returns></returns>
        public string getDatabase()
        {
            return this.database;
        }

        /// <summary>
        ///  Méthode pour exécuter requêtes d'insertion/modification/suppression
        /// </summary>
        /// <param name="requete"></param>
        /// <param name="valeur"></param>
        /// <param name="cle"></param>
        public void exec(string requete, string[] valeur, string[] cle)
        {
            try
            {
                // Ouverture de la connexion SQL (curseur)
                this.connexion.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connexion.CreateCommand();

                // Requête SQL
                cmd.CommandText = requete;


                for (int i = 0; i <= cle.Length - 1; i++)
                {
                    cmd.Parameters.AddWithValue(cle[i], valeur[i]);
                }
                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                this.connexion.Close();
            }
            catch
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }
        }

        /// <summary>
        /// méthode pour exécuter requête de recherche à résultat unique
        /// </summary>
        /// <param name="requete"></param>
        /// <param name="valeur"></param>
        /// <param name="cle"></param>
        /// <returns></returns>
        public object query(string requete, string[] valeur, string[] cle)
        {
            //try {
            // Ouverture de la connexion SQL
            this.connexion.Open();
            object resultat = null;

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = this.connexion.CreateCommand();

            // Requête SQL
            cmd.CommandText = requete;

            for (int i = 0; i <= cle.Length - 1; i++)
            {
                cmd.Parameters.AddWithValue(cle[i], valeur[i]);
            }

            // Exécution de la commande SQL                
            resultat = cmd.ExecuteScalar();
            // Fermeture de la connexion
            this.connexion.Close();

            return resultat;

            /*} catch {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }*/
        }


        /// <summary>
        /// méthode pour exécuter requête de recherche à résultats multiples
        /// </summary>
        /// <param name="requete"></param>
        /// <param name="valeur"></param>
        /// <param name="cle"></param>
        /// <returns></returns>
        public MySqlDataReader queryAll(string requete, string[] valeur, string[] cle)
        {
            //try {
            // Ouverture de la connexion SQL
            this.connexion.Open();
            MySqlDataReader resultats = null;

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = this.connexion.CreateCommand();

            // Requête SQL
            cmd.CommandText = requete;

            for (int i = 0; i <= cle.Length - 1; i++)
            {
                cmd.Parameters.AddWithValue(cle[i], valeur[i]);
            }

            // Exécution de la commande SQL
            resultats = cmd.ExecuteReader();
            // Fermeture de la connexion
            this.connexion.Close();
            return resultats;

            /*} catch {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }*/
        }

        /// <summary>
        /// méthode pour exécuter requête de recherche à résultat unique sans paramètres
        /// </summary>
        /// <param name="requete"></param>
        /// <returns></returns>
        public object querySansParam(string requete)
        {
            //try {
            // Ouverture de la connexion SQL
            this.connexion.Open();
            object resultat = null;

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = this.connexion.CreateCommand();

            // Requête SQL
            cmd.CommandText = requete;

            // Exécution de la commande SQL                
            resultat = cmd.ExecuteScalar();
            // Fermeture de la connexion
            this.connexion.Close();

            return resultat;

            /*} catch {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }*/
        }

        /// <summary>
        /// méthode pour exécuter requête de recherche à résultats multiples sans paramètres
        /// </summary>
        /// <param name="requete"></param>
        /// <param name="valeur"></param>
        /// <param name="cle"></param>
        /// <returns></returns>
        public MySqlDataReader queryAllSansParam(string requete, string[] valeur, string[] cle)
        {
            //try {
            // Ouverture de la connexion SQL
            this.connexion.Open();
            MySqlDataReader resultats = null;

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = this.connexion.CreateCommand();

            // Requête SQL
            cmd.CommandText = requete;

            // Exécution de la commande SQL
            resultats = cmd.ExecuteReader();
            // Fermeture de la connexion
            this.connexion.Close();
            return resultats;

            /*} catch {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }*/
        }
    }
}