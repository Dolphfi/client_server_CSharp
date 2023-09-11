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
    internal class ControlDashBoard
    {
        #region"Methode Dashboard"

        #region"Afficher Quantite Client"
        public int AfficherQuantiteClient()
        {
            return DalDashboard.AfficherQuantiteClient();
        }
        #endregion

        #region"Afficher Quantite Compte"
        public int AfficherQuantiteCompte()
        {
            return DalDashboard.AfficherQuantiteCompte();
        }

        #endregion

        #region"Afficher Quantite Employe"
        public int AfficherQuantiteEmploye()
        {
            return DalDashboard.AfficherQuantiteEmploye();
        }
        #endregion

        #region"Afficher Quantite Utilisateur"
        public int AfficherQuantiteUtilisateur()
        {
            return DalDashboard.AfficherQuantiteUtilisateur();
        }
        #endregion

        #region"Afficher Quantite Depot"
        public int AfficherQuantiteDepot()
        {
            return DalDashboard.AfficherQuantiteRetrait();
        }
        #endregion

        #region"Afficher Quantite Retrait"
        public int AfficherQuantiteRetrait()
        {
            return DalDashboard.AfficherQuantiteRetrait();
        }
        #endregion

        #region"Afficher Quantite Transfert"
        public int AfficherQuantiteTransfert()
        {
            return DalDashboard.AfficherQuantiteTransfert();
        }
        #endregion



        #region"Afficher Quantite Transfert"
        public int AfficherQuantitePayroll()
        {
            return DalDashboard.AfficherQuantitePayroll();
        }
        #endregion

        #endregion


    }
}
