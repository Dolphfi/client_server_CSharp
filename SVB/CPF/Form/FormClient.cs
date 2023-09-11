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
    public partial class FormClient : Form
    {
       
        
        readonly DateTime dat = DateTime.Now;
        public static string cod, nm_c_c, ty, no, sex, adres, tel, dat_de_N, emai, ni_c;

        DateTime datla = DateTime.Now;
        public GestionInterface.IClient cli = null;
     
        public GestionInterface.IUtilisateur util1 = null;

        public FormClient(string co, GestionInterface.IClient cl, GestionInterface.IUtilisateur ut)
        {
            InitializeComponent();
            cod = co;
            cli =cl;
            util1 = ut;
        }
        

        private void FormClient_Load(object sender, EventArgs e)
        {
            try
            {
                AfficherClient();
                cbTypeM.Text = "Choisir";
                cbType.Text = "Choisir";
                cbSexe.Text = "Choisir";
                cbSexeM.Text = "Choisir";

                txtNumero_compteM.Enabled = false;
                txtNumero_compte.Text = "Choisir";


            }
            catch (Exception)
            {

               
            }
           




        }

       





        #region"Recherche Clientr"
        private void btrechercherR_Click(object sender, EventArgs e)
        {
            
                if (txtrechclienR.Text.Trim() == String.Empty)
                    MessageBox.Show("Veuillez remplir le champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {

                        nm_c_c = txtrechclienR.Text;
                        bool rech = false;
                        rech = this.cli.RechercherClient(nm_c_c);
                        if (rech == true)
                        {


                            DataSet data;
                            data = this.cli.afficherclientparcode(nm_c_c);
                            this.dtclientr.DataMember = "client";
                            this.dtclientr.AutoGenerateColumns = false;

                            this.numerocompter.DataPropertyName = "numerocompte";
                            this.typer.DataPropertyName = "type";
                            this.nomr.DataPropertyName = "nom";
                         
                            this.sexer.DataPropertyName = "sexe";
                            this.adresser.DataPropertyName = "adresse";
                            this.telephoner.DataPropertyName = "telephone";
                            this.date_naissancer.DataPropertyName = "date_naissance";
                            this.emailr.DataPropertyName = "email";
                            this.nif_cinr.DataPropertyName = "nif_cin";
                            this.date_inscr.DataPropertyName = "date_insc";
                            this.dtclientr.DataSource = data;
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtrechclienR_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region"Selection de numerocompte"

        private void txtNumero_compte_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumero_compte.Items.Add(this.cli.AfficherNumeroCompteClient());

                txtNumero_compte.Items.Clear();
                DataTable data;
                data = this.cli.AfficherNumeroCompteClient();

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
        #endregion
            #region"Supprimer Client"
        private void btSupprimer_Click(object sender, EventArgs e)
        {
         
                if (txtrechS.Text.Trim() == String.Empty)
                    MessageBox.Show("Veuillez remplir le champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        DialogResult rep = MessageBox.Show("Voulez-vous vaiment supprimer?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (rep == DialogResult.OK)
                        {
                            nm_c_c = txtrechS.Text;
                            int sup = 0;
                            sup = this.cli.Supprimerclient(nm_c_c);
                            if (sup > 0)
                            {

                            this.util1.Inftransaction(cod, "Supression- Client-" + "Numero Compte:" + nm_c_c, datla);

                            MessageBox.Show("Suppression ok");
                                AfficherClient();
                                DataSet data;
                                data = this.cli.afficherclientparcode(nm_c_c);
                                this.dtclients.DataMember = "client";
                                this.dtclients.AutoGenerateColumns = false;

                                this.numerocomptes.DataPropertyName = "numerocompte";
                                this.types.DataPropertyName = "type";
                                this.noms.DataPropertyName = "nom";
                              
                                this.sexes.DataPropertyName = "sexe";
                                this.adresses.DataPropertyName = "adresse";
                                this.telephones.DataPropertyName = "telephone";
                                this.date_naissances.DataPropertyName = "date_naissance";
                                this.emails.DataPropertyName = "email";
                                this.nif_cins.DataPropertyName = "nif_cin";
                                this.date_inscs.DataPropertyName = "date_insc";
                                this.dtclients.DataSource = data;
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
                    MessageBox.Show("Pas de suppression");
                }


                }


            
            
        }
            #endregion
            #region"Rechercher Client"
            private void btrechercherS_Click(object sender, EventArgs e)
        {
           
                if (txtrechS.Text.Trim() == String.Empty)
                    MessageBox.Show("Veuillez remplir le champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {

                        nm_c_c = txtrechS.Text;
                        bool rech = false;
                        rech = this.cli.RechercherClient(nm_c_c);
                        if (rech == true)
                        {


                            DataSet data;
                            data = this.cli.afficherclientparcode(nm_c_c);
                            this.dtclients.DataMember = "client";
                            this.dtclients.AutoGenerateColumns = false;

                            this.numerocomptes.DataPropertyName = "numerocompte";
                            this.types.DataPropertyName = "type";
                            this.noms.DataPropertyName = "nom";
                           
                            this.sexes.DataPropertyName = "sexe";
                            this.adresses.DataPropertyName = "adresse";
                            this.telephones.DataPropertyName = "telephone";
                            this.date_naissances.DataPropertyName = "date_naissance";
                            this.emails.DataPropertyName = "email";
                            this.nif_cins.DataPropertyName = "nif_cin";
                            this.date_inscs.DataPropertyName = "date_insc";
                            this.dtclients.DataSource = data;
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
            #region"Modifier Client"
            private void btModifier_Click(object sender, EventArgs e)
        {
           
                if (txtNumero_compteM.Text.Trim() == String.Empty || cbTypeM.Text.Trim() == String.Empty || txtNomM.Text.Trim() == String.Empty || cbSexeM.Text.Trim() == String.Empty || txtAdresseM.Text.Trim() == String.Empty || masktexTelephoneM.Text.Trim() == String.Empty || txtEmailM.Text.Trim() == String.Empty || txtNif_cinM.Text.Trim() == String.Empty || masDate_de_NaissanceM.Text.Trim() == String.Empty)
                    MessageBox.Show("Veuillez remplir les champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        //DialogResult rep = MessageBox.Show("Vous-voulez vraiment modifier?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        //if (rep == DialogResult.OK)
                        //{

                            nm_c_c = txtNumero_compteM.Text.Trim();
                          
                            emai = txtEmailM.Text.Trim();
                            ni_c = txtNif_cinM.Text.Trim();
                            no = txtNomM.Text.Trim();
                            sex = cbSexeM.Text.Trim();
                            ty = cbTypeM.Text.Trim();
                            dat_de_N = masDate_de_NaissanceM.Text.Trim();
                            tel = masktexTelephoneM.Text.Trim();
                            string dat1 = pickerDateM.ToString();
                            adres = txtAdresseM.Text.Trim();


                            int ver = 0;

                            ver = this.cli.Modifiercli(nm_c_c, ty, no, sex, adres, tel, dat_de_N, emai, ni_c, dat);

                            if (ver > 0)
                            {
                            this.util1.Inftransaction(cod, "Modification- Client-->" + "Numero Compte-->:" + nm_c_c + "-->Type-->" + ty + "Nom complet-->" + no, datla);



                            txtrechM.Focus();
                                DeleteChampsEdditClient();
                                AfficherClient();
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
                    MessageBox.Show("Modification non reusite,Vous devez remplir les champs corectement.");
                }
                }
            
            
        }
            #endregion
            #region"Rechercher pour modifier"
            private void btrechercherM_Click(object sender, EventArgs e)
        {
            
           
                if (txtrechM.Text.Trim() == String.Empty)
                    MessageBox.Show("Veuillez remplir le champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {

                    try
                    {

                        nm_c_c = txtrechM.Text;
                        bool rech = false;
                        rech = this.cli.RechercherClient(nm_c_c);
                        if (rech == true)
                        {

                            txtNumero_compteM.Text = cli.PrendreNumero_compte();
                          
                            txtEmailM.Text = cli.PrendreEmail();
                            txtNif_cinM.Text = cli.PrendreNif_cin();
                            txtNomM.Text = cli.PrendreNom();
                            cbSexeM.Text = cli.PrendreSexe();
                            cbTypeM.Text = cli.PrendreTypec();
                            masDate_de_NaissanceM.Text = cli.PrendreDate_de_Naissance();
                            masktexTelephoneM.Text = cli.PrendreTelephone();
                            pickerDateM.Text = Convert.ToDateTime(cli.PrendreDate()).ToString();
                            txtAdresseM.Text = cli.PrendreAdresse();
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
            #region "Enregistrer Client"
        private void btInsert_Click(object sender, EventArgs e)
        {
           

                if (txtNumero_compte.Text.Trim() == String.Empty || cbType.Text.Trim() == String.Empty || txtNom.Text.Trim() == String.Empty  || cbSexe.Text.Trim() == String.Empty || txtAdresse.Text.Trim() == String.Empty || masktexTelephone.Text.Trim() == String.Empty || txtEmail.Text.Trim() == String.Empty || txtNif_cin.Text.Trim() == String.Empty || masDate_de_Naissance.Text.Trim() == String.Empty)
                    MessageBox.Show("Veuillez remplir les champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        //DialogResult rep = MessageBox.Show("Voulez-vous vaiment Ajouter?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        //if (rep == DialogResult.OK)
                        //{
                            nm_c_c = txtNumero_compte.Text;
                            ty = cbType.Text.Trim().ToString();
                            no = txtNom.Text.Trim();
                            sex = cbSexe.Text.Trim().ToString();
                            adres = txtAdresse.Text.Trim();
                            tel = masktexTelephone.Text.Trim().ToString();
                            ni_c = txtNif_cin.Text.Trim();
                            emai = txtEmail.Text;
                            dat_de_N = masDate_de_Naissance.Text.Trim();




                            int ver = 0;

                            ver = this.cli.InsererClient(nm_c_c, ty, no, sex, adres, tel, dat_de_N, emai, ni_c, dat);

                            if (ver > 0)
                            {

                            this.util1.Inftransaction(cod, "Insertion- Client-->" + "Numero Compte-->:" +nm_c_c+"-->Type-->"+ty+"Nom complet-->"+no, datla);
                          
                         
                                AfficherClient();
                            
                                DeleteChampsInsertClient();
                                MessageBox.Show("Insertion reusite");
                            }

                            else
                            {
                                MessageBox.Show("Insertion non reusite");
                            }
                        //}
                    }
                    catch (Exception ex)
                    {
                    MessageBox.Show("Insertion non reusite,Vous devez remplir les champs corectement.");
                }

                }



            
            
        }
        #endregion
            #region "Efface champs insertion Client"
        public void DeleteChampsInsertClient()
        {

            txtNumero_compte.Text = "Choisir";
            cbType.Text = "Choisir";
            txtNom.Clear();
         
            cbSexe.Text = "Choisir";
            txtAdresse.Clear();
            masktexTelephone.Clear();
            txtNif_cin.Clear();
            txtEmail.Clear();
            masDate_de_Naissance.Clear();

        }
        #endregion
            #region"Effacer Champs Modifier Client"
        public void DeleteChampsEdditClient()
        {
            txtNumero_compteM.Clear();
           
            txtEmailM.Clear();
            txtNif_cinM.Clear();
            txtNomM.Clear();
            cbSexeM.Text = "Choisir";
            cbTypeM.Text = "Choisir";
            masDate_de_NaissanceM.Clear();
            masktexTelephoneM.Clear();

            txtAdresseM.Clear();


        }
        #endregion
            #region"Afficher Client"
        public void AfficherClient()
        {
            try
            {
                DataSet data;
                data = this.cli.afficherclient();
                this.dtclienta.DataMember = "client";
                this.dtclienta.AutoGenerateColumns = false;

                this.numerocomptea.DataPropertyName = "numerocompte";
                this.typea.DataPropertyName = "type";
                this.noma.DataPropertyName = "nom";

                this.sexea.DataPropertyName = "sexe";
                this.adressea.DataPropertyName = "adresse";
                this.telephonea.DataPropertyName = "telephone";
                this.date_naissancea.DataPropertyName = "date_naissance";
                this.emaila.DataPropertyName = "email";
                this.nif_cina.DataPropertyName = "nif_cin";
                this.date_insca.DataPropertyName = "date_insc";
                this.dtclienta.DataSource = data;
            }
            catch (Exception)
            {

               
            }

           
        }
        #endregion
       
    }
    }
