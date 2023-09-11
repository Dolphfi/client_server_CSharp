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
    public partial class FormLoginUser : Form
    {
        Menu ths;
        public GestionInterface.IUtilisateur util = null;
        public GestionInterface.IEmploye emp = null;
        public int et = 0;

        public string username, password, fonc, cod;
        


     
        DateTime datla = DateTime.Now;


         
        public FormLoginUser()
        {
            InitializeComponent();
          
        }

        public void GererServer()
        {

            try
            {
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel);
                util = (GestionInterface.IUtilisateur)Activator.GetObject(typeof(GestionInterface.IUtilisateur), "tcp://localhost:1070/IUtilisateur");
                ChannelServices.UnregisterChannel(channel);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }









        int count, attemp;
        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.util.ModifierEtat(cod, 0);

        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            passwordtxt.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void FormLoginUser_Load(object sender, EventArgs e)
        {
            attemp = 0;
            GererServer();
        }

        private void timerLogin_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                timerLogin.Enabled = false;
                connectionbtn.Enabled = true;
                passwordtxt.Enabled = true;
                usertxt.Enabled = true;
                connectionbtn.Text = "Login";
                usertxt.Focus();

            }
            else
            {
                connectionbtn.Text = "Log in" + count;
                count = count - 1;
            }
        }


        void disable()
        {
            if (attemp == 3)
            {
                MessageBox.Show("Vous avez entrer déja  3 attemps\nAurevoir", "Attemps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                attemp = 0;
                count = 10;
                timerLogin.Enabled = true;
                this.Close();
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connectionbtn_Click(object sender, EventArgs e)
        {
          
            try
            {

              
                username = usertxt.Text.Trim();
                password = passwordtxt.Text.Trim();

                if (usertxt.Text.Trim() == String.Empty || passwordtxt.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("aucun champ ne doit pas etre vide");
                }
                else
                {
                    bool rech = false;
                    
                    rech = this.util.Recheruser(username, password);
              
                    if (rech == true)
                    {

                        et = this.util.PrendreEtat();

                        fonc = this.util.PrendreFonction();
                       
                        cod = this.util.PrendreCode();

                        if (et == 0)
                        {

                            this.util.Inftransaction(cod, "connexion", datla);
                        

                            if (fonc.ToLower()== "administrateur")
                            {
                                FormMenu sra = new FormMenu(cod, util, fonc, usertxt.Text);
                                sra.Show();
                                this.Hide();
                                this.util.ModifierEtat(cod, 1);
                            

                            }

                            else if (fonc.ToLower() == "secretaire")
                            {
                                FormMenu sr = new FormMenu(cod, util, fonc, usertxt.Text);
                                sr.Show();
                                this.Hide();
                                this.util.ModifierEtat(cod, 1);
                            }
                            else if (fonc.ToLower() == "caissier")
                            {
                                FormMenu sr = new FormMenu(cod, util, fonc, usertxt.Text);
                                sr.Show();
                                this.Hide();
                                this.util.ModifierEtat(cod, 1);
                            }
                            else if (fonc.ToLower() == "comptable")
                            {
                                FormMenu sr = new FormMenu(cod, util, fonc, usertxt.Text);
                                sr.Show();
                                this.Hide();
                                this.util.ModifierEtat(cod, 1);
                            }


                        }
                        else 
                        {
                            MessageBox.Show("Vous etes deja connecte.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or password incorrect.\n Essayer encore!", "Connection faide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usertxt.Clear();
                        passwordtxt.Clear();
                        usertxt.Focus();
                        attemp = attemp + 1;
                        disable();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Le serveur n'est pas en marche");
            }
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {

            pictureBoxHide.Hide();
            passwordtxt.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void pictureClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureClose, "Close");
        }

        private void pictureMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureMinimize, "Minimize");
        }
    }
}
