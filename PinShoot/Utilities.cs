using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinShoot
{
    public class Utilities
    {
        public static DataTable GetSysCodesByType(Types.SysTypes sysType)
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(viewConString))
            {
                cmd.CommandText = "SdShSyCodeByType";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FkShSyCodeType", sysType);
                cmd.Connection = conn;

                conn.Open();

                reader = cmd.ExecuteReader();
                // Data is accessible through the DataReader object here.
                dt.Columns.Add("RecId", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                DataRow row = dt.NewRow();
                row["RecId"] = "0";
                row["Name"] = "";
                dt.Load(reader);
                dt.Rows.InsertAt(row, 0);

                conn.Close();
            }
            return dt;
        }
    }
}
