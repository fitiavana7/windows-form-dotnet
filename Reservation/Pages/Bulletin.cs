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
    public partial class Bulletin : Form
    {
        SqlConnection cnx;
        SqlDataReader dr;
        private string id;
        private int total;
        private int coeff;
        public Bulletin(string identifiant)
        {
            cnx = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2012\Projects\Reservation\Reservation\Note.mdf;Integrated Security=True");
            InitializeComponent();
            this.id = identifiant ;
            remplir();
            remplirTotal();
            remplirCoeff();
            moyenneText.Text = (this.total / this.coeff).ToString() ;
            remplirStatut();
        }

        private void remplir() {
            matricule.Text = this.id;
            cnx.Open();
            string sql = "select * from Etudiants where matricule='" + this.id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nom.Text = dr[1].ToString();
                prenom.Text = dr[2].ToString();
                sexe.Text = dr[3].ToString();
                adresse.Text = dr[4].ToString();
                classe.Text = dr[5].ToString();
                annee.Text = dr[6].ToString();
            }
            dr.Dispose();
            cnx.Close();
        }

        private void remplirTotal() {
            cnx.Open();
            string sql = "select sum(noteavec) from Notes where matricule='" + this.id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.total = (int)dr[0];
            }
            dr.Dispose();
            cnx.Close();
        }
        private void remplirCoeff()
        {
            cnx.Open();
            string sql = "select sum(coefficient) from Notes where matricule='" + this.id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.coeff = (int)dr[0];
            }
            dr.Dispose();
            cnx.Close();
        }
        private void remplirStatut() {
            int moy = this.total / this.coeff ;
            if (moy < 5) {
                statut.Text = "Eliminé";
            } else if(moy > 4 && moy < 10){
                statut.Text = "Insuffisant";
            }
            else if (moy > 9 && moy < 15)
            {
                statut.Text = "Brillant";
            }
            else {
                statut.Text = "Un génie";
            }
        }
        private void fermer_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nom_Click(object sender, EventArgs e)
        {

        }

        private void prenom_Click(object sender, EventArgs e)
        {

        }

        private void sexe_Click(object sender, EventArgs e)
        {

        }

        private void annee_Click(object sender, EventArgs e)
        {

        }

        private void classe_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void moyenneText_Click(object sender, EventArgs e)
        {

        }

        private void statut_Click(object sender, EventArgs e)
        {

        }

        private void matricule_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void fermer_Click_1(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
