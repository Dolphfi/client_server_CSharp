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

namespace SERVER2023
{
    public partial class FormMenu : Form
    {
      
        Gestionserver canal = new Gestionserver();
        public GestionInterface.IUtilisateur util = null;
        readonly application.CtrlUtilisateur con = null;
        public static string code;
        public static int eta=0;
       
        readonly DateTime dat = DateTime.Now;

        public string cod, hre, codeuser;
        DateTime datla = DateTime.Now;
        private void btarreter_Click(object sender, EventArgs e)
        {
            try
            {
                buttonUtilisateur.Enabled = false;
                canal.Arreter();
                lbtitre.Text = "Le serveur n'est pas en marche";
                lbtitre.ForeColor = Color.Red;
                btdemarrer.Enabled = true;
                btarreter.Enabled = false;

            }
            catch (Exception)
            {

                
            }
           
        }

        private void btdemarrer_Click(object sender, EventArgs e)
        {
            try
            {
                canal.Serveur();
                lbtitre.Text = "Le serveur est en marche";
                lbtitre.ForeColor = Color.Green;
                btdemarrer.Enabled = false;
                btarreter.Enabled = true;
                buttonUtilisateur.Enabled = true;
            }
            catch (Exception)
            {

                
            }
             

        }


        public FormMenu(string f, string u,string c)
        {
            InitializeComponent();
            fonc = f;
            usernma = u;
            co = c;
            con = new application.CtrlUtilisateur();

        }

        string fonc;
        string usernma;
        string co;
        private void FormMenu_Load(object sender, EventArgs e)
        {
            buttonUtilisateur.Enabled = false;
            MovePanel(buttonUtilisateur);
            tabControlServer.Hide();
            tabControlUtilisateur.Hide();
            btarreter.Enabled = false;
            comboEtatUserM.Text = "Choisir";  
            if (fonc == "administrateur")
            {

                labelfonctionuser.Text = fonc + " : " + usernma;


            }
          


            timer1.Start();


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
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }


        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }







            private void buttonUtilisateur_Click(object sender, EventArgs e)
        {
            MovePanel(buttonUtilisateur);
            tabControlServer.Hide();
            tabControlUtilisateur.Show();

        }

        private void linkLabelLogoutM_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are You want to Logout?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                 
                  
                   
                    timer1.Stop();
                    FormLoginUser fd = new FormLoginUser();
                    fd.Show();
                    this.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Aurevoir");
            }


        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            MovePanel(buttonServer);
            tabControlServer.Show();
            tabControlUtilisateur.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRecherEtatUser_Click(object sender, EventArgs e)
        {

            if (txtRechercherEtatU.Text.Trim() == String.Empty)
                MessageBox.Show("Veuillez remplir le champs.", "Champs obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    code = txtRechercherEtatU.Text;
                    bool rech = false;
                    rech = this.con.Rechercherutilisateur(code);
                    if (rech == true)
                    {

                       
                        comboEtatUserM.Text = Convert.ToInt32(con.PrendreEtat()).ToString();


                    }
                    else
                    {
                        MessageBox.Show("Code incorrect");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("erreur");
                }
            }
        }

        private void btnModifierEtatU_Click(object sender, EventArgs e)
        {


            try
            {
                DialogResult rep = MessageBox.Show("Voulez-vous vaiment Modifier?", "Message de Confimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (rep == DialogResult.OK)
                {
                    code = txtRechercherEtatU.Text;
                    eta = Convert.ToInt32(comboEtatUserM.Text.ToString());
                   
                    int ver = 0;

                    ver = this.con.ModifierEtat(code,eta);

                    if (ver > 0)
                    {

                        MessageBox.Show("modification reusite");
                        this.con.Inftransaction(co, "Modification Etat -->" + code+ "-->" + "etat :" + eta, datla);
                        txtRechercherEtatU.Clear();
                        comboEtatUserM.Text = "Choisir";
                       
                    }

                    else
                    {
                        MessageBox.Show("modification non reusite");
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Erreur");
            }
        }
    }
}
