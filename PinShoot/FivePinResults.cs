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
    public partial class FivePinResults : Form
    {

        public FivePinResults()
        {

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            FivePinTimeEntry frm = new FivePinTimeEntry(this);
            frm.LoadEntry(0);
        }

        public void LoadResults()
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            // Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SdFivePinResults", viewConString);

            // Create a command builder to generate SQL update, insert, and
            // delete commands based on selectCommand. These are used to
            // update the database.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.AddWithValue("@FkEventList", ddlEvent.SelectedValue);

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dtgrdFivePinResults.AutoGenerateColumns = true;
            dtgrdFivePinResults.DataSource = table;
        }

        private void FivePinResults_Load(object sender, EventArgs e)
        {
            var eventList = Utilities.GetEventListForDropDown((int)Types.EventListType.FivePin);
            ddlEvent.ValueMember = "RecId";
            ddlEvent.DisplayMember = "EventName";
            ddlEvent.DataSource = eventList;

            LoadResults();
        }

        private void dtgrdFivePinResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var temp = dtgrdFivePinResults[e.ColumnIndex, e.RowIndex].Value;
                FivePinTimeEntry frm = new FivePinTimeEntry(this);
                frm.LoadEntry((int)temp);
            }
        }

        private void ddlEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadResults();
        }
    }
}
