using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFP.Domain
{
    internal class Transfert
    {
        public Transfert()
        {

        }

        #region "Les attributs"

        string id_Transaction;
        string numero_Comptede;
        string numero_Comptea;
        double montant;
        string description;

        double balance;
        DateTime date;
        string monnaie;
        string type;



        #endregion

        #region "Constructeur"
        public Transfert(string id_tra, string num_coptde, string num_copta, double mont, string descp, double bal, DateTime dat, string monn, string ty)
        {
            this.id_Transaction = id_tra;
            this.numero_Comptede = num_coptde;
            this.numero_Comptea = num_copta;
            this.montant = mont;
            this.description = descp;
            this.date = dat;
            this.balance = bal;
            this.monnaie = monn;
            this.type = ty;
        }
        #endregion
     
        #region "Les accesseurs"
        public string GetId_Transaction()
        {
            return id_Transaction;
        }
        public string GetNumero_Comptede()
        {
            return numero_Comptede;
        }

        public string GetNumero_Comptea()
        {
            return numero_Comptea;
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


        public string GetType()
        {
            return type;
        }

        #endregion

        #region "Les mutateurs"
        public void SetId_Transaction(string id_tra)
        {
            this.id_Transaction = id_tra;
        }
        public void SetNumero_Comptea(string num_copta)
        {
            this.numero_Comptea = num_copta;
        }

        public void SetNumero_Comptede(string num_coptde)
        {
            this.numero_Comptede = num_coptde;
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

        public void SetType(string ty)
        {
            this.type = ty;
        }
        #endregion
    }
}
