using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CFP.Domain;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;
namespace CFP.DAL
{
    class Dalemploye
    {
        #region"Chaine de Connection"
        public static MySqlConnection con = new MySqlConnection(ChaineConnexion.ConnectionString);
        public static MySqlCommand cmd;
        public static MySqlCommandBuilder cmd1;
        public static MySqlDataAdapter adapter;
            public static int ver;
            public static string req;
        #endregion

        #region"Insertion Employe"
        public static int InsererEmploye(Employe empl)
            {

                try
                {
                    req = "insert into employe values ('" + empl.GetCode() + "','" + empl.GetNom() + "','" + empl.GetPrenom() + "','" +
                    empl.GetSexe() + "','" + empl.GetTelephone() + "','" + empl.GetSalaire() + "','" + empl.GetRole() + "','" + empl.GetDate() + "','" + empl.GetEmail() + "','" + empl.GetNif() + "','" + empl.GetAdresse() + "','" + empl.GetDatenaissance() + "','" + empl.GetNumerocompte() + "')";
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

        #region"Afficher Employe"
        public static DataSet AfficherEmploye()
        {
           //creation instance de type dataset
           DataSet data = new DataSet();
            // requete de selection
            req = "select *from employe ";
            //ouverture de la connexion
            con.Open();
            // creation intance de type MySqlDataAdapter 
             adapter = new MySqlDataAdapter(req, con);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "employe");
            //retoure de l'instance data
            con.Close();
            return data;
        }
        #endregion

        #region"Afficher Employe Par Code"
        public static DataSet afficheremployeparcode(string cod)
        {
            //creation instance de type dataset
            DataSet data = new DataSet();
            // requete de selection
            req = "select* from employe where Id = '" + cod + "'";
            //ouverture de la connexion
            con.Open();
            // creation intance de type MySqlDataAdapter 
            adapter = new MySqlDataAdapter(req, con);
            //cration de instance MySqlCommandBuilder 
            cmd1 = new MySqlCommandBuilder(adapter);
            //filtrage de donnees
            adapter.Fill(data, "employe");
            //retoure de l'instance data
            con.Close();
            return data;
        }

        #endregion

        #region"Rechercher employe"
        public static Employe RechercherEmploye(string cod)
        {
            Employe rech = new Employe();
            string req = "select* from employe where Id='" + cod + "'";
            try
            {

                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    rech.SetCode(rd[0].ToString());
                    rech.SetNom(rd[1].ToString());
                    rech.SetPrenom(rd[2].ToString());
                    rech.SetSexe(rd[3].ToString());
                    rech.SetTelephone(rd[4].ToString());
                    rech.SetSalaire(Convert.ToDouble( rd[5].ToString()));
                    rech.SetRole(rd[6].ToString());
                    rech.SetDate(Convert.ToDateTime(rd[7].ToString()));
                    rech.SetEmail(rd[8].ToString());
                    rech.SetNif(rd[9].ToString());
                    rech.SetAdresse(rd[10].ToString());
                    rech.SetDatenaissance(rd[11].ToString());
                    rech.SetNumerocompte(rd[12].ToString());
               


                }

            }

            catch (Exception ex)

            { }
            finally
            {

                con.Close();
            }

            return rech;

        }
        #endregion



        




        #region"Rechercher employe Pay"
        public static Employe RechercherEmployePay(string cod)
        {
            Employe rech = new Employe();
            string req = "select NumeroCompte,id,name,last_name,salaire from employe where NumeroCompte = '" + cod + "'";
            try
            {

                con.Open();
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {

                    rech.SetNumerocompte(rd[0].ToString());
                    rech.SetCode(rd[1].ToString());
                    rech.SetNom(rd[2].ToString());
                    rech.SetPrenom(rd[3].ToString());
                    rech.SetSalaire(Convert.ToDouble(rd[4].ToString()));




                }

            }

            catch (Exception ex)

            {
                MessageBox.Show("Erreur " + ex);
            }
            finally
            {

                con.Close();
            }

            return rech;

        }
        #endregion

        #region"Modifier employe"
        public static int ModifierEmploye(string cd, string no, string pr, string sex, string tel, double sal,string rol, DateTime dat,string ema, string ni,string adr,string datn,string num)
        {
            string requ = "Update employe Set name = '" + no + "', last_name='" +pr + "',sexe='" + sex + "',phone='"+tel+ "',salaire='" + sal + "',role='" + rol + "',dateEmp='" + dat + "' ,email='" + ema + "',nif='" + ni + "',adresse='" + adr + "',datenaissance='" + datn + "',NumeroCompte='" + num + "' WHERE Id = '" + cd + "'";
            int val = 0;
            try
            {

                con.Open();
                cmd = new MySqlCommand(requ, con);
                val = cmd.ExecuteNonQuery();
            }

            catch (Exception a)
            {
                MessageBox.Show("modification" + a.Message + ")non reussie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }

            return val;

        }
        #endregion

        #region"Suppression employe"
        public static int SupprimerEmploye(string co)
        {

            string req = "delete from employe where Id='" + co + "' ";
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




        #region" Afficher Numerocompte Qui a ete deja Cree"

        public static DataTable AfficherNumeroCompteEmploye()
        {

            //creation instance de type dataset
            DataTable data = new DataTable();
            // requete de selection
            req = "SELECT numerocompte FROM gestioncompte WHERE numerocompte NOT IN (SELECT DISTINCT NumeroCompte FROM employe)";
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


    }
}

