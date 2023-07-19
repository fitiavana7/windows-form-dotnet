namespace Reservation.Pages
{
    partial class Liste
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.anneeList = new System.Windows.Forms.ListBox();
            this.classeList = new System.Windows.Forms.ListBox();
            this.adresseList = new System.Windows.Forms.ListBox();
            this.sexeList = new System.Windows.Forms.ListBox();
            this.prenomList = new System.Windows.Forms.ListBox();
            this.nomList = new System.Windows.Forms.ListBox();
            this.matriculeList = new System.Windows.Forms.ListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.supprimer = new System.Windows.Forms.Button();
            this.ajouterNote = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.annee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.classe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sexe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnStat = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.btnListe = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAcceuil = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.etudiantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteDataSet1 = new Reservation.NoteDataSet1();
            this.etudiantsTableAdapter = new Reservation.NoteDataSet1TableAdapters.EtudiantsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 525);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(245, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(766, 525);
            this.panel5.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.anneeList);
            this.panel7.Controls.Add(this.classeList);
            this.panel7.Controls.Add(this.adresseList);
            this.panel7.Controls.Add(this.sexeList);
            this.panel7.Controls.Add(this.prenomList);
            this.panel7.Controls.Add(this.nomList);
            this.panel7.Controls.Add(this.matriculeList);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.supprimer);
            this.panel7.Controls.Add(this.ajouterNote);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 140);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(766, 385);
            this.panel7.TabIndex = 3;
            // 
            // anneeList
            // 
            this.anneeList.Enabled = false;
            this.anneeList.FormattingEnabled = true;
            this.anneeList.Location = new System.Drawing.Point(634, 51);
            this.anneeList.Name = "anneeList";
            this.anneeList.Size = new System.Drawing.Size(110, 225);
            this.anneeList.TabIndex = 24;
            // 
            // classeList
            // 
            this.classeList.Enabled = false;
            this.classeList.FormattingEnabled = true;
            this.classeList.Location = new System.Drawing.Point(530, 51);
            this.classeList.Name = "classeList";
            this.classeList.Size = new System.Drawing.Size(109, 225);
            this.classeList.TabIndex = 23;
            // 
            // adresseList
            // 
            this.adresseList.Enabled = false;
            this.adresseList.FormattingEnabled = true;
            this.adresseList.Location = new System.Drawing.Point(425, 51);
            this.adresseList.Name = "adresseList";
            this.adresseList.Size = new System.Drawing.Size(110, 225);
            this.adresseList.TabIndex = 22;
            // 
            // sexeList
            // 
            this.sexeList.Enabled = false;
            this.sexeList.FormattingEnabled = true;
            this.sexeList.Location = new System.Drawing.Point(324, 51);
            this.sexeList.Name = "sexeList";
            this.sexeList.Size = new System.Drawing.Size(106, 225);
            this.sexeList.TabIndex = 21;
            // 
            // prenomList
            // 
            this.prenomList.Enabled = false;
            this.prenomList.FormattingEnabled = true;
            this.prenomList.Location = new System.Drawing.Point(218, 51);
            this.prenomList.Name = "prenomList";
            this.prenomList.Size = new System.Drawing.Size(108, 225);
            this.prenomList.TabIndex = 20;
            // 
            // nomList
            // 
            this.nomList.Enabled = false;
            this.nomList.FormattingEnabled = true;
            this.nomList.Location = new System.Drawing.Point(112, 51);
            this.nomList.Name = "nomList";
            this.nomList.Size = new System.Drawing.Size(110, 225);
            this.nomList.TabIndex = 19;
            // 
            // matriculeList
            // 
            this.matriculeList.FormattingEnabled = true;
            this.matriculeList.Location = new System.Drawing.Point(20, 51);
            this.matriculeList.Name = "matriculeList";
            this.matriculeList.Size = new System.Drawing.Size(98, 225);
            this.matriculeList.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(766, 45);
            this.panel8.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(656, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(30, 10, 10, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 22);
            this.label13.TabIndex = 22;
            this.label13.Text = "Annee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(560, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(30, 10, 10, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 22);
            this.label12.TabIndex = 21;
            this.label12.Text = "Classe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(451, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(30, 10, 10, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Adresse";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(343, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(30, 10, 10, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Sexe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(238, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(30, 10, 10, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Prénom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(141, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(30, 10, 10, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(30, 10, 10, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Matricule";
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimer.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimer.Location = new System.Drawing.Point(455, 311);
            this.supprimer.Margin = new System.Windows.Forms.Padding(0);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(133, 44);
            this.supprimer.TabIndex = 15;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.commencer_Click);
            // 
            // ajouterNote
            // 
            this.ajouterNote.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ajouterNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouterNote.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ajouterNote.Location = new System.Drawing.Point(612, 311);
            this.ajouterNote.Margin = new System.Windows.Forms.Padding(0);
            this.ajouterNote.Name = "ajouterNote";
            this.ajouterNote.Size = new System.Drawing.Size(132, 44);
            this.ajouterNote.TabIndex = 14;
            this.ajouterNote.Text = "ajouter note";
            this.ajouterNote.UseVisualStyleBackColor = false;
            this.ajouterNote.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.annee);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.classe);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.sexe);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.nom);
            this.panel6.Location = new System.Drawing.Point(3, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(762, 79);
            this.panel6.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(652, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "trouver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(494, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "annee scolaire :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // annee
            // 
            this.annee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.annee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annee.ForeColor = System.Drawing.Color.White;
            this.annee.FormattingEnabled = true;
            this.annee.Location = new System.Drawing.Point(495, 37);
            this.annee.Name = "annee";
            this.annee.Size = new System.Drawing.Size(132, 23);
            this.annee.TabIndex = 12;
            this.annee.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(335, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "classe :";
            // 
            // classe
            // 
            this.classe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classe.ForeColor = System.Drawing.Color.White;
            this.classe.FormattingEnabled = true;
            this.classe.Location = new System.Drawing.Point(336, 37);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(132, 23);
            this.classe.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(182, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sexe :";
            // 
            // sexe
            // 
            this.sexe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.sexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexe.ForeColor = System.Drawing.Color.White;
            this.sexe.FormattingEnabled = true;
            this.sexe.Location = new System.Drawing.Point(183, 37);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(132, 23);
            this.sexe.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom :";
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.nom.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.ForeColor = System.Drawing.Color.White;
            this.nom.Location = new System.Drawing.Point(17, 36);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(140, 25);
            this.nom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 10, 10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISTE DE TOUS LES ETUDIANTS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 525);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.btnStat);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.btnDeconnecter);
            this.panel4.Controls.Add(this.btnListe);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.btnAjout);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.btnAcceuil);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 349);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Reservation.Properties.Resources._6;
            this.pictureBox6.Location = new System.Drawing.Point(24, 193);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // btnStat
            // 
            this.btnStat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStat.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStat.ForeColor = System.Drawing.Color.White;
            this.btnStat.Location = new System.Drawing.Point(0, 193);
            this.btnStat.Margin = new System.Windows.Forms.Padding(10);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(232, 41);
            this.btnStat.TabIndex = 8;
            this.btnStat.Text = "Statistics";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Reservation.Properties.Resources._5;
            this.pictureBox5.Location = new System.Drawing.Point(24, 254);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::Reservation.Properties.Resources._7;
            this.pictureBox4.Location = new System.Drawing.Point(24, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // btnDeconnecter
            // 
            this.btnDeconnecter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnecter.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnecter.ForeColor = System.Drawing.Color.White;
            this.btnDeconnecter.Location = new System.Drawing.Point(0, 254);
            this.btnDeconnecter.Margin = new System.Windows.Forms.Padding(10);
            this.btnDeconnecter.Name = "btnDeconnecter";
            this.btnDeconnecter.Size = new System.Drawing.Size(232, 41);
            this.btnDeconnecter.TabIndex = 5;
            this.btnDeconnecter.Text = "Deconnecter";
            this.btnDeconnecter.UseVisualStyleBackColor = true;
            this.btnDeconnecter.Click += new System.EventHandler(this.btnDeconnecter_Click);
            // 
            // btnListe
            // 
            this.btnListe.BackColor = System.Drawing.Color.White;
            this.btnListe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListe.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.btnListe.Location = new System.Drawing.Point(0, 132);
            this.btnListe.Margin = new System.Windows.Forms.Padding(10);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(232, 41);
            this.btnListe.TabIndex = 4;
            this.btnListe.Text = "Liste etudiant";
            this.btnListe.UseVisualStyleBackColor = false;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Reservation.Properties.Resources._9;
            this.pictureBox3.Location = new System.Drawing.Point(24, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btnAjout
            // 
            this.btnAjout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjout.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.ForeColor = System.Drawing.Color.White;
            this.btnAjout.Location = new System.Drawing.Point(0, 71);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(10);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(232, 41);
            this.btnAjout.TabIndex = 2;
            this.btnAjout.Text = "Ajout etudiant";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reservation.Properties.Resources._8;
            this.pictureBox2.Location = new System.Drawing.Point(24, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnAcceuil
            // 
            this.btnAcceuil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcceuil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceuil.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceuil.ForeColor = System.Drawing.Color.White;
            this.btnAcceuil.Location = new System.Drawing.Point(0, 10);
            this.btnAcceuil.Margin = new System.Windows.Forms.Padding(10);
            this.btnAcceuil.Name = "btnAcceuil";
            this.btnAcceuil.Size = new System.Drawing.Size(232, 41);
            this.btnAcceuil.TabIndex = 0;
            this.btnAcceuil.Text = "Acceuil";
            this.btnAcceuil.UseVisualStyleBackColor = true;
            this.btnAcceuil.Click += new System.EventHandler(this.btnAcceuil_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 170);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "study.net";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reservation.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(56, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // etudiantsBindingSource
            // 
            this.etudiantsBindingSource.DataMember = "Etudiants";
            this.etudiantsBindingSource.DataSource = this.noteDataSet1;
            // 
            // noteDataSet1
            // 
            this.noteDataSet1.DataSetName = "NoteDataSet1";
            this.noteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudiantsTableAdapter
            // 
            this.etudiantsTableAdapter.ClearBeforeFill = true;
            // 
            // Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 525);
            this.Controls.Add(this.panel1);
            this.Name = "Liste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste";
            this.Load += new System.EventHandler(this.Liste_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnDeconnecter;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAcceuil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox annee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox classe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sexe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button ajouterNote;
        private NoteDataSet1 noteDataSet1;
        private System.Windows.Forms.BindingSource etudiantsBindingSource;
        private NoteDataSet1TableAdapters.EtudiantsTableAdapter etudiantsTableAdapter;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox anneeList;
        private System.Windows.Forms.ListBox classeList;
        private System.Windows.Forms.ListBox adresseList;
        private System.Windows.Forms.ListBox sexeList;
        private System.Windows.Forms.ListBox prenomList;
        private System.Windows.Forms.ListBox nomList;
        private System.Windows.Forms.ListBox matriculeList;

    }
}