using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
    public interface IPayroll
    {

        #region"Methode Payroll"

        #region Accesseurs
        string PrendreId_payroll();

        string PrendreNumero_Compte();


      




        string PrendreDescription();


        double PrendreSalaire();


        double PrendreSalaire_net();




        DateTime PrendreDate();


        string PrendreNom();

        string PrendrePrenom();


        double PrendreTax();


        string PrendreCodeEmploye();



        #endregion
        /**************************************************************************/
        #region mutateurs

        void ModifierId_payroll(string id_pay);

        void ModifierNumero_Compte(string num_copt);

      

        void ModifierDescription(string descp);


        void ModifierSalaire(double sal);


        void ModifierSalaire_net(double saln);


        void ModifierDate(DateTime dat);


        void ModifierPrenom(string pre);



        void ModifierNom(string no);


        void ModifierTax(double ta);



        void ModifierCodeEmploye(string co);

        #endregion

        #region"Insertion Retrait"
        int InsererPayroll(string id_pay, string num_copt, string no, string pre, double sal, string descp, double saln, DateTime dat, double ta, string co);

        #endregion

        #region"Afficher Retrait par id"
        DataSet AfficherayrollPcode(string co);

        #endregion

        #region"Rechercher Retrait par id"

      //  bool RechercherPayroll(string num_copt);

        #endregion

        #region"Recher Retrait pour visualiser"
        bool RechercherPayrollV(string id);

        #endregion

        #region"code auto Retrait"
        int RerchercherCodeAutoTransactionPayroll();


        #endregion

        #region"Modifier code Retrait"
        int ModifierCodeAutoTransactionPayroll();

        #endregion

        #endregion
    }
}
