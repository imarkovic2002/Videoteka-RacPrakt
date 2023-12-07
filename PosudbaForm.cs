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
    public partial class PosudbaForm : Form
    {
        public PosudbaForm()
        {
            InitializeComponent();
        }


        private void btnExitPosudba_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Close();
        }

        private void chBoxListaFilmova_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PosudbaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {

        }
    }
}
