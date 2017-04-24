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
    public partial class EventList : Form
    {
        public EventList()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventList_Load(object sender, EventArgs e)
        {
            LoadEventList();
        }

        public void LoadEventList()
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            // Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SdEventList", viewConString);

            // Create a command builder to generate SQL update, insert, and
            // delete commands based on selectCommand. These are used to
            // update the database.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dtgEventList.AutoGenerateColumns = true;
            dtgEventList.DataSource = table;
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            frmEvent frm = new frmEvent(this);
            frm.OpenEvent(0);

        }

        private void dtgEventList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var temp = dtgEventList[e.ColumnIndex, e.RowIndex].Value;
                frmEvent frm = new frmEvent(this);
                frm.OpenEvent((int)temp);
            }

        }
    }
}
