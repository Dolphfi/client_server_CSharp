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
    public partial class FormMenu : Form
    {
        public GestionInterface.IUtilisateur util = null;
        public GestionInterface.IEmploye empl = null;
        public GestionInterface.IClient cli = null;
        public GestionInterface.ICompte comp = null;
        public GestionInterface.IDashBoard dash = null;
        public GestionInterface.IDepot dep = null;
        public GestionInterface.IRetrait ret = null;
        public GestionInterface.ITransfert tra = null;
        public GestionInterface.IStatistique sta = null;

        public GestionInterface.IPayroll pay = null;

        //   readonly CFP.application.CtrlUtilisateur con = null;
        public string  cod, hre;
        public int et = 0;
        DateTime datla = DateTime.Now;


        public FormMenu( string co, GestionInterface.IUtilisateur ut, string f, string u)
        {
            InitializeComponent();
            fonc = f;
            usernma = u;
            util = ut;
            cod = co;

        }

        string fonc;
        string usernma;

       










        private void FormMenu_Load(object sender, EventArgs e)
        {

            GererServer();

            if (fonc == "administrateur")
            {

                labelfonctionuser.Text = fonc + " : " + usernma;
               

            }


            else if (fonc == "secretaire")
            {
                buttonUtilisateur.Enabled = false;
                buttonTransaction.Enabled = false;
                buttonStatistique.Enabled = false;
                buttonEmployer.Enabled = false;
                labelfonctionuser.Text = fonc + " : " + usernma;
                buttonPayroll.Enabled = false;



            }
            else if (fonc == "caissier")
            {
                buttonUtilisateur.Enabled = false;
                buttonStatistique.Enabled = false;
                buttonEmployer.Enabled = false;
                buttonCompte.Enabled = false;
                buttonClient.Enabled = false;
                labelfonctionuser.Text = fonc + " : " + usernma;
                buttonPayroll.Enabled = false;


            }

            else if (fonc == "comptable")
            {
                buttonUtilisateur.Enabled = false;
                buttonStatistique.Enabled = false;
                buttonEmployer.Enabled = false;
                buttonCompte.Enabled = false;
                buttonClient.Enabled = false;
                buttonTransaction.Enabled = false;
                labelfonctionuser.Text = fonc + " : " + usernma;


            }

            timer1.Start();

        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void linkLabelLogoutM_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are You want to Logout?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                   // cod = this.util.PrendreCode();
                    this.util.Inftransaction(cod, "deconnexion", datla);
                    this.Close();
                    this.util.ModifierEtat(cod, 0);

                    timer1.Stop();
                    FormLoginUser fd = new FormLoginUser();
                    fd.Show();
                    
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Le server n'est pas en marche");
                FormLoginUser fd = new FormLoginUser();
                fd.Show();
                this.Close();

            }

           
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            loadform(new FormDashBoard(dash));
        }





        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }

        private void buttonCompte_Click(object sender, EventArgs e)
        {
            MovePanel(buttonCompte);
            loadform(new FormCompte(cod, comp, util));
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            loadform(new FormClient(cod, cli, util));
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            MovePanel(buttonTransaction);
            loadform(new FormTransaction(cod, dep,ret,tra, util));
        }

        private void buttonStatistique_Click(object sender, EventArgs e)
        {
            MovePanel(buttonStatistique);
            loadform(new FormStatistique(sta));
        }

        private void buttonEmployer_Click(object sender, EventArgs e)
        {
            MovePanel(buttonEmployer);
            loadform(new FormEmploye(cod,empl,util));
        }

        private void buttonPayroll_Click(object sender, EventArgs e)
        {
            MovePanel(buttonPayroll);
            loadform(new FormPayroll(cod,util,pay,empl,comp));

        }

     
        
        private void buttonUtilisateur_Click(object sender, EventArgs e)
        {
            MovePanel(buttonUtilisateur);
            loadform(new FormUtilisateur(cod, util));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void GererServer()
        {

            try
            {
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel);
                util = (GestionInterface.IUtilisateur)Activator.GetObject(typeof(GestionInterface.IUtilisateur), "tcp://localhost:1070/IUtilisateur");
                empl = (GestionInterface.IEmploye)Activator.GetObject(typeof(GestionInterface.IEmploye), "tcp://localhost:1070/IEmploye");
               cli = (GestionInterface.IClient)Activator.GetObject(typeof(GestionInterface.IClient), "tcp://localhost:1070/IClient");
                comp = (GestionInterface.ICompte)Activator.GetObject(typeof(GestionInterface.ICompte), "tcp://localhost:1070/ICompte");
                dash= (GestionInterface.IDashBoard)Activator.GetObject(typeof(GestionInterface.IDashBoard), "tcp://localhost:1070/IDashBoard");
                dep = (GestionInterface.IDepot)Activator.GetObject(typeof(GestionInterface.IDepot), "tcp://localhost:1070/IDepot");
                ret = (GestionInterface.IRetrait)Activator.GetObject(typeof(GestionInterface.IRetrait), "tcp://localhost:1070/IRetrait");
               tra = (GestionInterface.ITransfert)Activator.GetObject(typeof(GestionInterface.ITransfert), "tcp://localhost:1070/ITransfert");
                sta= (GestionInterface.IStatistique)Activator.GetObject(typeof(GestionInterface.IStatistique), "tcp://localhost:1070/IStatistique");
                pay = (GestionInterface.IPayroll)Activator.GetObject(typeof(GestionInterface.IPayroll), "tcp://localhost:1070/IPayroll");
                ChannelServices.UnregisterChannel(channel);

            }
            catch (Exception)
            {
                MessageBox.Show("Le server n'est pas en marche" );
            }
        }
    }
}
