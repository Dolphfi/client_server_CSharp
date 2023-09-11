using CFP.DAL;
using SVB.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVB.DAL
{
    internal class DalPayroll
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

        #region"Insertion Payroll"
        public static int InsererPayroll(Payroll pay)
        {

            try
            {

                req = "insert into payroll values ('" + pay.GetId_payroll() + "','" + pay.GetNumero_Compte() + "', '" + pay.GetNom() + "','" + pay.GetPrenom()+ "','" + pay.GetSalaire() + "','" +
               pay.GetDescription() + "','" + pay.GetSalaire_net() + "','" + pay.GetDate() + "','" + pay.GetTax() + "','" + pay.GetCodeEmploye() + "')";
                con1.Open();
                cmd = new MySqlCommand(req, con1);
                ver = cmd.ExecuteNonQuery();

                req = ("UPDATE gestioncompte SET solde = solde + '" + pay.GetSalaire_net() + "'  WHERE numerocompte =  '" + pay.GetNumero_Compte() + "'");
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

        #region"Afficher Payroll par code"
        public static DataSet AfficherPayrollcode(string id)
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select *from payroll where id_pay='" + id + "'";
            //ouverture de la connexion
            con1.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con1);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "payroll");
            //retoure de l'instance data
            con1.Close();
            return data;
        }
        #endregion

        #region"Rechercher Payroll par id"
        public static Payroll RechercherPayrollV(string id)
        {
            Payroll rech = new Payroll();
            string req = "select id_pay  from payroll where id_pay = '" + id + "'";

            try
            {

                con1.Open();
                cmd = new MySqlCommand(req, con1);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    
                    rech.SetId_Transaction(rd[0].ToString());
                    rech.SetNumero_Compte(rd[1].ToString());
                    rech.SetNom(rd[2].ToString());
                    rech.SetPrenom(rd[3].ToString());
                    rech.SetSalaire(Convert.ToDouble(rd[4]));
                    rech.SetDescription(rd[5].ToString());
                    rech.SetSalaire_net(Convert.ToDouble(rd[6]));
                    rech.SetDate(Convert.ToDateTime(rd[7]));
                    rech.SetTax(Convert.ToDouble(rd[9]));
                    rech.SetCodeEmploye(rd[10].ToString());


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
