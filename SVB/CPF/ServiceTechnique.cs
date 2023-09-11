using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CFP
{
    class ServiceTechnique
    {
        #region"Chainne de connection"
        public static string chcon = "Server=localhost;database=bd_svb; User Id=root; Password=";
        public static MySqlConnection sc = new MySqlConnection(chcon);
        public static MySqlCommand cmd;
        public static string req;
        public static string aff;
        public static int val, val1;
        #endregion

        // methode rechercher numoreCode
        #region"Code utilisateur et Modification"
        public static int RerchercherCodeAutoGestionUtilisateur()
        {
            int compteur = 0;
            try
            {
                string req = "select *from controlutilisateur";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    compteur = Convert.ToInt32(rd[0]);
                }

            }
            catch (Exception ex)
            {

            }
            finally {
                sc.Close();
            }
            return compteur;
        }





        public static int ModifierCodeGestionUtilisateur()
        {

            try
            {
                val = RerchercherCodeAutoGestionUtilisateur();
                val1 = val + 1;
                req = "update controlutilisateur set numerocode='" + val1 + "' where numerocode='" + val + "'";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }

            finally
            {
                sc.Close();
            }
            return val1;
        }
        #endregion

        #region"Code Auto Compte et Modificagtion"
        public static int RerchercherNumero_compteAutoGestionCompte()
        {
            int compteur = 0;
            try
            {
                string req = "select *from controlcompte";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
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
                sc.Close();
            }
            return compteur;
        }


        public static int ModifierNumero_compteGestionCompte()
        {

            try
            {
                val = RerchercherNumero_compteAutoGestionCompte();
                val1 = val + 1;
                req = "update controlcompte set numerocompte='" + val1 + "' where numerocompte='" + val + "'";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }

            finally
            {
                sc.Close();
            }
            return val1;
        }

        #endregion

        #region"Code Auto Employe et modification"
        public static int RerchercherCode_Auto_Gestion_Employe()
        {
            int compteur = 0;
            try
            {
                string req = "select *from controlemploye";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
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
                sc.Close();
            }
            return compteur;
        }

        public static int ModifierCode_Auto_Gestion_Employe()
        {

            try
            {
                val = RerchercherCode_Auto_Gestion_Employe();
                val1 = val + 1;
                req = "update controlemploye set numerocode='" + val1 + "' where numerocode='" + val + "'";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }

            finally
            {
                sc.Close();
            }
            return val1;
        }

        #endregion

        #region"Code Auto Depot et Modification"
        public static int RerchercherCodeAutoTransactionDepot()
        {
            int compteur = 0;
            try
            {
                string req = "select *from controldepot";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
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
                sc.Close();
            }
            return compteur;
        }


        public static int ModifierCodeAutoTransactionDepot()
        {

            try
            {
                val = RerchercherCodeAutoTransactionDepot();
                val1 = val + 1;
                req = "update controldepot set numerocode='" + val1 + "' where numerocode='" + val + "'";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }

            finally
            {
                sc.Close();
            }
            return val1;
        }
        #endregion

        #region"Code auto Transfert et Modification"

        public static int RerchercherCodeAutoTransactionTransfert()
        {
            int compteur = 0;
            try
            {
                string req = "select *from controltransfert";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
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
                sc.Close();
            }
            return compteur;
        }





        public static int ModifierCodeAutoTransactionTransfert()
        {

            try
            {
                val = RerchercherCodeAutoTransactionTransfert();
                val1 = val + 1;
                req = "update controltransfert set numerocode='" + val1 + "' where numerocode='" + val + "'";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }

            finally
            {
                sc.Close();
            }
            return val1;
        }

        #endregion

        #region"Code auto Retrait et Modification"
        public static int RerchercherCodeAutoTransactionRetrait()
        {
            int compteur = 0;
            try
            {
                string req = "select *from controlretrait";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
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
                sc.Close();
            }
            return compteur;
        }
        

        public static int ModifierCodeAutoTransactionRetrait()
        {

            try
            {
                val = RerchercherCodeAutoTransactionRetrait();
                val1 = val + 1;
                req = "update controlretrait set numerocode='" + val1 + "' where numerocode='" + val + "'";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }

            finally
            {
                sc.Close();
            }
            return val1;
        }


        #endregion


        #region"Code auto Payroll et Modification"
        public static int RerchercherCodeAutoTransactionPayroll()
        {
            int compteur = 0;
            try
            {
                string req = "select *from controlpayroll";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
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
                sc.Close();
            }
            return compteur;
        }


        public static int ModifierCodeAutoTransactionPayroll()
        {

            try
            {
                val = RerchercherCodeAutoTransactionPayroll();
                val1 = val + 1;
                req = "update controlpayroll set numerocode='" + val1 + "' where numerocode='" + val + "'";
                sc.Open();
                cmd = new MySqlCommand(req, sc);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }

            finally
            {
                sc.Close();
            }
            return val1;
        }


        #endregion


    }
}
