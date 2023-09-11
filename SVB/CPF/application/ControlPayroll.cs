using CFP;
using CFP.DAL;
using SVB.DAL;
using SVB.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVB.application
{
    internal class ControlPayroll
    {
        Payroll pay;

        #region"Methode Payroll"

        #region Accesseurs
        public string PrendreId_payroll()
        {
            return this.pay.GetId_payroll();
        }
        public string PrendreNumero_Compte()
        {
            return this.pay.GetNumero_Compte();
        }

       


        public string PrendreDescription()
        {
            return this.pay.GetDescription();
        }

        public double PrendreSalaire()
        {
            return this.pay.GetSalaire();
        }

        public double PrendreSalaire_net()
        {
            return this.pay.GetSalaire_net();
        }



        public DateTime PrendreDate()
        {
            return this.pay.GetDate();
        }

        public string PrendreNom()
        {
            return this.pay.GetNom();
        }
        public string PrendrePrenom()
        {
            return this.pay.GetPrenom();
        }

        public double PrendreTax()
        {
            return this.pay.GetTax();
        }

        public string PrendreCodeEmploye()
        {
            return this.pay.GetCodeEmploye();
        }


        #endregion
       
        #region mutateurs

       
        public void ModifierId_payroll(string id_pay)
        {
            this.pay.SetId_Transaction(id_pay);
        }
        public void ModifierNumero_Compte(string num_copt)
        {
            this.pay.SetNumero_Compte(num_copt);
        }
     
        public void ModifierDescription(string descp)
        {
            this.pay.SetDescription(descp);
        }

        public void ModifierSalaire(double sal)
        {
            this.pay.SetSalaire(sal);
        }

        public void ModifierSalaire_net(double saln)
        {
            this.pay.SetSalaire_net(saln);
        }

        public void ModifierDate(DateTime dat)
        {
            this.pay.SetDate(dat);
        }

        public void ModifierPrenom(string pre)
        {
            this.pay.SetPrenom(pre);
        }


        public void ModifierNom(string no)
        {
            this.pay.SetNom(no);
        }

        public void ModifierTax(double ta)
        {
            this.pay.SetTax(ta);
        }


        public void ModifierCodeEmploye(string co)
        {
            this.pay.SetCodeEmploye(co);
        }
        #endregion

        #region"Insertion Retrait"
        public int InsererPayroll(string id_pay, string num_copt, string no, string pre, double sal, string descp, double saln, DateTime dat, double ta,string co)
        {
           pay = new Payroll(id_pay,num_copt,no,pre,sal, descp,saln,dat,ta,co);
            return DalPayroll.InsererPayroll(pay);
        }
        #endregion

        #region"Afficher Payroll par id"
        public DataSet AfficherayrollPcode(string co)
        {
            return DalPayroll.AfficherPayrollcode(co);

        }
        #endregion

        //#region"Rechercher Payroll par id"

        //public bool RechercherPayroll(string num_copt)
        //{
        //    bool rech = false;
        //    this.pay = DalPayroll.RechercherPayroll(num_copt);
        //    if (pay.GetNumero_Compte() != null)
        //    {
        //        rech = true;
        //    }
        //    return rech;

        //}
        //#endregion

        #region"Recher Payrlol pour visualiser"
        public bool RechercherPayrollV(string id)
        {
            bool rech = false;
            this.pay = DalPayroll.RechercherPayrollV(id);
            if (pay.GetId_payroll()!= null)
            {
                rech = true;
            }
            return rech;

        }
        #endregion

        #region"code auto Retrait"
        public int RerchercherCodeAutoTransactionPayroll()
        {
            return ServiceTechnique.RerchercherCodeAutoTransactionPayroll();
        }

        #endregion

        #region"Modifier code Retrait"
        public int ModifierCodeAutoTransactionPayroll()
        {
            return ServiceTechnique.ModifierCodeAutoTransactionPayroll();
        }
        #endregion

        #endregion
    }
}
