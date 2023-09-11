using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
    public interface IDashBoard
    {
        #region"Methode Dashboard"

        #region"Afficher Quantite Client"
        int AfficherQuantiteClient();

        #endregion

        #region"Afficher Quantite Compte"
        int AfficherQuantiteCompte();


        #endregion

        #region"Afficher Quantite Employe"
        int AfficherQuantiteEmploye();

        #endregion

        #region"Afficher Quantite Utilisateur"
        int AfficherQuantiteUtilisateur();

        #endregion

        #region"Afficher Quantite Depot"
        int AfficherQuantiteDepot();

        #endregion

        #region"Afficher Quantite Retrait"
        int AfficherQuantiteRetrait();

        #endregion

        #region"Afficher Quantite Transfert"
       int AfficherQuantiteTransfert();



        #endregion
        int AfficherQuantitePayroll();
        #endregion


    }
}
