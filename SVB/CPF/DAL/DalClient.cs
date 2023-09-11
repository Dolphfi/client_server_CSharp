using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CFP.Domain;
using MySql.Data.MySqlClient;
using System.Data;
namespace CFP.DAL
{
    class DalClient
    {


        #region"Chaine de Connection"
        public static MySqlConnection con = new MySqlConnection(ChaineConnexion.ConnectionString);
        public static MySqlCommand cmd;
        public static MySqlCommandBuilder cmd1;
        public static MySqlDataAdapter adapter;
            public static int ver;
        public static string va;
        public static string req;


           #endregion


        #region"Enregistrer client"
        public static int InsererClient(Client cli)
            {
          
                try
                {
                    req = "insert into gestionclient values ('" + cli.GetNumero_compte() + "','" + cli.GetTypec() + "','" + cli.GetNom() + "','" +
                    cli.GetSexe() + "','" + cli.GetAdresse() + "','" + cli.GetTelephone() + "','" + cli.GetDate_de_Naissance() + "','" + cli.GetEmail() + "','" + cli.GetNif_cin() + "','" + cli.GetDate()+"')";
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


        #region"Rechercher client"
        public static Client RechercherClient(string nm_c_c)
        {
            Client rech = new Client();
            string req = "select* from gestionclient where numerocompte='" + nm_c_c + "'";
            try
            {

                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {

                    rech.SetNumero_compte(rd[0].ToString());
                    rech.SetTypec(rd[1].ToString());
                    rech.SetNom(rd[2].ToString());
                  
                    rech.SetSexe(rd[3].ToString());
                    rech.SetAdresse(rd[4].ToString());
                    rech.SetTelephone(rd[5].ToString());
                    rech.SetDate_de_Naissance(rd[6].ToString());
                    rech.SetEmail(rd[7].ToString());
                    rech.SetNif_cin(rd[8].ToString());
                    rech.SetDate(Convert.ToDateTime(rd[9].ToString()));



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



       


        #region"Suppression client"
        public static int SupprimerClient(string nm_c_c)
        {

            string req = "delete from gestionclient where numerocompte='" + nm_c_c + "' ";
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


        #region"Afficher Clisent"
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


        #region"Afficher Client Par numerocompte"
        public static DataSet afficherclientparcode(string code)
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select* from gestionclient where numerocompte = '" + code + "'";
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


        #region" Afficher Numerocompte Qui a ete deja Cree"

        public static DataTable AfficherNumeroCompteClient()
        {

            //creation instance de type dataset
            DataTable data = new DataTable();
            // requete de selection
            req = "SELECT numerocompte FROM gestioncompte WHERE numerocompte NOT IN (SELECT DISTINCT numerocompte FROM gestionclient)";
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


        #region"Modifier client"
        public static int ModifierClient(string nm_c_c, string ty, string no, string sex, string adres, string tel, string dat_de_N, string emai, string ni_c, DateTime dat)
        {
            string requ = "Update gestionclient Set type = '" + ty + "', nom='" + no +  "',sexe='" + sex + "',adresse='" + adres + "',telephone='" + tel + "',date_naissance='" + dat_de_N + "',email='" + emai + "' ,nif_cin='" + ni_c+ "' ,date_insc='" + dat + "' WHERE numerocompte = '" + nm_c_c + "'";
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

