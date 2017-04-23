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
    public partial class ParticpantList : Form
    {
        public ParticpantList()
        {
            InitializeComponent();
        }


        void ParticpantList_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            LoadParticipantList();
        }

        private void dtgParticipantList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var temp = dtgParticipantList[e.ColumnIndex, e.RowIndex].Value;
                frmParticipant frm = new frmParticipant(this);
                frm.OpenParticipant((int) temp);              
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmParticipant frm = new frmParticipant(this);
            frm.OpenParticipant(0);
        }

        public void LoadParticipantList()
        {

            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            // Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SdParticipants", viewConString);

            // Create a command builder to generate SQL update, insert, and
            // delete commands based on selectCommand. These are used to
            // update the database.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dtgParticipantList.AutoGenerateColumns = true;
            dtgParticipantList.DataSource = table;

            // Resize the DataGridView columns to fit the newly loaded content.
            //dtgParticipantList.AutoResizeColumns(
            //    DataGridViewAutoSizeColumnsMode.ColumnHeader);
        }
    }
}
