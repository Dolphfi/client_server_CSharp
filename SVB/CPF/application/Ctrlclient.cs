using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFP.DAL;
using CFP.Domain;
using System.Data;
namespace CFP.application
{
    class Ctrlclient
    {
        #region"Methode Client"

        Client cli;

        #region Accesseurs
        

        public string PrendreNumero_compte()
        {

            
            return this.cli.GetNumero_compte();
        }
        public string PrendreTypec()
        {
            return this.cli.GetTypec();
           
        }
        public string PrendreNom()
        {

            return this.cli.GetNom();

        }
      
        public string PrendreSexe()
        {
            return this.cli.GetSexe();


        }
        public string PrendreAdresse()
        {
            return this.cli.GetAdresse();


        }


        public string PrendreTelephone()
        {
            return this.cli.GetTelephone();


        }

        public string PrendreDate_de_Naissance()
        {
            return this.cli.GetDate_de_Naissance();


        }



        public string PrendreEmail()
        {
            return this.cli.GetEmail();


        }


        public string PrendreNif_cin()
        {
            return this.cli.GetNif_cin();


        }



        public DateTime PrendreDate()
        {
            return this.cli.GetDate();


        }


        #endregion
      
        #region mutateurs
        public void ModifierNumero_compte(string nm_c_c)
        {
            this.cli.SetNumero_compte(nm_c_c);
        }

        public void ModifierTypec(string ty)
        {
            this.cli.SetTypec(ty);
        }

        public void ModifierNom(string no)
        {
            this.cli.SetNom(no);
        }

      

        public void ModifierSexe(string sex)
        {
            this.cli.SetSexe(sex);
        }

        public void ModifierAdresse(string adres)
        {
            this.cli.SetAdresse(adres);
        }


        public void ModifierTelephone(string tel)
        {
            this.cli.SetTelephone( tel);
        }


        public void ModifierDate_de_Naissance(string dat_de_N)
        {
            this.cli.SetDate_de_Naissance(dat_de_N);
        }


        public void ModifierEmail(string emai)
        {
            this.cli.SetEmail(emai);
        }

        public void ModifierNif_cin(string ni_c)
        {
            this.cli.SetNif_cin( ni_c);
        }


        public void ModifierDate(DateTime dat)
        {
            this.cli.SetDate(dat);
        }



        #endregion


        #region" methode de la creation de l’intance Enregistrer Client"
        public int InsererClient(string nm_c_c, string ty, string no, string pre, string sex, string adres, string tel, string dat_de_N, string emai, string ni_c, DateTime dat)
        {
            cli = new Client(nm_c_c,ty,no,pre,sex, adres, tel, dat_de_N, emai, ni_c,dat);
            return DalClient.InsererClient(cli);
        }
        #endregion


        #region"Modifier Employe"
        public int Modifiercli(string nm_c_c, string ty, string no,string sex, string adres, string tel, string dat_de_N, string emai, string ni_c, DateTime dat)
        {

            return DalClient.ModifierClient(nm_c_c, ty, no, sex, adres, tel, dat_de_N, emai, ni_c,dat);
        }
        #endregion


        #region"Recher Client"
        public bool RechercherClient(string nm_c_c)
        {
            bool rech = false;
            this.cli = DalClient.RechercherClient(nm_c_c);
            if (cli.GetNumero_compte() != null)
            {
                rech = true;
            }
            return rech;

        }
        #endregion




       




        #region"Suppression"
        public int Supprimerclient(string nm_c_c)
        {
            return DalClient.SupprimerClient(nm_c_c);

        }
        #endregion


        #region"code auto"
        
             public DataSet afficherclient()
        {
            return DalClient.afficherclient();
        }


        public DataTable AfficherNumeroCompteClient()
        {
            return DalClient.AfficherNumeroCompteClient();
        }

        public DataSet afficherclientparcode(string code)
        {
            return DalClient.afficherclientparcode(code);
        }




        #endregion

        #endregion
    }
}
