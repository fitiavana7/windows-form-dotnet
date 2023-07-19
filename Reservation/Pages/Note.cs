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
    public partial class Note : Form
    {
        SqlConnection cnx;
        SqlDataReader dr;
        private string id ;
        private bool aBulletin;
        public Note(string matricule)
        {
            cnx = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2012\Projects\Reservation\Reservation\Note.mdf;Integrated Security=True");
            InitializeComponent();
            this.id = matricule;
            textId.Text = this.id;
            charger();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void charger(){
            matiereList.Items.Clear();
            coefficientList.Items.Clear();
            notesSansList.Items.Clear();
            noteAvecList.Items.Clear();
            cnx.Open();
            string sql = "select matiere , coefficient ,note , noteavec from Notes where matricule='"+this.id+"'";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            dr = cmd.ExecuteReader();
            aBulletin = dr.HasRows? true : false  ;
            while (dr.Read())
            {
                matiereList.Items.Add(dr[0].ToString().Trim());
                coefficientList.Items.Add(dr[1].ToString().Trim());
                notesSansList.Items.Add(dr[2].ToString().Trim());
                noteAvecList.Items.Add(dr[3].ToString().Trim());
            }
            dr.Dispose();
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                string sql = "insert into Notes(Id , matiere , note , coefficient , noteavec , matricule) values('" + DateTime.Now.GetHashCode() + "' , '" + matiere.Text + "' , '" + notesans.Text + "' , '" + coefficient.Text + "' , '" + noteavec.Text + "' , '" + this.id + "') ";
                SqlCommand cmd = new SqlCommand(sql, cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show(
                       "Note ajouté avec succès",
                       "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
               );
                matiere.Text = "";
                notesans.Text = "00";
                coefficient.Text = "00";
                noteavec.Text = "";
                charger();
            }
            catch (Exception exe)
            {
                MessageBox.Show(
                         exe.ToString(),
                         "Information",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information
                 );
            }
        }

        private void btnAcceuil_Click(object sender, EventArgs e)
        {
            Hide();
            new App().Show();
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

        private void commencer_Click(object sender, EventArgs e)
        {
            
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (matiereList.SelectedIndex > -1)
            {
                cnx.Open();
                string sql = "delete from Notes where matricule='" + this.id + "' and matiere='" + matiereList.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                charger();
                MessageBox.Show(
                   "Note effacé avec succès !",
                   "Information",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                 "Selectionnez une ligne de matiere ",
                 "Information",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
              );
            }
        }

        private void bulletin_Click(object sender, EventArgs e)
        {
            if (!aBulletin)
            {
                MessageBox.Show(
                     "Entrer des notes pour voir un bulletin !",
                     "Information",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                  );
            }
            else {
                new Bulletin(this.id).Show();
            }
        }
    }
}
