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
    internal class DalTransfert
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

        #region"Afficher Transfert"
        public static int InsererTransfert(Transfert tra)
        {

            try
            {

                req = "insert into transfert values ('" + tra.GetId_Transaction() + "','" + tra.GetNumero_Comptede() + "','" + tra.GetNumero_Comptea() + "','" + tra.GetMontant() + "','" +
                tra.GetDescription() + "','" + tra.GetDate() + "')";
                con.Open();
                cmd = new MySqlCommand(req, con);
                ver = cmd.ExecuteNonQuery();

                req = ("UPDATE gestioncompte SET solde = solde + '" + tra.GetMontant() + "'  WHERE numerocompte =  '" + tra.GetNumero_Comptea() + "'");
                cmd = new MySqlCommand(req, con);
                ver = cmd.ExecuteNonQuery();


                req = ("UPDATE gestioncompte SET solde = solde - '" + tra.GetMontant() + "'  WHERE numerocompte =  '" + tra.GetNumero_Comptede() + "'");
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

        #region"Afficher Transfert par id"
        public static DataSet AfficherTransfertcode(string cod)
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select *from transfert where idtransaction='" + cod + "'";
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

        #region"Rechercher le compte qui va recevpoir"
        public static Transfert RechercherTransferta(string num_copta)
        {
            Transfert rech = new Transfert();

            string req = "select c.numerocompte,c.type,c.monaie,c.solde from gestioncompte c,gestionclient a where c.numerocompte = a.numerocompte and a.numerocompte = '" + num_copta + "'";

            try
            {

                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {

                    rech.SetNumero_Comptea(rd[0].ToString());
                    rech.SetType(rd[1].ToString());
                    rech.SetMonnaie(rd[2].ToString());
                    rech.SetBalance(Convert.ToDouble(rd[3]));



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

        #region"Afficher Transfert par id"
        public static Transfert RechercherTransfertV(string id)
        {
            Transfert rech = new Transfert();
         

                string req = "select idtransaction from transfert where idtransaction = '" + id + "'";

                try
                {

                    con.Open();
                    cmd = new MySqlCommand(req, con);
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {

                        rech.SetId_Transaction(rd[0].ToString());
                        rech.SetNumero_Comptede(rd[1].ToString());
                        rech.SetNumero_Comptea(rd[2].ToString());
                    rech.SetMontant(Convert.ToDouble(rd[3]));
                    rech.SetDescription(rd[4].ToString());
                    rech.SetDate(Convert.ToDateTime(rd[5]));


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

        #region"Rechercher  numerocompte qui va transferer le montan"
        public static Transfert RechercherTransfertde(string num_coptde)
        {
            Transfert rech = new Transfert();

            string req = "select c.numerocompte,c.type,c.monaie,c.solde from gestioncompte c,gestionclient a where c.numerocompte = a.numerocompte and a.numerocompte = '" + num_coptde + "'";
           
            try
            {

                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {

                    rech.SetNumero_Comptede(rd[0].ToString());
                    rech.SetType(rd[1].ToString());
                    rech.SetMonnaie(rd[2].ToString());
                    rech.SetBalance(Convert.ToDouble(rd[3]));


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
