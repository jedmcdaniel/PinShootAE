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
    public partial class TeamList : Form
    {
        public TeamList()
        {
            InitializeComponent();
        }

        private void TeamList_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            LoadTeamList();
        }

        public void LoadTeamList()
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            // Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SdTeams", viewConString);

            // Create a command builder to generate SQL update, insert, and
            // delete commands based on selectCommand. These are used to
            // update the database.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dtgrdTeamList.AutoGenerateColumns = true;
            dtgrdTeamList.DataSource = table;
        }

        private void dtgrdTeamList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var temp = dtgrdTeamList[e.ColumnIndex, e.RowIndex].Value;
                Team frm = new Team(this);
                frm.OpenTeam((int)temp);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            Team frm = new Team(this);
            frm.OpenTeam(0);

        }
    }
}
