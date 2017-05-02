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

namespace PinShoot
{
    public partial class frmParticipant : Form
    {
        ParticpantList _owner;

        public frmParticipant(ParticpantList owner)
        {
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmParticipant_FormClosing);
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveParticipant();
            this.Close();
        }

        private void frmParticipant_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveParticipant()
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            using (var conn = new SqlConnection(viewConString))
            using (var command = new SqlCommand("SsParticipant", conn)
            {
                CommandType = CommandType.StoredProcedure,

            })

            {
                conn.Open();
                command.Parameters.AddWithValue("@RecId", int.Parse(txtID.Text));
                command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                command.Parameters.AddWithValue("@FkShSyCodeGender", ddlGender.SelectedValue);
                command.Parameters.AddWithValue("@StreetAddress", txtStreetAddress.Text);
                command.Parameters.AddWithValue("@StreetAddress2", txtStreetAddress2.Text);
                command.Parameters.AddWithValue("@City", txtCity.Text);
                command.Parameters.AddWithValue("@AddressState", txtState.Text);
                command.Parameters.AddWithValue("@ZipCode", txtZipCode.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                command.Parameters.AddWithValue("@DepartmentAffiliation", txtClub.Text);
                command.Parameters.AddWithValue("@FkShSyCodeUSPSAClass", (int)ddlUSPSA.SelectedValue > 0 ? ddlUSPSA.SelectedValue : DBNull.Value);
                command.Parameters.AddWithValue("@FkShSyCodeSCClass", (int)ddlSCClass.SelectedValue > 0 ? ddlSCClass.SelectedValue : DBNull.Value);
                command.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);
                command.ExecuteNonQuery();
            }
        }

        private void btnSaveAndCreateNew_Click(object sender, EventArgs e)
        {
            SaveParticipant();
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStreetAddress.Text = "";
            txtStreetAddress2.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtClub.Text = "";
            ddlGender.SelectedIndex = 0;
            ddlUSPSA.SelectedIndex = 0;
            ddlSCClass.SelectedIndex = 0;
            chkIsActive.Checked = true;
            txtID.Text = "0";
            txtFirstName.Focus();
        }

        public void OpenParticipant(int ParticipantId)
        {
            var genderList = Utilities.GetSysCodesByType(Types.SysTypes.Gender);
            ddlGender.ValueMember = "RecId";
            ddlGender.DisplayMember = "Name";
            ddlGender.DataSource = genderList;

            var uspsaClass = Utilities.GetSysCodesByType(Types.SysTypes.USPSAClass);
            ddlUSPSA.ValueMember = "RecId";
            ddlUSPSA.DisplayMember = "Name";
            ddlUSPSA.DataSource = uspsaClass;


            var scClass = Utilities.GetSysCodesByType(Types.SysTypes.SCClass);
            ddlSCClass.ValueMember = "RecId";
            ddlSCClass.DisplayMember = "Name";
            ddlSCClass.DataSource = scClass;

            if (ParticipantId == 0)
            {
                txtID.Text = "0";
                txtID.Visible = false;
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
                cmd.CommandText = "SlParticipant";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RecId", ParticipantId);
                cmd.Connection = conn;

                conn.Open();
          
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtID.Text = ParticipantId.ToString();
                    txtFirstName.Text = reader["FirstName"].ToString();
                    txtLastName.Text = reader["LastName"].ToString();
                    txtStreetAddress.Text = reader["StreetAddress"].ToString();
                    txtStreetAddress2.Text = reader["StreetAddress2"].ToString();
                    txtCity.Text = reader["City"].ToString();
                    txtState.Text = reader["AddressState"].ToString();
                    txtZipCode.Text = reader["ZipCode"].ToString();
                    txtClub.Text = reader["DepartmentAffiliation"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    ddlGender.SelectedValue = (int) reader["FkShSyCodeGender"];
                    chkIsActive.Checked = (bool) reader["IsActive"] ;
                    ddlUSPSA.SelectedValue = reader["FkShSyCodeUSPSAClass"];
                    ddlSCClass.SelectedValue = reader["FkShSyCodeSCClass"];
                }
               conn.Close();
            }
            txtID.Visible = false;
            this.ShowDialog();
        }

        private void frmParticipant_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.LoadParticipantList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            using (var conn = new SqlConnection(viewConString))
            using (var command = new SqlCommand("SxParticipants", conn)
            {
                CommandType = CommandType.StoredProcedure,
            })
            {
                conn.Open();
                command.Parameters.AddWithValue("@RecId", int.Parse(txtID.Text));
                command.ExecuteNonQuery();
            }
            this.Close();
        }

    }
}
