using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinShoot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnParticipants_Click(object sender, EventArgs e)
        {
            //frmParticipant frm = new frmParticipant();
            //frm.Show();

            ParticpantList frm = new ParticpantList();
            frm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            EventList frm = new EventList();
            frm.ShowDialog();

        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            TeamList frm = new TeamList();
            frm.ShowDialog();
        }

        private void btnPinTimeEntry_Click(object sender, EventArgs e)
        {
            FivePinResults frm = new FivePinResults();
            frm.ShowDialog();
        }
    }
}
