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
    public partial class Ajouter : Form
    {
        SqlConnection cnx;
        public Ajouter()
        {
            cnx = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2012\Projects\Reservation\Reservation\Note.mdf;Integrated Security=True");
            InitializeComponent();
            sexe.Items.AddRange(new string[] { "Homme" , "Femme"});
            sexe.SelectedIndex = 0;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nom.Text.Length < 3)
            {
                MessageBox.Show(
                       "Nom invalide!",
                       "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
               );
                nom.Focus();
            }
            else {
                if (adresse.Text.Length < 3)
                {
                    MessageBox.Show(
                           "Adresse invalide !",
                           "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information
                   );
                    adresse.Focus();
                }
                else {
                    if (matricule.Text.Length == 0)
                    {
                        MessageBox.Show(
                               "Veuiller remplir le champ matricule !",
                               "Information",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information
                       );
                        matricule.Focus();
                    }
                    else {
                        if (classe.Text.Length < 3)
                        {
                            MessageBox.Show(
                                   "Veuiller remplir le champ classe !",
                                   "Information",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information
                           );
                            classe.Focus();
                        }
                        else {
                            if (annee.Text.Length < 3)
                            {
                                MessageBox.Show(
                                       "Veuiller remplir le champ année scolaire !",
                                       "Information",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information
                               );
                                annee.Focus();
                            }
                            else {
                                try
                                {
                                    cnx.Open();
                                    string sql = "insert into Etudiants(matricule , nom , prenom , sexe , adresse , classe , annee) values('" + matricule.Text + "' , '" + nom.Text + "' , '" + prenom.Text + "' , '" + (string)sexe.SelectedItem + "' , '" + adresse.Text + "' , '" + classe.Text + "' , '" + annee.Text + "') ";
                                    SqlCommand cmd = new SqlCommand(sql, cnx);
                                    cmd.ExecuteNonQuery();
                                    cnx.Close();
                                    MessageBox.Show(
                                           "Etudiant ajouté avec succès",
                                           "Information",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information
                                   );
                                    nom.Text = "";
                                    prenom.Text = "";
                                    adresse.Text = "";
                                    matricule.Text = "";
                                    classe.Text = "";
                                    annee.Text = "";
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
                        }
                    }
                }
            }
        }

        private void commencer_Click(object sender, EventArgs e)
        {
            nom.Text = "";
            prenom.Text = "";
            adresse.Text = "";
            matricule.Text = "";
            classe.Text = "";
            annee.Text = "";
            MessageBox.Show(
                "Formulaire reinitialisé",
                 "Information",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
                                   );
        }
    }
}
