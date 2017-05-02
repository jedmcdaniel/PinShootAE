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

        public static DataTable GetParticipantsForDropDown()
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(viewConString))
            {
                cmd.CommandText = "SdParticipantsForDropDown";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                conn.Open();

                reader = cmd.ExecuteReader();
                // Data is accessible through the DataReader object here.
                dt.Columns.Add("RecId", typeof(int));
                dt.Columns.Add("ParticipantName", typeof(string));
                DataRow row = dt.NewRow();
                row["RecId"] = "0";
                row["ParticipantName"] = "";
                dt.Load(reader);
                dt.Rows.InsertAt(row, 0);

                conn.Close();
            }
            return dt;
        }
        public static DataTable GetTeamsForDropDown(int fkShSyCodeTeamType)
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@FkShSyCodeTeamType", fkShSyCodeTeamType);
            SqlDataReader reader;
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(viewConString))
            {
                cmd.CommandText = "SdTeamsForDropDown";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                conn.Open();

                reader = cmd.ExecuteReader();
                // Data is accessible through the DataReader object here.
                dt.Columns.Add("RecId", typeof(int));
                dt.Columns.Add("TeamNumber", typeof(string));
                DataRow row = dt.NewRow();
                row["RecId"] = "0";
                row["TeamNumber"] = "";
                dt.Load(reader);
                dt.Rows.InsertAt(row, 0);

                conn.Close();
            }
            return dt;
        }

        public static DataTable GetEventListForDropDown(int fkShSyCodeEventType)
        {
            var viewConString = System.Configuration.ConfigurationManager.ConnectionStrings["PinShootDb"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@FkShSyCodeEventType", fkShSyCodeEventType);
            SqlDataReader reader;
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(viewConString))
            {
                cmd.CommandText = "SdEventListForDropDown";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                conn.Open();

                reader = cmd.ExecuteReader();
                // Data is accessible through the DataReader object here.
                dt.Columns.Add("RecId", typeof(int));
                dt.Columns.Add("EventName", typeof(string));
                DataRow row = dt.NewRow();
                row["RecId"] = "0";
                row["EventName"] = "";
                dt.Load(reader);
                dt.Rows.InsertAt(row, 0);

                conn.Close();
            }
            return dt;
        }
    }
}
