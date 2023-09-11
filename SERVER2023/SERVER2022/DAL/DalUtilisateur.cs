using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SERVER2023.Domain;
using SERVER2023.DAL;

namespace SERVER2023.DAL
{
    class DalUtilisateur
    {
   
        #region"chaine de connection"
        public static MySqlConnection con = new MySqlConnection(ChaineConnexion.ConnectionString);
        public static MySqlCommand cmd;
        public static MySqlCommandBuilder cmd1;
        public static MySqlDataAdapter adapter;
        public static int ver;
        public static string req;
        private static string nouser, date;
        #endregion

        #region"Insertion sur les utilisateurs"
        public static int InsererUtilisateur(Utilisateur us)
        {


            try
            {
                
                req = "insert into tblutilisateur values ('" + us.getCode() + "','" + us.getCode_Employe() + "','" + us.getFonction() + "','" +
                us.getUser() + "','" + us.getPassword() + "','" + us.getModule_acces() + "','" + us.getDate() + "','" + us.getEtat() + "')";
                con.Open();
                cmd = new MySqlCommand(req, con);
                ver = cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(" DAL" + ex.Message);
            }

            finally
            {
                con.Close();
            }
            return ver;



        }
        #endregion

        #region"methode rechercher utilisateur"
        public static Utilisateur Rechercherutilisateur(string cod)
        {
            Utilisateur rech = new Utilisateur();
            string req = "Select * from tblutilisateur where code_utilisateur='" + cod + "' or code_empl='" + cod + "'";
            try
            {
                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    rech.setCode(rd[0].ToString());
                    rech.setCode_Employe(rd[1].ToString());
                    rech.setFonction(rd[2].ToString());
                    rech.setUser(rd[3].ToString());
                    rech.setPassword(rd[4].ToString());
                    rech.setModule_acces(rd[5].ToString());
                    rech.setDate(Convert.ToDateTime(rd[6].ToString()));
                    rech.setEtat(Convert.ToInt32(rd[7].ToString()));
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return rech;
        }
        #endregion

        #region"Modification utilisateur"
        public static int ModifierUtilisateur(string co, string cod, string fon, string us, string pas,string moda, DateTime dat,int et)
        {


            string req = "Update tblutilisateur set code_empl='" + cod + "', fonction='" + fon + "',user='" + us + "',password='" + pas + "',module_acces='" + moda + "',date_insc='" + dat + "',etat='" + et + "' where code_utilisateur='" + co + "'";
            int ver = 0;
            try
            {
                con.Open();
                cmd = new MySqlCommand(req, con);
                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception ef)
            {
                MessageBox.Show(ef.Message);
            }
            finally
            {
                con.Close();
            }
            return ver;
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

        #region"Afficher Utilisateur"
        public static DataSet afficherutilisateurparcode(string code)
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select* from tblutilisateur where code_utilisateur = '" + code + "'";
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

        #region"Methode de Suppression"
        public static int SupprimerUtilisateur(string co)
        {
            string req = "delete from tblutilisateur where code_utilisateur='" + co + "'";
            int var = 0;
            try
            {
                con.Open();
                cmd = new MySqlCommand(req, con);
                var = cmd.ExecuteNonQuery();

            }
            catch (Exception ed)
            {
            }
            finally
            {
                con.Close();
            }
            return var;
        }

        #endregion

        #region"gestion de connection"
        public static Utilisateur Rechercheruser(string us, string pas)
        {
            nouser = us;
            Utilisateur rech = new Utilisateur();
            string req = "Select * from tblutilisateur where user='" + us + "' and password='" + pas + "'";
              try
            {
                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    rech.setCode(rd[0].ToString());
                    rech.setCode_Employe(rd[1].ToString());
                    rech.setFonction(rd[2].ToString());
                    rech.setUser(rd[3].ToString());
                    rech.setPassword(rd[4].ToString());
                    rech.setModule_acces(rd[5].ToString());
                    rech.setDate(Convert.ToDateTime(rd[6].ToString()));
                    rech.setEtat(Convert.ToInt32(rd[7].ToString()));
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return rech;
        }
        #endregion

        #region"Afficher Code employer pour enregistrer Utlisateur"
        public static DataTable AfficherCodeEmployerUtilisateur()
        {

            //creation instance de type dataset
            DataTable data = new DataTable();
            // requete de selection
            req = "SELECT id FROM employe WHERE id NOT IN (SELECT DISTINCT code_empl FROM tblutilisateur)";
            //ouverture de la connexion
            con.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data);
            //retoure de l'instance data
            con.Close();
            return data;


        }
        #endregion


        #region"Informations transaction sur les utilisateurs"
        public static int InsererTransaction(Tracer tr)
        {
            date = DateTime.Today.Date.ToShortDateString();

          
            string req = "insert into tbltracabilite(code_utilisateur,libele,date_tra) values ('" + tr.Getcode() + "','" + tr.GetLibele() + "','" + tr.GetDate() + "')";
            int ver = 0;
            try
            {

               con.Open();


                cmd = new MySqlCommand(req, con);
                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception ef)
            {
            }
            finally
            {
                con.Close();
            }
            return ver;
        }
        #endregion

        public static int ModifierEtat(string co, int et)
        {


            string req = "Update tblutilisateur set  etat='" + et + "' where code_utilisateur='" + co + "'";
            int ver = 0;
            try
            {

                con.Open();


                cmd = new MySqlCommand(req, con);
                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception ef)
            {
            }
            finally
            {
                con.Close();
            }
            return ver;
        }






    }
}
