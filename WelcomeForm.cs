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
    public partial class WelcomeForm : Form
    {

        private string _username = "";
        public WelcomeForm(string username)
        {
            InitializeComponent();
            _username = username;
            Init(username);
        }

        private void Init(string username)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            User user = new User();

            user = databaseHelper.GetUser(_username);

            lblWelcome.Text = lblWelcome.Text + ", " + user.Ime + " " + user.Prezime;

            dgListaZaduzenja.DataSource = databaseHelper.GetPosudba(user.ID);
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPosudiFilm_Click(object sender, EventArgs e)
        {
            PosudbaForm posudbaForm = new PosudbaForm();
            posudbaForm.ShowDialog();
        }

        private void btnExitWelcome_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Close();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnExitPosudba_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }
    }
}
