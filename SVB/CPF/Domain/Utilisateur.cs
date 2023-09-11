using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFP.Domain
{
    class Utilisateur
    {
        public Utilisateur()
        {

        }

        #region"Attributs et les contructeurs"
        string code;
        string code_Empl;
        string fonction;
        string usename;
        string password;
        string module_acces;
        DateTime date;
        int etat;
        #endregion
        #region"les contructeurs"
        public Utilisateur(string co, string cemp, string fonct, string us, string pass, string moda, DateTime dat, int eta)
        {
            this.code = co;
            this.code_Empl = cemp;
            this.fonction = fonct;
          
            this.usename = us;
            this.password = pass;
            this.module_acces = moda;
            this.date = dat;
            this.etat = eta;

        }
        #endregion
        #region"mutateur"
        public void setCode(string co)
        {
            this.code = co;
        }
        public void setCode_Employe(string cemp)
        {
            this.code_Empl = cemp;
        }
        public void setFonction(string fonct)
        {
            this.fonction = fonct;
        }

        public void setUser(string us)
        {
            this.usename = us;
        }
        public void setPassword(string pass)
        {
            this.password = pass;
        }

        public void setModule_acces(string moda)
        {
            this.module_acces = moda;
        }
    
        public void setDate(DateTime dat)
        {
            this.date = dat;
        }

        public void setEtat(int eta)
        {
            this.etat = eta;
        }


        #endregion
        #region"Accesseur"
        public string getCode()
        {
            return this.code;
        }
        public string getCode_Employe()
        {
            return this.code_Empl;
        }
        public string getFonction()
        {
            return this.fonction;
        }

        public string getUser()
        {
            return this.usename;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getModule_acces()
        {
            return this.module_acces;
        }
       
        public DateTime getDate()
        {
            return this.date;
        }

        public int getEtat()
        {
            return this.etat;
        }

        #endregion

    }
}
