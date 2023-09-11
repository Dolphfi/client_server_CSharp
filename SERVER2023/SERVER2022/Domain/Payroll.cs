using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER2023.Domain
{
    internal class Payroll
    {

        public Payroll()
        {

        }
        #region "Les attributs"

        string id_payroll;
        string numero_Compte;
        string description;
        string nom;
        string prenom;
      
        double salaire_net;
        double salaire;
        string codeEmploye;
        double tax;
        DateTime date;



        #endregion

        #region "Constructeur"
        public Payroll(string id_pay, string num_copt, string no, string pre, double sal, string descp, double saln, DateTime dat, double ta, string coe)
        {
            this.id_payroll = id_pay;
            this.numero_Compte = num_copt;
           
            this.description = descp;
            this.date = dat;
            this.nom = no;
            this.prenom = pre;
            this.codeEmploye = coe;
            this.salaire = sal;
            this.salaire_net = saln;
            this.tax = ta;
        }
        #endregion

        #region "Les accesseurs"
        public string GetId_payroll()
        {
            return id_payroll;
        }
        public string GetNumero_Compte()
        {
            return numero_Compte;
        }
       
        public string GetDescription()
        {
            return description;
        }

        public double GetSalaire()
        {
            return salaire;
        }

        public double GetSalaire_net()
        {
            return salaire_net;
        }


        public DateTime GetDate()
        {
            return date;
        }
        public string GetNom()
        {
            return nom;
        }


        public string GetPrenom()
        {
            return prenom;
        }

        public double GetTax()
        {
            return tax;
        }


        public string GetCodeEmploye()
        {
            return codeEmploye;
        }


        #endregion

        #region "Les mutateurs"
        public void SetId_Transaction(string id_pay)
        {
            this.id_payroll = id_pay;
        }
        public void SetNumero_Compte(string num_copt)
        {
            this.numero_Compte = num_copt;
        }

        public void SetDescription(string descp)
        {
            this.description = descp;
        }
        public void SetSalaire(double sal)
        {
            this.salaire = sal;
        }


        public void SetSalaire_net(double sal_net)
        {
            this.salaire_net = sal_net;
        }


        
        public void SetDate(DateTime dat)
        {
            this.date = dat;
        }

        public void SetNom(string no)
        {
            this.nom = no;
        }

        public void SetPrenom(string pre)
        {
            this.nom = pre;
        }

        public void SetTax(double ta)
        {
            this.tax = ta;
        }


        public void SetCodeEmploye(string co)
        {
            this.codeEmploye = co;
        }

        #endregion
    }
}
