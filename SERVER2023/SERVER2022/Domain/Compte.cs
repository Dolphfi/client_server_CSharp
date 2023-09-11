using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER2023.Domain
{
    internal class Compte
    {
        public Compte()
        {
        }

        #region "Les attributs"

        string numero_compte;
        string typec;
        string monnaie;
     double solde;
        string  etat;
        DateTime date;


        #endregion

        #region "Constructeur"
        public Compte(string nm_c_c, string ty, string mon, double sol, string et, DateTime dat)
        {
            this.numero_compte = nm_c_c;
            this.typec = ty;
            this.monnaie = mon;
            this.solde = sol;
            this.etat = et;
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
        public string GetMonnaie()
        {
            return monnaie;


        }
        public double GetSolde()
        {
            return solde;


        }

        public string GetEtat()
        {
            return etat;


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
            this.typec = ty;
        }


        public void SetMonnaie(string mon)
        {
            this.monnaie = mon;
        }

        public void SetSolde(double sol)
        {
            this.solde = sol;
        }


        public void SetEtat(string et)
        {
            this.etat = et;
        }
        public void SetDate(DateTime dat)
        {
            this.date = dat;
                
        }
      

        #endregion
    }
}
