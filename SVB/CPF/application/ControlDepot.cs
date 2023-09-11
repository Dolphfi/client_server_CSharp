using CFP.DAL;
using CFP.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFP.application
{
  
    internal class ControlDepot
    {

        #region"Methode depot"

        Depot dep;
        #region Accesseurs
        public string PrendreId_Transaction()
        {
            return this.dep.GetId_Transaction();
        }
        public string PrendreNumero_Compte()
        {
            return this.dep.GetNumero_Compte();
        }
      
        public double PrendreMontant()
        {
            return this.dep.GetMontant();
        }



        public string PrendreDescription()
        {
            return this.dep.GetDescription();
        }

        public double PrendreBalance()
        {
            return this.dep.GetBalance();
        }



        public DateTime PrendreDate()
        {
            return this.dep.GetDate();
        }

        public string PrendreMonnaie()
        {
            return this.dep.GetMonnaie();
        }
        #endregion
        /**************************************************************************/
        #region mutateurs
        public void ModifierId_Transaction(string id_tra)
        {
            this.dep.SetId_Transaction(id_tra);
        }
        public void ModifierNumero_Compte(string num_copt)
        {
            this.dep.SetNumero_Compte(num_copt);
        }
        public void ModifierMontant(double mont)
        {
            this.dep.SetMontant(mont);
        }
        public void ModifierDescription(string descp)
        {
            this.dep.SetDescription(descp);
        }

        public void ModifierBalance(double bal)
        {
            this.dep.SetBalance(bal);
        }

        public void ModifierDate(DateTime dat)
        {
            this.dep.SetDate(dat);
        }

        public void ModifierMonnaie(string monn)
        {
            this.dep.SetMonnaie(monn);
        }
        #endregion

        #region"Insert Depot"
        public int InsererDepot(string id_tra, string num_copt, double mont, string descp,double bal, DateTime dat,string monn)
        {
            dep = new Depot(id_tra, num_copt, mont, descp,bal, dat,monn);
            return DalDepot.InsererDepot(dep);
        }

        #endregion

        #region"Afficher Depot par Id"
        public DataSet AfficherDepotcode(string nm_c_c)
        {
            return DalDepot.AfficherDepotcode(nm_c_c);

        }
        #endregion

        #region"Rechercher Depot"
        public bool RechercherDepot(string num_copt)
        {
            bool rech = false;
            this.dep = DalDepot.RechercherDepot(num_copt);
            if (dep.GetNumero_Compte() != null)
            {
                rech = true;
            }
            return rech;

        }
        #endregion

        #region"Rechercher Depot par id Pour visualisaser"
        public bool RechercherDepotV(string id)
        {
            bool rech = false;
            this.dep = DalDepot.RechercherDepotV(id);
            if (dep.GetId_Transaction() != null)
            {
                rech = true;
            }
            return rech;

        }
        #endregion

        #region"code auto Depot"
        public int RerchercherCodeAutoTransactionDepot()
        {
            return ServiceTechnique.RerchercherCodeAutoTransactionDepot();
        }
        #endregion

        #region"Modifier Code Depot"
        public int ModifierCodeAutoTransactionDepot()
        {
            return ServiceTechnique.ModifierCodeAutoTransactionDepot();
        }
        #endregion

        #endregion
    }
}