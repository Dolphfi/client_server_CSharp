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
    internal class DalDashboard
    {
        #region"Chaine de connection"
        public static MySqlConnection con = new MySqlConnection(ChaineConnexion.ConnectionString);
        public static MySqlCommand cmd;
        public static MySqlCommandBuilder cmd1;
        public static MySqlDataAdapter adapter;
        public static int ver;
        public static string req;
        #endregion

        #region"Afficher Quantite Client"

        public static int AfficherQuantiteClient()
        {
            int compteur = 0;
            try
            {
                string req = "SELECT COUNT(*) FROM gestionclient";
                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    compteur = Convert.ToInt32(rd[0]);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return compteur;
        }
        #endregion

        #region"Afficher Quantite Compte"
        public static int AfficherQuantiteCompte()
        {
            int compteur = 0;
            try
            {
                string req = "SELECT COUNT(*) FROM gestioncompte";
                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    compteur = Convert.ToInt32(rd[0]);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return compteur;
        }

        #endregion

        #region"Afficher Quantite Utilisateur"
        public static int AfficherQuantiteUtilisateur()
        {
            int compteur = 0;
            try
            {
                string req = "SELECT COUNT(*) FROM tblutilisateur";
                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    compteur = Convert.ToInt32(rd[0]);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return compteur;
        }
        #endregion

        #region"Afficher Quantite Employe"
        public static int AfficherQuantiteEmploye()
        {
            int compteur = 0;
            try
            {
                string req = "SELECT COUNT(*) FROM employe";
                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    compteur = Convert.ToInt32(rd[0]);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return compteur;
        }


        #endregion

        #region"Afficher Quantite Depot"
        public static int AfficherQuantiteDepot()
        {
            int compteur = 0;
            try
            {
                string req = "SELECT COUNT(*) FROM depot";
                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    compteur = Convert.ToInt32(rd[0]);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return compteur;
        }

        #endregion

        #region"Afficher Quantite Retrait"
        public static int AfficherQuantiteRetrait()
        {
            int compteur = 0;
            try
            {
                string req = "SELECT COUNT(*) FROM retrait";
                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    compteur = Convert.ToInt32(rd[0]);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return compteur;
        }

        #endregion

        #region"Afficher Quantite Transfert"
        public static int AfficherQuantiteTransfert()
        {
            int compteur = 0;
            try
            {
                string req = "SELECT COUNT(*) FROM transfert";
                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    compteur = Convert.ToInt32(rd[0]);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return compteur;
        }

        #endregion


        #region"Afficher Quantite Transfert"
        public static int AfficherQuantitePayroll()
        {
            int compteur = 0;
            try
            {
                string req = "SELECT COUNT(*) FROM payroll";
                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    compteur = Convert.ToInt32(rd[0]);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return compteur;
        }

        #endregion

    }
}
