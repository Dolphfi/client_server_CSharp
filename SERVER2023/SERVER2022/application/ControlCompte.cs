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
    internal class ControlCompte : MarshalByRefObject, GestionInterface.ICompte
    {
        #region"Methode compte"

        Compte compt;

        #region Accesseurs


        public string PrendreNumero_compte()
        {
            return this.compt.GetNumero_compte();
        }

        public string PrendreTypec()
        {
            return this.compt.GetTypec();

        }
        public string PrendreMonnaie()
        {

            return this.compt.GetMonnaie();

        }
        public double PrendreSolde()
        {
            return this.compt.GetSolde();


        }

        public string PrendreEtat()
        {
            return this.compt.GetEtat();


        }
        public DateTime PrendreDate()
        {
            return this.compt.GetDate();


        }
       

        #endregion
        /*******************/
        #region mutateurs
        public void ModifierNumero_compte(string nm_c_c)
        {
            this.compt.SetNumero_compte(nm_c_c);
        }

        public void ModifierTypec(string ty)
        {
            this.compt.SetTypec(ty);
        }

        public void ModifierMonnaie(string mon)
        {
            this.compt.SetMonnaie(mon);
        }

        public void ModifierSolde(double sol)
        {
            this.compt.SetSolde(sol);
        }


        public void ModifierEtat(string et)
        {
            this.compt.SetEtat(et);
        }


        public void ModifierDate(DateTime dat)
        {
            this.compt.SetDate(dat);
        }


        #endregion
        // methode de la creation de l’intance

        #region"Insertion Compte"
        public int InsererCompte(string nm_c_c, string ty, string mon, double sol, string et, DateTime dat)
        {
            compt = new Compte(nm_c_c,ty,mon,sol,et,dat);
            return DalCompte.InsererCompte(compt);
        }
        #endregion

        #region"Modifier Employe"
        public int Modifiercompt(string nm_c_c, string ty, string mon, double sol,string et, DateTime dat)
        {

            return DalCompte.ModifierCompte(nm_c_c, ty, mon, sol,et, dat);
        }
        #endregion

        #region"Rechercher compte"

        public bool RechercherCompte(string nm_c_c)
        {
            bool rech = false;
            this.compt = DalCompte.RechercheCompte(nm_c_c);
            if (compt.GetNumero_compte() != null)
            {
                rech = true;
            }
            return rech;

        }
        #endregion

        #region"Suppression"

        public int Supprimercompte(string nm_c_c)
        {
            return DalCompte.SupprimerCompte(nm_c_c);

        }
        #endregion

        #region"Afficher Compte Par numerocompte"
        public DataSet affichercompteparcode(string nm_c_c)
        {
            return DalCompte.affichercompteparcode(nm_c_c);

        }
        #endregion

        #region"Afficher Compte"
        public DataSet affichercompte()
        {
            return DalCompte.affichercompte();

        }
        #endregion

        #region"compte auto"
        public int RerchercherNumero_compteAutoGestionCompte()
        {
            return ServiceTechnique.RerchercherNumero_compteAutoGestionCompte();
        }

        #endregion

        #region"Modifier Compte Auto"
        public int ModifierNumero_compteGestionCompte()
        {
            return ServiceTechnique.ModifierNumero_compteGestionCompte();
        }
        #endregion

        #endregion

    }
}
