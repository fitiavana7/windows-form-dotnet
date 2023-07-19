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
    public partial class Signup : Form
    {
        SqlConnection cnx;
        public Signup()
        {
            cnx = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2012\Projects\Reservation\Reservation\Note.mdf;Integrated Security=True");
            InitializeComponent();
           }

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mail.Text.Length < 6)
            {
                MessageBox.Show(
                    "Mail trop court ou nulle",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                mail.Focus();
            }
            else
            {
                if (mdp1.Text.Length < 6)
                {
                    MessageBox.Show(
                        "Utiliser de mot de passe long , plus de 6 caractères",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    mdp1.Focus();
                }
                else {
                    if (mdp1.Text != mdp2.Text)
                    {
                        MessageBox.Show(
                            "Le mot de passe doit être identique",
                            "Erreur",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        mdp2.Focus();
                    }
                    else {
                        try {
                            cnx.Open();
                            string sql = "insert into Utilisateur(Id,mail,password) values('"+DateTime.Now.GetHashCode()+"' , '" + mail.Text + "' ,'" + mdp1.Text + "' )";
                            SqlCommand cmd = new SqlCommand(sql, cnx);
                            cmd.ExecuteNonQuery();
                            cnx.Close();
                            Hide();
                            new Login().Show();
                            MessageBox.Show(
                                "Vôtre compte est bien créé !",
                                "Succès",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        catch (Exception exe)
                        {
                            MessageBox.Show(
                                "Erreur sql!" + exe.ToString(),
                                "Succès",
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
