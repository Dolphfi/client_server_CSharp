using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
    public interface ITransfert
    {
        #region"Methode Transfert"


        #region Accesseurs
       string PrendreId_Transaction();

      string PrendreNumero_Comptede();


        string PrendreNumero_Comptea();


       double PrendreMontant();




        string PrendreDescription();


       double PrendreBalance();




        DateTime PrendreDate();


        string PrendreMonnaie();


        string PrendreType();

        #endregion
        /**************************************************************************/
        #region mutateurs

        void ModifierId_Transaction(string id_tra);

        void ModifierNumero_Comptede(string num_coptde);

        void ModifierNumero_Comptea(string num_copta);






       void ModifierMontant(double mont);

        void ModifierDescription(string descp);


        void ModifierBalance(double bal);


         void ModifierDate(DateTime dat);


        void ModifierMonnaie(string monn);


        void ModifierType(string ty);

        #endregion

        #region"Insertion Transfert"

        int InsererTransfert(string id_tra, string num_coptde, string num_copta, double mont, string descp, double bal, DateTime dat, string monn, string ty);

        #endregion

        #region"Afficher Rechercher numercompte qui va faire du transfert"
       bool RechercherTransfertde(string num_coptde);

        #endregion

        #region"Afficher Transfert pour visualiser"
      bool RechercherTransfertV(string id);

        #endregion

        #region"Afficher Transfert par id"
        DataSet AfficherTransfertcode(string nm_c_c);

        #endregion

        #region"Rechercher numerocompte qui va rechervoir "
        bool RechercherTransferta(string num_copta);

        #endregion

        #region"code auto Transfert"
        int RerchercherCodeAutoTransactionTransfert();

        #endregion

        #region"Modifier Code auto transfert"
        int ModifierCodeAutoTransactionTransfert();
       
        #endregion

        #endregion
    }
}
