using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
   public interface IStatistique
    {
        #region"Methode statistique"
        #region"Afficher  Compte"
        DataSet affichercompte();

        #endregion

        #region"Afficher Client"
        DataSet afficherclient();

        #endregion

        #region"Afficher Employe"
        DataSet afficheremploye();

        #endregion

        #region"Afficher Utilisateur"
        DataSet afficherUtilisateur();

        #endregion

        #region"Afficher Depot"
        DataSet afficherDepot();

        #endregion

        #region"Afficher Transfert"
        DataSet afficherTransfert();
        #endregion


        #region"Afficher Tracabilite"
        DataSet afficherTracabilite();
        #endregion


        #region"Afficher Payroll"
        DataSet afficherPayroll();
        #endregion


        #region"Afficher Retrait"
        DataSet afficherRetrait();
       
        #endregion

        #endregion
    }
}
