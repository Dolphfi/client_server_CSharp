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
    public partial class FormDashBoard : Form
    {
       
        

        public GestionInterface.IDashBoard dash = null;

        public FormDashBoard(GestionInterface.IDashBoard da)
        {
            InitializeComponent();
           dash= da;    
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            try
            {
                txt_Nombre_Client.Text = (this.dash.AfficherQuantiteClient().ToString());
                txt_Nombre_Compte.Text = (this.dash.AfficherQuantiteCompte().ToString());
                txt_Nombre_Employe.Text = (this.dash.AfficherQuantiteEmploye().ToString());
                txt_Nombre_Utilisateu.Text = (this.dash.AfficherQuantiteUtilisateur().ToString());
                txt_Nombre_Depot.Text = (this.dash.AfficherQuantiteDepot().ToString());
                txt_Nombre_Transfert.Text = (this.dash.AfficherQuantiteTransfert().ToString());
                txt_Nombre_Retrait.Text = (this.dash.AfficherQuantiteRetrait().ToString());
                txt_Nombre_Payroll.Text = (this.dash.AfficherQuantitePayroll().ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Le server n'est pas en marche");
            }
           
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_Nombre_Compte_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Nombre_Payroll_Click(object sender, EventArgs e)
        {

        }
    }
}
