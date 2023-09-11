using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
   public interface IDepot
    {
        #region"Methode depot"

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

        #region"Insert Depot"
        int InsererDepot(string id_tra, string num_copt, double mont, string descp, double bal, DateTime dat, string monn);


        #endregion

        #region"Afficher Depot par Id"
        DataSet AfficherDepotcode(string nm_c_c);

        #endregion

        #region"Rechercher Depot"
        bool RechercherDepot(string num_copt);

        #endregion

        #region"Rechercher Depot par id Pour visualisaser"
        bool RechercherDepotV(string id);

        #endregion

        #region"code auto Depot"
        int RerchercherCodeAutoTransactionDepot();

        #endregion

        #region"Modifier Code Depot"
        int ModifierCodeAutoTransactionDepot();
       
        #endregion

        #endregion
    }
}
