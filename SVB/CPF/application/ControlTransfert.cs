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
    internal class ControlTransfert
    {
        #region"Methode Transfert"

        Transfert tra;
        #region Accesseurs
        public string PrendreId_Transaction()
        {
            return this.tra.GetId_Transaction();
        }
        public string PrendreNumero_Comptede()
        {
            return this.tra.GetNumero_Comptede();
        }

        public string PrendreNumero_Comptea()
        {
            return this.tra.GetNumero_Comptea();
        }

        public double PrendreMontant()
        {
            return this.tra.GetMontant();
        }



        public string PrendreDescription()
        {
            return this.tra.GetDescription();
        }

        public double PrendreBalance()
        {
            return this.tra.GetBalance();
        }



        public DateTime PrendreDate()
        {
            return this.tra.GetDate();
        }

        public string PrendreMonnaie()
        {
            return this.tra.GetMonnaie();
        }

        public string PrendreType()
        {
            return this.tra.GetType();
        }
        #endregion
        /**************************************************************************/
        #region mutateurs

        public void ModifierId_Transaction(string id_tra)
        {
            this.tra.SetId_Transaction(id_tra);
        }
        public void ModifierNumero_Comptede(string num_coptde)
        {
            this.tra.SetNumero_Comptede(num_coptde);
        }
        public void ModifierNumero_Comptea(string num_copta)
        {
            this.tra.SetNumero_Comptea(num_copta);
        }





        public void ModifierMontant(double mont)
        {
            this.tra.SetMontant(mont);
        }
        public void ModifierDescription(string descp)
        {
            this.tra.SetDescription(descp);
        }

        public void ModifierBalance(double bal)
        {
            this.tra.SetBalance(bal);
        }

        public void ModifierDate(DateTime dat)
        {
            this.tra.SetDate(dat);
        }

        public void ModifierMonnaie(string monn)
        {
            this.tra.SetMonnaie(monn);
        }

        public void ModifierType(string ty)
        {
            this.tra.SetType(ty);
        }
        #endregion

        #region"Insertion Transfert"

        public int InsererTransfert(string id_tra, string num_coptde, string num_copta, double mont, string descp, double bal, DateTime dat, string monn, string ty)
        {
            tra = new Transfert(id_tra, num_coptde,num_copta, mont, descp, bal, dat, monn,ty);
            return DalTransfert.InsererTransfert(tra);
        }
        #endregion

        #region"Afficher Rechercher numercompte qui va faire du transfert"
        public bool RechercherTransfertde(string num_coptde)
        {
            bool rech = false;
            this.tra = DalTransfert.RechercherTransfertde(num_coptde);
            if (tra.GetNumero_Comptede() != null)
            {
                rech = true;
            }
            return rech;

        }
        #endregion

        #region"Afficher Transfert pour visualiser"
        public bool RechercherTransfertV(string id)
        {
            bool rech = false;
            this.tra = DalTransfert.RechercherTransfertV(id);
            if (tra.GetId_Transaction() != null)
            {
                rech = true;
            }
            return rech;

        }
        #endregion

        #region"Afficher Transfert par id"
        public DataSet AfficherTransfertcode(string nm_c_c)
        {
            return DalTransfert.AfficherTransfertcode(nm_c_c);

        }
        #endregion

        #region"Rechercher numerocompte qui va rechervoir "
        public bool RechercherTransferta(string num_copta)
        {
            bool rech = false;
            this.tra = DalTransfert.RechercherTransferta(num_copta);
            if (tra.GetNumero_Comptea() != null)
            {
                rech = true;
            }
            return rech;

        }
        #endregion

        #region"code auto Transfert"
        public int RerchercherCodeAutoTransactionTransfert()
        {
            return ServiceTechnique.RerchercherCodeAutoTransactionTransfert();
        }
        #endregion

        #region"Modifier Code auto transfert"
        public int ModifierCodeAutoTransactionTransfert()
        {
            return ServiceTechnique.ModifierCodeAutoTransactionTransfert();
        }
        #endregion

        #endregion

    }
}

