using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER2023.Domain
{
    internal class Retrait
    {
        public  Retrait()
        {
        }
        #region "Les attributs"

        string id_Transaction;
        string numero_Compte;
        double balance;
        string description;
        double montant;
        DateTime date;
        string monnaie;


        #endregion

        #region "Constructeur"
        public Retrait(string id_tra, string num_copt, double mont, string descp, double bal, DateTime dat,string monn)
        {
            this.id_Transaction = id_tra;
            this.numero_Compte = num_copt;
            this.montant = mont;
            this.description = descp;
            this.date = dat;
            this.balance = bal;
            this.monnaie = monnaie;
        }
        #endregion
      
        #region "Les accesseurs"
        public string GetId_Transaction()
        {
            return id_Transaction;
        }
        public string GetNumero_Compte()
        {
            return numero_Compte;
        }
        public double GetMontant()
        {
            return montant;
        }
        public string GetDescription()
        {
            return description;
        }

        public double GetBalance()
        {
            return balance;
        }


        public DateTime GetDate()
        {
            return date;
        }
        public string GetMonnaie()
        {
            return monnaie;
        }

        #endregion

        #region "Les mutateurs"
        public void SetId_Transaction(string id_tra)
        {
            this.id_Transaction = id_tra;
        }
        public void SetNumero_Compte(string num_copt)
        {
            this.numero_Compte = num_copt;
        }

        public void SetDescription(string descp)
        {
            this.description = descp;
        }
        public void SetBalance(double bal)
        {
            this.balance = bal;
        }


        public void SetMontant(double mont)
        {
            this.montant = mont;
        }
        public void SetDate(DateTime dat)
        {
            this.date = dat;
        }

        public void SetMonnaie(string monn)
        {
            this.monnaie = monn;
        }
        #endregion
    }
}

