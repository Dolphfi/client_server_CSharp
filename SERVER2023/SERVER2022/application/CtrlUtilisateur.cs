using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInterface;
using System.Threading.Tasks;
using SERVER2023.application;
using SERVER2023.DAL;
using SERVER2023.Domain;
using System.Data;

namespace SERVER2023.application
{
    class CtrlUtilisateur : MarshalByRefObject, GestionInterface.IUtilisateur
    {
        Utilisateur ut;
        public Tracer tr;
        #region"Methode utilisateur"

        #region"Methodes Accesseurs utilisateurs"

        public string PrendreCode()
        {
            return this.ut.getCode();

        }
        public string PrendreCode_employe()
        {
            return this.ut.getCode_Employe();

        }
        public string PrendreUsername()
        {
            return this.ut.getUser();
        }

        public string PrendreFonction()
        {
            return this.ut.getFonction();
        }
     
        public string PrendrePasword()
        {
            return this.ut.getPassword();
        }


        public string PrendreModule_acces()
        {
            return this.ut.getModule_acces();
        }
        public DateTime PrendreDate()
        {
            return this.ut.getDate();
        }


        public int PrendreEtat()
        {
            return this.ut.getEtat();
        }
        #endregion

        #region"Methodes mutateurs utilisateurs"

        public void ModifierCode(string co)
        {
            this.ut.setCode(co);

        }
        public void ModifierCode_employe(string cod)
        {
            this.ut.setCode_Employe(cod);

        }
        public void ModifierUsername(string user)
        {
            this.ut.setUser(user);
        }

        public void ModifierFonction(string fonct)
        {
            this.ut.setFonction(fonct);
        }

        public void ModifierPasword(string pas)
        {
            this.ut.setPassword(pas);
        }


        public void ModifierModule_acces(string moda)
        {
            this.ut.setModule_acces(moda);
        }

        public void ModifierDate(DateTime dat)
        {
            this.ut.setDate(dat);
        }

        public void ModifierEtat(int et)
        {
            this.ut.setEtat(et);
        }
        #endregion

        #region"insertion user"
        public int InsererUtilisateur(string co, string cod, string fon, string us, string pas,string moda, DateTime dat,int et)
        {
            ut = new Utilisateur (co, cod, fon, us, pas,moda, dat,et);
            return DalUtilisateur.InsererUtilisateur(ut);
        }

        #endregion

        #region"Methode rechercher utilisateur"
        public bool Rechercherutilisateur(string co)
        {
            bool rech = false;
            this.ut = DalUtilisateur.Rechercherutilisateur(co);
            if (this.ut.getCode() != null)
            {
                rech = true;
            }
            return rech;
        }
        #endregion

        #region"Modification user"
        public int Modifieruser(string co, string cod, string fonct, string us, string pas,string moda, DateTime dat,int et)
        {
            return DalUtilisateur.ModifierUtilisateur(co, cod, fonct, us, pas,moda, dat,et);

        }

        public int ModifieruserEtat(string co, int et)
        {
            return DalUtilisateur.ModifierEtat(co,et);

        }
        #endregion

        #region"Methode supprimer utilisateur"
        public int SupprimerUtilisateur(string co)
        {
            return DalUtilisateur.SupprimerUtilisateur(co);
        }

        #endregion

        #region"Afficher Utilisateur"
        public DataSet afficherUtilisateur()
        {
            return DalUtilisateur.AfficherUtilisateur();
        }
        #endregion

        #region"Afficher Utilisateur par code"
        public DataSet afficherutilisateurparcode(string cod)
        {
            return DalUtilisateur.afficherutilisateurparcode(cod);
        }
        #endregion

        #region"Methode rechercher user pour etablir la connection"
        public bool Recheruser(string us, string pas)
        {
            bool rech = false;
            this.ut = DalUtilisateur.Rechercheruser(us, pas);
            if (this.ut.getCode() != null)
            {
                rech = true;
            }
            return rech;
        }
        #endregion

        #region"code auto"
        public int RerchercherCodeAutoGestionUtilisateur()
        {
            return ServiceTechnique.RerchercherCodeAutoGestionUtilisateur();
        }
        #endregion

        #region"Modifier code auto utilisateur"
        public int ModifierCodeGestionUtilisateur()
        {
            return ServiceTechnique.ModifierCodeGestionUtilisateur();
        }
        #endregion

        #region"Afficher CodeEmploye dans utilisateur"
        public DataTable AfficherCodeEmployerUtilisateur()
        {
            return DalUtilisateur.AfficherCodeEmployerUtilisateur();
        }
        #endregion
        #region"Modification Etat"
        public int ModifierEtat(string co, int et)
        {
            return DalUtilisateur.ModifierEtat(co, et);

        }
        #region"tracer user"
        public int Inftransaction(string co, string lb, DateTime dat)
        {
            this.tr = new Tracer(co, lb, dat);
            return DalUtilisateur.InsererTransaction(this.tr);
        }
        #endregion
        #endregion

        #endregion
    }
}
