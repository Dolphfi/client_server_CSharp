using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
    public interface ICompte
    {
        #region"Methode compte"


        #region Accesseurs


        string PrendreNumero_compte();


        string PrendreTypec();
       
        
    string PrendreMonnaie();

    double PrendreSolde();


        string PrendreEtat();

        DateTime PrendreDate();



        #endregion
        /*******************/
        #region mutateurs
        void ModifierNumero_compte(string nm_c_c);


        void ModifierTypec(string ty);


        void ModifierMonnaie(string mon);


        void ModifierSolde(double sol);



        void ModifierEtat(string et);



        void ModifierDate(DateTime dat);



        #endregion
        // methode de la creation de l’intance

        #region"Insertion Compte"
        int InsererCompte(string nm_c_c, string ty, string mon, double sol, string et, DateTime dat);

        #endregion

        #region"Modifier Employe"
        int Modifiercompt(string nm_c_c, string ty, string mon, double sol, string et, DateTime dat);

        #endregion

        #region"Rechercher compte"

        bool RechercherCompte(string nm_c_c);

        #endregion

        #region"Suppression"

        int Supprimercompte(string nm_c_c);

        #endregion

        #region"Afficher Compte Par numerocompte"
         DataSet affichercompteparcode(string nm_c_c);

        #endregion

        #region"Afficher Compte"
         DataSet affichercompte();

        #endregion

        #region"compte auto"
        int RerchercherNumero_compteAutoGestionCompte();


        #endregion

        #region"Modifier Compte Auto"
        int ModifierNumero_compteGestionCompte();
       
        #endregion

        #endregion
    }
}
