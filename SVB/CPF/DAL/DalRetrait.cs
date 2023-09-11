using CFP.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFP.DAL
{
    internal class DalRetrait
    {
        #region"Chaine de Connection"
        public static MySqlConnection con1 = new MySqlConnection(ChaineConnexion.ConnectionString);
        public static MySqlCommand cmd;
        public static MySqlCommandBuilder cmd1;
        public static MySqlDataAdapter adapter;
        public static int ver;
        public static string req;
        public static string req1;
        public static string num_copt;

        #endregion

        #region"Insertion depot"
        public static int InsererRetrait(Retrait ret)
        {

            try
            {

                req = "insert into retrait values ('" + ret.GetId_Transaction() + "','" + ret.GetNumero_Compte() + "','" + ret.GetMontant() + "','" +
               ret.GetDescription() + "','" + ret.GetDate() + "')";
                con1.Open();
                cmd = new MySqlCommand(req, con1);
                ver = cmd.ExecuteNonQuery();

                req = ("UPDATE gestioncompte SET solde = solde - '" + ret.GetMontant() + "'  WHERE numerocompte =  '" + ret.GetNumero_Compte() + "'");
                cmd = new MySqlCommand(req, con1);
                ver = cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(" DAL" + ex.Message);
            }

            finally
            {
                con1.Close();
            }
            return ver;
        }
        #endregion

        #region"Afficher Retrait par code"
        public static DataSet AfficherRetraitcode(string cod)
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select *from retrait where idtransaction='" + cod + "'";
            //ouverture de la connexion
            con1.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con1);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "retrait");
            //retoure de l'instance data
            con1.Close();
            return data;
        }
        #endregion


        #region"Rechercher numero compte Pour faire un retrait"
        public static Retrait RechercherRetrait(string num_copt)
        {
            Retrait rech = new Retrait();

            string req = "select c.numerocompte,c.solde,c.monaie from gestioncompte c,gestionclient a where c.numerocompte = a.numerocompte and a.numerocompte= '" + num_copt + "'";

            try
            {

                con1.Open();
                cmd = new MySqlCommand(req, con1);
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

                con1.Close();
            }

            return rech;

        }
        #endregion


        #region"Rechercher Retrait par id"
        public static Retrait RechercherRetraitV(string id)
        {
            Retrait rech = new Retrait();
            string req = "select idtransaction from retrait where idtransaction = '" + id + "'";

            try
            {

                con1.Open();
                cmd = new MySqlCommand(req, con1);
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


                con1.Close();
            }

            return rech;

        }
        #endregion

    }
}
