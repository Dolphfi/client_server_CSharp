namespace SVB
{
    partial class FormPayroll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayroll));
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btrechercher = new System.Windows.Forms.Button();
            this.txtrech = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_payroll = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Ida = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txtnumerocompte = new System.Windows.Forms.TextBox();
            this.txtSalaire = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCodeE = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.Label();
            this.txtSalaireNet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Deduction_gr = new System.Windows.Forms.GroupBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.pickerDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtRecherPayroll = new System.Windows.Forms.TextBox();
            this.btRecherPayroll = new System.Windows.Forms.Button();
            this.dtpayrollP = new System.Windows.Forms.DataGridView();
            this.id_payp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_coptp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salnp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Deduction_gr.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpayrollP)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(232, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(343, 35);
            this.label13.TabIndex = 32;
            this.label13.Text = "GESTION PAYROLL";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.txtdescription);
            this.tabPage2.Controls.Add(this.d);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtSalaireNet);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Deduction_gr);
            this.tabPage2.Controls.Add(this.btValider);
            this.tabPage2.Controls.Add(this.pickerDate);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(799, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Paiement ";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox2.Controls.Add(this.btrechercher);
            this.groupBox2.Controls.Add(this.txtrech);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(220, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(351, 51);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numero Compte ";
            // 
            // btrechercher
            // 
            this.btrechercher.BackColor = System.Drawing.Color.Goldenrod;
            this.btrechercher.Location = new System.Drawing.Point(5, 19);
            this.btrechercher.Margin = new System.Windows.Forms.Padding(2);
            this.btrechercher.Name = "btrechercher";
            this.btrechercher.Size = new System.Drawing.Size(124, 29);
            this.btrechercher.TabIndex = 29;
            this.btrechercher.Text = "Rechercher";
            this.btrechercher.UseVisualStyleBackColor = false;
            this.btrechercher.Click += new System.EventHandler(this.btrechercher_Click);
            // 
            // txtrech
            // 
            this.txtrech.Location = new System.Drawing.Point(143, 22);
            this.txtrech.Margin = new System.Windows.Forms.Padding(2);
            this.txtrech.Name = "txtrech";
            this.txtrech.Size = new System.Drawing.Size(192, 24);
            this.txtrech.TabIndex = 28;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(535, 376);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(208, 24);
            this.txtdescription.TabIndex = 45;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(441, 376);
            this.d.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(84, 17);
            this.d.TabIndex = 46;
            this.d.Text = "Description";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Controls.Add(this.id_payroll);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Ida);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Txtnumerocompte);
            this.groupBox1.Controls.Add(this.txtSalaire);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtCodeE);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(778, 151);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les infos";
            // 
            // id_payroll
            // 
            this.id_payroll.Location = new System.Drawing.Point(102, 36);
            this.id_payroll.Margin = new System.Windows.Forms.Padding(2);
            this.id_payroll.Name = "id_payroll";
            this.id_payroll.Size = new System.Drawing.Size(148, 26);
            this.id_payroll.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(523, 106);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "No Compte";
            // 
            // Ida
            // 
            this.Ida.AutoSize = true;
            this.Ida.Location = new System.Drawing.Point(14, 38);
            this.Ida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ida.Name = "Ida";
            this.Ida.Size = new System.Drawing.Size(86, 19);
            this.Ida.TabIndex = 43;
            this.Ida.Text = "Id Payroll";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Salaire";
            // 
            // Txtnumerocompte
            // 
            this.Txtnumerocompte.Location = new System.Drawing.Point(630, 106);
            this.Txtnumerocompte.Margin = new System.Windows.Forms.Padding(2);
            this.Txtnumerocompte.Name = "Txtnumerocompte";
            this.Txtnumerocompte.Size = new System.Drawing.Size(137, 26);
            this.Txtnumerocompte.TabIndex = 16;
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(632, 31);
            this.txtSalaire.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(134, 26);
            this.txtSalaire.TabIndex = 17;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(335, 104);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(180, 26);
            this.txtPrenom.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(93, 109);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(157, 26);
            this.txtNom.TabIndex = 31;
            // 
            // txtCodeE
            // 
            this.txtCodeE.Location = new System.Drawing.Point(335, 35);
            this.txtCodeE.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodeE.Name = "txtCodeE";
            this.txtCodeE.Size = new System.Drawing.Size(180, 26);
            this.txtCodeE.TabIndex = 36;
            // 
            // txtCode
            // 
            this.txtCode.AutoSize = true;
            this.txtCode.Location = new System.Drawing.Point(274, 43);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(49, 19);
            this.txtCode.TabIndex = 37;
            this.txtCode.Text = "Code";
            // 
            // txtSalaireNet
            // 
            this.txtSalaireNet.Location = new System.Drawing.Point(528, 284);
            this.txtSalaireNet.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalaireNet.Name = "txtSalaireNet";
            this.txtSalaireNet.Size = new System.Drawing.Size(208, 24);
            this.txtSalaireNet.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Salaire Net";
            // 
            // Deduction_gr
            // 
            this.Deduction_gr.BackColor = System.Drawing.Color.Goldenrod;
            this.Deduction_gr.Controls.Add(this.txttax);
            this.Deduction_gr.Controls.Add(this.label3);
            this.Deduction_gr.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deduction_gr.ForeColor = System.Drawing.Color.White;
            this.Deduction_gr.Location = new System.Drawing.Point(49, 292);
            this.Deduction_gr.Margin = new System.Windows.Forms.Padding(2);
            this.Deduction_gr.Name = "Deduction_gr";
            this.Deduction_gr.Padding = new System.Windows.Forms.Padding(2);
            this.Deduction_gr.Size = new System.Drawing.Size(209, 106);
            this.Deduction_gr.TabIndex = 33;
            this.Deduction_gr.TabStop = false;
            this.Deduction_gr.Text = "Deduction";
            // 
            // txttax
            // 
            this.txttax.Location = new System.Drawing.Point(68, 50);
            this.txttax.Margin = new System.Windows.Forms.Padding(2);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(125, 26);
            this.txttax.TabIndex = 36;
            this.txttax.TextChanged += new System.EventHandler(this.txttax_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tax ";
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.Goldenrod;
            this.btValider.ForeColor = System.Drawing.Color.White;
            this.btValider.Location = new System.Drawing.Point(304, 336);
            this.btValider.Margin = new System.Windows.Forms.Padding(2);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(117, 28);
            this.btValider.TabIndex = 30;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // pickerDate
            // 
            this.pickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerDate.Location = new System.Drawing.Point(528, 325);
            this.pickerDate.Margin = new System.Windows.Forms.Padding(2);
            this.pickerDate.Name = "pickerDate";
            this.pickerDate.Size = new System.Drawing.Size(208, 24);
            this.pickerDate.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 328);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Date";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(-2, 64);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 533);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.groupBox13);
            this.tabPage1.Controls.Add(this.dtpayrollP);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(799, 498);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Afficher";
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox13.Controls.Add(this.txtRecherPayroll);
            this.groupBox13.Controls.Add(this.btRecherPayroll);
            this.groupBox13.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.ForeColor = System.Drawing.Color.White;
            this.groupBox13.Location = new System.Drawing.Point(238, 27);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox13.Size = new System.Drawing.Size(311, 60);
            this.groupBox13.TabIndex = 30;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = " Id Payroll";
            // 
            // txtRecherPayroll
            // 
            this.txtRecherPayroll.Location = new System.Drawing.Point(150, 23);
            this.txtRecherPayroll.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecherPayroll.Name = "txtRecherPayroll";
            this.txtRecherPayroll.Size = new System.Drawing.Size(158, 26);
            this.txtRecherPayroll.TabIndex = 21;
            // 
            // btRecherPayroll
            // 
            this.btRecherPayroll.BackColor = System.Drawing.Color.Goldenrod;
            this.btRecherPayroll.Location = new System.Drawing.Point(9, 22);
            this.btRecherPayroll.Margin = new System.Windows.Forms.Padding(2);
            this.btRecherPayroll.Name = "btRecherPayroll";
            this.btRecherPayroll.Size = new System.Drawing.Size(116, 27);
            this.btRecherPayroll.TabIndex = 19;
            this.btRecherPayroll.Text = "Rechercher";
            this.btRecherPayroll.UseVisualStyleBackColor = false;
            this.btRecherPayroll.Click += new System.EventHandler(this.btRecherPayroll_Click);
            // 
            // dtpayrollP
            // 
            this.dtpayrollP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpayrollP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_payp,
            this.num_coptp,
            this.nop,
            this.prep,
            this.salp,
            this.descpp,
            this.salnp,
            this.datp,
            this.tap,
            this.cop});
            this.dtpayrollP.Location = new System.Drawing.Point(8, 112);
            this.dtpayrollP.Margin = new System.Windows.Forms.Padding(2);
            this.dtpayrollP.Name = "dtpayrollP";
            this.dtpayrollP.RowHeadersWidth = 51;
            this.dtpayrollP.RowTemplate.Height = 24;
            this.dtpayrollP.Size = new System.Drawing.Size(787, 362);
            this.dtpayrollP.TabIndex = 29;
            // 
            // id_payp
            // 
            this.id_payp.HeaderText = "ID PAYROLL";
            this.id_payp.MinimumWidth = 6;
            this.id_payp.Name = "id_payp";
            this.id_payp.Width = 200;
            // 
            // num_coptp
            // 
            this.num_coptp.HeaderText = "NUMERO COMPTE";
            this.num_coptp.MinimumWidth = 6;
            this.num_coptp.Name = "num_coptp";
            this.num_coptp.Width = 200;
            // 
            // nop
            // 
            this.nop.HeaderText = "NOM";
            this.nop.MinimumWidth = 6;
            this.nop.Name = "nop";
            this.nop.Width = 200;
            // 
            // prep
            // 
            this.prep.HeaderText = "PRENOM";
            this.prep.MinimumWidth = 6;
            this.prep.Name = "prep";
            this.prep.Width = 200;
            // 
            // salp
            // 
            this.salp.HeaderText = "SALAIRE";
            this.salp.MinimumWidth = 6;
            this.salp.Name = "salp";
            this.salp.Width = 200;
            // 
            // descpp
            // 
            this.descpp.HeaderText = "DESCRIPTION";
            this.descpp.MinimumWidth = 6;
            this.descpp.Name = "descpp";
            this.descpp.Width = 125;
            // 
            // salnp
            // 
            this.salnp.HeaderText = "SALAIRE NET";
            this.salnp.MinimumWidth = 6;
            this.salnp.Name = "salnp";
            this.salnp.Width = 125;
            // 
            // datp
            // 
            this.datp.HeaderText = "DATE";
            this.datp.MinimumWidth = 6;
            this.datp.Name = "datp";
            this.datp.Width = 125;
            // 
            // tap
            // 
            this.tap.HeaderText = "TAX";
            this.tap.MinimumWidth = 6;
            this.tap.Name = "tap";
            this.tap.Width = 125;
            // 
            // cop
            // 
            this.cop.HeaderText = "CODE EMPLOYE";
            this.cop.MinimumWidth = 6;
            this.cop.Name = "cop";
            this.cop.Width = 125;
            // 
            // FormPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 596);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPayroll";
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.FormPayroll_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Deduction_gr.ResumeLayout(false);
            this.Deduction_gr.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpayrollP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSalaireNet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Deduction_gr;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btrechercher;
        private System.Windows.Forms.TextBox txtrech;
        private System.Windows.Forms.TextBox txtSalaire;
        private System.Windows.Forms.TextBox Txtnumerocompte;
        private System.Windows.Forms.DateTimePicker pickerDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtCodeE;
        private System.Windows.Forms.Label txtCode;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_payroll;
        private System.Windows.Forms.Label Ida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txtRecherPayroll;
        private System.Windows.Forms.Button btRecherPayroll;
        private System.Windows.Forms.DataGridView dtpayrollP;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_payp;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_coptp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nop;
        private System.Windows.Forms.DataGridViewTextBoxColumn prep;
        private System.Windows.Forms.DataGridViewTextBoxColumn salp;
        private System.Windows.Forms.DataGridViewTextBoxColumn descpp;
        private System.Windows.Forms.DataGridViewTextBoxColumn salnp;
        private System.Windows.Forms.DataGridViewTextBoxColumn datp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cop;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}