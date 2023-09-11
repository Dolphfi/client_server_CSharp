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
    public partial class FormPayroll : Form
    {
    

        public static string num_copt, cod, hre, code, codeEp, nom, id_p, desc, no, pre, co;
        public static double sol, sal, saln, ta;

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        //public static double txa = 100;
        private void btRecherPayroll_Click(object sender, EventArgs e)
        {

            if (txtRecherPayroll.Text.Trim() == String.Empty)
                MessageBox.Show("Veuillez remplir tous les champs.", "Requireld field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {

                    code = txtRecherPayroll.Text;
                    bool rech = false;
                    rech = this.pay.RechercherPayrollV(code);

                    if (rech == true)
                    {

                        DataSet data;
                        data = this.pay.AfficherayrollPcode(code);

                        this.dtpayrollP.DataMember = "payroll";
                        this.dtpayrollP.AutoGenerateColumns = false;
                        this.id_payp.DataPropertyName = "id_pay";
                        this.num_coptp.DataPropertyName = "num_copt";
                        this.nop.DataPropertyName = "no";
                        this.prep.DataPropertyName = "pre";
                        this.salp.DataPropertyName = "sal";
                        this.descpp.DataPropertyName = "descp";
                        this.salnp.DataPropertyName = "saln";
                        this.tap.DataPropertyName = "ta";
                        this.datp.DataPropertyName = "dat";
                        this.cop.DataPropertyName = "co";
                        this.dtpayrollP.DataSource = data;
                    }
                    else
                    {
                        MessageBox.Show("Code incorrect");
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Le server n'est pas en marche");
                }
            }
        }

        private void txttax_TextChanged(object sender, EventArgs e)
        {
            try
            {

                sal = Convert.ToDouble(txtSalaire.Text);
                ta = Convert.ToDouble(txttax.Text);
                saln = sal - ta;

                //saln = (sal*ta)/100;

                if (saln > 0)
                {
                    txtSalaireNet.Text = Convert.ToString(saln);
                }
                if (ta > sal)
                {
                    MessageBox.Show("Imposible");
                }
                

            }
            catch (Exception ex)
            {

               
            }

        }


        

        readonly DateTime dat = DateTime.Now;

        public FormPayroll(string co, GestionInterface.IUtilisateur ut, GestionInterface.IPayroll py, GestionInterface.IEmploye em, GestionInterface.ICompte cp)
        {
            InitializeComponent();
            cod = co;
            util = ut;
            pay = py;
            empl = em;
            compt = cp;

        }

        DateTime datla = DateTime.Now;
        public GestionInterface.ICompte compt = null;
        public GestionInterface.IEmploye empl = null;
        public GestionInterface.IUtilisateur util = null;
        public GestionInterface.IPayroll pay = null;
        private void FormPayroll_Load(object sender, EventArgs e)
        {
            try
            {
                Txtnumerocompte.Enabled = false;

                id_payroll.Enabled = false;
                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
                txtCodeE.Enabled = false;
                txtSalaire.Enabled = false;
                txtSalaireNet.Enabled = false;
               

                id_payroll.Text = "3837" + this.pay.RerchercherCodeAutoTransactionPayroll();
            }
            catch (Exception ex)
            {

              MessageBox.Show("Erreur" + ex.Message);  
            }
           
        }




        #region"Inserer"

        private void btValider_Click(object sender, EventArgs e)
        {

            if (Txtnumerocompte.Text.Trim() == String.Empty || txtdescription.Text.Trim() == String.Empty || txtSalaireNet.Text.Trim() == String.Empty ||txttax.Text.Trim() == String.Empty || Txtnumerocompte.Text == String.Empty)
                MessageBox.Show("Vous devez remplir les tous les champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    //DialogResult rep = MessageBox.Show("Voulez-vous vaiment efe?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    //if (rep == DialogResult.OK)
                    //{
                        id_p = id_payroll.Text.ToString();
                        num_copt = Txtnumerocompte.Text.ToString();
                        desc = txtdescription.Text.ToString();
                        no = txtNom.Text.ToString();
                        pre = txtPrenom.Text.ToString();
                        co= txtCodeE.Text.ToString();
                        ta = Convert.ToDouble(txttax.Text.ToString());
                        saln = Convert.ToDouble(txtSalaireNet.Text.ToString());
                        sal = Convert.ToDouble(txtSalaire.Text.ToString());

                        
                      

                        int ver = 0;
                      
                            ver = this.pay.InsererPayroll(id_p, num_copt,no,pre, sal,desc,saln,dat, ta, co);
                        


                        if (ver > 0)
                        {
                            this.util.Inftransaction(cod, "Insertion-->Payroll-->" + "Salaire-->:" + sal+"--Salaire Net"+sal+"-->Taxe-->"+ta, datla);
                            Txtnumerocompte.Clear();
                           
                            txtdescription.Clear();
                            txtNom.Clear();
                            txtPrenom.Clear();
                            txtCodeE.Clear();
                            txttax.Clear();
                            txtSalaireNet.Clear();
                            txtSalaire.Clear();

                            this.pay.ModifierCodeAutoTransactionPayroll();
                           id_payroll.Text = "3837" + Convert.ToInt32(this.pay.RerchercherCodeAutoTransactionPayroll()).ToString();
                          
                        }

                        else
                        {
                            MessageBox.Show("Payroll non reusite");
                        }
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DAL" + ex.Message);

                }
            }
        }
        #endregion


        #region"Rechercher "

        private void btrechercher_Click(object sender, EventArgs e)
        {

            if (txtrech.Text.Trim() == String.Empty)
                MessageBox.Show("Pease fill out field.", "Requireld field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {

                  string  num= txtrech.Text;
                    bool rech = false;
                    rech = this.empl.RechercherEmployePay(num);
                    if (rech == true)
                    {
                        txtCodeE.Text = empl.PrendreCode();
                        txtNom.Text = empl.Prendrenom();
                        txtPrenom.Text = empl.PrendrePrenom();
                        Txtnumerocompte.Text = empl.PrendreNumerocompte();
                       txtSalaire.Text = Convert.ToDouble(empl.PrendreSalaire()).ToString();

                    }
                    else
                    {
                        MessageBox.Show("Code incorrect");
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Le server n'est pas en marche");
                }

            }


        }
        #endregion


    }

}

