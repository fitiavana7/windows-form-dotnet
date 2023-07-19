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
    public partial class Login : Form
    {
        SqlConnection cnx;
        SqlDataReader dr;
        public Login()
        {
            cnx = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2012\Projects\Reservation\Reservation\Note.mdf;Integrated Security=True");
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();
            new Signup().Show();
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
            else {
                if (password.Text.Length < 6)
                {
                    MessageBox.Show(
                        "Utiliser de mot de passe long , plus de 6 caractères",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    password.Focus();
                }
                else {
                    try {
                        cnx.Open();
                        string sql = "select * from Utilisateur where mail='" + mail.Text + "' and password='" + password.Text + "' ";
                        SqlCommand cmd = new SqlCommand(sql, cnx);
                        dr = cmd.ExecuteReader();
                        if (!dr.HasRows)
                        {
                            MessageBox.Show(
                                "Compte non reconnu" + DateTime.Now.GetHashCode(),
                                "Echec de connection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else {
                            Hide();
                            new App().Show();
                            MessageBox.Show(
                                "Vous êtes connecté !",
                                "Connection reussi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        cnx.Close();
                    }
                    catch (Exception exe) { Console.WriteLine(exe); }
                    
                }
            }
        }

    }
}
