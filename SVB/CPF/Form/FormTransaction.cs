using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVB
{
    public partial class FormTransaction : Form
    {
        public string codeuser;
        DateTime datla = DateTime.Now;
     
        public GestionInterface.IUtilisateur util = null;
        public GestionInterface.IDepot dep = null;
        public GestionInterface.IRetrait ret = null;
        public GestionInterface.ITransfert tra = null;

        public FormTransaction(string co, GestionInterface.IDepot de, GestionInterface.IRetrait re, GestionInterface.ITransfert tr, GestionInterface.IUtilisateur ut)
        {
            InitializeComponent();
            codeuser = co;
            dep = de;
            util = ut;
            ret = re;
            tra = tr;
        }
       


        //readonly CFP.application.ControlDepot con = null;
        //readonly CFP.application.ControlRetrait con1 = null;
        //readonly CFP.application.ControlTransfert con2 = null;

        public static string id_tra, num_copt, descp, monn, num_coptde, num_copta, ty, code;
        public static double mont, bal;
        readonly DateTime dat = DateTime.Now;

        #region"Pour rechercher compte retrait"
        private void bt_Rech_Compte_Retrait_Click(object sender, EventArgs e)
        {
            if (txt_Rech_Numero_Compte_Retrait.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir les champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    num_copt = txt_Rech_Numero_Compte_Retrait.Text;
                    bool rech = false;
                    rech = this.ret.RechercherRetrait(num_copt);
                    if (rech == true)
                    {
                        txt_Monnai_Retrait.Text = ret.PrendreMonnaie();
                        txt_Numero_Compte_Retrait.Text = ret.PrendreNumero_Compte();

                        txt_Balance_Compte_Retrait.Text = Convert.ToString(ret.PrendreBalance());

                        txt_Balance_Compte_Retrait.Text = String.Format("{0:n}", double.Parse(txt_Balance_Compte_Retrait.Text));

                        txt_Id_Transaction_Retrait.Text = "TRANS-" + this.ret.RerchercherCodeAutoTransactionRetrait();
                    }
                    else
                    {
                        MessageBox.Show("Code incorrect");
                    }

                }
                catch (Exception)
                {
                   
                }

            }
        }
        #endregion

        #region "Validation de Retrait "
        private void bt_Valider_Retrait_Click(object sender, EventArgs e)
        {
            if (txt_Id_Transaction_Retrait.Text.Trim() == String.Empty || txt_Description_Retrait.Text.Trim() == String.Empty || txt_Montant_Retrait.Text.Trim() == String.Empty || txt_Numero_Compte_Retrait.Text.Trim() == String.Empty || txt_Balance_Compte_Retrait.Text == String.Empty)
                MessageBox.Show("Vous devez remplir les tous les champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    DialogResult rep = MessageBox.Show("Voulez-vous vaiment efe?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (rep == DialogResult.OK)
                    {
                        id_tra = txt_Id_Transaction_Retrait.Text.ToString();
                        num_copt = txt_Numero_Compte_Retrait.Text.ToString();
                        mont = Convert.ToDouble(txt_Montant_Retrait.Text);
                        descp = txt_Description_Retrait.Text.ToString();
                        bal = Convert.ToDouble(txt_Balance_Compte_Retrait.Text.ToString());
                        monn = txt_Monnai_Retrait.Text.ToString();
                        int ver = 0;
                        if (mont < 0)
                        {
                            MessageBox.Show("Vous devez entrer une valeur positive pour le montant");
                        }
                        else if (mont < 10 && monn == "Dollar")
                        {
                            MessageBox.Show("Vous devez entrer  Minimumm 10 Dollars");
                        }
                        else if (mont < 250 && monn == "Gourde")
                        {
                            MessageBox.Show("Vous devez entrer  Minimumm 250 Gourdes");
                        }
                        else if (bal < mont)
                        {
                            MessageBox.Show("Vous n'avez pas assez d'argent sur votre compte");
                        }
                        else if (monn == "Dollar" && bal <= 20)
                        {
                            MessageBox.Show("Vous ne pouvez pas vide le compte a zero,Car vous devez laisser minimmum 20 dollars ");
                        }
                        else if (monn == "Gourde" && bal <= 250)
                        {
                            MessageBox.Show("Vous ne pouvez pas vide le compte a zero,Car vous devez laisser minimmum 250 gourdes ");
                        }
                        else if (mont == bal)
                        {
                            MessageBox.Show("Vous ne pouvez pas vide le compte a zero");
                        }
                        else
                        {
                            ver = this.ret.InsererRetrait(id_tra, num_copt, mont, descp, bal, dat, monn);
                        }


                        if (ver > 0)
                        {
                            this.util.Inftransaction(codeuser, "Insertion-> Retrait-->" + "Id trans-->:" + id_tra + "No Compte-->:" + num_copt + "--" + "Montant-->:" + mont, datla);
                            ClearFillR();
                            this.ret.ModifierCodeAutoTransactionRetrait();
                            txt_Id_Transaction_Retrait.Text = "TRANS-" + Convert.ToInt32(this.ret.RerchercherCodeAutoTransactionRetrait()).ToString();
                            txt_Id_Transaction_Retrait.Text = "TRANS-" + this.ret.RerchercherCodeAutoTransactionRetrait();
                        }

                        else
                        {
                            MessageBox.Show("Retrait non reusite");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Retrait non reusite,Vous devez remplir les champs corectement.");

                }
            }

        }
        #endregion

        #region"Rechercher Debiteur"
        private void bt_Rech_Compte_Debiteur_Transfert_Click(object sender, EventArgs e)
        {

            if (txt_Numero_Compte_debiteur_Transfert.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir le champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    num_coptde = txt_Numero_Compte_debiteur_Transfert.Text;
                    bool rech = false;
                    rech = this.tra.RechercherTransfertde(num_coptde);
                    if (rech == true)
                    {

                        txtdeNumerocompte.Text = tra.PrendreNumero_Comptede();
                        txtMonnaieDebiteur.Text = tra.PrendreMonnaie();

                        txt_type_Debiteur.Text = tra.PrendreType();

                        txt_Balance_Debiteur_Transfert.Text = Convert.ToString(tra.PrendreBalance());
                        txt_Balance_Debiteur_Transfert.Text = String.Format("{0:n}", double.Parse(txt_Balance_Debiteur_Transfert.Text));
                        txt_Id_Transaction_Transfert.Text = "TRANS-" + this.tra.RerchercherCodeAutoTransactionTransfert();
                    }
                    else
                    {
                        MessageBox.Show("Code incorrect");
                    }

                }
                catch (Exception)
                {
                   
                }

            }
        }

        #endregion
        #region"Rechercher Depot pard id"
        private void btRechercherdepot_Click(object sender, EventArgs e)
        {

            if (txtRechercherDepot.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir le champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {

                    code = txtRechercherDepot.Text;
                    bool rech = false;
                    rech = this.dep.RechercherDepotV(code);

                    if (rech == true)
                    {

                        DataSet data;
                        data = this.dep.AfficherDepotcode(code);

                        this.dtDepotT.DataMember = "depot";
                        this.dtDepotT.AutoGenerateColumns = false;
                        this.Idtransactiondep.DataPropertyName = "idtransaction";
                        this.numerocomptedep.DataPropertyName = "numerocompte";
                        this.montantdep.DataPropertyName = "montant";
                        this.descriptiondep.DataPropertyName = "description";
                        this.datedep.DataPropertyName = "date";

                        this.dtDepotT.DataSource = data;
                    }
                    else
                    {
                        MessageBox.Show("Code incorrect");
                    }


                }
                catch (Exception )
                {
                    
                }
            }
        }
        #endregion
      
        #region "Rechercher pour faire retait"
        private void btRecherRetrait_Click(object sender, EventArgs e)
        {

            if (txtRecherRetrait.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir le champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {

                    code = txtRecherRetrait.Text;
                    bool rech = false;
                    rech = this.ret.RechercherRetraitV(code);

                    if (rech == true)
                    {

                        DataSet data;
                        data = this.ret.AfficherRetraitcode(code);

                        this.dtretraitS.DataMember = "retrait";
                        this.dtretraitS.AutoGenerateColumns = false;
                        this.Idtransactionret.DataPropertyName = "idtransaction";
                        this.numerocompteret.DataPropertyName = "numerocompte";
                        this.montantret.DataPropertyName = "montant";
                        this.descriptionret.DataPropertyName = "description";
                        this.dateret.DataPropertyName = "date";

                        this.dtretraitS.DataSource = data;
                    }
                    else
                    {
                        MessageBox.Show("Code incorrect");
                    }


                }
                catch (Exception )
                {
                   
                }
            }
        }

        #endregion
        #region"Rechercher transfert par id"
        private void btRechercherTransfert_Click(object sender, EventArgs e)
        {

            if (txtRechercherTransfert.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir le champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {

                    code = txtRechercherTransfert.Text;
                    bool rech = false;
                    rech = this.tra.RechercherTransfertV(code);

                    if (rech == true)
                    {

                        DataSet data;
                        data = this.tra.AfficherTransfertcode(code);

                        this.dtTransfertT.DataMember = "transfert";
                        this.dtTransfertT.AutoGenerateColumns = false;
                        this.idtransactiontra.DataPropertyName = "idtransaction";
                        this.de_comptetra.DataPropertyName = "de_compte";
                        this.a_comptetra.DataPropertyName = "a_compte";
                        this.montanttra.DataPropertyName = "montant";
                        this.descriptiontra.DataPropertyName = "description";
                        this.datetra.DataPropertyName = "date";
                        this.dtTransfertT.DataSource = data;
                    }
                    else
                    {
                        MessageBox.Show("Code incorrect");
                    }


                }
                catch (Exception )
                {
                    
                }
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Balance_Debiteur_Transfert_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtDepotT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region"Crediteur"
        private void bt_Numero_Compte_Crediteur_Transfert_Click(object sender, EventArgs e)
        {

            if (txt_Numero_Compte_Crediteur_Transfert.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir le champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    num_copta = txt_Numero_Compte_Crediteur_Transfert.Text;
                    bool rech = false;
                    rech = this.tra.RechercherTransferta(num_copta);
                    if (rech == true)
                    {

                        txtaNumerocompte.Text = tra.PrendreNumero_Comptea();
                        ttxtMonnaieCrediteur.Text = tra.PrendreMonnaie();

                        txt_type_Crediteur.Text = tra.PrendreType();

                        txt_Balance_Compte_Crediteur_Transfert.Text = Convert.ToString(tra.PrendreBalance());
                        txt_Balance_Compte_Crediteur_Transfert.Text = String.Format("{0:n}", double.Parse(txt_Balance_Compte_Crediteur_Transfert.Text));
                        txt_Id_Transaction_Transfert.Text = "TRANS-" + this.tra.RerchercherCodeAutoTransactionTransfert();
                    }
                    else
                    {
                        MessageBox.Show("Code incorrect");
                    }

                }
                catch (Exception)
                {
                    
                }

            }
        }
        #endregion

        #region"Valider Transfert"
        private void bt_Valider_Transfert_Click(object sender, EventArgs e)
        {
            if (txtdeNumerocompte.Text.Trim() == String.Empty || txtaNumerocompte.Text.Trim() == String.Empty || txt_Id_Transaction_Transfert.Text.Trim() == String.Empty || txt_Montant_Transferer_Compte_debiteur_Transfert.Text.Trim() == String.Empty || txt_Balance_Debiteur_Transfert.Text.Trim() == String.Empty || txt_Balance_Compte_Crediteur_Transfert.Text.Trim() == String.Empty || txt_Description_Transfert.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir les champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    DialogResult rep = MessageBox.Show("Voulez-vous vaiment efe?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (rep == DialogResult.OK)
                    {
                        id_tra = txt_Id_Transaction_Transfert.Text.ToString();
                        num_coptde = txtdeNumerocompte.Text.ToString();
                        num_copta = txtaNumerocompte.Text.ToString();
                        mont = Convert.ToDouble(txt_Montant_Transferer_Compte_debiteur_Transfert.Text);
                        descp = txt_Description_Transfert.Text.ToString();
                        bal = Convert.ToDouble(txt_Balance_Debiteur_Transfert.Text);
                        string monnde = txtMonnaieDebiteur.Text.ToString();
                        string monna = ttxtMonnaieCrediteur.Text.ToString();

                        string tyde = txt_type_Debiteur.Text;
                        string tya = txt_type_Crediteur.Text;

                        int ver = 0;
                        if (mont < 0)
                        {
                            MessageBox.Show("Vous devez entrer  une valeur positive pour le montant");

                        }
                        else if (monnde == "Gourde" && mont < 250)
                        {
                            MessageBox.Show("Vous devez entrer  minimmum 250 Gourdes");

                        }
                        else if (monnde == "Dollar" && mont < 10)
                        {
                            MessageBox.Show("Vous devez entrer  minimmum 10 Dollars");

                        }

                        else if (mont > bal)
                        {
                            MessageBox.Show("il y a pas asser d'argent sur le compte ");
                        }
                        else if (monnde == "Gourde" && bal == 250)
                        {
                            MessageBox.Show("Vous ne pouvez pas vider le compte ");
                        }
                        else if (monnde == "Dollar" && bal <= 10)
                        {
                            MessageBox.Show("Vous ne pouvez pas vider le compte ");
                        }
                        else if (bal == mont)
                        {
                            MessageBox.Show("Vous ne pouvez pas vider le compte ");
                        }
                        else if (monnde != monna)
                        {
                            MessageBox.Show("Les compte devrait de meme type d'argent ");
                        }
                        else if (num_coptde == num_copta)
                        {
                            MessageBox.Show("imposible ");
                        }

                        else if (tyde != tya)
                        {
                            MessageBox.Show("Les compte devrait de meme type ");
                        }
                        else
                        {
                            ver = this.tra.InsererTransfert(id_tra, num_coptde, num_copta, mont, descp, bal, dat, monn, ty);
                        }


                        if (ver > 0)
                        {
                            this.util.Inftransaction(codeuser, "Insertion->Transfert-->" + "De No Compte-->:" + num_coptde + "-->A NO Compte:" + num_copta + "--->Montant:" + mont, datla);

                            ClearFillT();
                            txt_Id_Transaction_Transfert.Text = "TRANS-" + this.tra.RerchercherCodeAutoTransactionTransfert();
                            this.tra.ModifierCodeAutoTransactionTransfert();
                            txt_Id_Transaction_Transfert.Text = "TRANS-" + Convert.ToInt32(this.tra.RerchercherCodeAutoTransactionTransfert()).ToString();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Transfert non reusite");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Transfert non reusite,Vous devez remplir les champs corectement.");

                }
            }
        }

        #endregion

        #region "Form Load"
        private void FormTransaction_Load(object sender, EventArgs e)
        {
            try
            {
                txt_Monnai_Depot.Enabled = false;
                txtaNumerocompte.Enabled = false;
                txtdeNumerocompte.Enabled = false;
                txt_type_Debiteur.Enabled = false;
                txt_type_Crediteur.Enabled = false;
                txt_Id_Transaction_Transfert.Enabled = false;
                txt_Balance_Debiteur_Transfert.Enabled = false;
                txt_Balance_Compte_Crediteur_Transfert.Enabled = false;

                txtMonnaieDebiteur.Enabled = false;
                ttxtMonnaieCrediteur.Enabled = false;


                txt_Numero_Compte_Depot.Enabled = false;
                txt_Numero_Compte_Retrait.Enabled = false;

                txt_Id_Transaction_Depot.Enabled = false;
                txt_Id_Transaction_Retrait.Enabled = false;

                txt_Balance_Compte_Depot.Enabled = false;
                txt_Balance_Compte_Retrait.Enabled = false;
                txt_Monnai_Retrait.Enabled = false;
                txt_Id_Transaction_Retrait.Text = "TRANS-" + this.ret.RerchercherCodeAutoTransactionRetrait();
                txt_Id_Transaction_Depot.Text = "TRANS-" + this.dep.RerchercherCodeAutoTransactionDepot();
                txt_Id_Transaction_Transfert.Text = "TRANS-" + this.tra.RerchercherCodeAutoTransactionTransfert();

            }
            catch (Exception)
            {

                MessageBox.Show("Le server n'est pas en marche");
            }
           
        }
        #endregion

        #region" Rechercher compte pour faire un depot"
        private void bt_rechercher_Numero_Compte_Depot_Click(object sender, EventArgs e)
        {

            if (txt_Rech_Numero_Compte_Depot.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir le champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    num_copt = txt_Rech_Numero_Compte_Depot.Text;
                    bool rech = false;
                    rech = this.dep.RechercherDepot(num_copt);
                    if (rech == true)
                    {

                        txt_Numero_Compte_Depot.Text = dep.PrendreNumero_Compte();
                        txt_Monnai_Depot.Text = dep.PrendreMonnaie();
                        txt_Balance_Compte_Depot.Text = Convert.ToString(dep.PrendreBalance());
                        txt_Balance_Compte_Depot.Text = String.Format("{0:n}", double.Parse(txt_Balance_Compte_Depot.Text));
                        txt_Id_Transaction_Depot.Text = "TRANS-" + this.dep.RerchercherCodeAutoTransactionDepot();
                    }
                    else
                    {
                        MessageBox.Show("Code incorrect");
                    }

                }
                catch (Exception)
                {
                  
                }

            }

        }
        #endregion

        #region "Validation de depot"
        private void bt_Valider_Depot_Click(object sender, EventArgs e)


        {
            if (txt_Id_Transaction_Depot.Text.Trim() == String.Empty || txt_Description_Depot.Text.Trim() == String.Empty || txt_Montant_Depot.Text.Trim() == String.Empty || txt_Numero_Compte_Depot.Text.Trim() == String.Empty || txt_Balance_Compte_Depot.Text == String.Empty)
                MessageBox.Show("Vous devez remplir toutes les champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                   // DialogResult rep = MessageBox.Show("Voulez-vous vaiment efe?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    //if (rep == DialogResult.OK)
                    //{
                        id_tra = txt_Id_Transaction_Depot.Text.ToString();
                        num_copt = txt_Numero_Compte_Depot.Text.ToString();
                        mont = Convert.ToDouble(txt_Montant_Depot.Text);
                        descp = txt_Description_Depot.Text.ToString();
                        monn = txt_Monnai_Depot.Text.ToString();
                        int ver = 0;
                        if (mont < 0)
                        {
                            MessageBox.Show("Vous devez entrer un nombre positive");


                        }
                        else if (mont < 250 && monn == "Gourde")
                        {
                            MessageBox.Show("Vous devez entrer Minimmum 250 gourdes pour faire le depot");

                        }
                        else if (mont < 10 && monn == "Dollar")
                        {
                            MessageBox.Show("Vous devez entrer Minimmum 10 Dollars pour faire le depot");

                        }
                        else
                        {
                            ver = this.dep.InsererDepot(id_tra, num_copt, mont, descp, bal, dat, monn);
                        }


                        if (ver > 0)
                        {
                           this.util.Inftransaction(codeuser, "Insertion-> Depot-->" + "Id trans-->:" +id_tra+ "No Compte-->:" + num_copt + "--" + "Montant-->:" + mont, datla);
                            ClearFill();
                            this.dep.ModifierCodeAutoTransactionDepot();
                            txt_Id_Transaction_Depot.Text = "TRANS-" + Convert.ToInt32(this.dep.RerchercherCodeAutoTransactionDepot()).ToString();
                            txt_Id_Transaction_Depot.Text = "TRANS-" + this.dep.RerchercherCodeAutoTransactionDepot();
                        }

                        else
                        {
                            MessageBox.Show("Depot non reusite");
                        }
                    //}
                }
                catch (Exception)
                {

                    MessageBox.Show("Depot non reusite,remplir les valeur corectement");
                }
            }

        }



        #endregion

        #region"Pour effacer les champs apres avoir valide"

        public void ClearFill()
        {

            txt_Id_Transaction_Depot.Clear();
            txt_Numero_Compte_Depot.Clear();
            txt_Montant_Depot.Clear();
            txt_Description_Depot.Clear();
            txt_Balance_Compte_Depot.Clear();
            txt_Monnai_Depot.Clear();
            txt_Rech_Numero_Compte_Depot.Clear();

        }


        public void ClearFillR()
        {
            txt_Monnai_Retrait.Clear();
            txt_Rech_Numero_Compte_Retrait.Clear();
            txt_Id_Transaction_Retrait.Clear();
            txt_Numero_Compte_Retrait.Clear();
            txt_Montant_Retrait.Clear();
            txt_Description_Retrait.Clear();
            txt_Balance_Compte_Retrait.Clear();

        }



        public void ClearFillT()
        {
            txt_Id_Transaction_Transfert.Clear();
            txt_Numero_Compte_debiteur_Transfert.Clear();
            txt_Numero_Compte_Crediteur_Transfert.Clear();

            txt_Montant_Transferer_Compte_debiteur_Transfert.Clear();
            txt_type_Debiteur.Clear();
            txt_type_Crediteur.Clear();
            txtMonnaieDebiteur.Clear();
            ttxtMonnaieCrediteur.Clear();
            txtdeNumerocompte.Clear();
            txtaNumerocompte.Clear();
            txt_Balance_Compte_Crediteur_Transfert.Clear();
            txt_Balance_Debiteur_Transfert.Clear();

            txt_Description_Transfert.Clear();

        }




        #endregion
    }
}
