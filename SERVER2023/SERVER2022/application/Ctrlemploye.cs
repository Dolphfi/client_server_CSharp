using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERVER2023.DAL;
using System.Data;
using SERVER2023.Domain;


namespace SERVER2023.application
{

    class Ctrlemploye : MarshalByRefObject, GestionInterface.IEmploye
    {
        #region"Methode Employe"
        Employe empl;
        #region Accesseurs
        public string PrendreCode()
        {
            return this.empl.GetCode();
        }
        public string Prendrenom()
        {
            return this.empl.GetNom();
        }
        public string PrendrePrenom()
        {
            return this.empl.GetPrenom();
        }
        public string Prendresexe()
        {
            return this.empl.GetSexe();
        }
        public string PrendreTELEPHONE()
        {
            return this.empl.GetTelephone();
        }

        public double PrendreSalaire()
        {
            return this.empl.GetSalaire();
        }


        public string PrendreRole()
        {
            return this.empl.GetRole();
        }
        public DateTime PrendreDate()
        {
            return this.empl.GetDate();
        }

        public string PrendreEmail()
        {
            return this.empl.GetEmail();
        }
        public string PrendreNif()
        {
            return this.empl.GetNif();
        }
        public string PrendreAdresse()
        {
            return this.empl.GetAdresse();
        }

        public string PrendreDatenaissance()
        {
            return this.empl.GetDatenaissance();
        }


        public string PrendreNumerocompte()
        {
            return this.empl.GetNumerocompte();
        }

     





        #endregion
        /**************************************************************************/
        #region mutateurs
        public void ModifierCode(string co)
        {
            this.empl.SetCode(co);
        }
        public void ModifierNom(string no)
        {
            this.empl.SetNom(no);
        }
        public void ModifierPrenom(string pre)
        {
            this.empl.SetPrenom(pre);
        }
        public void ModifierTelephone(string tel)
        {
            this.empl.SetTelephone(tel);
        }

        public void ModifierSalaire(double sal)
        {
            this.empl.SetSalaire(sal);
        }
        public void ModifierRole(string rol)
        {
            this.empl.SetRole(rol);
        }
        public void ModifierSexe(string sex)
        {
            this.empl.SetSexe(sex);
        }
        public void ModifierDate(DateTime dat)
        {
            this.empl.SetDate(dat);
        }

        public void ModifierEmail(string ema)
        {
            this.empl.SetEmail(ema);
        }


        public void ModifierNif(string nif)
        {
            this.empl.SetNif(nif);
        }

        public void ModifierAdresse(string adr)
        {
            this.empl.SetAdresse(adr);
        }

        public void ModifierDatenaissance(string datn)
        {
            this.empl.SetDatenaissance(datn);
        }

        public void ModifierNumerocompte(string num)
        {
            this.empl.SetNumerocompte(num);
        }




        #endregion


        #region"Techercher employe par code Pay"
        public bool RechercherEmployePay(string c)
        {
            bool rech = false;
            this.empl = Dalemploye.RechercherEmployePay(c);
            if (empl.GetNumerocompte() != null)
            {
                rech = true;
            }
            return rech;

        }
        #endregion
        // methode de la creation de l’intance
        #region"Insertion Employe"
        public int InsererEmploye(string co, string no, string pr, string sex, string tel, double sal, string rol, DateTime dat, string ema, string ni, string adr, string datn, string num)
        {
            empl = new Employe(co, no, pr, sex, tel, sal, rol, dat, ema, ni, adr, datn, num);
            return Dalemploye.InsererEmploye(empl);
        }
        #endregion

        #region"Afficher Employe"
        public DataSet afficheremploye()
        {
            return Dalemploye.AfficherEmploye();
        }
        #endregion

        #region"Afficher Employer Par code"
        public DataSet afficheremployeparcode(string cod)
        {
            return Dalemploye.afficheremployeparcode(cod);
        }
        #endregion

        #region"Techercher employe par code"
        public bool RechercherEmploye(string c)
        {
            bool rech = false;
            this.empl = Dalemploye.RechercherEmploye(c);
            if (empl.GetCode() != null)
            {
                rech = true;
            }
            return rech;

        }
        #endregion

        #region"Modifier Employe"
        public int Modifieremp(string code, string nom, string prenom, string sex, string telephone, double sal, string rol, DateTime dat, string ema, string ni, string adr, string datn, string num)
        {

            return Dalemploye.ModifierEmploye(code, nom, prenom, sex, telephone, sal, rol, dat, ema, ni, adr, datn, num);
        }
        #endregion

        #region"Suppression"
        public int Supprimeremployer(string co)
        {
            return Dalemploye.SupprimerEmploye(co);

        }
        #endregion
        public DataTable AfficherNumeroCompteEmploye()
        {
            return Dalemploye.AfficherNumeroCompteEmploye();
        }
        #region"code auto Employe"
        public int RerchercherCode_Auto_Gestion_Employe()
        {
            return ServiceTechnique.RerchercherCode_Auto_Gestion_Employe();
        }
        #endregion

        #region"Modifier code Auto"
        public int ModifierCode_Auto_Gestion_Employe()
        {
            return ServiceTechnique.ModifierCode_Auto_Gestion_Employe();
        }
        #endregion

        #endregion
    }
}
