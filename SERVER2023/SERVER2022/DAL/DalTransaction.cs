using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SERVER2023.Domain;
namespace SERVER2023.DAL
{
    public class DalTransaction
    {
        #region"chaine de connection"
        static MySqlConnection con = new MySqlConnection(ChaineConnexion.ConnectionString);
        private static MySqlCommand cmd;
        private static string nouser, date;
        #endregion

        #region"Informations sur les utilisateurs"
        public static int InftransactionEmpl(Transaction tr)
        {
         
            string req = "insert into tbltracabilite(code_empl,libele,date_tra) values ('" + tr.Getcode() + "','" + tr.GetLibele() + "','" + tr.GetDate() + "')";
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

    }
}
