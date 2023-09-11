using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInterface;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

namespace SVB
{
    public partial class FormEmploye : Form
    {
       
   
        public static string code, no, num,ty, pre, sex, tel, rol, ema, ni, adr, datn,pho;

        double sal;
        readonly DateTime dat = DateTime.Now;

        public string cod, hre;
        DateTime datla = DateTime.Now;

       

        public GestionInterface.IEmploye util = null;
        public GestionInterface.IUtilisateur util1 = null;

        private void txtNumero_compte_Click(object sender, EventArgs e)
        {

            try
            {
                txtNumero_compte.Items.Add(this.util.AfficherNumeroCompteEmploye());

                txtNumero_compte.Items.Clear();
                DataTable data;
                data = this.util.AfficherNumeroCompteEmploye();

                foreach (DataRow dr in data.Rows)
                {
                    txtNumero_compte.Items.Add(dr["numerocompte"].ToString());
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Le server n'est pas en marche");
            }




        }





        public FormEmploye(string co, GestionInterface.IEmploye emp, GestionInterface.IUtilisateur ut)
        {
            InitializeComponent();
         cod = co;
            util = emp;
            util1 = ut; 
        }

        #region"Rechercher Pour supprimer"
        private void btrechercherS_Click(object sender, EventArgs e)
        {

            if (txtrechS.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir le champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {

                    code = txtrechS.Text;
                    bool rech = false;
                    rech = this.util.RechercherEmploye(code);
                    if (rech == true)
                    {


                        DataSet data;
                        data = this.util.afficheremployeparcode(code);
                        this.dtemployes.DataMember = "employe";
                        this.dtemployes.AutoGenerateColumns = false;
                        this.Ids.DataPropertyName = "id";
                        this.names.DataPropertyName = "name";
                        this.last_names.DataPropertyName = "last_name";
                        this.sexes.DataPropertyName = "sexe";
                        this.telephones.DataPropertyName = "phone";
                        this.SalaireEmps.DataPropertyName = "salaire";
                        this.role_Empls.DataPropertyName = "role";
                        this.emails.DataPropertyName = "email";
                        this.nifs.DataPropertyName = "nif";
                        this.adresses.DataPropertyName = "adresse";
                        this.date_naissances.DataPropertyName = "role";
                        this.nocomptes.DataPropertyName = "NumeroCompte";
                        this.dates.DataPropertyName = "dateEmp";
                        this.dtemployes.DataSource = data;

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
                    DialogResult rep = MessageBox.Show("Voulez-vous vaiment supprimer?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (rep == DialogResult.OK)
                    {
                        code = txtrechS.Text;
                        int sup = 0;
                        sup = this.util.Supprimeremployer(code);
                        if (sup > 0)
                        {
                            MessageBox.Show("Suppression ok");
                            afficherAmploye();

                            DataSet data;
                            data = this.util.afficheremployeparcode(code);
                            this.dtemployes.DataMember = "employe";
                            this.dtemployes.AutoGenerateColumns = false;
                            this.Ids.DataPropertyName = "id";
                            this.names.DataPropertyName = "name";
                            this.last_names.DataPropertyName = "last_name";
                            this.sexes.DataPropertyName = "sexe";
                            this.telephones.DataPropertyName = "phone";
                            this.SalaireEmps.DataPropertyName = "salaire";
                            this.role_Empls.DataPropertyName = "role";
                            this.dates.DataPropertyName = "dateEmp";
                            this.emails.DataPropertyName = "email";
                            this.nifs.DataPropertyName = "nif";
                            this.adresses.DataPropertyName = "adresse";
                            this.date_naissances.DataPropertyName = "role";
                            this.nocomptes.DataPropertyName = "NumeroCompte";
                            this.dtemployes.DataSource = data;
                            txtrechS.Clear();
                            this.util1.Inftransaction(cod, "Supression-->Employe" + "-->Code:" + code, datla);
                        }
                        else
                        {
                            MessageBox.Show("Pas de suppression");
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Suppression non reusite");
                }


            }

        }
        #endregion

        #region"Recchercher"
       
  
        private void btrechercherR_Click(object sender, EventArgs e)
        {


            if (txtrechEmployeR.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir le champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {

                    code = txtrechEmployeR.Text;
                    bool rech = false;
                    rech = this.util.RechercherEmploye(code);

                    if (rech == true)
                    {

                        DataSet data;
                        data = this.util.afficheremployeparcode(code);

                        this.dtemploye.DataMember = "employe";
                        this.dtemploye.AutoGenerateColumns = false;
                        this.cde.DataPropertyName = "id";
                        this.nm.DataPropertyName = "name";
                        this.PR.DataPropertyName = "last_name";
                        this.SX.DataPropertyName = "sexe";
                        this.telephones.DataPropertyName = "phone";
                        this.SalaireEmplr.DataPropertyName = "salaire";
                        this.RoleEmplr.DataPropertyName = "role";
                        this.DT.DataPropertyName = "dateEmp";
                        this.emailr.DataPropertyName = "email";
                        this.nifr.DataPropertyName = "nif";
                        this.adresser.DataPropertyName = "adresse";
                        this.dateNaissancer.DataPropertyName = "role";
                        this.nocompter.DataPropertyName = "NumeroCompte";
                        this.dtemploye.DataSource = data;
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

        private void FormEmploye_Load(object sender, EventArgs e)
        {
            try
            {
              
                afficherAmploye();
                txtCode.Enabled = false;
                txtCode.Text = "EMPL-0" + Convert.ToInt32(this.util.RerchercherCode_Auto_Gestion_Employe()).ToString();
                txtCodeM.Enabled = false;
                txtNumero_compte.Text = "Choisir";
                txtRoleEmploye.Text = "Choisir";
               comboRoleEmployeM.Text = "Choisir";
                comboSexe.Text = "Choisir";
                txtNumerCompteM.Enabled = false;
                txtCodeM.Enabled = false;      


            }
            catch (Exception)
            {

                MessageBox.Show("Le server n'est pas en marche");
            }



            
        }
        #endregion

        #region"Rechercher pour modifier
        private void btrechercherM_Click(object sender, EventArgs e)
            {
                if (txtrechM.Text.Trim() == String.Empty)
                    MessageBox.Show("Vous devez remplir les champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {

                        code = txtrechM.Text;
                        bool rech = false;
                        rech = this.util.RechercherEmploye(code);
                        if (rech == true)
                        {
                            txtCodeM.Text = util.PrendreCode();
                            txtNameM.Text = util.Prendrenom();
                            txtLastNameM.Text = util.PrendrePrenom();
                            comboSexeM.Text = util.Prendresexe();
                            maskPhoneM.Text = util.PrendreTELEPHONE();
                            txtSalaireM.Text = Convert.ToDouble(util.PrendreSalaire()).ToString();
                            comboRoleEmployeM.Text = util.PrendreRole();
       
                             pickerDateM.Text = Convert.ToDateTime(util.PrendreDate()).ToString();
                             txtEmailM.Text = util.PrendreEmail(); 
                             txtAdresseM.Text= util.PrendreAdresse();
                             masNifM.Text = util.PrendreNif();
                             masDateNaissanceM.Text = util.PrendreDatenaissance();
                        txtNumerCompteM.Text = util.PrendreNumerocompte();
                       

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
            if (txtCodeM.Text.Trim() == String.Empty || txtNameM.Text.Trim() == String.Empty || comboSexeM.Text.Trim() == String.Empty || maskPhoneM.Text.Trim() == String.Empty || txtEmailM.Text.Trim() == String.Empty || masNifM.Text.Trim() == String.Empty || txtAdresseM.Text.Trim() == String.Empty || masDateNaissanceM.Text.Trim() == String.Empty)
                MessageBox.Show("Vous devez remplir les champs.", "Champs Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    //DialogResult rep = MessageBox.Show("Voulez-vous vaiment efe?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    //if (rep == DialogResult.OK)
                    //{
                        code = txtCodeM.Text;
                     
                        no = txtNameM.Text.Trim();
                        pre = txtLastNameM.Text.Trim();
                        sex = comboSexeM.Text.ToString();
                        tel = maskPhoneM.Text.Trim();
                        sal = Convert.ToDouble(txtSalaireM.Text.Trim());
                        rol = comboRoleEmployeM.Text.Trim().ToString();
                           
                        ema= txtEmailM.Text.Trim();
                        ni = masNifM.Text.Trim();
                        adr = txtAdresseM.Text.Trim();
                        datn = masDateNaissanceM.Text.Trim();
                        num= txtNumerCompteM.Text.Trim();
                       


                        string dat1 = pickerDateM.Text.ToString();
                        int ver = 0;

                        ver = this.util.Modifieremp(code, no, pre, sex, tel, sal, rol, dat,ema,ni,adr,datn,num);

                        if (ver > 0)
                        {
                            this.util1.Inftransaction(cod, "Modification-- Employe-->" + "Code-->:" + code + "-->Nom-->:" + no, datla);
                            DeleteFieldM();
                            afficherAmploye();
                            MessageBox.Show("modification reusite");
                            txtrechM.Clear();
                       
                        }

                        else
                        {
                            MessageBox.Show("modification non reusite");
                        }
                    //}
                }

                catch (Exception)
                {
                    MessageBox.Show("modification non reusite,remplir les valeur corectement");
                }

            }

        }
        #endregion

        #region"insertion"
        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == String.Empty || txtName.Text.Trim() == String.Empty || comboSexe.Text.Trim() == String.Empty || maskPhone.Text.Trim() == String.Empty || txtEmail.Text.Trim() == String.Empty || txtNif.Text.Trim() == String.Empty || txtAdresse.Text.Trim() == String.Empty || masDateNaissance.Text.Trim() == String.Empty ) 
                    MessageBox.Show("Renplir toutes les champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                try
                {

                   // DialogResult rep = MessageBox.Show("Voulez-vous vaiment efe?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    //if (rep == DialogResult.OK)
                    //{
                        code = txtCode.Text;
                        no = txtName.Text.Trim();
                        pre = txtLastName.Text.Trim();
                        sex = comboSexe.Text.ToString();
                        tel = maskPhone.Text.Trim();
                        sal = Convert.ToDouble(txtSalaire.Text);
                        rol = txtRoleEmploye.Text.Trim();
                        ema = txtEmail.Text.Trim();
                        ni = txtNif.Text.Trim();
                        adr = txtAdresse.Text.Trim();
                        datn = masDateNaissance.Text.ToString();
                        num = txtNumero_compte.Text.Trim().ToString();


                        int ver = 0;

                        if (sal < 0)
                        {
                            MessageBox.Show("Vous devez entrer une valeur positive");
                        }

                        else {
                            ver = this.util.InsererEmploye(code, no, pre, sex, tel, sal, rol, dat, ema, ni, adr, datn, num);
                        }

                        if (ver > 0)
                        {
                            this.util1.Inftransaction(cod, "Insertion-- Employe-->" + "Code-->:" + code + "-->Nom-->:" + no, datla);
                            DeleteField();
                            afficherAmploye();
                            this.util.ModifierCode_Auto_Gestion_Employe();
                            txtCode.Text = "EMPL-00" + Convert.ToInt16(this.util.RerchercherCode_Auto_Gestion_Employe()).ToString();
                            MessageBox.Show("Insertion reusite");

                        //}


                       
                    }

                }
                catch (Exception)

                {
                    MessageBox.Show("Insertion non reusite,remplir les valeur corectement");
                }
            }

        }
        #endregion

        #region"Afficher employe"
        public void afficherAmploye()
        {
            try
            {
                DataSet data = this.util.afficheremploye();
                this.dataGridViewA.DataMember = "employe";
                this.dataGridViewA.AutoGenerateColumns = false;
                this.codea.DataPropertyName = "id";
                this.noma.DataPropertyName = "name";
                this.prenoma.DataPropertyName = "last_name";
                this.sexa.DataPropertyName = "sexe";
                this.telepha.DataPropertyName = "phone";
                this.SalaireEmpla.DataPropertyName = "salaire";
                this.RoleEmpla.DataPropertyName = "role";
                this.datea.DataPropertyName = "dateEmp";

                this.emaila.DataPropertyName = "email";
                this.nifa.DataPropertyName = "nif";
                this.adressea.DataPropertyName = "adresse";
                this.dateNaissancea.DataPropertyName = "datenaissance";
                this.nocomptea.DataPropertyName = "NumeroCompte";
                this.dataGridViewA.DataSource = data;
            }
            catch (Exception)
            {

            }
           
        }
        #endregion

        #region "Delete Champs apres insertion
        public void DeleteField()
        {
            txtCode.Clear();
            txtName.Clear();
            txtLastName.Clear();
            comboSexe.Text = "Choisir le sexe";
            maskPhone.Clear();
            txtRoleEmploye.Text = "Choisir le sexe";
            txtSalaire.Clear();
            txtEmail.Clear();
            txtNif.Clear();
            txtAdresse.Clear();
            masDateNaissance.Clear();
           txtNumero_compte.Text = "Choisir";
        
        }
        #endregion

        #region"Delete Champs apres Modification
        public void DeleteFieldM()
        {
            txtCodeM.Clear();
            txtNameM.Clear();
            txtLastNameM.Clear();
            comboSexeM.Text = "Choisir";
            maskPhoneM.Clear();
            comboRoleEmployeM.Text = "Choisir";
            txtSalaireM.Clear();
            txtEmailM.Clear();
            txtAdresseM.Clear();
            masNifM.Clear();
            masDateNaissanceM.Clear();
            txtNumerCompteM.Text = "Choisir";
           

        }
        #endregion

       
    }
}









