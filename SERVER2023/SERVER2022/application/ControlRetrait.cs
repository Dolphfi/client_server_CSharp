using SERVER2023.DAL;
using SERVER2023.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER2023.application
{
    internal class ControlRetrait : MarshalByRefObject, GestionInterface.IRetrait
    {
        #region"Methode Retrait"

        Retrait ret;
        #region Accesseurs
        public string PrendreId_Transaction()
        {
            return this.ret.GetId_Transaction();
        }
        public string PrendreNumero_Compte()
        {
            return this.ret.GetNumero_Compte();
        }

        public double PrendreMontant()
        {
            return this.ret.GetMontant();
        }



        public string PrendreDescription()
        {
            return this.ret.GetDescription();
        }

        public double PrendreBalance()
        {
            return this.ret.GetBalance();
        }



        public DateTime PrendreDate()
        {
            return this.ret.GetDate();
        }

        public string PrendreMonnaie()
        {
            return this.ret.GetMonnaie();
        }
        #endregion
        /**************************************************************************/
        #region mutateurs
        public void ModifierId_Transaction(string id_tra)
        {
            this.ret.SetId_Transaction(id_tra);
        }
        public void ModifierNumero_Compte(string num_copt)
        {
            this.ret.SetNumero_Compte(num_copt);
        }
        public void ModifierMontant(double mont)
        {
            this.ret.SetMontant(mont);
        }
        public void ModifierDescription(string descp)
        {
            this.ret.SetDescription(descp);
        }

        public void ModifierBalance(double bal)
        {
            this.ret.SetBalance(bal);
        }

        public void ModifierDate(DateTime dat)
        {
            this.ret.SetDate(dat);
        }

        public void ModifierMonnaie(string monn)
        {
            this.ret.SetMonnaie(monn);
        }
        #endregion

        #region"Insertion Retrait"
        public int InsererRetrait(string id_tra, string num_copt, double mont, string descp, double bal, DateTime dat,string monn)
        {
            ret = new Retrait(id_tra, num_copt, mont, descp, bal, dat,monn);
            return DalRetrait.InsererRetrait(ret);
        }
        #endregion

        #region"Afficher Retrait par id"
        public DataSet AfficherRetraitcode(string nm_c_c)
        {
            return DalRetrait.AfficherRetraitcode(nm_c_c);

        }
        #endregion

        #region"Rechercher Retrait par id"

        public bool RechercherRetrait(string num_copt)
        {
            bool rech = false;
            this.ret = DalRetrait.RechercherRetrait(num_copt);
            if (ret.GetNumero_Compte() != null)
            {
                rech = true;
            }
            return rech;

        }
        #endregion

        #region"Recher Retrait pour visualiser"
        public bool RechercherRetraitV(string id)
        {
            bool rech = false;
            this.ret = DalRetrait.RechercherRetraitV(id);
            if (ret.GetId_Transaction() != null)
            {
                rech = true;
            }
            return rech;

        }
        #endregion

        #region"code auto Retrait"
        public int RerchercherCodeAutoTransactionRetrait()
        {
            return ServiceTechnique.RerchercherCodeAutoTransactionRetrait();
        }

        #endregion

        #region"Modifier code Retrait"
        public int ModifierCodeAutoTransactionRetrait()
        {
            return ServiceTechnique.ModifierCodeAutoTransactionRetrait();
        }
        #endregion

        #endregion
    }
}
