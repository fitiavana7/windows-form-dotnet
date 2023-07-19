using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation.Pages
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
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
    }
}
