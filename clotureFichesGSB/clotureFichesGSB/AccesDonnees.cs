using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Librairie MySQL ajoutée dans les références.
using MySql.Data.MySqlClient;


namespace clotureFichesGSB {

    public class AccesDonnees {

        private string host = "localhost";
        private string database = "gsb_frais";
        private string user = "root";
        private string password = "ppe";
        private MySqlConnection connexion;

        // Constructeur
        public AccesDonnees(/*string host, string database, string user, string password*/)
        {

            /*if (host != null) {
                this.host = host;
            }

            if (database != null) {
                this.database = database;
            }

            if (user != null) {
                this.user = user;
            }

            if (password != null) {
                this.password = password ;
            }*/

            this.Initialize();
        }


        // Méthode pour initialiser la connexion
        private void Initialize()
        {
            // Création de la chaîne de connexion
            string connect = "SERVER=" + host + "; DATABASE=" + database + "; UID=" + user + "; PASSWORD=" + password;
            //Console.WriteLine(connect);
            //Console.ReadKey();
            this.connexion = new MySqlConnection(connect);
        }

        // Accesseurs


        public string getHost()
        {
            return this.host;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getUser()
        {
            return this.user;
        }

        public string getDatabase()
        {
            return this.database;
        }

        public MySqlConnection getConnexion()
        {
            return this.connexion ;
        }


        /*
                public void setHost(string host) {
                    this.host = host;
                }

                public void setDatabase(string database) {
                    this.database = database;
                }
 
                public void setUser(string user) {
                    this.user = user;
                }

                public void setPassword(string password) {
                    this.password = password;
                }
          */



              
                // Méthode pour exécuter requêtes d'insertion/modification/suppression
                public void exec(string requete, string[] valeur, string[] cle) {
                    try {
                        // Ouverture de la connexion SQL (curseur)
                        this.connexion.Open();

                        // Création d'une commande SQL en fonction de l'objet connection
                        MySqlCommand cmd = this.connexion.CreateCommand();

                        // Requête SQL
                        cmd.CommandText = requete;


                        for (int i = 0; i <= cle.Length-1; i++) {
                            cmd.Parameters.AddWithValue(cle[i], valeur[i]);
                        }
                        // Exécution de la commande SQL
                        cmd.ExecuteNonQuery();

                        // Fermeture de la connexion
                        this.connexion.Close();
                    } catch {
                        // Gestion des erreurs :
                        // Possibilité de créer un Logger pour les exceptions SQL reçus
                        // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
                    }
                }

                //méthode pour exécuter requête de recherche à résultat unique
                public object query(string requete, string[] valeur, string[] cle){
                    //try {
                        // Ouverture de la connexion SQL
                        this.connexion.Open();
                        object resultat = null;

                        // Création d'une commande SQL en fonction de l'objet connection
                        MySqlCommand cmd = this.connexion.CreateCommand();

                        // Requête SQL
                        cmd.CommandText = requete;

                        for (int i = 0; i <= cle.Length-1; i++) {
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


                //méthode pour exécuter requête de recherche à résultats multiples
                public MySqlDataReader queryAll(string requete, string[] valeur, string[] cle) {
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

                //méthode pour exécuter requête de recherche à résultat unique sans paramètres
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

                //méthode pour exécuter requête de recherche à résultats multiples sans paramètres
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

