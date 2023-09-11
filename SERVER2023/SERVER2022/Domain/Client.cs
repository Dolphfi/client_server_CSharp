using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER2023.Domain
{
    internal class Client
    {
        public Client()
        {
        }

            #region "Les attributs"

            string numero_compte;
        string typec ;
        
        string  nom;
        string sexe;
        string adresse;
        string telephone;
        string date_de_Naissance;
        string email;
        string nif_cin;
        DateTime date;


        #endregion

        #region "Constructeur"
        public Client(string nm_c_c, string ty, string no, string sex, string adres, string tel, string dat_de_N, string emai, string ni_c,DateTime dat)
        {
            this.numero_compte = nm_c_c;
            this.typec = ty;
            this.nom = no;
           
            this.sexe = sex;
            this.adresse = adres;
            this.telephone = tel;
            this.date_de_Naissance = dat_de_N;
            this.email = emai;
            this.nif_cin = ni_c;
            this.date = dat;


        }
        #endregion
       
        #region "Les accesseurs"
        public string GetNumero_compte()
        {
           
            return numero_compte;
        }
        public string GetTypec()
        {
           
            return typec;
        }
        public string GetNom()
        {
            return nom;

           
        }

        public string GetSexe()
        {
            return sexe;

           
        }
        public string GetAdresse()
        {
            return adresse;


        }


        public string GetTelephone()
        {
            return telephone;


        }

        public string GetDate_de_Naissance()
        {
            return date_de_Naissance;


        }



        public string GetEmail()
        {
            return email;


        }


        public string GetNif_cin()
        {
            return nif_cin;


        }



        public DateTime GetDate()
        {
            return date;


        }

       
      
        #endregion

        #region "Les mutateurs"
        public void SetNumero_compte(string nm_c_c)
        {
            this.numero_compte = nm_c_c;
        }
        public void SetTypec(string ty)
        {
            this.typec  = ty;
        }
        
        
        public void SetNom(string no)
        {
            this.nom = no;
        }

      
        public void SetSexe(string sex)
        {
            this.sexe = sex;
        }
        public void SetAdresse(string adres)
        {
            this.adresse = adres;
        }


        public void SetTelephone(string tel)
        {
            this.telephone = tel;
        }

        public void SetDate_de_Naissance(string dat_de_N)
        {
            this.date_de_Naissance = dat_de_N;
        }
        public void SetEmail(string emai)
        {
            this.email = emai;
        }

        public void SetNif_cin(string nic_c)
        {
            this.nif_cin = nic_c;
        }

        public void SetDate(DateTime dat)
        {
            this.date = dat;
        }

       
        #endregion
    }
}
