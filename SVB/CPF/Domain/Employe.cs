using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFP.Domain
{
    class Employe
    {
        public Employe()
        {

        }

        #region "Les attributs"

        string code;
        string nom;
        string prenom;
        string telephone;
       double salaire;
        string role;
        string sexe;

        string email;
        string nif;
        string datenaissance;
        string adresse;
        DateTime date;
        string numerocompte;
      


        #endregion

        #region "Constructeur"
        public Employe(string co, string no, string pr, string sex, string tel, double sal,string rol, DateTime dat,string ema,string ni,string adr,string datn,string num)
        {
            this.code = co;
            this.nom = no;
            this.prenom = pr;
            this.sexe = sex;
            this.telephone = tel;
            this.salaire = sal;
            this.role = rol;
            this.date = dat;
            this.email = ema;
            this.nif =ni;
            this.adresse = adr;
            this.datenaissance = datn;
            this.numerocompte = num;
          
        }
        #endregion
      
        #region "Les accesseurs"
        public string GetCode()
        {
            return code;
        }
        public string GetNom()
        {
            return nom;
        }
        public string GetPrenom()
        {
            return prenom;
        }
        public string GetSexe()
        {
            return sexe;
        }
        public string GetTelephone()
        {
            return telephone;
        }

        public double GetSalaire()
        {
            return salaire;
        }

        public string GetRole()
        {
            return role;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetNif()
        {
            return nif;
        }

        public string GetAdresse()
        {
            return adresse;
        }
        public string GetDatenaissance()
        {
            return datenaissance;
        }


        public string GetNumerocompte()
        {
            return numerocompte;
        }



        #endregion

        #region "Les mutateurs"
        public void SetCode(string co)
        {
            this.code = co;
        }
        public void SetNom(string no)
        {
            this.nom = no;
        }
        public void SetPrenom(string pr)
        {
            this.prenom = pr;
        }
        public void SetSexe(string sex)
        {
            this.sexe = sex;
        }
        public void SetTelephone(string tel)
        {
            this.telephone = tel;
        }


        public void SetSalaire(double sal)
        {
            this.salaire = sal;
        }



        public void SetRole(string rol)
        {
            this.role = rol;
        }


        public void SetDate(DateTime dat)
        {
            this.date = dat;
        }




        public void SetEmail(string ema)
        {
            this.email =ema;
        }

        public void SetNif(string ni)
        {
            this.nif = ni;
        }

        public void SetAdresse(string adr)
        {
            this.adresse = adr;
        }

        public void SetDatenaissance(string datn)
        {
            this.datenaissance = datn;
        }



        public void SetNumerocompte(string num)
        {
            this.numerocompte= num;
        }

      
        #endregion
    }
}