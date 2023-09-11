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
    internal class DalDepot
    {
        #region"Chaine de Connection"
        public static MySqlConnection con = new MySqlConnection(ChaineConnexion.ConnectionString);
        public static MySqlCommand cmd;
        public static MySqlCommandBuilder cmd1;
        public static MySqlDataAdapter adapter;
        public static int ver;
        public static string req;
        public static string req1;
        public static string num_copt;
        #endregion

        #region"Insertion depot"
        public static int InsererDepot(Depot dep)
        {

            try
            {

                req = "insert into depot values ('" + dep.GetId_Transaction() + "','" + dep.GetNumero_Compte() + "','" + dep.GetMontant() + "','" +
                dep.GetDescription() + "','" + dep.GetDate() + "')";
                con.Open();
                cmd = new MySqlCommand(req, con);
                ver = cmd.ExecuteNonQuery();
             
                req = ("UPDATE gestioncompte SET solde = solde + '" + dep.GetMontant() + "'  WHERE numerocompte =  '" + dep.GetNumero_Compte() + "'");
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

        #region"Afficher Depot Part Id"
        public static DataSet AfficherDepotcode(string cod)
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select *from depot where idtransaction='" + cod + "'";
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

        #region"Rechercher Compte pour faire un depot"
        public static Depot RechercherDepot(string num_copt)
        {
            Depot rech = new Depot ();
          
            string req = "select c.numerocompte,c.solde,c.monaie from gestioncompte c,gestionclient a where c.numerocompte = a.numerocompte and a.numerocompte= '" + num_copt + "'";
   
            try
            {

                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
               
                if (rd.Read())
                {

                    rech.SetNumero_Compte(rd[0].ToString());
                    rech.SetBalance(Convert.ToDouble(rd[1]));
                    rech.SetMonnaie(rd[2].ToString());


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

        #region"Rechercher depot Pour Afficher par id "
        public static Depot RechercherDepotV(string id)
        {
            Depot rech = new Depot();

            string req = "select idtransaction from depot where idtransaction = '" + id + "'";

            try
            {

                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {

                    rech.SetId_Transaction(rd[0].ToString());
                    rech.SetNumero_Compte(rd[1].ToString());
                    rech.SetMontant(Convert.ToDouble(rd[2]));
                    rech.SetDescription(rd[3].ToString());
                    rech.SetDate(Convert.ToDateTime(rd[4]));


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


    }
}
