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
    public partial class FivePinTimeEntry : Form
    {
        FivePinResults _owner;
        float totalTime;
        float tieBreaker;

        public FivePinTimeEntry(FivePinResults owner)
        {
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FivePinTimeEntry_FormClosing);

            InitializeComponent();
        }

        private void FivePinTimeEntry_Load(object sender, EventArgs e)
        {

         }

        public void LoadEntry(int entryId)
        {
            var participantList = Utilities.GetParticipantsForDropDown();
            ddlParticipant.ValueMember = "RecId";
            ddlParticipant.DisplayMember = "ParticipantName";
            ddlParticipant.DataSource = participantList;

            var eventList = Utilities.GetEventListForDropDown((int) Types.EventListType.FivePin);
            ddlEvent.ValueMember = "RecId";
            ddlEvent.DisplayMember = "EventName";
            ddlEvent.DataSource = eventList;
            if (entryId == 0)
            {
                txtEntryId.Text = "0";
                txtEntry1.Text = "0";
                txtEntry2.Text = "0";
                txtEntry3.Text = "0";
                txtEntry4.Text = "0";
                txtEntry5.Text = "0";
                txtEntry6.Text = "0";
                lblTieBreaker.Text = "0.0";
                lblTotal.Text = "0.0";
                this.ShowDialog();
                return;
            }

            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(viewConString))
            {
                cmd.CommandText = "SlFivePinResults";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RecId", entryId);
                cmd.Connection = conn;

                conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtEntryId.Text = entryId.ToString();
                    ddlEvent.SelectedValue = reader["FkEventList"].ToString();
                    ddlParticipant.SelectedValue = reader["FkParticipant"];
                    txtEntry1.Text = reader["Time1"].ToString();
                    txtEntry2.Text = reader["Time2"].ToString();
                    txtEntry3.Text = reader["Time3"].ToString();
                    txtEntry4.Text = reader["Time4"].ToString();
                    txtEntry5.Text = reader["Time5"].ToString();
                    txtEntry6.Text = reader["Time6"].ToString();

                    totalTime = float.Parse(reader["TotalTime"].ToString());
                    tieBreaker = float.Parse(reader["TieBreaker"].ToString());

                    lblTotal.Text = totalTime.ToString();
                    lblTieBreaker.Text = tieBreaker.ToString();
                }
                conn.Close();
            }

            this.ShowDialog();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveTimeEntry();
            this.Close();
        }

        private void SaveTimeEntry()
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            using (var conn = new SqlConnection(viewConString))
            using (var command = new SqlCommand("SsFivePin", conn)
            {
                CommandType = CommandType.StoredProcedure,
            })

            {
                conn.Open();
                command.Parameters.AddWithValue("@RecId", int.Parse(txtEntryId.Text));
                command.Parameters.AddWithValue("@FkEventList", ddlEvent.SelectedValue);
                command.Parameters.AddWithValue("@FkParticipant", ddlParticipant.SelectedValue);
                command.Parameters.AddWithValue("@Time1", float.Parse(txtEntry1.Text));
                command.Parameters.AddWithValue("@Time2", float.Parse(txtEntry2.Text));
                command.Parameters.AddWithValue("@Time3", float.Parse(txtEntry3.Text));
                command.Parameters.AddWithValue("@Time4", float.Parse(txtEntry4.Text));
                command.Parameters.AddWithValue("@Time5", float.Parse(txtEntry5.Text));
                command.Parameters.AddWithValue("@Time6", float.Parse(txtEntry6.Text));
                command.Parameters.AddWithValue("@TotalTime", float.Parse(lblTotal.Text));
                command.Parameters.AddWithValue("@TieBreaker", float.Parse(lblTieBreaker.Text));
                command.ExecuteNonQuery();
            }

        }

        private void btnSaveCreateNew_Click(object sender, EventArgs e)
        {
            this.SaveTimeEntry();

            txtEntryId.Text = "0";
            txtEntry1.Text = "0";
            txtEntry2.Text = "0";
            txtEntry3.Text = "0";
            txtEntry4.Text = "0";
            txtEntry5.Text = "0";
            txtEntry6.Text = "0";
            lblTieBreaker.Text = "0.0";
            lblTotal.Text = "0.0";

            ddlParticipant.Focus();

        }

        private void FivePinTimeEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.LoadResults();
        }


        private void txtEntry2_TextChanged(object sender, EventArgs e)
        {
            this.SetValues(float.Parse(txtEntry2.Text));
        }

        private void txtEntry3_TextChanged(object sender, EventArgs e)
        {
            this.SetValues(float.Parse(txtEntry3.Text));
        }

        private void txtEntry4_TextChanged(object sender, EventArgs e)
        {
            this.SetValues(float.Parse(txtEntry4.Text));
        }

        private void txtEntry5_TextChanged(object sender, EventArgs e)
        {
            this.SetValues(float.Parse(txtEntry5.Text));
        }

        private void txtEntry6_TextChanged(object sender, EventArgs e)
        {
            this.SetValues(float.Parse(txtEntry6.Text));
        }

        private void SetValues(float newValue)
        {
            totalTime = float.Parse(txtEntry1.Text) + float.Parse(txtEntry2.Text) + float.Parse(txtEntry3.Text) + float.Parse(txtEntry4.Text) + float.Parse(txtEntry5.Text) + float.Parse(txtEntry6.Text);

            tieBreaker = tieBreaker < newValue ? newValue : tieBreaker;
            totalTime -= tieBreaker;

            lblTotal.Text = totalTime.ToString();
            lblTieBreaker.Text = tieBreaker.ToString();
        }

        private void txtEntry1_Leave(object sender, EventArgs e)
        {
            this.SetValues(float.Parse(txtEntry1.Text));
        }

        private void txtEntry2_Leave(object sender, EventArgs e)
        {
            this.SetValues(float.Parse(txtEntry2.Text));
        }

        private void txtEntry3_Leave(object sender, EventArgs e)
        {
            this.SetValues(float.Parse(txtEntry3.Text));
        }

        private void txtEntry4_Leave(object sender, EventArgs e)
        {
            this.SetValues(float.Parse(txtEntry4.Text));
        }

        private void txtEntry5_Leave(object sender, EventArgs e)
        {
            this.SetValues(float.Parse(txtEntry5.Text));
        }

        private void txtEntry6_Leave(object sender, EventArgs e)
        {
            this.SetValues(float.Parse(txtEntry6.Text));
        }
    }
}
