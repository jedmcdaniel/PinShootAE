using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinShoot
{
    public partial class TeamTimeEntry : Form
    {
        TeamResults _owner;
        float bestTime;
        float tieBreaker;

        public TeamTimeEntry(TeamResults owner)
        {
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamTimeEntry_FormClosing);

            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeamTimeEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.LoadResults();
        }

        private void SaveTimeEntry()
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            using (var conn = new SqlConnection(viewConString))
            using (var command = new SqlCommand("SsTeamEntry", conn)
            {
                CommandType = CommandType.StoredProcedure,
            })

            {
                conn.Open();
                command.Parameters.AddWithValue("@RecId", int.Parse(txtEntryId.Text));
                command.Parameters.AddWithValue("@FkEventList", ddlEvent.SelectedValue);
                command.Parameters.AddWithValue("@FkTeam", ddlParticipant.SelectedValue);
                command.Parameters.AddWithValue("@Time1", float.Parse(txtEntry1.Text));
                command.Parameters.AddWithValue("@Time2", float.Parse(txtEntry2.Text));
                command.Parameters.AddWithValue("@Time3", float.Parse(txtEntry3.Text));
                command.Parameters.AddWithValue("@BestTime", float.Parse(lblBest.Text));
                command.Parameters.AddWithValue("@TieBreaker", float.Parse(lblTieBreaker.Text));
                command.ExecuteNonQuery();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete this entry?";
            string caption = "Confirm Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            using (var conn = new SqlConnection(viewConString))
            using (var command = new SqlCommand("SxTeamEntry", conn)
            {
                CommandType = CommandType.StoredProcedure,
            })
            {
                conn.Open();
                command.Parameters.AddWithValue("@RecId", int.Parse(txtEntryId.Text));
                command.ExecuteNonQuery();
            }
            this.Close();
        }

        private void btnSaveCreateNew_Click(object sender, EventArgs e)
        {
            this.SaveTimeEntry();

            txtEntryId.Text = "0";
            txtEntry1.Text = "0";
            txtEntry2.Text = "0";
            txtEntry3.Text = "0";
            lblTieBreaker.Text = "0.0";
            lblBest.Text = "0.0";

            ddlParticipant.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveTimeEntry();
            this.Close();
        }



        private void SetValues()
        {
            float val1 = float.Parse(txtEntry1.Text);
            float val2 = float.Parse(txtEntry2.Text);
            float val3 = float.Parse(txtEntry3.Text);

            var arr = new float[] { val1, val2, val3 };
            //arr.OrderBy(a => a).ToArray();
            Array.Sort(arr);

            bestTime = arr[0];
            tieBreaker = arr[1];
            lblBest.Text = bestTime.ToString();
            lblTieBreaker.Text = tieBreaker.ToString();
        }


        private void txtEntry1_Leave(object sender, EventArgs e)
        {
            this.SetValues();
        }

        private void txtEntry2_Leave(object sender, EventArgs e)
        {
            this.SetValues();
        }

        private void txtEntry3_Leave(object sender, EventArgs e)
        {
            this.SetValues();
        }

        public void LoadEntry(int entryId)
        {
            var participantList = Utilities.GetTeamsForDropDownForResults();
            ddlParticipant.ValueMember = "RecId";
            ddlParticipant.DisplayMember = "Team";
            ddlParticipant.DataSource = participantList;

            var eventList = Utilities.GetEventListForDropDown((int)Types.EventListType.Team);
            ddlEvent.ValueMember = "RecId";
            ddlEvent.DisplayMember = "EventName";
            ddlEvent.DataSource = eventList;
            if (entryId == 0)
            {
                txtEntryId.Text = "0";
                txtEntry1.Text = "0";
                txtEntry2.Text = "0";
                txtEntry3.Text = "0";
                lblTieBreaker.Text = "0.0";
                lblBest.Text = "0.0";
                this.ShowDialog();
                return;
            }

            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(viewConString))
            {
                cmd.CommandText = "SlTeamResults";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RecId", entryId);
                cmd.Connection = conn;

                conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtEntryId.Text = entryId.ToString();
                    ddlEvent.SelectedValue = reader["FkEventList"].ToString();
                    ddlParticipant.SelectedValue = reader["FkTeam"];
                    txtEntry1.Text = reader["Time1"].ToString();
                    txtEntry2.Text = reader["Time2"].ToString();
                    txtEntry3.Text = reader["Time3"].ToString();

                    lblBest.Text = reader["BestTime"].ToString();
                    lblTieBreaker.Text = reader["TieBreaker"].ToString();
                }
                conn.Close();
            }

            this.ShowDialog();
        }
    }
}
