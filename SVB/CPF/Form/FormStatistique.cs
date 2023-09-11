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
    public partial class FormStatistique : Form
    {
       
        public GestionInterface.IStatistique sta = null;
        public FormStatistique( GestionInterface.IStatistique st)
        {
            InitializeComponent();
          
           sta = st;
            
        }

       

        #region"Affichage Client"
        public void AfficherClient()
        {
            try
            {
                DataSet data;
                data = this.sta.afficherclient();
                this.dtclienta.DataMember = "client";
                this.dtclienta.AutoGenerateColumns = false;
                this.numerocomptea.DataPropertyName = "numerocompte";
                this.typecl.DataPropertyName = "type";
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

        #region"Affichage Compte"
        public void afficherCompte()
        {
            try
            {
                DataSet data;
                data = this.sta.affichercompte();
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

        #region"Afichage Utilisateur"
        public void afficherUtilisateur()
        {
            try
            {

                DataSet data;
                data = this.sta.afficherUtilisateur();
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

             
            }

        }

        #endregion


        #region"Affichage Employer"
        public void afficherAmploye()
        {
            try
            {
                DataSet data;
                data = this.sta.afficheremploye();
                this.dataGridViewA.DataMember = "employe";
                this.dataGridViewA.AutoGenerateColumns = false;
                this.codea.DataPropertyName = "id";
                this.nome.DataPropertyName = "name";
                this.prenome.DataPropertyName = "last_name";
                this.sexa.DataPropertyName = "sexe";
                this.telepha.DataPropertyName = "phone";
                this.SalaireEmpla.DataPropertyName = "salaire";
                this.RoleEmpla.DataPropertyName = "role";
                this.datea.DataPropertyName = "dateEmp";

                this.emaile.DataPropertyName = "email";
                this.nifa.DataPropertyName = "nif";
                this.adressee.DataPropertyName = "adresse";
                this.dateNaissancea.DataPropertyName = "datenaissance";
                this.dataGridViewA.DataSource = data;


            }
            catch (Exception)
            {

               
            }
           
        
        }
        #endregion

        #region"Affichage Depot "
        public void afficherDepotS()
        {
            try
            {
                DataSet data;
                data = this.sta.afficherDepot();

                this.dtdepotS.DataMember = "depot";
                this.dtdepotS.AutoGenerateColumns = false;
                this.Idtransactiondep.DataPropertyName = "idtransaction";
                this.numerocomptedep.DataPropertyName = "numerocompte";
                this.montantdep.DataPropertyName = "montant";
                this.descriptiondep.DataPropertyName = "description";
                this.datedep.DataPropertyName = "date";

                this.dtdepotS.DataSource = data;
            }
            catch (Exception)
            {

               
            }
        
        }
        #endregion


        #region"Affichage Retrait"
        public void afficherRetraitS()
        {
            try
            {
                DataSet data;
                data = this.sta.afficherRetrait();

                this.dtretraitS.DataMember = "retrait";
                this.dtretraitS.AutoGenerateColumns = false;
                this.Idtransactionret.DataPropertyName = "idtransaction";
                this.numerocompteret.DataPropertyName = "numerocompte";
                this.montantret.DataPropertyName = "montant";
                this.descriptionret.DataPropertyName = "description";
                this.dateret.DataPropertyName = "date";
                this.dtretraitS.DataSource = data;
            }
            catch (Exception)
            {

                
            }
           
        }
        #endregion


        #region"Transfert
        public void afficherTransfertS()
        {
            try
            {

                DataSet data;
                data = this.sta.afficherTransfert();

                this.dttransfertS.DataMember = "transfert";
                this.dttransfertS.AutoGenerateColumns = false;
                this.idtransactiontra.DataPropertyName = "idtransaction";
                this.de_comptetra.DataPropertyName = "de_compte";
                this.a_comptetra.DataPropertyName = "a_compte";
                this.montanttra.DataPropertyName = "montant";
                this.descriptiontra.DataPropertyName = "description";
                this.datetra.DataPropertyName = "date";
                this.dttransfertS.DataSource = data;
            }
            catch (Exception)
            {

               
            }



        }

        #endregion

        #region"Trancabilite
        public void afficherTracabilite()
        {
            try
            {
                DataSet data;
                data = this.sta.afficherTracabilite();

                this.dataTracabilite.DataMember = "tracabilite";
                this.dataTracabilite.AutoGenerateColumns = false;
                this.Code_user_tra.DataPropertyName = "code_utilisateur";
                this.libele.DataPropertyName = "libele";
                this.date_tra.DataPropertyName = "date_tra";
            
                this.dataTracabilite.DataSource = data;
            }
            catch (Exception)
            {

                
            }

          
        }

        #endregion





        #region"Trancabilite
        public void afficherPayroll()
        {
            try
            {
                DataSet data;
                data = this.sta.afficherPayroll();

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
            catch (Exception)
            {

                
            }


        }

        #endregion








        #region"Form Load"
        private void FormStatistique_Load(object sender, EventArgs e)
        {
            try
            {
                afficherAmploye();
                afficherUtilisateur();
                afficherCompte();
                AfficherClient();
                afficherDepotS();
                afficherRetraitS();
                afficherTransfertS();
                afficherTracabilite();
                afficherPayroll();

            }
            catch (Exception)
            {

               
            }
           
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

