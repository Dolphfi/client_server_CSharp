using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
    public interface IRetrait
    {
        #region"Methode Retrait"


        #region Accesseurs
        string PrendreId_Transaction();

      string PrendreNumero_Compte();


        double PrendreMontant();




        string PrendreDescription();


        double PrendreBalance();




         DateTime PrendreDate();


        string PrendreMonnaie();

        #endregion
        /**************************************************************************/
        #region mutateurs
        void ModifierId_Transaction(string id_tra);

        void ModifierNumero_Compte(string num_copt);

        void ModifierMontant(double mont);

       void ModifierDescription(string descp);


        void ModifierBalance(double bal);


        void ModifierDate(DateTime dat);


        void ModifierMonnaie(string monn);

        #endregion

        #region"Insertion Retrait"
        int InsererRetrait(string id_tra, string num_copt, double mont, string descp, double bal, DateTime dat, string monn);

        #endregion

        #region"Afficher Retrait par id"
        DataSet AfficherRetraitcode(string nm_c_c);

        #endregion

        #region"Rechercher Retrait par id"

        bool RechercherRetrait(string num_copt);

        #endregion

        #region"Recher Retrait pour visualiser"
        bool RechercherRetraitV(string id);

        #endregion

        #region"code auto Retrait"
        int RerchercherCodeAutoTransactionRetrait();


        #endregion

        #region"Modifier code Retrait"
        int ModifierCodeAutoTransactionRetrait();
       
        #endregion

        #endregion
    }
}
