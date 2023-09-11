using SERVER2023.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVER2023.DAL
{
    internal class DalCompte
    {
        #region"Chaine de connection"
        public static MySqlConnection con = new MySqlConnection(ChaineConnexion.ConnectionString);
        public static MySqlCommand cmd;
        public static MySqlCommandBuilder cmd1;
        public static MySqlDataAdapter adapter;
        public static int ver;
        public static string req;
        #endregion

        #region"Insertion Compte" 
        public static int InsererCompte(Compte conpt)
        {

            try
            {
                req = "insert into gestioncompte values ('" + conpt.GetNumero_compte() + "','" + conpt.GetTypec() + "','" + conpt.GetMonnaie() + "','" + conpt.GetSolde() + "','" +
                conpt.GetEtat() + "','" + conpt.GetDate() + "')";
                con.Open();
                cmd = new MySqlCommand(req, con);
                ver = cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
            return ver;
        }

        #endregion


        #region"Rechercher Compte"
        public static Compte RechercheCompte(string nm_c_c)
        {
            Compte rech = new Compte();
            string req = "select* from gestioncompte where numerocompte='" + nm_c_c + "'";
            try
            {

                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {

                    rech.SetNumero_compte(rd[0].ToString());
                    rech.SetTypec(rd[1].ToString());
                    rech.SetMonnaie(rd[2].ToString());
                    rech.SetSolde(Convert.ToDouble(rd[3]));
                    rech.SetEtat(rd[4].ToString());
                    rech.SetDate(Convert.ToDateTime(rd[5].ToString()));

                   

                }

            }

            catch (Exception ex)

            {
            }
            finally
            {

                con.Close();
            }

            return rech;

        }
        #endregion


        #region"Suppression compte"
        public static int SupprimerCompte(string nm_c_c)
        {

            string req = "delete from gestioncompte where numerocompte='" + nm_c_c + "' ";
            int del = 0;
            try
            {
                con.Open();
                cmd = new MySqlCommand(req, con);
                del = cmd.ExecuteNonQuery();

            }
            catch (Exception ed)
            {
            }
            finally
            {
                con.Close();
            }
            return del;
        }
        #endregion


        #region"Afficher Les Comptes"
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


        #region"Afficher Compte par numerocompte"
        public static DataSet affichercompteparcode(string nm_c_c)
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select* from gestioncompte where numerocompte = '" + nm_c_c + "'";
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

        #region"Modifier client"
        public static int ModifierCompte(string nm_c_c, string ty, string mon, Double sol, string et, DateTime dat)
        {
            string requ = "Update gestioncompte Set type = '" + ty + "', monaie='" + mon + "',solde='" + sol + "',etat='" + et + "', date_insc='" + dat + "' WHERE numerocompte = '" + nm_c_c + "'";
            int val = 0;
            try
            {

                con.Open();
                cmd = new MySqlCommand(requ, con);
                val = cmd.ExecuteNonQuery();
            }

            catch (Exception a)
            {
                //MessageBox.Show(ef.Message);
                MessageBox.Show("modification" + a.Message + ")non reussie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }

            return val;

        }
        #endregion



    }
}
