using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace SERVER2023
{
    public partial class FormLoginUser : Form
    {
        Menu ths;
        readonly application.CtrlUtilisateur con = null;
        string username, password, fonc,co;

        public FormLoginUser()
        {
            InitializeComponent();
            con = new application.CtrlUtilisateur();

        }



        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureMinimize, "Minimize");
        }

        private void pictureClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureClose, "Close");
        }



        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            passwordtxt.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        int count, attemp;

        private void FormLoginUser_Load(object sender, EventArgs e)
        {
            attemp = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

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
                //connectionbtn.Enabled = false;
                //passwordtxt.Enabled = false;
                //usertxt.Enabled = false;
            }
        }




        #region"Connection Etablir"

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
                    rech = this.con.Recheruser(username, password);
                    if (rech == true)
                    {
                        fonc = this.con.PrendreFonction();
                        co=this.con.PrendreCode();
                        if (fonc == "administrateur")
                        {
                            FormMenu sra = new FormMenu(fonc, usertxt.Text,co);
                            sra.Show();
                            this.Hide();


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
            catch (Exception ex)
            {
                MessageBox.Show("Erreur " + ex);
            }
        }
        #endregion

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {

            pictureBoxHide.Hide();
            passwordtxt.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }




    }

}
