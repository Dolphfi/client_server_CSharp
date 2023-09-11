using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
    public interface IClient
    {
        #region"Methode Client"



        #region Accesseurs


        string PrendreNumero_compte();

       string PrendreTypec();

        string PrendreNom();

       

       string PrendreSexe();

        string PrendreAdresse();



        string PrendreTelephone();


       string PrendreDate_de_Naissance();




        string PrendreEmail();



        string PrendreNif_cin();




        DateTime PrendreDate();



        #endregion

        #region mutateurs
        void ModifierNumero_compte(string nm_c_c);


        void ModifierTypec(string ty);


        void ModifierNom(string no);





        void ModifierSexe(string sex);


        void ModifierAdresse(string adres);



       void ModifierTelephone(string tel);



        void ModifierDate_de_Naissance(string dat_de_N);



        void ModifierEmail(string emai);


        void ModifierNif_cin(string ni_c);



        void ModifierDate(DateTime dat);




        #endregion


        #region" methode de la creation de l’intance Enregistrer Client"
        int InsererClient(string nm_c_c, string ty, string no, string sex, string adres, string tel, string dat_de_N, string emai, string ni_c, DateTime dat);

        #endregion


        #region"Modifier Employe"
        int Modifiercli(string nm_c_c, string ty, string no, string sex, string adres, string tel, string dat_de_N, string emai, string ni_c, DateTime dat);

        #endregion


        #region"Modifier Client"
        bool RechercherClient(string nm_c_c);
        #endregion


        #region"Suppression"
      int Supprimerclient(string nm_c_c);
        #endregion


        #region"code auto"

        DataSet afficherclient();



        DataTable AfficherNumeroCompteClient();


        DataSet afficherclientparcode(string code);
        #endregion

        #endregion
    }
}
