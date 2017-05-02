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
    public partial class frmEvent : Form
    {
        EventList _owner;

        public frmEvent(EventList owner)
        {
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEvent_FormClosing);
            InitializeComponent();
        }

        private void Event_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveEvent()
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            using (var conn = new SqlConnection(viewConString))
            using (var command = new SqlCommand("SsEvents", conn)
            {
                CommandType = CommandType.StoredProcedure,

            })

            {
                conn.Open();
                command.Parameters.AddWithValue("@RecId", int.Parse(txtEventId.Text));
                command.Parameters.AddWithValue("@EventName", txtEventName.Text);
                command.Parameters.AddWithValue("@FkShSyCodeEventType", ddlEventType.SelectedValue);
                command.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);
                command.ExecuteNonQuery();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveEvent();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveEvent();
            txtEventName.Text = "";
            txtEventId.Text = "0";
            chkIsActive.Checked = true;

            txtEventName.Focus();
        }

        public void OpenEvent(int eventId)
        {
            var eventTypeList = Utilities.GetSysCodesByType(Types.SysTypes.EventType);
            ddlEventType.ValueMember = "RecId";
            ddlEventType.DisplayMember = "Name";
            ddlEventType.DataSource = eventTypeList;

            if (eventId == 0)
            {
                txtEventId.Text = "0";
                txtEventId.Visible = false;
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
                cmd.CommandText = "SlEvent";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RecId", eventId);
                cmd.Connection = conn;

                conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtEventId.Text = eventId.ToString();
                    txtEventName.Text = reader["EventName"].ToString();
                    ddlEventType.SelectedValue = reader["FkShSyCodeEventType"];
                    chkIsActive.Checked = (bool)reader["IsActive"];
               }
                conn.Close();
            }
            txtEventId.Visible = false;
            this.ShowDialog();
        }

        private void frmEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.LoadEventList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            using (var conn = new SqlConnection(viewConString))
            using (var command = new SqlCommand("SxEvent", conn)
            {
                CommandType = CommandType.StoredProcedure,
            })
            {
                conn.Open();
                command.Parameters.AddWithValue("@RecId", int.Parse(txtEventId.Text));
                command.ExecuteNonQuery();
            }
            this.Close();
        }
    }
}
