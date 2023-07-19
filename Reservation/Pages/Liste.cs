using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Reservation.Pages
{
    public partial class Liste : Form
    {
        SqlConnection cnx;
        SqlDataReader dr;
        public Liste()
        {
            cnx = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2012\Projects\Reservation\Reservation\Note.mdf;Integrated Security=True");
            InitializeComponent();
            chargerTrie();
            chargerTrie2();
            charger();
        }

        private void chargerTrie() {
            cnx.Open();
            string sql = "select annee from Etudiants group by annee";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                annee.Items.Add(dr[0].ToString().Trim());
            }
            dr.Dispose();
            cnx.Close();
            //
            sexe.Items.AddRange(new string[] { "Homme", "Femme" });
        }

        private void chargerTrie2() {

            cnx.Open();
            string sql2 = "select classe from Etudiants group by classe";
            SqlCommand cmd2 = new SqlCommand(sql2, cnx);
            dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                classe.Items.Add(dr[0].ToString().Trim());
            }
            dr.Dispose();
            cnx.Close();
        }

        private void charger()
        {
            cnx.Open();
            string sql = "select * from Etudiants";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                matriculeList.Items.Add(dr[0].ToString().Trim());
                nomList.Items.Add(dr[1].ToString().Trim());
                prenomList.Items.Add(dr[2].ToString().Trim());
                sexeList.Items.Add(dr[3].ToString().Trim());
                adresseList.Items.Add(dr[4].ToString().Trim());
                classeList.Items.Add(dr[5].ToString().Trim());
                anneeList.Items.Add(dr[6].ToString().Trim());
            }
            dr.Dispose();
            cnx.Close();
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
            MessageBox.Show(
                   "Vous vous êtes deconnecté !",
                   "Information",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
           );
        }
       

        private void btnAjout_Click_1(object sender, EventArgs e)
        {
            Hide();
            new Ajouter().Show();
        }

        private void btnAcceuil_Click_1(object sender, EventArgs e)
        {
            Hide();
            new App().Show();
        }

        private void btnListe_Click_1(object sender, EventArgs e)
        {
            Hide();
            new Liste().Show();
        }

        private void btnStat_Click_1(object sender, EventArgs e)
        {
            Hide();
            new Stat().Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Note(matriculeList.SelectedItem.ToString()).Show();
        }

        private void commencer_Click(object sender, EventArgs e)
        {
            cnx.Open();
            string sql = "delete from Etudiants where matricule='" + matriculeList.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            matriculeList.Items.Clear();
            nomList.Items.Clear();
            prenomList.Items.Clear();
            sexeList.Items.Clear();
            adresseList.Items.Clear();
            classeList.Items.Clear();
            anneeList.Items.Clear();
            charger();
            MessageBox.Show(
                   "Etudiant supprimé avec succès !",
                   "Information",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
           );
        }

        private void Liste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'noteDataSet1.Etudiants' table. You can move, or remove it, as needed.
            this.etudiantsTableAdapter.Fill(this.noteDataSet1.Etudiants);
            // TODO: This line of code loads data into the 'noteDataSet1.Etudiants' table. You can move, or remove it, as needed.
            this.etudiantsTableAdapter.Fill(this.noteDataSet1.Etudiants);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.etudiantsTableAdapter.FillBy(this.noteDataSet1.Etudiants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.etudiantsTableAdapter.FillBy1(this.noteDataSet1.Etudiants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void etudiantsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.etudiantsTableAdapter.FillBy2(this.noteDataSet1.Etudiants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nom.Text.Length < 1)
            {
                MessageBox.Show("Veuiller entrer un nom à chercher !", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                matriculeList.Items.Clear();
                nomList.Items.Clear();
                prenomList.Items.Clear();
                sexeList.Items.Clear();
                adresseList.Items.Clear();
                classeList.Items.Clear();
                anneeList.Items.Clear();
                cnx.Open();
                string sql = "select * from Etudiants where nom='" + nom.Text + "' and sexe='" + sexe.SelectedItem.ToString() + "' and classe='" + classe.SelectedItem.ToString() + "' and annee='" + annee.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, cnx);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    matriculeList.Items.Add(dr[0].ToString().Trim());
                    nomList.Items.Add(dr[1].ToString().Trim());
                    prenomList.Items.Add(dr[2].ToString().Trim());
                    sexeList.Items.Add(dr[3].ToString().Trim());
                    adresseList.Items.Add(dr[4].ToString().Trim());
                    classeList.Items.Add(dr[5].ToString().Trim());
                    anneeList.Items.Add(dr[6].ToString().Trim());
                }
                dr.Dispose();
                cnx.Close();
            }
        }
    }
}
