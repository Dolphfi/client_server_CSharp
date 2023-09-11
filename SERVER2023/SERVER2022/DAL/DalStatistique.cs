using SERVER2023.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER2023.DAL
{
    internal class DalStatistique
    {
        #region"Chaine de connection"
        public static MySqlConnection con = new MySqlConnection(ChaineConnexion.ConnectionString);
        public static MySqlCommand cmd;
        public static MySqlCommandBuilder cmd1;
        public static MySqlDataAdapter adapter;
        public static int ver;
        public static string req;
        #endregion

        #region"Afficher Compte"
        public static DataSet affichercompte()
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select* from gestioncompte";
            //ouverture de la connexion
            con.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "compte");
            //retoure de l'instance data
            con.Close();
            return data;
        }
        #endregion

        #region"Afficher Client"
        public static DataSet afficherclient()
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select* from gestionclient";
            //ouverture de la connexion
            con.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "client");
            //retoure de l'instance data
            con.Close();
            return data;
        }

        #endregion

        #region"Afficher Employer"
        public static DataSet AfficherEmploye()
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select *from employe ";
            //ouverture de la connexion
            con.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "employe");
            //retoure de l'instance data
            con.Close();
            return data;
        }
        #endregion

        #region"Afficher Utilisateur"
        public static DataSet AfficherUtilisateur()
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select *from tblutilisateur";
            //ouverture de la connexion
            con.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "utilisateur");
            //retoure de l'instance data
            con.Close();
            return data;
        }

        #endregion

        #region"Afficher Depot"
        public static DataSet AfficherDepot()
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select *from depot";
            //ouverture de la connexion
            con.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "depot");
            //retoure de l'instance data
            con.Close();
            return data;
        }
        #endregion

        #region"Afficher retrait"
        public static DataSet AfficherRetrait()
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select *from retrait";
            //ouverture de la connexion
            con.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "retrait");
            //retoure de l'instance data
            con.Close();
            return data;
        }
        #endregion

        #region"Afficher Transfert"
        public static DataSet AfficherTransfert()
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select *from transfert";
            //ouverture de la connexion
            con.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "transfert");
            //retoure de l'instance data
            con.Close();
            return data;
        }
        #endregion

        #region"Afficher Transfert"
        public static DataSet AfficherTracabilite()
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select *from tbltracabilite";
            //ouverture de la connexion
            con.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "tracabilite");
            //retoure de l'instance data
            con.Close();
            return data;
        }
        #endregion




        #region"Afficher Payroll"
        public static DataSet AfficherPayroll()
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select *from payroll";
            //ouverture de la connexion
            con.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "payroll");
            //retoure de l'instance data
            con.Close();
            return data;
        }
        #endregion


    }
}
