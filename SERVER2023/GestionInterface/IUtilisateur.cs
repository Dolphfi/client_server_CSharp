using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GestionInterface
{
    public interface IUtilisateur
    {

        #region"Methode utilisateur"

        #region"Methodes Accesseurs utilisateurs"

        string PrendreCode();

        string PrendreCode_employe();

        string PrendreUsername();


        string PrendreFonction();

        string PrendrePasword();



        string PrendreModule_acces();

        DateTime PrendreDate();

        int PrendreEtat();

        #endregion

        #region"Methodes mutateurs utilisateurs"

        void ModifierCode(string co);

        void ModifierCode_employe(string cod);

        void ModifierUsername(string user);


        void ModifierFonction(string fonct);


        void ModifierPasword(string pas);



        void ModifierModule_acces(string moda);


        void ModifierDate(DateTime dat);
        void ModifierEtat(int et);
        #endregion

        #region"insertion user"
        int InsererUtilisateur(string co, string cod, string fon, string us, string pas, string moda, DateTime dat,int et);


        #endregion

        #region"Methode rechercher utilisateur"
        bool Rechercherutilisateur(string co);

        #endregion

        #region"Modification user"
        int Modifieruser(string co, string cod, string fonct, string us, string pas, string moda, DateTime dat,int et);

        #endregion

        #region"Methode supprimer utilisateur"
        int SupprimerUtilisateur(string co);

        #endregion

        #region"Afficher Utilisateur"
        DataSet afficherUtilisateur();

        #endregion

        #region"Afficher Utilisateur par code"
        DataSet afficherutilisateurparcode(string cod);

        #endregion

        #region"Methode rechercher user pour etablir la connection"
        bool Recheruser(string us, string pas);

        #endregion

        #region"code auto"
        int RerchercherCodeAutoGestionUtilisateur();

        #endregion

        #region"Modifier code auto utilisateur"
        int ModifierCodeGestionUtilisateur();

        #endregion

        #region"Afficher CodeEmploye dans utilisateur"
        DataTable AfficherCodeEmployerUtilisateur();

        #endregion

        int ModifierEtat(string co, int et);
        int Inftransaction(string co, string lb, DateTime dat);
        #endregion

    }
}
