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
    public partial class FormUtilisateur : Form
    {
     
        public static string code, cod, cemp, fonct, user, pass, moda;
        public static int eta;
        readonly DateTime dat = DateTime.Now;

     
        DateTime datla = DateTime.Now;

        
        public GestionInterface.IUtilisateur util = null;
      

        public FormUtilisateur(string co,GestionInterface.IUtilisateur ut)
        {
            InitializeComponent();
            cod = co;
            util = ut;
            
          
          }
       
        #region"Form Load"
        private void FormUtilisateur_Load(object sender, EventArgs e)
        {
            try
            {
                txtCodeU.Text = "USER-" + this.util.RerchercherCodeAutoGestionUtilisateur();
                txtCodeEd.Text = "Choisir";
                afficherUtilisateur();
                txtCodeUM.Enabled = false;
                txtCodeEM.Enabled = false;
                txtCodeU.Enabled = false;
                comboEtat.Text = "Choisir";
                comboEtatM.Text = "Choisir";
                combofonction.Text = "Choisir";
                combofonctionM.Text = "Choisir";
                combomoduleaccesM.Text = "Choisir";
                combomoduleacces.Text = "Choisir";

            }
            catch (Exception)
            {

                MessageBox.Show("Le server n'est pas en marche");
            }
           


        }
        #endregion
        #region"Modifier"
        private void btModifierU_Click(object sender, EventArgs e)
        {


            try
            {
               // DialogResult rep = MessageBox.Show("Voulez-vous vaiment Modifier?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //if (rep == DialogResult.OK)
                //{
                    code = txtCodeUM.Text;
                    cemp = txtCodeEM.Text;
                    user = txtUsernameM.Text;
                    fonct = combofonctionM.Text;
                    pass = txtPasswordM.Text;
                    moda = combomoduleaccesM.Text;
                    eta = Convert.ToInt32(comboEtatM.Text.Trim());
                    string dat1 = pickerDateM.Text.ToString();
                    int ver = 0;

                    ver = this.util.Modifieruser(code, cemp, fonct, user, pass, moda, dat,eta);

                    if (ver > 0)
                    {

                        MessageBox.Show("modification reusite");
                        DeleteFieldM();
                        txtrechU_M.Clear();
                        afficherUtilisateur();
                        this.util.Inftransaction(cod, "Modification-Utilisateur-->" + "Code-->:" + code + "Foction-->" + fonct, datla);
                    }

                    else
                    {
                        MessageBox.Show("modification non reusite");
                    }
                //}
            }

            catch (Exception)
            {
                MessageBox.Show("Le server n'est pas en marche");
            }
        }
        #endregion
        #region"Rechercher pour Supprimer"
        private void btrechercherS_Click(object sender, EventArgs e)
        {

            if (txtrechS.Text.Trim() == String.Empty)
                MessageBox.Show("Veuillez remplir le champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {

                    code = txtrechS.Text;
                    bool rech = false;
                    rech = this.util.Rechercherutilisateur(code);
                    if (rech == true)
                    {
                        DataSet data;
                        data = this.util.afficherutilisateurparcode(code);
                        this.dtutilisateurs.DataMember = "utilisateur";
                        this.dtutilisateurs.AutoGenerateColumns = false;
                        this.code_users.DataPropertyName = "code_utilisateur";
                        this.code_employes.DataPropertyName = "code_empl";
                        this.fonctions.DataPropertyName = "fonction";
                        this.usernames.DataPropertyName = "user";
                        this.passwords.DataPropertyName = "password";
                        this.module_acces.DataPropertyName = "module_acces";
                        this.date_insc.DataPropertyName = "Date_insc";
                        this.etats.DataPropertyName = "etat";
                        this.dtutilisateurs.DataSource = data;


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
        #region"Supprimer "
        private void btSupprimer_User_Click(object sender, EventArgs e)
        {
            if (txtrechS.Text.Trim() == String.Empty)
                MessageBox.Show("Veuillez remplir le champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    //DialogResult rep = MessageBox.Show("Voulez-vous vaiment supprimer?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    //if (rep == DialogResult.OK)
                   // {
                        code = txtrechS.Text;
                        int sup = 0;
                        sup = this.util.SupprimerUtilisateur(code);
                        if (sup > 0)
                        {
                            MessageBox.Show(" suppression Ok");
                            afficherUtilisateur();
                            DataSet data;
                            data = this.util.afficherutilisateurparcode(code);
                            this.dtutilisateurs.DataMember = "utilisateur";
                            this.dtutilisateurs.AutoGenerateColumns = false;
                            this.code_users.DataPropertyName = "code_utilisateur";
                            this.code_employes.DataPropertyName = "code_empl";
                            this.fonctions.DataPropertyName = "fonction";
                            this.usernames.DataPropertyName = "user";
                            this.passwords.DataPropertyName = "password";
                            this.module_acces.DataPropertyName = "module_acces";
                            this.date_insc.DataPropertyName = "Date_insc";
                            this.dtutilisateurs.DataSource = data;
                            txtrechS.Clear();

                            this.util.Inftransaction(cod, "Supression-Utilisateur-->" + "Code :" + code, datla);


                        }
                        else
                        {
                            MessageBox.Show("Pas de suppression");
                        }
                    //}

                }
                catch (Exception )
                {
                    MessageBox.Show("Le server n'est pas en marche");
                }


            }

        }
        #endregion
        #region"Rechercher Par Code"
        private void btrechercher_Par_code_Click(object sender, EventArgs e)
        {

            if (txttrecherchuser.Text.Trim() == String.Empty)
                MessageBox.Show("Veuillez remplir le champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {

                    code = txttrecherchuser.Text;
                    bool rech = false;
                    rech = this.util.Rechercherutilisateur(code);
                    if (rech == true)
                    {

                        DataSet data;
                        data = this.util.afficherutilisateurparcode(code);
                        this.dtutilisateurr.DataMember = "utilisateur";
                        this.dtutilisateurr.AutoGenerateColumns = false;
                        this.code_userr.DataPropertyName = "code_utilisateur";
                        this.usernamer.DataPropertyName = "user";
                        this.code_employer.DataPropertyName = "code_empl";
                        this.fonctionr.DataPropertyName = "fonction";
                        this.passwordr.DataPropertyName = "password";
                        this.module_accesr.DataPropertyName = "module_acces";
                        this.date_inscr.DataPropertyName = "Date_insc";
                        this.etatr.DataPropertyName = "etat";
                        this.dtutilisateurr.DataSource = data;

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
        #region"Code employe aussin de L'utilisateur"
        private void txtCodeEd_Click(object sender, EventArgs e)
        {
            txtCodeEd.Items.Add(this.util.AfficherCodeEmployerUtilisateur());

            txtCodeEd.Items.Clear();
            DataTable data;
            data = this.util.AfficherCodeEmployerUtilisateur();

            foreach (DataRow dr in data.Rows)
            {
                txtCodeEd.Items.Add(dr["id"].ToString());
            }
        }

        #endregion

        #region"Rechercher Pour modifer"
        private void btrechercherU_M_Click(object sender, EventArgs e)
        {

            if (txtrechU_M.Text.Trim() == String.Empty)
                MessageBox.Show("Veuillez remplir le champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    code = txtrechU_M.Text;
                    bool rech = false;
                    rech = this.util.Rechercherutilisateur(code);
                    if (rech == true)
                    {

                        txtCodeUM.Text = util.PrendreCode();
                        txtCodeEM.Text = util.PrendreCode_employe();
                        txtUsernameM.Text = util.PrendreUsername();
                        combofonctionM.Text = util.PrendreFonction();
                        txtPasswordM.Text = util.PrendrePasword();
                        combomoduleaccesM.Text = util.PrendreModule_acces();
                        pickerDateM.Text = Convert.ToDateTime(util.PrendreDate()).ToString();
                        comboEtatM.Text = Convert.ToInt32(util.PrendreEtat()).ToString();


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
        #region"Insertion Utilisateur"

        private void btInsertUtilisateur_Click(object sender, EventArgs e)
        {
            try
            {
                //DialogResult rep = MessageBox.Show("Voulez-vous vaiment Ajouter?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //if (rep == DialogResult.OK)
                //{
                    code = txtCodeU.Text.ToString();
                    cemp = txtCodeEd.Text.ToString();
                    user = txtUsername.Text.Trim();
                    fonct = combofonction.Text.Trim();
                    pass = txtPassword.Text.Trim();
                    moda = combomoduleacces.Text.Trim();
                    eta = Convert.ToInt32(comboEtat.Text.Trim());
                    

                    int ver = 0;


                    ver = this.util.InsererUtilisateur(code, cemp, fonct, user, pass, moda, dat,eta);

                    if (ver > 0)
                    {
                        this.util.Inftransaction(cod, "Insertion-Utilisateur-->" + "Code-->:" + code+"Foction-->"+fonct, datla);
                        


                        DeleteField();
                        afficherUtilisateur();
                        this.util.ModifierCodeGestionUtilisateur();
                        txtCodeU.Text = "USER-" + Convert.ToInt32(this.util.RerchercherCodeAutoGestionUtilisateur()).ToString();
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
                MessageBox.Show("Le server n'est pas en marche");
            }

        }

        #endregion
        #region "Effacer les champs apres la validation"
        public void DeleteField()
        {

            txtCodeU.Clear();
            txtCodeEd.Text = "Choisir";
            txtUsername.Clear();
            combofonction.Text = "Choisir";
            txtPassword.Clear();
            comboEtat.Text = "Choisir";
            combomoduleacces.Text = "Choisir";
        }

        public void DeleteFieldM()
        {
            txtCodeUM.Clear();
            txtCodeEM.Clear();
            txtUsernameM.Clear();
            combofonctionM.Text = "Choisir le sexe";
            txtPasswordM.Clear();
            txtUsernameM.Clear();
            combomoduleaccesM.Text = "Choisir";
            comboEtatM.Text = "Choisir";
        }

        #endregion
        #region"Afficher Utilisateur"
        public void afficherUtilisateur()
        {
            try
            {
                DataSet data;
                data = this.util.afficherUtilisateur();
                this.dtutilisateura.DataMember = "utilisateur";
                this.dtutilisateura.AutoGenerateColumns = false;
                this.code_usera.DataPropertyName = "code_utilisateur";
                this.usernamea.DataPropertyName = "user";
                this.code_employea.DataPropertyName = "code_empl";
                this.fonctiona.DataPropertyName = "fonction";
                this.passworda.DataPropertyName = "password";
                this.module_accesa.DataPropertyName = "module_acces";
                this.date_insca.DataPropertyName = "Date_insc";
                this.etata.DataPropertyName = "etat";
                this.dtutilisateura.DataSource = data;

            }
            catch (Exception)
            {

                MessageBox.Show("Le server n'est pas en marche");
            }

           
        }
        #endregion
    }
}
