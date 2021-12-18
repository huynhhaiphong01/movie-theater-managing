using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRP.DAL
{
    class DBHelper
    {
        private static DBHelper _instance;
        private SqlConnection cnn { get; set; }
        public static DBHelper Instance
        {
            get
            {
                string query = @"Data Source=DESKTOP-0V7AQ3F;Initial Catalog=QLRP;Integrated Security=True";
                if (_instance == null) _instance = new DBHelper(query);
                return DBHelper._instance;
            }
            private set { DBHelper._instance = value; }
        }
        public DBHelper(string query)
        {
            cnn = new SqlConnection(query);
        }
        public DataTable GetRecord(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, cnn);
            try
            {
                if (cnn.State != ConnectionState.Open && cnn.State != ConnectionState.Connecting) cnn.Open();
                ad.Fill(dt);
                cnn.Close();
                return dt;
            }
            catch (Exception) { throw; }
            finally
            {
                cnn.Close();
            }

        }
        public void ExcuteDB(string s)
        {
            SqlCommand cmd = new SqlCommand(s, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void ExcuteDB1(SqlCommand cmd)
        {
            cmd.Connection = cnn;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
