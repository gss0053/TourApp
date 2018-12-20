using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp
{
    class DBConnect
    {
        private SqlDataAdapter da;
        private SqlConnection con;

        public DBConnect()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            da = new SqlDataAdapter();
        }
        private SqlConnection Open()
        {
            if (con.State == System.Data.ConnectionState.Closed || con.State == System.Data.ConnectionState.Broken)
            {
                con.Open();
            }
            return con;
        }

        public bool ExcuteInsert(string cmdTxt, SqlParameter[] sqlParameters)
        {
            bool result = false;
            using (SqlTransaction transaction = Open().BeginTransaction())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = cmdTxt;
                cmd.Transaction = transaction;

                if (sqlParameters != null)
                {
                    cmd.Parameters.AddRange(sqlParameters);
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    result = true;
                }
                catch (SqlException)
                {
                    System.Windows.Forms.MessageBox.Show("Insert 실패", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    result = false;
                }
                return result;
            }
        }
    }
}
