using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool AutorizirajKorisnika;

            DatabaseHelper databaseHelper = new DatabaseHelper();

            AutorizirajKorisnika = databaseHelper.AutorizirajKorisnika(txtUsername.Text, txtLozinka.Text);

            if (AutorizirajKorisnika)
            {

                WelcomeForm welcomeform = new WelcomeForm(txtUsername.Text);
                welcomeform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Neispravna lozinka.");
            }
            
        }
    }
}
