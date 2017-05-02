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
    public partial class Team : Form
    {
        TeamList _owner;
        public Team(TeamList owner)
        {
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Team_FormClosing);
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveTeam();
            this.Close();
        }

        private void SaveTeam()
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            using (var conn = new SqlConnection(viewConString))
            using (var command = new SqlCommand("SsTeam", conn)
            {
                CommandType = CommandType.StoredProcedure,
            })

            {
                conn.Open();
                command.Parameters.AddWithValue("@RecId", int.Parse(txtTeamId.Text));
                command.Parameters.AddWithValue("@TeamNumber", txtTeamNumber.Text);
                command.Parameters.AddWithValue("@FkShSyCodeTeamType", ddlTeamType.SelectedValue);
                command.Parameters.AddWithValue("@FkParticipant1", ddlParticipant1.SelectedValue);
                command.Parameters.AddWithValue("@FkParticipant2", ddlParticipant2.SelectedValue);
                command.Parameters.AddWithValue("@FkParticipant3", ddlParticipant3.SelectedValue);
                command.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);
                command.ExecuteNonQuery();
            }
        }

        private void btnSaveCreateNew_Click(object sender, EventArgs e)
        {

            this.SaveTeam();

            txtTeamNumber.Text = "";
            ddlTeamType.SelectedValue = 0;
            ddlParticipant1.SelectedValue = 0;
            ddlParticipant2.SelectedValue = 0;
            ddlParticipant3.SelectedValue = 0;
            chkIsActive.Checked = true;

            txtTeamNumber.Focus();
        }

        private void Team_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.LoadTeamList();
        }

        private void Team_Load(object sender, EventArgs e)
        {

        }

        public void OpenTeam(int teamId)
        {
            var teamTypeList = Utilities.GetSysCodesByType(Types.SysTypes.TeamType);
            ddlTeamType.ValueMember = "RecId";
            ddlTeamType.DisplayMember = "Name";
            ddlTeamType.DataSource = teamTypeList;

            var participantList = Utilities.GetParticipantsForDropDown();
            ddlParticipant1.ValueMember = "RecId";
            ddlParticipant1.DisplayMember = "ParticipantName";
            ddlParticipant1.DataSource = participantList;

            var participantList2 = Utilities.GetParticipantsForDropDown();
            ddlParticipant2.ValueMember = "RecId";
            ddlParticipant2.DisplayMember = "ParticipantName";
            ddlParticipant2.DataSource = participantList2;

            var participantList3 = Utilities.GetParticipantsForDropDown();
            ddlParticipant3.ValueMember = "RecId";
            ddlParticipant3.DisplayMember = "ParticipantName";
            ddlParticipant3.DataSource = participantList3;

            if (teamId == 0)
            {
                txtTeamId.Text = "0";
                txtTeamId.Visible = false;
                chkIsActive.Checked = true;
                this.ShowDialog();
                return;
            }
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(viewConString))
            {
                cmd.CommandText = "SlTeam";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RecId", teamId);
                cmd.Connection = conn;

                conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtTeamId.Text = teamId.ToString();
                    txtTeamNumber.Text = reader["TeamNumber"].ToString();
                    ddlTeamType.SelectedValue = reader["FkShSyCodeTeamType"];
                    ddlParticipant1.SelectedValue = reader["FkParticipant1"];
                    ddlParticipant2.SelectedValue = reader["FkParticipant2"];
                    ddlParticipant3.SelectedValue = reader["FkParticipant3"];
                    chkIsActive.Checked = (bool)reader["IsActive"];
                }
                conn.Close();
            }
            txtTeamId.Visible = false;
            this.ShowDialog();
        }
    }
}
