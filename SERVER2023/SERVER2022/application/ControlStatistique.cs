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
    internal class ControlStatistique : MarshalByRefObject, GestionInterface.IStatistique
    {
        #region"Methode statistique"
        #region"Afficher  Compte"
        public DataSet affichercompte()
        {
            return DalStatistique.affichercompte();

        }
        #endregion

        #region"Afficher Client"
        public DataSet afficherclient()
        {
            return DalStatistique.afficherclient();
        }
        #endregion

        #region"Afficher Employe"
        public DataSet afficheremploye()
        {
            return DalStatistique.AfficherEmploye();
        }
        #endregion

        #region"Afficher Utilisateur"
        public DataSet afficherUtilisateur()
        {
            return DalStatistique.AfficherUtilisateur();
        }
        #endregion

        #region"Afficher Depot"
        public DataSet afficherDepot()
        {
            return DalStatistique.AfficherDepot();
        }
        #endregion

        #region"Afficher Transfert"
        public DataSet afficherTransfert()
        {
            return DalStatistique.AfficherTransfert();
        }
        #endregion

        #region"Afficher Tracabilite"
        public DataSet afficherTracabilite()
        {
            return DalStatistique.AfficherTracabilite();
        }
        #endregion




        #region"Afficher Payroll"
        public DataSet afficherPayroll()
        {
            return DalStatistique.AfficherPayroll();
        }
        #endregion




        #region"Afficher Retrait"
        public DataSet afficherRetrait()
        {
            return DalStatistique.AfficherRetrait();
        }
        #endregion

        #endregion

    }
}
