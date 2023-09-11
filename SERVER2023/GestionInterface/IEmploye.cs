using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
    public interface IEmploye
    {
        #region"Methode Employe"

        #region Accesseurs
        string PrendreCode();

        string Prendrenom();

        string PrendrePrenom();

        string Prendresexe();

        string PrendreTELEPHONE();


        double PrendreSalaire();




        string PrendreRole();

        DateTime PrendreDate();
        string PrendreEmail();
        string PrendreNif();
        string PrendreAdresse();
        string PrendreDatenaissance();
        string PrendreNumerocompte();
       




        #endregion
        /**************************************************************************/
        #region mutateurs
        void ModifierCode(string co);

        void ModifierNom(string no);

        void ModifierPrenom(string pre);

        void ModifierTelephone(string tel);


        void ModifierSalaire(double sal);

        void ModifierRole(string rol);

        void ModifierSexe(string sex);

        void ModifierDate(DateTime dat);
        void ModifierEmail(string ema);
        void ModifierNif(string nif);
        void ModifierAdresse(string adr);
        void ModifierDatenaissance(string datn);
        void ModifierNumerocompte(string num);
        bool RechercherEmployePay(string c);

        #endregion
        // methode de la creation de l’intance
        #region"Insertion Employe"
        int InsererEmploye(string co, string no, string pr, string sex, string tel, double sal, string rol, DateTime dat, string ema, string ni, string adr, string datn, string num);

        #endregion

        #region"Afficher Employe"
        DataSet afficheremploye();

        #endregion

        #region"Afficher Employer Par code"
        DataSet afficheremployeparcode(string cod);

        #endregion


        DataTable AfficherNumeroCompteEmploye();
        #region"Techercher employe par code"
        bool RechercherEmploye(string c);

        #endregion

        #region"Modifier Employe"
        int Modifieremp(string code, string nom, string prenom, string sex, string telephone, double sal, string rol, DateTime dat, string ema, string ni, string adr, string datn, string num);

        #endregion

        #region"Suppression"
        int Supprimeremployer(string co);

        #endregion

        #region"code auto Employe"
        int RerchercherCode_Auto_Gestion_Employe();

        #endregion

        #region"Modifier code Auto"
        int ModifierCode_Auto_Gestion_Employe();

        #endregion

        #endregion
    }
}
