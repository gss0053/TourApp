using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
                    System.Windows.Forms.MessageBox.Show("Insert Fail", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    result = false;
                }
                return result;
            }
        }

        public void ExecuteInsert(string[] memberinfo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            con.Open();
            SqlCommand comm = new SqlCommand();
            comm.Connection = con;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "Insert";

            comm.Parameters.AddWithValue("@ID", memberinfo[0]);
            comm.Parameters.AddWithValue("@PASSWORD", memberinfo[1]);
            comm.Parameters.AddWithValue("@NAME", memberinfo[2]);
            comm.Parameters.AddWithValue("@PHONE", memberinfo[3]);
            comm.Parameters.AddWithValue("@BIRTHDAY", memberinfo[4]);

            comm.ExecuteNonQuery();

            con.Close();
        }

        public void ExcuteSelect(List<Membership> lstMembership)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            con.Open();
            SqlCommand comm = new SqlCommand();
            comm.Connection = con;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "Select";

            SqlDataReader sr = comm.ExecuteReader();

            while (sr.Read())
            {
                lstMembership.Add(new Membership(sr[0].ToString(), sr[1].ToString(), sr[2].ToString(), sr[3].ToString(), sr[4].ToString()));
            }
            con.Close();
        }
    }
}