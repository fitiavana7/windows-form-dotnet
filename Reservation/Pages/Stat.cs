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
    public partial class Stat : Form
    {
        SqlConnection cnx;
        SqlDataReader dr;
        public Stat()
        {
            cnx = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2012\Projects\Reservation\Reservation\Note.mdf;Integrated Security=True");
            InitializeComponent();
            chart1.Titles.Add("STATISTIQUES SUR LES CLASSES");
            chart2.Titles.Add("STATISTIQUES SUR LES NOTES FREQUENTES DES ETUDIANTS");
            remplir();
            remplir2();
        }

        private void remplir() {
            cnx.Open();
            string sql = "select classe , count(classe) from Etudiants group by classe";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["s1"].Points.AddXY(dr[0].ToString().Trim(), dr[1].ToString().Trim());
            }
            dr.Dispose();
            cnx.Close();
        }

        private void remplir2()
        {
            cnx.Open();
            string sql = "select note, count(note) from Notes group by note";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chart2.Series["s1"].Points.AddXY(dr[0].ToString().Trim(), dr[1].ToString().Trim());
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

        private void btnAjout_Click(object sender, EventArgs e)
        {
            Hide();
            new Ajouter().Show();
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            Hide();
            new Liste().Show();
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            Hide();
            new Stat().Show();
        }

        private void btnAcceuil_Click(object sender, EventArgs e)
        {
            Hide();
            new App().Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
