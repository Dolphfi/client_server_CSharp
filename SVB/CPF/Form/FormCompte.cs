using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVB
{
    public partial class FormCompte : Form
    {

        public static string nm_c_c, ty, mon, et;
        public static double sol;
        readonly DateTime dat = DateTime.Now;

        public string cod, hre;
        
        DateTime datla = DateTime.Now;
        public GestionInterface.ICompte compt = null;
        public GestionInterface.IUtilisateur util = null;

        public FormCompte(string co, GestionInterface.ICompte cp, GestionInterface.IUtilisateur ut)
        {
            InitializeComponent();
            cod = co;
            util = ut;
            compt =cp;
        }



        #region"Inserer Compte"
        private void btInsert_Click(object sender, EventArgs e)
        {
           

           
                if (txtnumerocompte.Text.Trim() == String.Empty || comboType.Text.Trim() == String.Empty || comboEtat.Text.Trim() == String.Empty || txtSolde.Text.Trim() == String.Empty || comboMonnaie.Text.Trim() == String.Empty)
                    MessageBox.Show("Remplir toutes les champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        //DialogResult rep = MessageBox.Show("Voulez-vous vaiment efe?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        //if (rep == DialogResult.OK)
                        //{
                            nm_c_c = txtnumerocompte.Text;
                            ty = comboType.Text.Trim().ToString();
                            et = comboEtat.Text.Trim();
                            sol = Convert.ToDouble(txtSolde.Text);
                            mon = comboMonnaie.Text.Trim().ToString();


                            int ver = 0;
                            if (sol < 0 && sol!=0)
                            {

                                MessageBox.Show("Vous devez entrer une valeur positive pour le solde");
                            }
                            else if (sol < 500 && mon == "Gourde")
                            {
                                MessageBox.Show("Vous devez entrer minimum 500 gourdes pour ouvrir le compte");
                            }
                            else if (sol < 50 && mon == "Dollar")
                            {
                                MessageBox.Show("Vous devez entrer minimum 50 Dollars pour ouvrir le compte");
                            }
                            else
                            {
                                ver = this.compt.InsererCompte(nm_c_c, ty, mon, sol, et, dat);
                          
                           
                        }

                            if (ver > 0)
                            {
                           
                            this.util.Inftransaction(cod, "Insertion-->" + "Numero compte-->:" + nm_c_c + "--Solde-->:" + sol+"--Type-->:"+ty, datla);

                            deleteChampInsertCompte();
                                afficherCompte();
                                this.compt.ModifierNumero_compteGestionCompte();
                                txtnumerocompte.Text = "0003837" + Convert.ToInt32(this.compt.RerchercherNumero_compteAutoGestionCompte()).ToString();
                                MessageBox.Show("Insertion reusite");
                          
                        }

                            else
                            {
                                MessageBox.Show("Insertion non reusite");
                            }
                        //}
                    }
                    catch (Exception)
                    {
                    MessageBox.Show("Insertion non reusite, Remplir les champs corectement");
                }

                }
            
           
        }
        #endregion
        #region"Effacer Champs compte"
        public void deleteChampInsertCompte()
        {
            txtnumerocompte.Clear();
            comboType.Text = "Choisir";
            comboEtat.Text = "Choisir";
            txtSolde.Clear();
            comboMonnaie.Text = "Choisir";

        }
        #endregion
        #region"Rechercher pour Modifier
        private void btrechercherM_Click(object sender, EventArgs e)
        {

                if (txtrechM.Text.Trim() == String.Empty)
                    MessageBox.Show("Vous devez remplir les champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {

                        nm_c_c = txtrechM.Text;
                        bool rech = false;
                        rech = this.compt.RechercherCompte(nm_c_c);
                        if (rech == true)
                        {

                            TxtnumerocompteM.Text = compt.PrendreNumero_compte();
                            comboTypeM.Text = compt.PrendreTypec();
                            comboMonnaieM.Text = compt.PrendreMonnaie();
                            txtSoldeM.Text = Convert.ToDouble(compt.PrendreSolde()).ToString();
                            comboEtatM.Text = compt.PrendreEtat();
                            pickerDateM.Text = Convert.ToDateTime(compt.PrendreDate()).ToString();

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
        #region"Modifier"
        private void btModifier_Click(object sender, EventArgs e)
        {
            
                if (TxtnumerocompteM.Text.Trim() == String.Empty || comboTypeM.Text.Trim() == String.Empty || comboEtatM.Text.Trim() == String.Empty || txtSoldeM.Text.Trim() == String.Empty || comboMonnaieM.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir les champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                {
                    try
                    {
                        //DialogResult rep = MessageBox.Show("Voulez-vous vaiment efe?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        //if (rep == DialogResult.OK)
                        //{

                            nm_c_c = TxtnumerocompteM.Text.Trim();
                            ty = comboTypeM.Text.Trim();
                            mon = comboMonnaieM.Text.Trim();
                            sol = Convert.ToDouble(txtSoldeM.Text);
                            et = comboEtatM.Text.Trim();
                            string dat1 = pickerDateM.Text.Trim().ToString();

                            int ver = 0;


                            if (sol < 0)
                            {

                                MessageBox.Show("Vous devez entrer une valeur positive pour le solde");
                            }
                            else if (sol < 50)
                            {
                                MessageBox.Show("Vous devez entrer minimum 50 ");
                            }
                            else
                            {
                                ver = this.compt.Modifiercompt(nm_c_c, ty, mon, sol, et, dat);

                            this.util.Inftransaction(cod, "Modification-->" + "Numero compte-->:" + nm_c_c + "--Solde-->:" + sol + "--Type-->:" + ty, datla);

                        }


                            if (ver > 0)
                            {
                                deleteChampEdditCompte();
                                afficherCompte();
                                MessageBox.Show("modification reusite");
                            }

                            else
                            {
                                MessageBox.Show("modification non reusite");
                            }
                        //}
                    }

                    catch (Exception)
                    {
                    MessageBox.Show("Insertion non reusite, Remplir les champs corectement");
                }
                }


            }
        #endregion
        #region "Rechercher pour Supprimer"
        private void btrechercherS_Click(object sender, EventArgs e)
        {
                if (txtrechS.Text.Trim() == String.Empty)
                    MessageBox.Show("Remplir le champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {

                        nm_c_c = txtrechS.Text;
                        bool rech = false;
                        rech = this.compt.RechercherCompte(nm_c_c);
                        if (rech == true)
                        {

                            DataSet data;
                            data = this.compt.affichercompteparcode(nm_c_c);
                            this.dtcomptes.DataMember = "compte";
                            this.dtcomptes.AutoGenerateColumns = false;
                            this.no_comptes.DataPropertyName = "numerocompte";
                            this.types.DataPropertyName = "type";
                            this.monnaies.DataPropertyName = "monaie";
                            this.etats.DataPropertyName = "etat";
                            this.date_creations.DataPropertyName = "date_insc";
                            this.soldes.DataPropertyName = "solde";
                            this.dtcomptes.DataSource = data;


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
        #region"Supprimer"
        private void btSupprimer_Click(object sender, EventArgs e)
        {

                if (txtrechS.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir le champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                else
                {
                    try
                    {
                        DialogResult rep = MessageBox.Show("Voulez-vous vaiment efe?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (rep == DialogResult.OK)
                        {
                            nm_c_c = txtrechS.Text;
                            int sup = 0;
                            sup = this.compt.Supprimercompte(nm_c_c);
                            if (sup > 0)
                            {
                                MessageBox.Show("Suppression ok");
                                afficherCompte();
                           
                            this.util.Inftransaction(cod, "Supression--" + "--Numero compte-->:" + nm_c_c, datla);
                            DataSet data;
                                data = this.compt.affichercompteparcode(nm_c_c);
                                this.dtcomptes.DataMember = "compte";
                                this.dtcomptes.AutoGenerateColumns = false;
                                this.no_comptes.DataPropertyName = "numerocompte";
                                this.types.DataPropertyName = "type";
                                this.monnaies.DataPropertyName = "monaie";
                                this.etats.DataPropertyName = "etat";
                                this.date_creations.DataPropertyName = "date_insc";
                                this.soldes.DataPropertyName = "solde";
                                this.dtcomptes.DataSource = data;
                                txtrechS.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Pas de suppression");
                            }
                        }

                    }
                    catch (Exception)
                    {
                    MessageBox.Show("Supression non reusite");
                }


                }


            
           
        }
        #endregion
        #region"Rechercher"
        private void bt_Rechercher_Compte_Click(object sender, EventArgs e)
        {
            
                if (txtRechCompte.Text.Trim() == String.Empty)
                    MessageBox.Show("Remplir le champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {

                        nm_c_c = txtRechCompte.Text;
                        bool rech = false;
                        rech = this.compt.RechercherCompte(nm_c_c);
                        if (rech == true)
                        {

                            DataSet data;
                            data = this.compt.affichercompteparcode(nm_c_c);
                            this.datcompter.DataMember = "compte";
                            this.datcompter.AutoGenerateColumns = false;
                            this.no_compter.DataPropertyName = "numerocompte";
                            this.typer.DataPropertyName = "type";
                            this.monnaier.DataPropertyName = "monaie";
                            this.etatr.DataPropertyName = "etat";
                            this.datecrer.DataPropertyName = "date_insc";
                            this.solder.DataPropertyName = "solde";
                            this.datcompter.DataSource = data;


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
        #region"Effcer champs eddit compte"
        public void deleteChampEdditCompte()
        {
            TxtnumerocompteM.Clear();
            comboTypeM.Text = "Choisir";
            comboEtatM.Text = "Choisir";
            txtSoldeM.Clear();
            comboMonnaieM.Text = "Choisir";

        }
        #endregion
        #region"Afficher Compte Methode
        public void afficherCompte()
        {
            try
            {
                DataSet data;
                data = this.compt.affichercompte();
                this.dtcomptea.DataMember = "compte";
                this.dtcomptea.AutoGenerateColumns = false;
                this.nocomptea.DataPropertyName = "numerocompte";
                this.typea.DataPropertyName = "type";
                this.monnaiea.DataPropertyName = "monaie";
                this.etata.DataPropertyName = "etat";
                this.datecrea.DataPropertyName = "date_insc";
                this.soldea.DataPropertyName = "solde";
                this.dtcomptea.DataSource = data;
            }
            catch (Exception)
            {

               
            }
           
        }
        #endregion
        #region"Form Loard
        private void FormCompte_Load(object sender, EventArgs e)
        {
            try
            {
                afficherCompte();
                txtnumerocompte.Text = "0003837" + this.compt.RerchercherNumero_compteAutoGestionCompte();
                txtnumerocompte.Enabled = false;
                TxtnumerocompteM.Enabled = false;
                comboEtat.Text = "Choisir";
                comboType.Text = "Choisir";
                comboMonnaie.Text = "Choisir";

                comboEtatM.Text = "Choisir";
                comboTypeM.Text = "Choisir";
                comboMonnaieM.Text = "Choisir";

            }
            catch (Exception)
            {

               
            }
           
        }
        #endregion
    }
}
